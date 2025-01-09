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
    public partial class MailForm : Form
    {
        public MailForm()
        {
            InitializeComponent();
        }

        private void MailForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.adminNetworkData". При необходимости она может быть перемещена или удалена.
            this.adminNetworkDataTableAdapter.Fill(this.testerDataSet.adminNetworkData);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SMTP_Mail smtpSend = new SMTP_Mail();
            smtpSend.SendMail(dataGridView1.Rows[0].Cells[1].Value.ToString(), "587", "ardestap", dataGridView1.Rows[0].Cells[4].Value.ToString(), "ardestap@yandex.ru", dataGridView1.Rows[0].Cells[6].Value.ToString(), "RESULT SEND", "PING", textBox1.Text, true, "G:\\Новая папка (2)\\Hello World.txt");
        }
    }
}
