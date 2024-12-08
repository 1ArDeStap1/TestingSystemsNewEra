using ClosedXML.Excel;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Tester.AnimationClasses;
using Tester.testerDataSetTableAdapters;


namespace Tester
{
    public partial class AdminForm : Form
    {


        public AdminForm()
        {
            InitializeComponent();
            Animator.Start();
        }

        public void AdminForm_Load(object sender, EventArgs e)
        {
            formsStyle1.Apply();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.OPK". При необходимости она может быть перемещена или удалена.
            this.oPKTableAdapter.Fill(this.testerDataSet.OPK);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.result_answer". При необходимости она может быть перемещена или удалена.
            this.result_answerTableAdapter.Fill(this.testerDataSet.result_answer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.result". При необходимости она может быть перемещена или удалена.
            this.resultTableAdapter.Fill(this.testerDataSet.result);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.answer". При необходимости она может быть перемещена или удалена.
            answerTableAdapter.Fill(this.testerDataSet.answer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.question". При необходимости она может быть перемещена или удалена.
            questionTableAdapter1.Fill(this.testerDataSet.question);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.test". При необходимости она может быть перемещена или удалена.
            testTableAdapter.Fill(this.testerDataSet.test);


            question_TypesTableAdapter1.Fill(this.testerDataSet.Question_Types);


        }

        private void InsertedMessage()
        {
            MessageBox.Show("Запись успешно добавлена!");
        }

        private void UpdatedMessage()
        {
            MessageBox.Show("Запись успешно изменена!");
        }

        private void DeletedMessage()
        {
            MessageBox.Show("Запись успешно Удалена!");
        }

        private bool DeleteConfirm()
        {
            return MessageBox.Show("Вы действительно хотите удалить эту запись?", "Требуется подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            if (imageIn != null)
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            testTableAdapter.Update(textBox1.TextInput, textBox2.Text, Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(((Button)sender).Tag), Convert.ToInt32(((Button)sender).Tag));
            testTableAdapter.Fill(testerDataSet.test);
            UpdatedMessage();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                questionTableAdapter1.Update(textBox3.Text, textBox4.Text, imageToByteArray(pictureBox1.Image), Convert.ToInt32(Grid.SelectedRows[0].Cells[0].Value), Convert.ToInt32(dataGridView7.SelectedRows[0].Cells[0].Value), Convert.ToInt32(dataGridView8.SelectedRows[0].Cells[0].Value), Convert.ToInt32(((Button)sender).Tag), Convert.ToInt32(Grid.SelectedRows[0].Cells[0].Value), Convert.ToInt32(dataGridView7.SelectedRows[0].Cells[0].Value), Convert.ToInt32(dataGridView8.SelectedRows[0].Cells[0].Value));
                questionTableAdapter1.Fill(testerDataSet.question);


            }
            catch (Exception ex)
            {

                MessageBox.Show("Возникла неизвестная ошибка " + ex.ToString());
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (DeleteConfirm())
                {
                    testTableAdapter.Delete(Convert.ToInt32(Grid.SelectedRows[0].Cells[0].Value));
                    testTableAdapter.Fill(testerDataSet.test);
                }
            }
            catch
            {

                MessageBox.Show("Возникла неизвестная ошибка");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                answerTableAdapter.UpdateQuery(textBox5.Text, checkBox1.Checked, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value), Convert.ToInt32(((Button)sender).Tag));
                answerTableAdapter.Fill(testerDataSet.answer);
                UpdatedMessage();
            }
            catch
            {

                MessageBox.Show("Возникла неизвестная ошибка");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = Program.SelectImage();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                //questionTableAdapter.Insert(textBox8.Text, textBox9.Text, imageToByteArray(pictureBox2.Image), Convert.ToInt32(Grid.SelectedRows[0].Cells[0].Value), opk);
                questionTableAdapter1.Fill(testerDataSet.question);
                InsertedMessage();

                /*
                    questionTableAdapter.Insert(textBox8.Text, textBox9.Text, imageToByteArray(pictureBox2.Image), Convert.ToInt32(Grid.SelectedRows[0].Cells[0].Value));
                    questionTableAdapter.Fill(testerDataSet.question);
                    InsertedMessage();

                } else
                {
                    MessageBox.Show("Вы не выбрали ни одну компетенцию");
                }
                */
            }
            catch
            {

                MessageBox.Show("Возникла неизвестная ошибка");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*testTableAdapter.Insert(textBox6.Text, textBox7.Text, Convert.ToInt32(numericUpDown2.Value));
            testTableAdapter.Fill(testerDataSet.test);
            InsertedMessage();*/

            TestCreation CreationForm = new TestCreation();
            Hide();
            CreationForm.ShowDialog(this);
            Show();
        }

        /* private void button6_Click(object sender, EventArgs e)
         {
             //answerTableAdapter.Insert(textBox10.Text, checkBox2.Checked, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
             answerTableAdapter.Fill(testerDataSet.answer);
             InsertedMessage();
         }*/

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = Program.SelectImage();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DeleteConfirm())
            {
                //questionTableAdapter.Delete(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value),Convert.ToInt32(Grid.SelectedRows[0].Cells[0].Value));
                questionTableAdapter1.Fill(testerDataSet.question);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (DeleteConfirm())
            {
                answerTableAdapter.Delete((int)(dataGridView2.SelectedRows[0].Cells[0].Value));
                answerTableAdapter.Fill(testerDataSet.answer);
            }
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminUserForm adminGroupForm = new AdminUserForm();
            Hide();
            adminGroupForm.ShowDialog(this);
            Show();
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminGroupsForm adminGroupForm = new AdminGroupsForm();
            Hide();
            adminGroupForm.ShowDialog(this);
            Show();
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if ((dataGridView3.SelectedRows.Count > 0) && (dataGridView6.Rows.Count > 0))
            {
                string filt = "";
                for (int i = 0; i < dataGridView6.Rows.Count; i++)
                {
                    filt += "id = " + dataGridView6.Rows[i].Cells[2].Value + " OR ";
                }
                if (filt.EndsWith("OR "))
                {
                    filt = filt.Substring(0, filt.LastIndexOf("OR "));
                }
                fKanswerquestionBindingSource1.Filter = filt;
                Debug.WriteLine(filt);
                fKanswerquestionBindingSource1.ResetBindings(true);
            }
            else
            {
                fKanswerquestionBindingSource1.Filter = "id = 0";
            }
        }

        private void fKresultvariantresultBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fKresultvariantresultBindingSource1_ListChanged(object sender, ListChangedEventArgs e)
        {
            dataGridView3_SelectionChanged(this, null);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void testBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string result;
            using (StringWriter sw = new StringWriter())
            {
                this.testerDataSet.result.WriteXml(sw);
                result = sw.ToString();
            }
            XLWorkbook wb = new XLWorkbook();
            wb.Worksheets.Add(this.testerDataSet.result, "WorksheetName");
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                wb.SaveAs(FBD.SelectedPath + "\\WorksheetName.xlsx");
            }

        }

        private void AdminForm_Activated(object sender, EventArgs e)
        {
            //formsStyle1.Apply();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.result_answer". При необходимости она может быть перемещена или удалена.
            this.result_answerTableAdapter.Fill(this.testerDataSet.result_answer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.result". При необходимости она может быть перемещена или удалена.
            this.resultTableAdapter.Fill(this.testerDataSet.result);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.answer". При необходимости она может быть перемещена или удалена.
            answerTableAdapter.Fill(this.testerDataSet.answer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.question". При необходимости она может быть перемещена или удалена.
            questionTableAdapter1.Fill(this.testerDataSet.question);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.test". При необходимости она может быть перемещена или удалена.
            testTableAdapter.Fill(this.testerDataSet.test);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}