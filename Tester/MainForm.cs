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
    public partial class MainForm : Form
    {
        int userId;
        public MainForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.question". При необходимости она может быть перемещена или удалена.
            this.questionTableAdapter.Fill(this.testerDataSet.question);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.test". При необходимости она может быть перемещена или удалена.
            this.testTableAdapter.Fill(this.testerDataSet.test);

            splitContainer1.Panel2.HorizontalScroll.Enabled = false;
            splitContainer1.Panel2.HorizontalScroll.Visible = false;
            splitContainer1.Panel2.AutoScrollPosition = new Point(0,0);
            resetScrolls();

        }

        private void resetScrolls()
        {
            splitContainer1.Panel2.AutoScrollPosition = new Point(0, 0);
            splitContainer1.Panel2.AutoScrollOffset = new Point(0, 0);
            splitContainer1.Panel2.VerticalScroll.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoTestForm form = new DoTestForm(Convert.ToInt32(((Button)sender).Tag), userId, Convert.ToInt32(label2.Tag));
            Hide();
            try
            {
                form.ShowDialog(this);
            }
            finally
            {
                Show();
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("help.pdf");
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            resetScrolls();
        }

        private void label2_SizeChanged(object sender, EventArgs e)
        {
            resetScrolls();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*try
            {*/
            if (Grid.SelectedRows.Count > 0)
            {
                ShowResultsForm form = new ShowResultsForm((int)Grid.SelectedRows[0].Cells[0].Value, userId);
                form.ShowDialog(this);
            }
            /*}
            catch (Exception ex) { }*/
        }

        private void учебныйМатераилToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("material.chm");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
