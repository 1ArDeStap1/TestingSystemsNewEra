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

namespace Tester
{
    public partial class DoTestForm : Form
    {
        int testId = 0;
        int userId = 0;
        bool trening;
        int timeLimit = 0;
        bool hardEnd = false;
        public DoTestForm(int testId, int userId, int timeLimit = 0)
        {
            InitializeComponent();
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

        private void initGame()
        {
            if (dataGridView2.RowCount > 0)
            {
                Question[] questions = new Question[dataGridView2.RowCount];
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    answerBindingSource.Filter = "question_id = " + dataGridView2.Rows[i].Cells[0].Value.ToString();
                    answerBindingSource.ResetBindings(true);
                    if (dataGridView3.RowCount > 0)
                    {
                        Answer[] tmpAnswers = new Answer[dataGridView3.RowCount];
                        int[] tmpCAnswers = new int[0];
                        for (int j=0; j < dataGridView3.RowCount; j++)
                        {
                            tmpAnswers[j] = new Answer();
                            tmpAnswers[j].id = Convert.ToInt32(dataGridView3.Rows[j].Cells[0].Value.ToString());
                            tmpAnswers[j].content = dataGridView3.Rows[j].Cells[1].Value.ToString();
                            if (Convert.ToBoolean(((DataGridViewCheckBoxCell)(dataGridView3.Rows[j].Cells[2])).Value.ToString()))
                            {
                                Array.Resize<int>(ref tmpCAnswers, tmpCAnswers.Length + 1);
                                tmpCAnswers[tmpCAnswers.Length - 1] = j;
                            }
                        }
                        Bitmap question;
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

                        questions[i] = new Question((int)dataGridView2.Rows[i].Cells[0].Value, (string)dataGridView2.Rows[i].Cells[1].Value, question, tmpAnswers, tmpCAnswers);
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
            questionImage.Image = question.image;
            answersList.Items.Clear();
            answersList.Items.AddRange(question.answers);
            countLabel.Text = q.ToString() + " из " + test.Count.ToString();
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
            int[] currentAnswers = new int[answersList.SelectedIndices.Count];
            for (int i = 0; i < currentAnswers.Length; i++)
                currentAnswers[i] = answersList.SelectedIndices[i];
            test.answers = currentAnswers;
            if (!test.isEnd() && !hardEnd)
            {
                fillQuestion(test.nextQuestion());
            }
            else
            {
                timer.Stop();
                q--;
                test.nextQuestion();
                double mark = Math.Floor((Convert.ToDouble(test.rightsCount) / Convert.ToDouble(test.Count)) * 1000.0) / 100.0;
                MessageBox.Show("Молодец, так держать!\nТы ответил правильно на " + test.rightsCount.ToString() + " вопросов из " + test.Count.ToString() + "!\n" +
                    "Предполагаемая отметка: " + mark.ToString() + "\n" +
                    "Время прохождения теста в секундах: " + timerLabel.Text + "\r\nОсвоены компетенции ");
                if (!trening)
                {
                    int inserted = Convert.ToInt32(resultTableAdapter.InsertQuery(userId, testId, mark, startedTime));
                    Debug.WriteLine("id: " + inserted.ToString());
                    foreach (int answer in test.answersIds)
                    {
                        result_answerTableAdapter.Insert(inserted, answer);
                    }
                    resultTableAdapter.Fill(testerDataSet.result);
                    result_answerTableAdapter.Fill(testerDataSet.result_answer);
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet1.result_answer". При необходимости она может быть перемещена или удалена.
            this.result_answerTableAdapter.Fill(this.testerDataSet.result_answer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet1.result". При необходимости она может быть перемещена или удалена.
            this.resultTableAdapter.Fill(this.testerDataSet.result);
            this.answerTableAdapter.Fill(this.testerDataSet.answer);
            this.questionTableAdapter.Fill(this.testerDataSet.question);
            this.testTableAdapter.Fill(this.testerDataSet.test);

            answersList.DrawMode = DrawMode.OwnerDrawVariable;

            initGame();
        }

        private void answersList_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            if (e.Index < 0) return;

            e.DrawBackground();
            //Let’s declare a brush, so that we can color the items that are added in the listbox. 
            Brush myBrush = default(Brush);
            if ((e.State == DrawItemState.Selected))
            {
                e.Graphics.FillRectangle(Brushes.LightCyan, e.Bounds);
            }
            //Determine the color of the brush to draw each item based on the index of the item to draw. 
            switch ((e.Index) % 2)
            {
                case 0:
                    myBrush = Brushes.Teal;
                    break;
                case 1:
                    myBrush = Brushes.MediumSlateBlue;
                    break;
            }
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
                                          e.ForeColor,
                                          Color.Cyan);//Choose the color

            e.DrawBackground();
            e.Graphics.DrawString(lb.Items[e.Index].ToString(), lb.Font, myBrush, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
            //If the ListBox has focus, draw a focus rectangle around the selected item. 
            e.DrawFocusRectangle();
        }

        private void answersList_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            Graphics g = e.Graphics;
            //We will get the size of the string which we are about to draw, 
            //so that we could set the ItemHeight and ItemWidth property 
            SizeF size = g.MeasureString(lb.Items[e.Index].ToString(), lb.Font, Width - 5 - SystemInformation.VerticalScrollBarWidth);
            e.ItemHeight = Convert.ToInt32(size.Height) + 5;
            e.ItemWidth = Convert.ToInt32(size.Width) + 5;
        }
    }
}
