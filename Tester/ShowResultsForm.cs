using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester
{
    public partial class ShowResultsForm : Form
    {
        public ShowResultsForm(int testId, int userId)
        {
            InitializeComponent();
            questionBindingSource.Filter = "test_id = "+testId.ToString();
            resultBindingSource.Filter = "user_id = " + userId.ToString() + " AND test_id = "+testId.ToString();
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
                fKanswerquestionBindingSource.Filter = filt;
                Debug.WriteLine(filt);
                fKanswerquestionBindingSource.ResetBindings(true);
            }
            else
            {
                fKanswerquestionBindingSource.Filter = "id = 0";
            }
        }

        private void ShowResultsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.answer". При необходимости она может быть перемещена или удалена.
            this.answerTableAdapter.Fill(this.testerDataSet.answer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.question". При необходимости она может быть перемещена или удалена.
            this.questionTableAdapter.Fill(this.testerDataSet.question);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.answer". При необходимости она может быть перемещена или удалена.
            this.answerTableAdapter.Fill(this.testerDataSet.answer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.question". При необходимости она может быть перемещена или удалена.
            this.questionTableAdapter.Fill(this.testerDataSet.question);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.result_answer". При необходимости она может быть перемещена или удалена.
            this.result_answerTableAdapter.Fill(this.testerDataSet.result_answer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.result". При необходимости она может быть перемещена или удалена.
            this.resultTableAdapter.Fill(this.testerDataSet.result);

            if (dataGridView3.Rows.Count <= 0)
            {
                Hide();
                MessageBox.Show("Вы ещё не проходили этот тест.");
                Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
