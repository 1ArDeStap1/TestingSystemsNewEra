using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tester.testerDataSetTableAdapters;

using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;

namespace Tester
{
    public partial class DoTestForm : MaterialForm
    {
        MatchingControl matchingControl = new MatchingControl();
        string groupName = "";
        int questionTypeId = 0;
        int testId = 0;
        int userId = 0;
        bool trening;
        int result_id;
        int timeLimit = 0;
        bool hardEnd = false;
        public DoTestForm(int testId, int userId, int timeLimit = 0)
        {
            InitializeComponent();

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

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.testerConnectionString))
            {
                conn.Open();
                string query = @"SELECT g.name AS group_name
                                FROM [dbo].[users] u
                                JOIN [dbo].[group] g ON u.group_id = g.id
                                WHERE u.id = @UserId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            this.groupName = reader.GetString(0);
                        }
                    }
                }
            }

            this.testId = testId;
            this.userId = userId;
            testBindingSource.Filter = "id = " + testId.ToString();
            answerBindingSource.Filter = "question_id = 0";
            trening = MessageBox.Show("Хотите ли вы пройти пробное тестирование?", "Пробное тестирование", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            if (trening)
            {
                if (MessageBox.Show("В режиме тренинга нет ограничения по времени и Ваши результаты не будут записаны.\nВы уверены, что хотите пройти тест без сохранения результатов и без ограничения по времени?", "Подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    trening = false;
                }
            }
            if ((timeLimit > 0) && !trening)
            {
                this.timeLimit = timeLimit;
                MessageBox.Show("Этот тест ограничен " + timeLimit.ToString() + " секундами.\nНажмите ОК, когда будете готовы.");
                //seconds = timeLimit;
            }
            timer.Start();
        }

        Questions test;
        int q = 1;
        int seconds = 0;
        string qsPath = Application.StartupPath + "\\questions\\";
        DateTime startedTime;
        List<int> opk_ids = new List<int>();

        private void initGame()
        {
            if (dataGridView2.RowCount > 0)
            {
                Question[] questions = new Question[dataGridView2.RowCount];
                
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    answerBindingSource.Filter = "question_id = " + dataGridView2.Rows[i].Cells[0].Value.ToString();
                    answerBindingSource.ResetBindings(true);

                    oPKBindingSource.Filter = "Id = " + dataGridView2.Rows[i].Cells[5].Value.ToString();
                    oPKBindingSource.ResetBindings(true);
                    OPK tmpOpk = new OPK();
                    tmpOpk.OPK_ID = Convert.ToInt32(dataGridView4.Rows[0].Cells[0].Value.ToString());
                    tmpOpk.OPK_DESCRIPTION = dataGridView4.Rows[0].Cells[1].Value.ToString();
                    tmpOpk.OPK_PERCENT = Convert.ToDecimal(dataGridView4.Rows[0].Cells[2].Value.ToString());
                    if (!opk_ids.Contains(tmpOpk.OPK_ID))
                    {
                        opk_ids.Add(tmpOpk.OPK_ID);
                    }

                    if (dataGridView3.RowCount > 0)
                    {
                        Answer[] tmpAnswers = new Answer[dataGridView3.RowCount];
                        int[] tmpCAnswers = new int[0];
                        Dictionary<int, string> tmpCAnswersData = new Dictionary<int, string>();
                        for (int j=0; j < dataGridView3.RowCount; j++)
                        {
                            tmpAnswers[j] = new Answer();
                            tmpAnswers[j].id = Convert.ToInt32(dataGridView3.Rows[j].Cells[0].Value.ToString());
                            tmpAnswers[j].content = dataGridView3.Rows[j].Cells[1].Value.ToString();
                            if (Convert.ToBoolean(((DataGridViewCheckBoxCell)(dataGridView3.Rows[j].Cells[2])).Value.ToString()))
                            {
                                Array.Resize<int>(ref tmpCAnswers, tmpCAnswers.Length + 1);
                                tmpCAnswers[tmpCAnswers.Length - 1] = j;
                                tmpCAnswersData.Add(tmpAnswers[j].id, tmpAnswers[j].content);
                            }
                        }
                        Bitmap question;
                        string description = "";
                        if ((dataGridView2.Rows[i].Cells[3].Value.ToString().Length == 0) || (((byte[])(dataGridView2.Rows[i].Cells[3].Value)).Length == 0))
                        {
                            question = new Bitmap(questionImage.Width, questionImage.Height);

                            Graphics g = Graphics.FromImage(question);

                            try
                            {
                                g.TextRenderingHint = TextRenderingHint.AntiAlias;
                                g.SmoothingMode = SmoothingMode.AntiAlias;
                                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                                description = dataGridView2.Rows[i].Cells[2].Value.ToString();
                                g.DrawString(dataGridView2.Rows[i].Cells[2].Value.ToString(), answersList.Font, Brushes.Black, new RectangleF(0, 0, questionImage.Width, questionImage.Height));
                            }
                            finally
                            {
                                g.Flush();
                            }
                        }
                        else
                        {
                            question = new Bitmap(new MemoryStream((byte[])(dataGridView2.Rows[i].Cells[3].Value)));
                        }

                        questions[i] = new Question((int)dataGridView2.Rows[i].Cells[0].Value, (string)dataGridView2.Rows[i].Cells[1].Value, question, tmpAnswers, tmpCAnswers, tmpCAnswersData, tmpOpk, description, false, (int)dataGridView2.Rows[i].Cells[6].Value);
                    }
                }

                test = new Questions(questions);
                q = 1;
                backQuestion.Enabled = false;
                fillQuestion(test.nextQuestion());
                startedTime = DateTime.Now;
            } else
            {
                Hide();
                MessageBox.Show("Увы, но в тесте нет вопросов.\nКак так - не понятно, но пройти его нельзя, это факт.");
                Close();
            }
        }

        private void fillQuestion(Question question)
        {
            label1.Text = question.cont;
            if (question.description == "")
            {
                questionImage.Visible = true;
                questionImage.Image = question.image;
                materialCard2.Visible = false;
            }
            else
            {
                questionImage.Visible = false;
                materialCard2.Visible = true;
                materialLabel1.Text = question.description;
            }

            answersList.SelectionMode = SelectionMode.MultiSimple;
            answersList.Items.Clear();
            answersList.Items.AddRange(question.answers);
            countLabel.Text = q.ToString() + " из " + test.Count.ToString();
            questionTypeId = question.type_id;

            if (questionTypeId == 2)
            {
                answersList.Visible = false;
                label2.Visible = true;
                AnswerTextBox1.Visible = true;
                panelMatching.Visible = false;
                AnswerTextBox1.Text = "";
            } else if (questionTypeId == 3)
            {
                label2.Visible = false;
                AnswerTextBox1.Visible = false;
                answersList.Visible = false;
                panelMatching.Visible = true;
                panelMatching.Controls.Clear();
                FillMatchingPanel(question.id);
            } else if (questionTypeId == 4) 
            {
                answersList.SelectionMode = SelectionMode.One;
                answersList.Visible = true;
                label2.Visible = false;
                AnswerTextBox1.Visible = false;
                panelMatching.Visible = false;
            }
            else if (questionTypeId == 5)
            {
                label2.Visible = false;
                AnswerTextBox1.Visible = false;
                answersList.Visible = false;
                panelMatching.Visible = true;
                panelMatching.Controls.Clear();
                FillMatchingPanel(question.id);
            }
            else
            {
                answersList.Visible = true;
                label2.Visible = false;
                AnswerTextBox1.Visible = false;
                panelMatching.Visible = false;
            }

        }

        private void FillMatchingPanel(int qId)
        {
            this.matchingControl = new MatchingControl();

            this.matchingControl.LoadPairs(matchingControl.LoadMatchingPairs(qId));

            panelMatching.Controls.Clear();
            panelMatching.Controls.Add(matchingControl);
        }

        private void backQuestion_Click(object sender, EventArgs e)
        {
            q--;
            if (test.backQuestion())
            {
                nextQuestion.Enabled = false;
                backQuestion.Enabled = false;
                fillQuestion(test.nextQuestion());
            }
        }

        private void answersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            nextQuestion.Enabled = true;
        }

        private void nextQuestion_Click(object sender, EventArgs e)
        {
            q++;
            nextQuestion.Enabled = false;
            backQuestion.Enabled = true;

            Dictionary<int, string> currentAnswers = new Dictionary<int, string>();
            if (questionTypeId == 1 || questionTypeId == 4)
            {
                for (int i = 0; i < answersList.SelectedIndices.Count; i++)
                    currentAnswers.Add(answersList.SelectedIndices[i], "");
                test.answers = currentAnswers;
            } 
            else if (questionTypeId == 2)
            {
                currentAnswers.Add(((Tester.Answer)answersList.Items[0]).id, AnswerTextBox1.Text);
                test.answers = currentAnswers;
            }
            else if (questionTypeId == 3 || questionTypeId == 5)
            {
                string[] UAnswers = matchingControl.DictToString(matchingControl.GetUserAnswers());
                string CurrAnswer = "";

                for (int i = 0; i < UAnswers.Length; i++) {

                    CurrAnswer += UAnswers[i] + "\n";
                }
                currentAnswers.Add(((Tester.Answer)answersList.Items[0]).id, CurrAnswer);
                test.answers = currentAnswers;

            }

            if (!test.isEnd() && !hardEnd)
            {
                Question NextQuest = test.nextQuestion();
                if (questionTypeId == 2)
                {
                    if (!test.questions[test.now - 1].right) {
                        answerTableAdapter.Insert(AnswerTextBox1.Text, false, test.questions[test.now - 1].id);
                        answerTableAdapter.Fill(testerDataSet.answer);
                        int NewID = (int)answerTableAdapter.GetData()[answerTableAdapter.GetData().Count - 1][0];
                        test.answersIds.Add(NewID);
                    }
                } else if (questionTypeId == 3 || questionTypeId == 5)
                {
                    if (!test.questions[test.now - 1].right)
                    {
                        string[] UAnswers = matchingControl.DictToString(matchingControl.GetUserAnswers());
                        string constructorAnswers = "";
                        for (int i = 0; i < UAnswers.Length; i++)
                        {
                            constructorAnswers += UAnswers[i] + "\n";
                        }
                        
                        answerTableAdapter.Insert(constructorAnswers, false, test.questions[test.now - 1].id);
                        answerTableAdapter.Fill(testerDataSet.answer);
                        int NewID = (int)answerTableAdapter.GetData()[answerTableAdapter.GetData().Count - 1][0];
                        test.answersIds.Add(NewID);

                    }
                }

                fillQuestion(NextQuest);
            }
            else
            {
                timer.Stop();
                q--;
                test.nextQuestion();
                double mark = Math.Floor((Convert.ToDouble(test.rightsCount) / Convert.ToDouble(test.Count)) * 100.0);
                
                if (!trening)
                {
                    int inserted = Convert.ToInt32(resultTableAdapter.InsertQuery(userId, testId, mark, startedTime));
                    Debug.WriteLine("id: " + inserted.ToString());
                    foreach (int answer in test.answersIds)
                    {
                        result_answerTableAdapter.InsertQuery(inserted, answer);
                    }
                    resultTableAdapter.Fill(testerDataSet.result);

                    string opksResult = "";
                    int rightsOpks;
                    int AllQuestOpk;
                    decimal TmpOpkPercent = 0;
                    foreach (int opk_id in opk_ids)
                    {
                        rightsOpks = 0;
                        AllQuestOpk = 0;
                        string tmpOpkDesc = "";
                        foreach (Question quest in test.questions)
                        {
                            if (quest.opk.OPK_ID == opk_id)
                            {
                                tmpOpkDesc = quest.opk.ToString();
                                TmpOpkPercent = quest.opk.OPK_PERCENT;
                                if (quest.right)
                                {
                                    rightsOpks++;
                                    AllQuestOpk++;
                                }
                                else
                                {
                                    AllQuestOpk++;
                                }
                            }
                        }
                        string resultMsg = "Компетенция не освоена";
                        decimal CompletePercent = (decimal)Math.Round(Convert.ToDouble(rightsOpks) / Convert.ToDouble(AllQuestOpk) * 100, 2);
                        if (CompletePercent >= TmpOpkPercent)
                        {
                            if (rightsOpks == AllQuestOpk)
                            {
                                resultMsg = "Компетенция полностью освоена";
                            }
                            else
                            {
                                resultMsg = "Компетенция освоена, но следует подучить учебный материал";
                            }
                            opksResult = opksResult + tmpOpkDesc + " на " + Convert.ToString(CompletePercent) + "%\r\n";

                        }
                        opk_resultTableAdapter1.InsertQuery(opk_id, userId, rightsOpks, AllQuestOpk, CompletePercent, inserted, resultMsg);
                        
                    }
                    opk_resultTableAdapter1.Fill(testerDataSet.opk_result);
                    result_answerTableAdapter.Fill(testerDataSet.result_answer);
                    this.result_id = inserted;
                    string FileResult = ExportToExcel();

                    using (SummaryResultForm SumRes = new SummaryResultForm(result_id, mark))
                    {
                        SumRes.ShowDialog();
                    }

                    this.adminNetworkDataTableAdapter1.Fill(testerDataSet.adminNetworkData);
                    DataRow dataForSend = testerDataSet.adminNetworkData.Select("Id = 1")[0];
                    string testName = testerDataSet.test.Select("id = " + testId.ToString())[0]["name"].ToString();
                    if (dataForSend != null && dataForSend["SendTo"].ToString() != "" && dataForSend["SendTo"].ToString() != "Null")
                    {
                        SMTP_Mail SendMail = new SMTP_Mail();
                        string[] fi = FileResult.Split(new[] { "_" }, StringSplitOptions.None);
                        StreamReader fileReader = new StreamReader(@"SendTemplate.html");
                        string template = fileReader.ReadToEnd();
                        SendMail.SendMail(dataForSend["smtpServer"].ToString(), dataForSend["smtpPort"].ToString(), dataForSend["smtpUsername"].ToString(), dataForSend["smtpUserpassword"].ToString(), dataForSend["smtpSendFrom"].ToString(), dataForSend["smtpSenderName"].ToString(), fi[0] + " " + fi[1] + " Прошёл тест " + testName, template, dataForSend["SendTo"].ToString(), true, FileResult);
                    }
                } else
                {
                    MessageBox.Show("Предполагаемая отметка: " + mark.ToString() + "\n");
                }
                Close();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            timerLabel.Text = Math.Abs(seconds).ToString();
            if ((seconds == timeLimit) && (timeLimit > 0))
            {
                MessageBox.Show("Время вышло!");
                hardEnd = true;
                answersList.SelectedItems.Clear();
                nextQuestion_Click(sender, e);
            } 
        }

        private void DoTestForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.matching_pairs". При необходимости она может быть перемещена или удалена.
            this.matching_pairsTableAdapter.Fill(this.testerDataSet.matching_pairs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.Question_Types". При необходимости она может быть перемещена или удалена.
            this.question_TypesTableAdapter.Fill(this.testerDataSet.Question_Types);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.opk_result". При необходимости она может быть перемещена или удалена.
            this.opk_resultTableAdapter1.Fill(this.testerDataSet.opk_result);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet1.result_answer". При необходимости она может быть перемещена или удалена.
            this.result_answerTableAdapter.Fill(this.testerDataSet.result_answer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet1.result". При необходимости она может быть перемещена или удалена.
            this.resultTableAdapter.Fill(this.testerDataSet.result);
            this.answerTableAdapter.Fill(this.testerDataSet.answer);
            this.questionTableAdapter.Fill(this.testerDataSet.question);
            this.testTableAdapter.Fill(this.testerDataSet.test);
            this.opkTableAdapter1.Fill(this.testerDataSet.OPK);
            this.opk_resultTableAdapter1.Fill(this.testerDataSet.opk_result);

            answersList.DrawMode = DrawMode.OwnerDrawVariable;

            
            label1.BackColor = Color.FromArgb(21, 101, 192);
            label1.ForeColor = Color.White;

            countLabel.BackColor = Color.FromArgb(21, 101, 192);
            countLabel.ForeColor = Color.White;

            timerLabel.BackColor = Color.FromArgb(21, 101, 192);
            timerLabel.ForeColor = Color.White;

            initGame();
        }

        private void answersList_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            if (e.Index < 0) return;

            e.DrawBackground();
            //Let’s declare a brush, so that we can color the items that are added in the listbox. 
            /*Brush myBrush = new SolidBrush(Color.White);*/
            if ((e.State == DrawItemState.Selected))
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(21, 101, 192)), e.Bounds);
            } else
            {
                /*myBrush = new SolidBrush(Color.Black);*/
            }
            //Determine the color of the brush to draw each item based on the index of the item to draw. 
            /*switch ((e.Index) % 2)
            {
                case 0:
                    myBrush = Brushes.Black;
                    break;
                case 1:
                    myBrush = Brushes.Black;
                    break;
            }*/
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;


            //if the item state is selected them change the back color 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          Color.White,
                                          Color.FromArgb(21, 101, 192));//Choose the color

            e.DrawBackground();
            e.Graphics.DrawString(lb.Items[e.Index].ToString(), lb.Font, new SolidBrush(e.ForeColor), new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
            //If the ListBox has focus, draw a focus rectangle around the selected item. 
            e.DrawFocusRectangle();
        }

        private void answersList_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            Graphics g = e.Graphics;
            //We will get the size of the string which we are about to draw, 
            //so that we could set the ItemHeight and ItemWidth property 
            SizeF size = g.MeasureString(lb.Items[e.Index].ToString(), lb.Font, Width - 10 - SystemInformation.VerticalScrollBarWidth);
            e.ItemHeight = Convert.ToInt32(size.Height) + 20;
            e.ItemWidth = Convert.ToInt32(size.Width) + 5;
        }

        private string ExportToExcel()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheetResult = workbook.Worksheets.Add("Результат основной ");
                DataTable dt = new DataTable();
                DataRow[] dtr = testerDataSet.result.Select("id = " + result_id.ToString());
                dt = dtr.CopyToDataTable();
                dt = DtColumnsRemove(dt, new string[] { "id", "user_id", "test_id", "opk_result_id" });
                dt = DtColumnsRename(dt, new string[] { "Дата завершения", "Логин", "Фамилия", "Имя", "Отчество", "Название группы", "Оценка (в %)", "Дата начала" });
                DateTime Savedt = DateTime.Now;
                string SaveFileName = dt.Rows[0]["Фамилия"].ToString() + "_" + dt.Rows[0]["Имя"].ToString() + "_" + Savedt.ToString("yyyyMMddHHmmss") + ".xlsx";
                worksheetResult.Cell(1, 1).InsertTable(dt, false);
                var worksheetResult_OPK = workbook.Worksheets.Add("Результат по компетенциям ");
                dtr = testerDataSet.opk_result.Select("result_id = " + result_id.ToString());
                dt = dtr.CopyToDataTable();
                dt = DtColumnsRemove(dt, new string[] { "Id", "user_id", "result_id" });
                dt = DtColumnsRename(dt, new string[] { "Идентификатор Компетенции", "Кол-во правильных", "Кол-во вопросов", "% Освоения", "Описание результата", "Название компетенции", "Требуемый % для освоения компетенции" });
                worksheetResult_OPK.Cell(1, 1).InsertTable(dt, false);
                var worksheetResult_QA = workbook.Worksheets.Add("Результат подробно ");
                dtr = testerDataSet.question.Select("test_id = " + testId);
                dt = dtr.CopyToDataTable();
                dt = DtColumnsRemove(dt, new string[] { "id", "image", "test_id" });
                dt = DtColumnsRename(dt, new string[] { "Название", "Описание", "Идентификатор компетенции", "Идентификатор типа" });
                List<string> tmpColumnNames = new List<string>();
                foreach (DataColumn column in dt.Columns)
                    tmpColumnNames.Add(column.ColumnName);
                tmpColumnNames.Add("Ответ");
                tmpColumnNames.Add("Правильный");
                worksheetResult_QA.Cell(1, 1).InsertData(tmpColumnNames, true);
                int x = 2;
                int y = 1;
                DataTable dtRA = testerDataSet.result_answer.Select("result_id = "+result_id.ToString()).CopyToDataTable();
                foreach (DataRow Row in dtr)
                {
                    DataRow opkTextRow = testerDataSet.OPK.Select("Id = " + Row[5])[0];
                    DataRow TypeTextRow = testerDataSet.Question_Types.Select("Id = " + Row[6])[0];
                    worksheetResult_QA.Cell(x, y).InsertData(new string[] { Row[1].ToString(), Row[2].ToString(), opkTextRow[1].ToString(), TypeTextRow[1].ToString()  }, true);
                    y += 4;
                    DataRow[] dtrA = dtRA.Select("question_id = "+ Row[0].ToString());
                    foreach (DataRow AnswerRow in dtrA)
                    {
                        worksheetResult_QA.Cell(x, y).InsertData(new string[] { AnswerRow[3].ToString(), (bool)AnswerRow[4]? "ДА": "НЕТ" }, true);
                        x++;
                    }
                    x++;
                    y = 1;
                    
                }
                workbook.SaveAs(Environment.CurrentDirectory + @"/TestingResults/" + groupName + "/" + SaveFileName);
                return SaveFileName;
            }
        }

        private DataTable DtColumnsRename(DataTable dt, string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                dt.Columns[i].ColumnName = names[i];
            }
            return dt;
        }

        private DataTable DtColumnsRemove(DataTable dt, string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                dt.Columns.Remove(dt.Columns[names[i]]);
            }
            return dt;
        }

        private void AnswerTextBox1_TextChanged(object sender, EventArgs e)
        {
            nextQuestion.Enabled = true;
        }

        private void countLabel_Click(object sender, EventArgs e)
        {

        }

        private void panelMatching_Click(object sender, EventArgs e)
        {
            nextQuestion.Enabled = true;
        }
    }
}
