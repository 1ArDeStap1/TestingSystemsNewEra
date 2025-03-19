using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class MatchingAnswerForm : MaterialForm
    {
        public MatchingAnswerForm()
        {
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue900, Primary.Blue800,
                Primary.Blue700, Accent.LightBlue700,
                TextShade.WHITE
            );

            InitializeComponent();
        }

        private void MatchingAnswerForm_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            
            MatchingControl matchingControl = new MatchingControl();
            matchingControl.LoadPairs(new Dictionary<string, string>
            {
                { "Apple", "Яблоко" },
                { "Dog", "Собака" },
                { "Car", "Машина" }
            });

            panelMatching.Controls.Add(matchingControl);

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            foreach (var control in panelMatching.Controls)
            {
                if (control is MatchingControl matchingControl)
                {
                    if (matchingControl.CheckAnswers())
                        MessageBox.Show("Все ответы верны!");
                    else
                        MessageBox.Show("Есть ошибки, попробуйте ещё раз.");
                }
            }
        }
    }
}
