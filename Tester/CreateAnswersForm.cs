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

namespace Tester
{
    public partial class CreateAnswersForm : MaterialForm
    {
        int qurrQuestId;
        string qType;
        bool correctAnswer;


        public CreateAnswersForm(string qType, int qurrQuestId)
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

        private void CreateAnswersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.question". При необходимости она может быть перемещена или удалена.
            this.questionTableAdapter.FillBy2(this.testerDataSet.question, qurrQuestId);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.answer". При необходимости она может быть перемещена или удалена.
            this.answerTableAdapter.Fill(this.testerDataSet.answer);
            /*answerTableAdapter.Fill(this.testerDataSet.answer);
*/
            switch (qType)
            {
                case "basic":
                    materialLabel1.Visible = false;
                    textBox1.Visible = false;
                    break;
                case "InputAnswer":
                    materialLabel2.Visible = false;
                    textBox10.Visible = false;
                    checkBox2.Visible = false;                    
                    break;
                default:
                    break;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            switch (qType)
            {
                case "basic":
                    correctAnswer = checkBox2.Checked;
                    answerTableAdapter.Insert(textBox10.Text, correctAnswer, qurrQuestId);
                    answerTableAdapter.Fill(testerDataSet.answer);
                    break;
                case "InputAnswer":
                    correctAnswer = true; 
                    answerTableAdapter.Insert(textBox1.Text, correctAnswer, qurrQuestId);
                    answerTableAdapter.Fill(testerDataSet.answer);
                    Close();
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
                int answerId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                switch (qType)
                {
                    case "basic":
                        // Предположим, что у вас есть текстовые поля для ввода новых ответов
                        // и вы хотите обновить ответ по ID, который хранится в выбранной строке DataGridView.
                        newAnswerText = textBox10.Text;
                        answerTableAdapter.UpdateQuery(newAnswerText, isCorrect, qurrQuestId, answerId);
                        answerTableAdapter.Fill(testerDataSet.answer); // обновляем данные в DataSet
                        break;
                    case "InputAnswer":
                        isCorrect = true;
                        newAnswerText = textBox1.Text;
                        answerTableAdapter.UpdateQuery(newAnswerText, isCorrect, qurrQuestId, answerId);
                        answerTableAdapter.Fill(testerDataSet.answer); // обновляем данные в DataSet
                        Close();
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
    }
}
