using ClosedXML.Excel;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Tester.AnimationClasses;
using Tester.testerDataSetTableAdapters;
using System.Linq;

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
            LoadDataTables();
        }

        private void LoadDataTables()
        {
            this.oPKTableAdapter.Fill(this.testerDataSet.OPK);
            this.result_answerTableAdapter.Fill(this.testerDataSet.result_answer);
            this.resultTableAdapter.Fill(this.testerDataSet.result);
            this.answerTableAdapter.Fill(this.testerDataSet.answer);
            this.questionTableAdapter1.Fill(this.testerDataSet.question);
            this.testTableAdapter.Fill(this.testerDataSet.test);
            this.question_TypesTableAdapter1.Fill(this.testerDataSet.Question_Types);
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
            using (MemoryStream ms = new MemoryStream())
            {
                if (imageIn != null)
                    imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                testTableAdapter.Update(textBox1.Text, textBox2.Text, 
                    Convert.ToInt32(numericUpDown1.Text), 
                    Convert.ToInt32(((Button)sender).Tag), 
                    Convert.ToInt32(((Button)sender).Tag));
                testTableAdapter.Fill(testerDataSet.test);
                UpdatedMessage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении теста: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                questionTableAdapter1.Update(textBox3.Text, textBox4.Text, 
                    imageToByteArray(pictureBox1.Image),
                    Convert.ToInt32(Grid.SelectedRows[0].Cells[0].Value),
                    Convert.ToInt32(dataGridView7.SelectedRows[0].Cells[0].Value),
                    Convert.ToInt32(dataGridView8.SelectedRows[0].Cells[0].Value),
                    Convert.ToInt32(((Button)sender).Tag),
                    Convert.ToInt32(Grid.SelectedRows[0].Cells[0].Value),
                    Convert.ToInt32(dataGridView7.SelectedRows[0].Cells[0].Value),
                    Convert.ToInt32(dataGridView8.SelectedRows[0].Cells[0].Value));
                questionTableAdapter1.Fill(testerDataSet.question);
                UpdatedMessage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении вопроса: " + ex.Message);
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
                    DeletedMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении теста: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                answerTableAdapter.UpdateQuery(textBox5.Text, checkBox1.Checked,
                    Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value),
                    Convert.ToInt32(((Button)sender).Tag));
                answerTableAdapter.Fill(testerDataSet.answer);
                UpdatedMessage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении ответа: " + ex.Message);
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
                questionTableAdapter1.Fill(testerDataSet.question);
                InsertedMessage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении вопроса: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (TestCreation CreationForm = new TestCreation())
            {
                Hide();
                CreationForm.ShowDialog(this);
                Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = Program.SelectImage();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (DeleteConfirm())
                {
                    questionTableAdapter1.Fill(testerDataSet.question);
                    DeletedMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении вопроса: " + ex.Message);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (DeleteConfirm())
                {
                    answerTableAdapter.Delete((int)(dataGridView2.SelectedRows[0].Cells[0].Value));
                    answerTableAdapter.Fill(testerDataSet.answer);
                    DeletedMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении ответа: " + ex.Message);
            }
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AdminUserForm adminGroupForm = new AdminUserForm())
            {
                Hide();
                adminGroupForm.ShowDialog(this);
                Show();
            }
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AdminGroupsForm adminGroupForm = new AdminGroupsForm())
            {
                Hide();
                adminGroupForm.ShowDialog(this);
                Show();
            }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if ((dataGridView3.SelectedRows.Count > 0) && (dataGridView6.Rows.Count > 0))
            {
                string filter = string.Join(" OR ", System.Linq.Enumerable.Cast<DataGridViewRow>(dataGridView6.Rows)
                    .Select(r => $"id = {r.Cells[2].Value}").ToList());
                
                fKanswerquestionBindingSource1.Filter = filter;
                fKanswerquestionBindingSource1.ResetBindings(true);
            }
            else
            {
                fKanswerquestionBindingSource1.Filter = "id = 0";
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(this.testerDataSet.result, "Results");
                    using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                    {
                        if (fbd.ShowDialog() == DialogResult.OK)
                        {
                            wb.SaveAs(Path.Combine(fbd.SelectedPath, "Results.xlsx"));
                            MessageBox.Show("Экспорт успешно завершен!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при экспорте: " + ex.Message);
            }
        }

        private void AdminForm_Activated(object sender, EventArgs e)
        {
            LoadDataTables();
        }
    }
}