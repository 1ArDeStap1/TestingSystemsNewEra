using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tester.AnimationClasses;
using Tester.testerDataSetTableAdapters;


using MaterialSkin;
using MaterialSkin.Controls;

namespace Tester
{
    public partial class AddQuestionForm : MaterialForm
    {
        int LastTest;
        AdminForm adminForm = new AdminForm();

        public int QuestionType;
        public int qurrentQuestiion;
        int selectedtest;
        bool isRedact;

        public AddQuestionForm(bool isRedact = false, int SelectedTest = 0)
        {
            InitializeComponent();
            this.isRedact = isRedact;
            this.selectedtest = SelectedTest;
            if(SelectedTest == 0 )
            {
                this.isRedact = false;
                this.selectedtest = LastTest;
            }
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue900, Primary.Blue800,
                Primary.Blue700, Accent.LightBlue700,
                TextShade.WHITE
            );
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            if (imageIn != null)
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value) < 0)
                {
                    MessageBox.Show("Вы не выбрали ни одной компетенции");
                    return;
                }
                else if (textBox8.Text== "")
                {
                    MessageBox.Show("Не все поля заполнены");
                    return;
                }
            } catch
            {
                MessageBox.Show("Вы не выбрали ни одной компетенции");
                return;
            }

            int test_id = (int)testerDataSet1.test[0]["id"];


            questionTableAdapter.Insert(textBox8.Text, textBox9.Text, imageToByteArray(pictureBox2.Image), test_id, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value), Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value), (decimal)NumberPoints.Value);

            this.questionTableAdapter.Fill(this.testerDataSet1.question);

            qurrentQuestiion = questionTableAdapter.GetData().Count - 1;

            QuestionType = (int)dataGridView2.SelectedRows[0].Cells[0].Value;
            qurrentQuestiion = Convert.ToInt32(questionTableAdapter.GetData()[qurrentQuestiion].id);


            CreateAnswersForm addAnswer = new CreateAnswersForm(QuestionType, qurrentQuestiion);
            addAnswer.ShowDialog(this);
            Show();

        }

        private void AddQuestionForm_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet1.Question_Types". При необходимости она может быть перемещена или удалена.
            this.question_TypesTableAdapter.Fill(this.testerDataSet1.Question_Types);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet1.question". При необходимости она может быть перемещена или удалена.
            if (!isRedact)
                this.testTableAdapter1.FillBy2(this.testerDataSet1.test);
            else
                this.testTableAdapter1.FillBy(this.testerDataSet1.test, selectedtest);

            if (!isRedact)
                this.questionTableAdapter.Fill(this.testerDataSet1.question);
            else
                this.questionTableAdapter.Fill(this.testerDataSet1.question);



            LastTest = adminForm.testTableAdapter.GetData().Count - 1;
            opkTableAdapter1.Fill(testerDataSet1.OPK);



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            opkTableAdapter1.Insert(textBox1.Text, numericUpDown1.Value);
            opkTableAdapter1.Update(testerDataSet1.OPK);
            opkTableAdapter1.Fill(testerDataSet1.OPK);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void oPKBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = Program.SelectImage();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.questionTableAdapter.FillBy(this.testerDataSet1.question);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.testTableAdapter1.FillBy2(this.testerDataSet1.test);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void AddQuestionForm_Deactivate(object sender, EventArgs e)
        {

        }

        private void AddQuestionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "TestCreation")
                {
                    form.Close();
                    break;
                }
            }
        }

        private void textBox8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            qurrentQuestiion = (int)Grid.SelectedRows[0].Cells[0].Value;
        }

        private void Grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            isRedact = false;
            
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            questionTableAdapter.Update(textBox8.Text, textBox9.Text, imageToByteArray(pictureBox2.Image), adminForm.testTableAdapter.GetData()[LastTest].id, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value), Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value), (decimal)NumberPoints.Value, (int)Grid.SelectedRows[0].Cells[0].Value, selectedtest, (int)Grid.SelectedRows[0].Cells[4].Value, Convert.ToInt32(Grid.SelectedRows[0].Cells[1].Value));
            QuestionType = (int)dataGridView2.SelectedRows[0].Cells[0].Value;
            qurrentQuestiion = Convert.ToInt32(Grid.SelectedRows[0].Cells[0].Value);
            questionTableAdapter.Fill(this.testerDataSet1.question);
            CreateAnswersForm addAnswer = new CreateAnswersForm(QuestionType, qurrentQuestiion);
            addAnswer.ShowDialog(this);
            Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
