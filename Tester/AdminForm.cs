using ClosedXML.Excel;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Tester.AnimationClasses;
using Tester.testerDataSetTableAdapters;
using System.Linq;
using System.Data;

using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections.Generic;


namespace Tester
{
    public partial class AdminForm : MaterialForm
    {
        public AdminForm()
        {
            InitializeComponent();
            
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

        public void AdminForm_Load(object sender, EventArgs e)
        {
            
            LoadDataTables();
            if (testerDataSet.adminNetworkData.Select("Id = 1")[0][7].ToString() == "" || testerDataSet.adminNetworkData.Select("Id = 1")[0][7].ToString() == "Null")
            {
                MessageBox.Show("У вас не привязана почта для рассылки результатов. \r\nДля привязки зайдите на вкладку 'Управление почтой' и введите свой почтовый адрес");
            }
            SwitchElementsVisiblity(false);
        }


        private void UpdateDataTables()
        {

            this.adminNetworkDataTableAdapter1.Update(this.testerDataSet.adminNetworkData);
            this.oPKTableAdapter.Update(this.testerDataSet.OPK);
            /*this.question_TypesTableAdapter1.Update(this.testerDataSet.Question_Types);*/
            this.resultTableAdapter.Update(this.testerDataSet.result);
            this.testTableAdapter.Update(this.testerDataSet.test);
            this.questionTableAdapter1.Update(this.testerDataSet.question);
            this.answerTableAdapter.Update(this.testerDataSet.answer);
            this.groupTableAdapter1.Update(this.testerDataSet.group);
            this.usersTableAdapter1.Update(this.testerDataSet.users);

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
            this.adminNetworkDataTableAdapter1.Fill(this.testerDataSet.adminNetworkData);
            this.groupTableAdapter1.Fill(this.testerDataSet.group);
            this.usersTableAdapter1.Fill(this.testerDataSet.users);

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            using (Opk_Result_Form opkResForm = new Opk_Result_Form((int)dataGridView3.SelectedRows[0].Cells[6].Value, (int)dataGridView3.SelectedRows[0].Cells[3].Value))
            {
                opkResForm.ShowDialog(this);
                Show();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MailForm mailForm = new MailForm();
            mailForm.ShowDialog(this);
        }

        private void сохранитьБазуДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {

                    SerializerXML Xmls = new SerializerXML();
                    Xmls.SaveToXML(testerDataSet, new DataTable[8] { testerDataSet.adminNetworkData, testerDataSet.test, testerDataSet.OPK, testerDataSet.Question_Types, testerDataSet.question, testerDataSet.answer, testerDataSet.group, testerDataSet.users }, fbd.SelectedPath);

                }
            }
        }


        private void загрузитьБазуДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fbd = new OpenFileDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    SerializerXML Xmls = new SerializerXML();
                    List<DataTable> returnedData = Xmls.ImportFromXML(testerDataSet, fbd.FileName);
                    if (returnedData != null)
                    {
                        foreach (DataTable returnedDT in returnedData)
                        {
                            foreach (DataTable dt in testerDataSet.Tables)
                            {
                                if (dt.TableName == returnedDT.TableName)
                                {
                                    dt.Merge(returnedDT);
                                    
                                    
                                }
                            }
                        }
                        UpdateDataTables();
                        LoadDataTables();

                    }

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, EventArgs e)
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

        private void materialButton1_Click(object sender, EventArgs e)
        {
            
            using (TestCreation tstForm = new TestCreation())
            {
                Hide();
                tstForm.ShowDialog(this);
                Show();
            }
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            SwitchElementsVisiblity(true);
        }

        private void SwitchElementsVisiblity(bool visible)
        {
            materialMultiLineTextBox21.Visible = visible;
            materialLabel3.Visible = visible;
            materialTextBox1.Visible = visible;
            materialLabel2.Visible  = visible;
            materialTextBox2.Visible = visible;
            materialButton3.Visible = visible;
            materialButton2.Visible = visible;
            materialLabel4.Visible = visible;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            try
            {
                testTableAdapter.Update(materialTextBox1.Text, materialMultiLineTextBox21.Text, Convert.ToInt32(materialTextBox2.Text), (int)Grid.SelectedRows[0].Cells[0].Value, (int)Grid.SelectedRows[0].Cells[0].Value);
                using (AddQuestionForm addQuest = new AddQuestionForm(true, (int)Grid.SelectedRows[0].Cells[0].Value))
                {
                    Hide();
                    addQuest.ShowDialog(this);
                    Show();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при открытии редактора "+ ex.Message);
            }
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            using (MatchingAnswerForm MAF = new MatchingAnswerForm())
            {
                Hide();
                MAF.ShowDialog(this);
                Show();
            }
        }
    }
}