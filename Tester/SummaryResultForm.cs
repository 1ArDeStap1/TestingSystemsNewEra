using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Tester
{
    public partial class SummaryResultForm : Form
    {
        int Result;
        double ComplitionPercent;
        private string[] firstString = new string[3] {
        "- Вы продемонстрировали отрывочные знания нормативно-правовых документов в сфере образования;\r\n-Вами не корретно определены цель, задачи и алгоритм подготовки и проведения родительского собрания;\r\n- Вами допущены ошибки при отборе форм, методов, \r\nтехнологий организации родительских собраний и индивидуального и тематического консультирования родителей (или законных представителей) обучающихся основного общего образования по типичным проблемам обучения и воспитания; \r\n- Вы не в полной мере\r\nвладеете методами анализа\r\nпедагогической ситуации и критериями успешного взаимодействия с участниками образовательного процесса.",
            "- Вы продемонстрировали на достаточном уровне знание нормативно-правовых документов в сфере образования. \r\n-Вами были допущены небольшие погрешности при определении цели и задач и алгоритма подготовки и проведения родительского собрания; \r\n-Имеются некоторые ошибки при отборе форм, методов и\tтехнологии организации родительских собраний и индивидуального и тематического консультирования родителей (или законных представителей) обучающихся основного общего образования по типичным проблемам обучения и воспитания; \r\n-Вами допущены незначительные ошибки при анализе\r\nпедагогической ситуации с учетом критериев успешного взаимодействия с участниками образовательного процесса; ",
            "- Вы продемонстрировали отличное знание нормативно-правовых документов в сфере образования;\r\n- Вы продемонстрировали корректную постановку цели, задач и знание алгоритма подготовки и проведения родительского собрания;\r\n-Вами успешно и систематически использованы формы, методы и технологии организации родительских собраний и индивидуального и тематического консультирования родителей (или законных представителей) обучающихся основного общего образования по типичным проблемам обучения и воспитания; \r\n-Вы в полной мере продемонстрировали \r\nУмение применять\r\nметоды анализа\r\nпедагогической\r\nситуации с учетом критериев успешного взаимодействия с участниками образовательного процесса"};

        private string[] SecondString = new string[3] {
        "Достигнутый уровень оценки результатов обучения показывает, что Вами усвоены элементарные знания основных вопросов по подготовке и проведению родительского собрания, но Вы проявили недостаточное владение системой знаний об особенностях адаптации обучающихся основного общего образования, формах, методах и технологиях взаимодействия с родителями",
        "Достигнутый уровень оценки результатов обучения показывает, что Вы имеете представления о формах, методах, технологиях организации родительских собраний и индивидуального и тематического консультирования родителей (или законных представителей); умеете применять их на определенных этапах взаимодействия с родителями. ",
        "Достигнутый уровень оценки результатов обучения показывает, что у Вас имеются прочные знания и развитые практические умения для их применения при подготовке и проведении родительского собрания и организации взаимодействия\r\nс участниками образовательного процесса по вопросам адаптации обучающихся основного общего образования."};

        private string[] ThirdString = new string[3] {
        "Вам необходимо:\r\n- повторить теоретические материалы по основным требованиям к организации и проведению родительского собрания по вопросам адаптации обучающихся основного общего образования; к организации индивидуального и тематического консультирования родителей (или законных представителей) обучающихся основного общего образования по типичным проблемам обучения и воспитания;  \r\n -научиться формулировать цель, задачи и освоить алгоритм подготовки и проведения родительского собрания;   \r\n-научиться проектировать работу с родителями с учетом критериев успешного взаимодействия с участниками образовательного процесса\r\n",
        "Вам необходимо: \r\n-научиться отбирать соответствующие ресурсы, наиболее эффективные формы, методы и технологии организации взаимодействия с участниками образовательного процесса   \r\n",
        "Вы молодец! Нет предела совершенству, поэтому не останавливайтесь на достигнутом!"};

        public SummaryResultForm(int ResultId, double ComplitionPercent)
        {
            InitializeComponent();
            this.Result = ResultId;
            this.ComplitionPercent = ComplitionPercent;
        }
        
        private void SummaryResultForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.testerConnectionString))
            {
                conn.Open();

                string query = @"SELECT
                    o.Name AS 'Компетенция', 
                    opr.user_id AS 'Пользователь', 
                    opr.corrects AS 'Кол-во правильных', 
                    opr.all_questions AS 'Всего вопросов', 
                    opr.opk_percent AS 'Процент компетенции'
                FROM opk_result AS opr 
                JOIN OPK o ON opr.opk_id = o.Id
                WHERE result_id = @ResId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ResId", Result);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    OpkResultTable.DataSource = dt;
                }
            }
            ConstructResult();
        }

        private void ConstructResult()
        {
            string BigResult = "";
            /*double cPercent;
            foreach (DataRow Drow in OpkResultTable.Rows)
            {
                if (Drow[0].ToString().ToUpper().Contains("ОПК 7"))
                {
                    BigResult += "\r\n\r\n";
                    cPercent = Math.Round(Convert.ToDouble((int)Drow[2]) / Convert.ToDouble((int)Drow[3] * 100), 2);
                    BigResult += AddStringIndexResult(cPercent, 1);
                } else if (Drow[0].ToString().ToUpper().Contains("ПК 2"))
                {
                    BigResult += "\r\n\r\n";
                    cPercent = Math.Round(Convert.ToDouble((int)Drow[2]) / Convert.ToDouble((int)Drow[3] * 100), 2);
                    BigResult += AddStringIndexResult(cPercent, 2);
                }
            }*/


            BigResult += AddStringIndexResult(ComplitionPercent, 1);
            BigResult += "\r\n\r\n";
            BigResult += AddStringIndexResult(ComplitionPercent, 2);
            BigResult += "\r\n\r\n";
            BigResult += AddStringIndexResult(ComplitionPercent, 3);
            materialLabel1.Text = BigResult;
        }

        private string AddStringIndexResult(double Percentcompl, int ResArray)
        {
            int i = 0;
            if (Percentcompl <= 70)
            {
                i = 0;
            } else if (Percentcompl <= 85)
            {
                i = 1;
            } else {
                i = 2;
            }

            if (ResArray == 1)
            {
                return firstString[i];
            }
            else if (ResArray == 2)
            {
                return SecondString[i];
            }
            else
            {
                return ThirdString[i];
            }
        }

    }
}
