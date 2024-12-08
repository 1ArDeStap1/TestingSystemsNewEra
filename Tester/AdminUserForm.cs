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
    public partial class AdminUserForm : Form
    {
        public AdminUserForm()
        {
            InitializeComponent();
        }

        private void AdminUserForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.testerDataSet.group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.testerDataSet.users);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox5.Text != textBox6.Text) || (textBox10.Text.ToLower() == "admin"))
            {
                Program.MessageError();
            }
            else {
                try
                {
                    int inserdted = usersTableAdapter.Insert(textBox10.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox5.Text, Convert.ToInt32(comboBox2.SelectedValue));
                    groupTableAdapter.Fill(testerDataSet.group);
                    Program.MessageCreated();
                }
                catch (Exception ex)
                {
                    Program.MessageError(ex);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text != textBox3.Text) || (textBox14.Text.ToLower() == "admin"))
            {
                Program.MessageError();
            }
            else {
                try
                {
                    usersTableAdapter.Update(textBox14.Text, textBox11.Text, textBox12.Text, textBox13.Text, textBox1.Text, Convert.ToInt32(comboBox3.SelectedValue), Convert.ToInt32(Grid.SelectedRows[0].Cells[0].Value), Convert.ToInt32(Grid.SelectedRows[0].Cells[0].Value));
                    usersTableAdapter.Fill(testerDataSet.users);
                    Program.MessageCreated();
                }
                catch (Exception ex)
                {
                    Program.MessageError(ex);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                usersTableAdapter.Delete(Convert.ToInt32(Grid.SelectedRows[0].Cells[0].Value));
                usersTableAdapter.Fill(testerDataSet.users);
                Program.MessageCreated();
            }
            catch (Exception ex)
            {
                Program.MessageError(ex);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Поиск")
            {
                button3.Text = "Сброс";
                usersBindingSource.Filter = "login LIKE '%" + textBox4.Text + "%' AND name LIKE '%" + comboBox1.Text + "%'";
            }
            else
            {
                button3.Text = "Поиск";
                usersBindingSource.RemoveFilter();
            }
        }
    }
}
