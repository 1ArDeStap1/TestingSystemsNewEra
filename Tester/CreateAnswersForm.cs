using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms;
using System.Data.SqlClient;

namespace Tester
{
    public partial class CreateAnswersForm : MaterialForm
    {
        int qurrQuestId;
        int qType;
        bool correctAnswer;


        public CreateAnswersForm(int qType, int qurrQuestId)
        {
            this.qType = qType;
            this.qurrQuestId = qurrQuestId;

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue900, Primary.Blue800,
                Primary.Blue700, Accent.LightBlue100,
                TextShade.WHITE
            );

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadMatching_pairsTable()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.testerConnectionString))
            {
                conn.Open();
                string query = "SELECT id, left_text, right_text, extra_options FROM matching_pairs WHERE question_id = @questionId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@questionId", qurrQuestId);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Если DataGridView уже привязан к DataSource, просто обновляем источник
                        MatchingPairsTable.DataSource = dt;
                    }
                }
            }
        }

        private void AddMatching_PairsRow(string leftText, string rightText, string extraOptions = "")
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.testerConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO matching_pairs (question_id, left_text, right_text, extra_options) VALUES (@qId, @left, @right, @extra)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@qId", qurrQuestId);
                    cmd.Parameters.AddWithValue("@left", leftText);
                    cmd.Parameters.AddWithValue("@right", rightText);
                    cmd.Parameters.AddWithValue("@extra", string.Join(",", extraOptions));
                    cmd.ExecuteNonQuery();
                }
                
            }
            LoadMatching_pairsTable();
        }

        private void UpdateMatchingPair(int pairId, string leftText, string rightText, string extraOptions = "")
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.testerConnectionString))
            {
                conn.Open();
                string query = @"
                                UPDATE matching_pairs 
                                SET left_text = @left, right_text = @right, extra_options = @extra 
                                WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", pairId);
                    cmd.Parameters.AddWithValue("@left", leftText);
                    cmd.Parameters.AddWithValue("@right", rightText);
                    cmd.Parameters.AddWithValue("@extra", extraOptions);

                    cmd.ExecuteNonQuery();
                }
            }
            LoadMatching_pairsTable();
        }

        private void CreateAnswersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.matching_pairs". При необходимости она может быть перемещена или удалена.
            //this.matching_pairsTableAdapter.Fill(this.testerDataSet.matching_pairs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.question". При необходимости она может быть перемещена или удалена.
            this.questionTableAdapter.FillBy2(this.testerDataSet.question, qurrQuestId);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.answer". При необходимости она может быть перемещена или удалена.
            this.answerTableAdapter.Fill(this.testerDataSet.answer);
            /*answerTableAdapter.Fill(this.testerDataSet.answer);
*/
            switch (qType)
            {
                case 1:
                    materialCard2.Visible = false;
                    MatchingPairsTable.Visible = false;
                    dataGridView1.Visible = true;
                    materialCard1.Visible = true;

                    materialLabel1.Visible = false;
                    textBox1.Visible = false;
                    break;
                case 2:
                    materialCard2.Visible = false;
                    MatchingPairsTable.Visible = false;
                    dataGridView1.Visible = true;
                    materialCard1.Visible = true;

                    materialLabel2.Visible = false;
                    textBox10.Visible = false;
                    checkBox2.Visible = false;                    
                    break;
                case 3:
                    LoadMatching_pairsTable();
                    materialCard1.Visible = false;
                    materialCard2.Visible = true;
                    dataGridView1.Visible = false;
                    MatchingPairsTable.Visible = true;
                    break;
                default:
                    break;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            switch (qType)
            {
                case 1:
                    correctAnswer = checkBox2.Checked;
                    answerTableAdapter.Insert(textBox10.Text, correctAnswer, qurrQuestId);
                    answerTableAdapter.Fill(testerDataSet.answer);
                    break;
                case 2:
                    correctAnswer = true; 
                    answerTableAdapter.Insert(textBox1.Text, correctAnswer, qurrQuestId);
                    answerTableAdapter.Fill(testerDataSet.answer);
                    Close();
                    break;
                case 3:
                    AddMatching_PairsRow(LeftVal.Text, RightVal.Text);
                    break;
                default:
                    break;
            }
 
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.questionTableAdapter.FillBy1(this.testerDataSet.question);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            try
            {
                string newAnswerText = textBox1.Text; // текст нового ответа из текстового поля
                bool isCorrect = checkBox2.Checked; // состояние чекбокса для правильного ответа
                int answerId; 
                switch (qType)
                {
                    case 1:
                        // Предположим, что у вас есть текстовые поля для ввода новых ответов
                        // и вы хотите обновить ответ по ID, который хранится в выбранной строке DataGridView.
                        newAnswerText = textBox10.Text;
                        answerId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                        answerTableAdapter.UpdateQuery(newAnswerText, isCorrect, qurrQuestId, answerId);
                        answerTableAdapter.Fill(testerDataSet.answer); // обновляем данные в DataSet
                        break;
                    case 2:
                        isCorrect = true;
                        newAnswerText = textBox1.Text;
                        answerId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                        answerTableAdapter.UpdateQuery(newAnswerText, isCorrect, qurrQuestId, answerId);
                        answerTableAdapter.Fill(testerDataSet.answer); // обновляем данные в DataSet
                        Close();
                        break;
                    case 3:
                        UpdateMatchingPair((int)MatchingPairsTable.SelectedRows[0].Cells["id"].Value, LeftVal.Text, RightVal.Text);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении ответа: " + ex.Message);
            }
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
