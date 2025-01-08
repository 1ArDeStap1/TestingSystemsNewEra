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
    public partial class Opk_Result_Form : Form
    {
        public Opk_Result_Form(int UserID, int ResultID)
        {
            InitializeComponent();
            opkresultBindingSource1.Filter = "user_id = "+ UserID.ToString() + " AND result_id = " + ResultID.ToString();
        }

        private void Opk_Result_Form_Load(object sender, EventArgs e)
        {
            this.opk_resultTableAdapter1.Fill(this.testerDataSet.opk_result);

        }
    }
}
