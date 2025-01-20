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
using Tester.testerDataSetTableAdapters;

using MaterialSkin;
using MaterialSkin.Controls;

namespace Tester
{
    public partial class TestCreation : MaterialForm
    {
        public TestCreation()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminForm Adm = new AdminForm();

            Adm.testTableAdapter.Insert(textBox6.Text, textBox7.Text, Convert.ToInt32(numericUpDown2.Text));
                
            Adm.testTableAdapter.Update(Adm.testerDataSet.test);

            Adm.testTableAdapter.Fill(Adm.testerDataSet.test);

            AddQuestionForm addQuestion = new AddQuestionForm();
            Hide();
            addQuestion.ShowDialog(Adm);
            Show();


            //InsertedMessage();
        }
    }
}
