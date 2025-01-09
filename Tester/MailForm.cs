using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tester.AnimationClasses;
using Tester.CustomStyles;

namespace Tester
{
    public partial class MailForm : Form
    {
        Size DefaultFormSize = new Size(441, 298);
        Size ExtendedSize = new Size(892, 454);
        bool IsExtendedOptions = false;
        public MailForm()
        {
            Animator.Start();
            InitializeComponent();
        }

        private void MailForm_Load(object sender, EventArgs e)
        {
            formsStyle1.Apply();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.adminNetworkData". При необходимости она может быть перемещена или удалена.
            this.adminNetworkDataTableAdapter.Fill(this.testerDataSet.adminNetworkData);
            this.Size = DefaultFormSize;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dtO = testerDataSet.adminNetworkData.Select("Id = 1")[0];
            if (!IsExtendedOptions)
            {
                if (customTextBox1.Text != "")
                {
                    dtO[7] = customTextBox1.Text;
                    
                } else
                {
                    MessageBox.Show("Не все поля заполнены");
                }

            }
            else
            {
                if (customTextBox1.Text != "" && customTextBox2.Text != "" && customTextBox3.Text != "" && customTextBox4.Text != "" && customTextBox5.Text != "" && customTextBox6.Text != "" && customTextBox7.Text != "")
                {
                    dtO[1] = customTextBox2.Text;
                    dtO[2] = customTextBox3.Text;
                    dtO[3] = customTextBox4.Text;
                    dtO[4] = customTextBox5.Text;
                    dtO[5] = customTextBox6.Text;
                    dtO[6] = customTextBox7.Text;
                    dtO[7] = customTextBox1.Text;
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены");
                }
            }
            adminNetworkDataTableAdapter.Update(dtO);
            adminNetworkDataTableAdapter.Fill(testerDataSet.adminNetworkData);
        }

        private void ExtendedOptions_Click(object sender, EventArgs e)
        {
            if (IsExtendedOptions)
            {
                this.Size = DefaultFormSize;
                formsStyle1.Apply(false);
                IsExtendedOptions = false;
            } else
            {
                this.Size = ExtendedSize;
                formsStyle1.Apply(false);
                IsExtendedOptions = true;
            }
        }
    }
}
