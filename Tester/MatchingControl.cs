using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester
{
    public partial class MatchingControl : UserControl
    {

        private Dictionary<string, string> correctPairs = new Dictionary<string, string>();
        private Dictionary<string, ComboBox> userAnswers = new Dictionary<string, ComboBox>();
        public List<int> correctAnswers = new List<int>();

        public MatchingControl()
        {
            InitializeComponent();
        }

        public Dictionary<string, string> LoadMatchingPairs(int questionId)
        {
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            List<int> correctAnswers = new List<int>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.testerConnectionString))
            {
                conn.Open();
                string query = "SELECT left_text, right_text FROM matching_pairs WHERE question_id = @questionId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@questionId", questionId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string leftText = reader.GetString(0);
                            string rightText = reader.GetString(1);
                            pairs[leftText] = rightText;
                        }
                    }
                }
                query = "SELECT id, description FROM answer WHERE question_id = @questionId AND correct = 'true'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@questionId", questionId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int AnswerId = reader.GetInt32(0);
                            correctAnswers.Add(AnswerId);
                        }
                    }
                }
                this.correctAnswers = correctAnswers;

            }

            return pairs;
        }

        public void LoadPairs(Dictionary<string, string> pairs)
        {
            correctPairs = pairs;
            userAnswers.Clear();
            this.Controls.Clear();

            int padding = 10;
            int columnWidth = this.Width / 2 - 2 * padding; // Делим ширину на два столбца
            int y = padding;

            List<string> rightItems = new List<string>(pairs.Values);
            rightItems = rightItems.OrderBy(a => Guid.NewGuid()).ToList(); // Перемешивание вариантов



            foreach (var pair in pairs)
            {
                /// Лейбл для левой колонки с переносом
                Label leftLabel = new Label
                {
                    Text = pair.Key,
                    Location = new System.Drawing.Point(padding, y),
                    Width = columnWidth,
                    AutoSize = false,
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(5),
                    Font = new Font("Arial", 10),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                };

                // Устанавливаем перенос текста
                leftLabel.MaximumSize = new Size(columnWidth, 0);
                leftLabel.AutoEllipsis = true; // Добавляет "..." если текст не помещается
                leftLabel.TextAlign = ContentAlignment.MiddleLeft;

                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(leftLabel, pair.Key); // Показываем полный текст при наведении

                // Комбобокс для правой колонки
                ComboBox comboBox = new ComboBox
                {
                    Location = new System.Drawing.Point(columnWidth + 2 * padding, y),
                    Width = columnWidth,
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    IntegralHeight = false,
                    MaxDropDownItems = 10,
                    Font = new Font("Arial", 10),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                };

                // Добавляем длинные элементы в ComboBox с переносом строк
                foreach (string item in rightItems)
                {
                    comboBox.Items.Add(item);
                }

                toolTip.SetToolTip(comboBox, "Выберите соответствие");

                // Вычисляем высоту с учетом многострочного текста
                int calculatedHeight = GetMultilineHeight(pair.Key, leftLabel.Font, columnWidth) + 10;
                leftLabel.Height = calculatedHeight;
                comboBox.Height = calculatedHeight;

                this.Controls.Add(leftLabel);
                this.Controls.Add(comboBox);

                userAnswers[pair.Key] = comboBox;

                y += calculatedHeight + padding; // Двигаем вниз с учетом высоты
            }
        }


        /// <summary>
        /// Вычисляет высоту для текста в многострочном Label
        /// </summary>
        private int GetMultilineHeight(string text, Font font, int maxWidth)
        {
            return TextRenderer.MeasureText(text, font, new Size(maxWidth, int.MaxValue), TextFormatFlags.WordBreak).Height;
        }

        /// <summary>
        /// Функция для добавления переноса строки в длинные тексты
        /// </summary>
        private string WrapText(string text, int maxLength)
        {
            if (text.Length <= maxLength) return text;

            StringBuilder wrappedText = new StringBuilder();
            for (int i = 0; i < text.Length; i += maxLength)
            {
                wrappedText.Append(text.Substring(i, Math.Min(maxLength, text.Length - i)) + Environment.NewLine);
            }
            return wrappedText.ToString();
        }

        /// <summary>
        /// Проверяет, правильно ли выбраны соответствия
        /// </summary>
        public bool CheckAnswers()
        {
            foreach (var pair in correctPairs)
            {
                if (userAnswers[pair.Key].SelectedItem == null || userAnswers[pair.Key].SelectedItem.ToString() != pair.Value)
                    return false;
            }
            return true;
        }

        public Dictionary<string, string> GetUserAnswers()
        {
            Dictionary<string, string> userSelections = new Dictionary<string, string>();

            foreach (var pair in userAnswers)
            {
                if (pair.Value.SelectedItem != null)
                    userSelections[pair.Key] = pair.Value.SelectedItem.ToString();
            }

            return userSelections;
        }

        public string[] DictToString(Dictionary<string, string> dict)
        {
            string[] returnedArray = new string[dict.Count];
            int i = 0;
            foreach (var pair in dict)
            {
                returnedArray[i] = pair.Key + " - " + pair.Value;
                i++;
            }
            return returnedArray;
        }

        public MatchingControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void MatchingControl_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
