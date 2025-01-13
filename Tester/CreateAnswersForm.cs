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

namespace Tester
{
    public partial class CreateAnswersForm : Form
    {
        int qurrQuestId;
        string qType;
        bool correctAnswer;

        public CreateAnswersForm(string qType, int qurrQuestId)
        {
            this.qType = qType;
            this.qurrQuestId = qurrQuestId;

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateAnswersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.question". При необходимости она может быть перемещена или удалена.
            this.questionTableAdapter.FillBy1(this.testerDataSet.question);
            this.questionTableAdapter.FillBy(this.testerDataSet.question, qurrQuestId);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.answer". При необходимости она может быть перемещена или удалена.
            this.answerTableAdapter.Fill(this.testerDataSet.answer);

            switch (qType)
            {
                case "basic":
                    label1.Visible = false;
                    textBox1.Visible = false;
                    break;
                case "InputAnswer":
                    label12.Visible = false;
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
    }
}
