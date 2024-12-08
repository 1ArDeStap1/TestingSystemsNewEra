using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox5.Text != textBox6.Text) || (textBox1.Text.ToLower() == "admin"))
            {
                Program.MessageError();
            }
            else {
                try
                {
                    int inserdted = usersTableAdapter.Insert(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, Convert.ToInt32(comboBox1.SelectedValue));
                    Program.MessageRegistered();
                }
                catch (Exception ex)
                {
                    Program.MessageError(ex);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.testerDataSet.group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.testerDataSet.users);

        }
    }
}
