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


using MaterialSkin;
using MaterialSkin.Controls;

namespace Tester
{
    public partial class MailForm : MaterialForm
    {
        Size DefaultFormSize = new Size(441, 298);
        Size ExtendedSize = new Size(892, 454);
        bool IsExtendedOptions = false;
        public MailForm()
        {
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
            InitializeComponent();
        }

        private void MailForm_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testerDataSet.adminNetworkData". При необходимости она может быть перемещена или удалена.
            this.adminNetworkDataTableAdapter.Fill(this.testerDataSet.adminNetworkData);
            

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
                
                IsExtendedOptions = false;
            } else
            {
                this.Size = ExtendedSize;
                
                IsExtendedOptions = true;
            }
        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {

        }
    }
}
