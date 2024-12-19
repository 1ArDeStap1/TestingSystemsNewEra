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

namespace Tester
{
    public partial class TestCreation : Form
    {
        public TestCreation()
        {
            InitializeComponent();
            Animator.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formsStyle1.Apply();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminForm Adm = new AdminForm();

            Adm.testTableAdapter.Insert(textBox6.TextInput, textBox7.TextInput, Convert.ToInt32(numericUpDown2.TextInput));

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
