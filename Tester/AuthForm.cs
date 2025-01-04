using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tester.AnimationClasses;

namespace Tester
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            Animator.Start();

            string fontName = "Open Sans";
            string fontPath = Application.StartupPath+"/Fonts/OpenSans-Regular.ttf";
            float fontSize = 12;

            using (Font fontTester = new Font(
                    fontName,
                    fontSize,
                    FontStyle.Regular,
                    GraphicsUnit.Pixel))
            { 
                if (fontTester.Name != fontName)
                {
                    if (File.Exists(fontPath))
                    {
                        //AddFont
                        MessageBox.Show("Пожалуйста, установите предложенный шрифт для корректного отображения информации.");
                        Process.Start(fontPath);
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegForm form = new RegForm();
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

        private void button1_Click(object sender, EventArgs e)
        {
            int authed = 0;
            try
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.testerConnectionString);
                conn.Open();
                SqlCommand checkLogin = conn.CreateCommand();
                checkLogin.CommandText = "SELECT id FROM users WHERE CONVERT(VARCHAR, login) = '" + textBox1.Text+ "' AND CONVERT(VARCHAR, password) = '" + textBox2.Text + "'";
                authed = Convert.ToInt32(checkLogin.ExecuteScalar());
                conn.Close();
            }
            catch
            {

            }
            if (textBox1.Text == Properties.Settings.Default.Логин_администратора && textBox2.Text== Properties.Settings.Default.Пароль_администратора)
            {
                AdminForm adminForm = new AdminForm();
                Hide();
                try
                {
                    adminForm.ShowDialog(this);
                }
                finally
                {
                    Show();
                }
            }
            else
            {
                if (authed > 0)
                {
                    MainForm form = new MainForm(authed);
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
                else
                {
                    MessageBox.Show("Увы, вы ввели неправильный логи или пароль.\nПопытайтесь ещё раз.", "Войти не получилось", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void AuthForm_Shown(object sender, EventArgs e)
        {
            
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            formsStyle1.Apply();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
