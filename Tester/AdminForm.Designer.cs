using System.Drawing;
using System.Windows.Forms;

namespace Tester
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.ToolStripMenu = new System.Windows.Forms.MenuStrip();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testerDataSet = new Tester.testerDataSet();
            this.questionTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKquestiontestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oPKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKanswerquestionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKresultvariantresultBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKresulttestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKquestiontestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKanswerquestionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Grid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.testTableAdapter = new Tester.testerDataSetTableAdapters.testTableAdapter();
            this.answerTableAdapter = new Tester.testerDataSetTableAdapters.answerTableAdapter();
            this.resultTableAdapter = new Tester.testerDataSetTableAdapters.resultTableAdapter();
            this.result_answerTableAdapter = new Tester.testerDataSetTableAdapters.result_answerTableAdapter();
            this.questionTableAdapter1 = new Tester.testerDataSetTableAdapters.questionTableAdapter();
            this.fKresultvariantresultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKresultvariantanswerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionOPKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oPKTableAdapter = new Tester.testerDataSetTableAdapters.OPKTableAdapter();
            this.questionQuestionTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.question_TypesTableAdapter1 = new Tester.testerDataSetTableAdapters.Question_TypesTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox2 = new Tester.CustomStyles.CustomTextBox();
            this.numericUpDown1 = new Tester.CustomStyles.CustomTextBox();
            this.textBox1 = new Tester.CustomStyles.CustomTextBox();
            this.customButton2 = new Tester.CustomButton();
            this.customButton1 = new Tester.CustomButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.btnExport = new System.Windows.Forms.Button();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.test_idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formsStyle1 = new Tester.FormsStyle(this.components);
            this.Группы = new System.Windows.Forms.ToolStripMenuItem();
            this.Пользователи = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKquestiontestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKanswerquestionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKresultvariantresultBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKresulttestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKquestiontestBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKanswerquestionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKresultvariantresultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKresultvariantanswerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionOPKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionQuestionTypesBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl5.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStripMenu
            // 
            this.ToolStripMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Группы,
            this.Пользователи});
            this.ToolStripMenu.Location = new System.Drawing.Point(13, 9);
            this.ToolStripMenu.Name = "ToolStripMenu";
            this.ToolStripMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.ToolStripMenu.Size = new System.Drawing.Size(167, 24);
            this.ToolStripMenu.TabIndex = 0;
            this.ToolStripMenu.Text = "Группы";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // группыToolStripMenuItem
            // 
            this.группыToolStripMenuItem.Name = "группыToolStripMenuItem";
            this.группыToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.группыToolStripMenuItem.Text = "Группы";
            this.группыToolStripMenuItem.Click += new System.EventHandler(this.группыToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataMember = "test";
            this.testBindingSource.DataSource = this.testerDataSet;
            this.testBindingSource.CurrentChanged += new System.EventHandler(this.testBindingSource_CurrentChanged);
            // 
            // testerDataSet
            // 
            this.testerDataSet.CaseSensitive = true;
            this.testerDataSet.DataSetName = "testerDataSet";
            this.testerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questionTypesBindingSource
            // 
            this.questionTypesBindingSource.DataMember = "Question_Types";
            this.questionTypesBindingSource.DataSource = this.testerDataSet;
            // 
            // fKquestiontestBindingSource
            // 
            this.fKquestiontestBindingSource.DataMember = "FK_question_test";
            this.fKquestiontestBindingSource.DataSource = this.testBindingSource;
            // 
            // oPKBindingSource
            // 
            this.oPKBindingSource.DataMember = "OPK";
            this.oPKBindingSource.DataSource = this.testerDataSet;
            // 
            // fKanswerquestionBindingSource
            // 
            this.fKanswerquestionBindingSource.DataSource = this.fKquestiontestBindingSource;
            // 
            // fKresultvariantresultBindingSource1
            // 
            this.fKresultvariantresultBindingSource1.DataMember = "FK_result_variant_result";
            this.fKresultvariantresultBindingSource1.DataSource = this.fKresulttestBindingSource;
            this.fKresultvariantresultBindingSource1.CurrentChanged += new System.EventHandler(this.fKresultvariantresultBindingSource1_CurrentChanged);
            this.fKresultvariantresultBindingSource1.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.fKresultvariantresultBindingSource1_ListChanged);
            // 
            // fKresulttestBindingSource
            // 
            this.fKresulttestBindingSource.DataMember = "FK_result_test";
            this.fKresulttestBindingSource.DataSource = this.testBindingSource;
            // 
            // fKquestiontestBindingSource1
            // 
            this.fKquestiontestBindingSource1.DataMember = "FK_question_test";
            this.fKquestiontestBindingSource1.DataSource = this.testBindingSource;
            // 
            // fKanswerquestionBindingSource1
            // 
            this.fKanswerquestionBindingSource1.DataMember = "FK_answer_question";
            this.fKanswerquestionBindingSource1.DataSource = this.fKquestiontestBindingSource1;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AutoGenerateColumns = false;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid.BackgroundColor = System.Drawing.Color.Linen;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.Grid.DataSource = this.testBindingSource;
            this.Grid.GridColor = System.Drawing.SystemColors.Control;
            this.Grid.Location = new System.Drawing.Point(13, 46);
            this.Grid.Margin = new System.Windows.Forms.Padding(4);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Grid.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(211, 591);
            this.Grid.TabIndex = 9;
            this.Grid.TabStop = false;
            this.Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "№";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 45;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // testTableAdapter
            // 
            this.testTableAdapter.ClearBeforeFill = true;
            // 
            // answerTableAdapter
            // 
            this.answerTableAdapter.ClearBeforeFill = true;
            // 
            // resultTableAdapter
            // 
            this.resultTableAdapter.ClearBeforeFill = true;
            // 
            // result_answerTableAdapter
            // 
            this.result_answerTableAdapter.ClearBeforeFill = true;
            // 
            // questionTableAdapter1
            // 
            this.questionTableAdapter1.ClearBeforeFill = true;
            // 
            // fKresultvariantresultBindingSource
            // 
            this.fKresultvariantresultBindingSource.DataMember = "FK_result_variant_result";
            this.fKresultvariantresultBindingSource.DataSource = this.fKresulttestBindingSource;
            // 
            // fKresultvariantanswerBindingSource
            // 
            this.fKresultvariantanswerBindingSource.DataSource = this.fKanswerquestionBindingSource;
            // 
            // questionOPKBindingSource
            // 
            this.questionOPKBindingSource.DataSource = this.fKquestiontestBindingSource;
            // 
            // oPKTableAdapter
            // 
            this.oPKTableAdapter.ClearBeforeFill = true;
            // 
            // questionQuestionTypesBindingSource
            // 
            this.questionQuestionTypesBindingSource.DataSource = this.fKquestiontestBindingSource;
            // 
            // question_TypesTableAdapter1
            // 
            this.question_TypesTableAdapter1.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Location = new System.Drawing.Point(228, 46);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 595);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage1.Controls.Add(this.tabControl3);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(795, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Информация о тесте";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(4, 4);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(787, 559);
            this.tabControl3.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.numericUpDown1);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.customButton2);
            this.tabPage3.Controls.Add(this.customButton1);
            this.tabPage3.Controls.Add(this.linkLabel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(779, 531);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Изменение";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderColor = System.Drawing.Color.DarkBlue;
            this.textBox2.BorderColorNotActive = System.Drawing.Color.DarkGray;
            this.textBox2.Font = new System.Drawing.Font("Arial", 11.5F);
            this.textBox2.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(7, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(762, 265);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextInput = "";
            this.textBox2.TextPreview = "Описание теста";
            this.textBox2.UseSystemPasswordChars = false;
            this.textBox2.VerticalOffset = 100;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.BorderColor = System.Drawing.Color.DarkBlue;
            this.numericUpDown1.BorderColorNotActive = System.Drawing.Color.DarkGray;
            this.numericUpDown1.Font = new System.Drawing.Font("Arial", 11.5F);
            this.numericUpDown1.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.numericUpDown1.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown1.Location = new System.Drawing.Point(7, 80);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(275, 52);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.TextInput = "";
            this.numericUpDown1.TextPreview = "Время прохождения теста";
            this.numericUpDown1.UseSystemPasswordChars = false;
            this.numericUpDown1.VerticalOffset = 100;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderColor = System.Drawing.Color.DarkBlue;
            this.textBox1.BorderColorNotActive = System.Drawing.Color.DarkGray;
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.5F);
            this.textBox1.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(7, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(702, 54);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextInput = "";
            this.textBox1.TextPreview = "Название Теста";
            this.textBox1.UseSystemPasswordChars = false;
            this.textBox1.VerticalOffset = 0;
            this.textBox1.Click += new System.EventHandler(this.TextBox1_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.DarkBlue;
            this.customButton2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customButton2.ForeColor = System.Drawing.Color.Chartreuse;
            this.customButton2.Location = new System.Drawing.Point(339, 452);
            this.customButton2.Margin = new System.Windows.Forms.Padding(4);
            this.customButton2.Name = "customButton2";
            this.customButton2.RoundingEnabled = true;
            this.customButton2.RoundingPercent = 30;
            this.customButton2.Size = new System.Drawing.Size(430, 57);
            this.customButton2.TabIndex = 11;
            this.customButton2.Text = "Сохранить Изменения";
            this.customButton2.Click += new System.EventHandler(this.button1_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.DarkBlue;
            this.customButton1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customButton1.ForeColor = System.Drawing.Color.Chartreuse;
            this.customButton1.Location = new System.Drawing.Point(716, 8);
            this.customButton1.Margin = new System.Windows.Forms.Padding(4);
            this.customButton1.Name = "customButton1";
            this.customButton1.RoundingEnabled = true;
            this.customButton1.RoundingPercent = 75;
            this.customButton1.Size = new System.Drawing.Size(53, 53);
            this.customButton1.TabIndex = 10;
            this.customButton1.Text = "+";
            this.customButton1.Click += new System.EventHandler(this.button4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.testBindingSource, "id", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(40, 480);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 15);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Удалить тест";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage2.Controls.Add(this.dataGridView7);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(795, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вопросы";
            // 
            // dataGridView7
            // 
            this.dataGridView7.AllowUserToAddRows = false;
            this.dataGridView7.AllowUserToDeleteRows = false;
            this.dataGridView7.AutoGenerateColumns = false;
            this.dataGridView7.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView7.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView7.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView7.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn7,
            this.nameDataGridViewTextBoxColumn4});
            this.dataGridView7.DataSource = this.oPKBindingSource;
            this.dataGridView7.Location = new System.Drawing.Point(4, 128);
            this.dataGridView7.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView7.MultiSelect = false;
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.ReadOnly = true;
            this.dataGridView7.RowHeadersVisible = false;
            this.dataGridView7.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView7.Size = new System.Drawing.Size(246, 307);
            this.dataGridView7.TabIndex = 28;
            // 
            // idDataGridViewTextBoxColumn7
            // 
            this.idDataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn7.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn7.Name = "idDataGridViewTextBoxColumn7";
            this.idDataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn4
            // 
            this.nameDataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn4.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn4.Name = "nameDataGridViewTextBoxColumn4";
            this.nameDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.fKquestiontestBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(223, 600);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "№";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 45;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Вопрос";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(237, 7);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(854, 600);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tabControl4);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(846, 572);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Содержимое вопроса";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage7);
            this.tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl4.Location = new System.Drawing.Point(4, 4);
            this.tabControl4.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(838, 564);
            this.tabControl4.TabIndex = 28;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dataGridView8);
            this.tabPage7.Controls.Add(this.linkLabel2);
            this.tabPage7.Controls.Add(this.pictureBox1);
            this.tabPage7.Controls.Add(this.button2);
            this.tabPage7.Controls.Add(this.label4);
            this.tabPage7.Controls.Add(this.label6);
            this.tabPage7.Controls.Add(this.label5);
            this.tabPage7.Controls.Add(this.textBox3);
            this.tabPage7.Controls.Add(this.textBox4);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage7.Size = new System.Drawing.Size(830, 536);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Изменение";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGridView8
            // 
            this.dataGridView8.AllowUserToAddRows = false;
            this.dataGridView8.AllowUserToDeleteRows = false;
            this.dataGridView8.AutoGenerateColumns = false;
            this.dataGridView8.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView8.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView8.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView8.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn8,
            this.typeNameDataGridViewTextBoxColumn});
            this.dataGridView8.DataSource = this.questionTypesBindingSource;
            this.dataGridView8.Location = new System.Drawing.Point(489, 127);
            this.dataGridView8.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView8.MultiSelect = false;
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.ReadOnly = true;
            this.dataGridView8.RowHeadersVisible = false;
            this.dataGridView8.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView8.Size = new System.Drawing.Size(276, 173);
            this.dataGridView8.TabIndex = 12;
            // 
            // idDataGridViewTextBoxColumn8
            // 
            this.idDataGridViewTextBoxColumn8.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn8.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn8.Name = "idDataGridViewTextBoxColumn8";
            this.idDataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "Type_Name";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "Type_Name";
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            this.typeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fKquestiontestBindingSource, "id", true));
            this.linkLabel2.LinkColor = System.Drawing.Color.Red;
            this.linkLabel2.Location = new System.Drawing.Point(7, 504);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(97, 15);
            this.linkLabel2.TabIndex = 25;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Удалить вопрос";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.fKquestiontestBindingSource, "image", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.pictureBox1.Location = new System.Drawing.Point(7, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 334);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.BlueViolet;
            this.button2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fKquestiontestBindingSource, "id", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Lavender;
            this.button2.Location = new System.Drawing.Point(118, 498);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(695, 26);
            this.button2.TabIndex = 24;
            this.button2.Text = "BUTTON";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(7, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Вопрос";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(7, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Рисунок вопроса";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(7, 406);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Содержимое вопроса (если нет картинки)";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKquestiontestBindingSource, "name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBox3.Location = new System.Drawing.Point(7, 22);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(560, 21);
            this.textBox3.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKquestiontestBindingSource, "description", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBox4.Location = new System.Drawing.Point(7, 423);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(560, 68);
            this.textBox4.TabIndex = 23;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView2);
            this.tabPage5.Controls.Add(this.panel1);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(846, 572);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Варианты ответа";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2});
            this.dataGridView2.DataSource = this.fKanswerquestionBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.Location = new System.Drawing.Point(4, 118);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(838, 450);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.TabStop = false;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "№";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Width = 45;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 114);
            this.panel1.TabIndex = 13;
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.tabPage9);
            this.tabControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl5.Location = new System.Drawing.Point(0, 0);
            this.tabControl5.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(838, 114);
            this.tabControl5.TabIndex = 27;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.linkLabel3);
            this.tabPage9.Controls.Add(this.label7);
            this.tabPage9.Controls.Add(this.button3);
            this.tabPage9.Controls.Add(this.textBox5);
            this.tabPage9.Controls.Add(this.checkBox1);
            this.tabPage9.Location = new System.Drawing.Point(4, 24);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage9.Size = new System.Drawing.Size(830, 86);
            this.tabPage9.TabIndex = 0;
            this.tabPage9.Text = "Изменение";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fKanswerquestionBindingSource, "id", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.linkLabel3.LinkColor = System.Drawing.Color.Red;
            this.linkLabel3.Location = new System.Drawing.Point(7, 58);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(103, 15);
            this.linkLabel3.TabIndex = 26;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Удалить вариант";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(7, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Содержимое";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fKanswerquestionBindingSource, "id", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(124, 52);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(698, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "BUTTON";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKanswerquestionBindingSource, "description", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBox5.Location = new System.Drawing.Point(7, 22);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(731, 21);
            this.textBox5.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.fKanswerquestionBindingSource, "correct", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.checkBox1.Location = new System.Drawing.Point(751, 25);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Верный";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage11.Controls.Add(this.btnExport);
            this.tabPage11.Controls.Add(this.dataGridView6);
            this.tabPage11.Controls.Add(this.dataGridView3);
            this.tabPage11.Controls.Add(this.dataGridView5);
            this.tabPage11.Controls.Add(this.dataGridView4);
            this.tabPage11.Location = new System.Drawing.Point(4, 24);
            this.tabPage11.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage11.Size = new System.Drawing.Size(795, 567);
            this.tabPage11.TabIndex = 2;
            this.tabPage11.Text = "Результаты";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(412, 218);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(342, 215);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "EXPORT To EXCEL";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView6.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView6.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView6.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView6.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn6,
            this.resultidDataGridViewTextBoxColumn,
            this.answeridDataGridViewTextBoxColumn});
            this.dataGridView6.DataSource = this.fKresultvariantresultBindingSource1;
            this.dataGridView6.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView6.Location = new System.Drawing.Point(117, 125);
            this.dataGridView6.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView6.MultiSelect = false;
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView6.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView6.Size = new System.Drawing.Size(133, 71);
            this.dataGridView6.TabIndex = 11;
            this.dataGridView6.TabStop = false;
            this.dataGridView6.Visible = false;
            // 
            // idDataGridViewTextBoxColumn6
            // 
            this.idDataGridViewTextBoxColumn6.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn6.HeaderText = "id";
            this.idDataGridViewTextBoxColumn6.Name = "idDataGridViewTextBoxColumn6";
            this.idDataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // resultidDataGridViewTextBoxColumn
            // 
            this.resultidDataGridViewTextBoxColumn.DataPropertyName = "result_id";
            this.resultidDataGridViewTextBoxColumn.HeaderText = "result_id";
            this.resultidDataGridViewTextBoxColumn.Name = "resultidDataGridViewTextBoxColumn";
            this.resultidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // answeridDataGridViewTextBoxColumn
            // 
            this.answeridDataGridViewTextBoxColumn.DataPropertyName = "answer_id";
            this.answeridDataGridViewTextBoxColumn.HeaderText = "answer_id";
            this.answeridDataGridViewTextBoxColumn.Name = "answeridDataGridViewTextBoxColumn";
            this.answeridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.test_idColumn,
            this.markColumn,
            this.stColumn,
            this.idDataGridViewTextBoxColumn3,
            this.nameDataGridViewTextBoxColumn2,
            this.loginDataGridViewTextBoxColumn,
            this.atDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.fKresulttestBindingSource;
            this.dataGridView3.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView3.Location = new System.Drawing.Point(9, 0);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(525, 600);
            this.dataGridView3.TabIndex = 10;
            this.dataGridView3.TabStop = false;
            this.dataGridView3.SelectionChanged += new System.EventHandler(this.dataGridView3_SelectionChanged);
            // 
            // test_idColumn
            // 
            this.test_idColumn.DataPropertyName = "test_id";
            this.test_idColumn.HeaderText = "test_id";
            this.test_idColumn.Name = "test_idColumn";
            this.test_idColumn.ReadOnly = true;
            this.test_idColumn.Visible = false;
            // 
            // markColumn
            // 
            this.markColumn.DataPropertyName = "mark";
            this.markColumn.HeaderText = "Отметка";
            this.markColumn.Name = "markColumn";
            this.markColumn.ReadOnly = true;
            // 
            // stColumn
            // 
            this.stColumn.DataPropertyName = "st";
            this.stColumn.HeaderText = "Начало";
            this.stColumn.Name = "stColumn";
            this.stColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "№";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            this.idDataGridViewTextBoxColumn3.Width = 45;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Группа";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Пользователь";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // atDataGridViewTextBoxColumn
            // 
            this.atDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.atDataGridViewTextBoxColumn.DataPropertyName = "at";
            this.atDataGridViewTextBoxColumn.HeaderText = "Конец";
            this.atDataGridViewTextBoxColumn.Name = "atDataGridViewTextBoxColumn";
            this.atDataGridViewTextBoxColumn.ReadOnly = true;
            this.atDataGridViewTextBoxColumn.Width = 67;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView5.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView5.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn5,
            this.descriptionDataGridViewTextBoxColumn2,
            this.correctDataGridViewCheckBoxColumn1});
            this.dataGridView5.DataSource = this.fKanswerquestionBindingSource1;
            this.dataGridView5.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView5.Location = new System.Drawing.Point(816, 0);
            this.dataGridView5.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView5.MultiSelect = false;
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView5.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(270, 579);
            this.dataGridView5.TabIndex = 11;
            this.dataGridView5.TabStop = false;
            // 
            // idDataGridViewTextBoxColumn5
            // 
            this.idDataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn5.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn5.HeaderText = "№";
            this.idDataGridViewTextBoxColumn5.Name = "idDataGridViewTextBoxColumn5";
            this.idDataGridViewTextBoxColumn5.ReadOnly = true;
            this.idDataGridViewTextBoxColumn5.Width = 45;
            // 
            // descriptionDataGridViewTextBoxColumn2
            // 
            this.descriptionDataGridViewTextBoxColumn2.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn2.HeaderText = "Ответ";
            this.descriptionDataGridViewTextBoxColumn2.Name = "descriptionDataGridViewTextBoxColumn2";
            this.descriptionDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // correctDataGridViewCheckBoxColumn1
            // 
            this.correctDataGridViewCheckBoxColumn1.DataPropertyName = "correct";
            this.correctDataGridViewCheckBoxColumn1.HeaderText = "Правильный";
            this.correctDataGridViewCheckBoxColumn1.Name = "correctDataGridViewCheckBoxColumn1";
            this.correctDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn4,
            this.nameDataGridViewTextBoxColumn3});
            this.dataGridView4.DataSource = this.fKquestiontestBindingSource1;
            this.dataGridView4.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView4.Location = new System.Drawing.Point(541, 0);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersVisible = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView4.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(278, 579);
            this.dataGridView4.TabIndex = 10;
            this.dataGridView4.TabStop = false;
            // 
            // idDataGridViewTextBoxColumn4
            // 
            this.idDataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn4.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn4.HeaderText = "№";
            this.idDataGridViewTextBoxColumn4.Name = "idDataGridViewTextBoxColumn4";
            this.idDataGridViewTextBoxColumn4.ReadOnly = true;
            this.idDataGridViewTextBoxColumn4.Width = 45;
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "Вопрос";
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            this.nameDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // formsStyle1
            // 
            this.formsStyle1.form = this;
            // 
            // Группы
            // 
            this.Группы.Name = "Группы";
            this.Группы.Size = new System.Drawing.Size(61, 20);
            this.Группы.Text = "Группы";
            this.Группы.Click += new System.EventHandler(this.группыToolStripMenuItem_Click);
            // 
            // Пользователи
            // 
            this.Пользователи.Name = "Пользователи";
            this.Пользователи.Size = new System.Drawing.Size(97, 20);
            this.Пользователи.Text = "Пользователи";
            this.Пользователи.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1046, 654);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.ToolStripMenu);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ToolStripMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администрирование";
            this.Activated += new System.EventHandler(this.AdminForm_Activated);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ToolStripMenu.ResumeLayout(false);
            this.ToolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKquestiontestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKanswerquestionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKresultvariantresultBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKresulttestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKquestiontestBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKanswerquestionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKresultvariantresultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKresultvariantanswerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionOPKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionQuestionTypesBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl5.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ToolStripMenu;
        public testerDataSet testerDataSet;
        private System.Windows.Forms.BindingSource testBindingSource;
        public testerDataSetTableAdapters.testTableAdapter testTableAdapter;
        private System.Windows.Forms.BindingSource fKquestiontestBindingSource;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.BindingSource fKanswerquestionBindingSource;
        private testerDataSetTableAdapters.answerTableAdapter answerTableAdapter;
        internal System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группыToolStripMenuItem;
        private System.Windows.Forms.BindingSource fKresulttestBindingSource;
        private testerDataSetTableAdapters.resultTableAdapter resultTableAdapter;
        private System.Windows.Forms.BindingSource fKresultvariantresultBindingSource;
        private testerDataSetTableAdapters.result_answerTableAdapter result_answerTableAdapter;
        private System.Windows.Forms.BindingSource fKquestiontestBindingSource1;
        private System.Windows.Forms.BindingSource fKresultvariantresultBindingSource1;
        private System.Windows.Forms.BindingSource fKanswerquestionBindingSource1;
        private System.Data.DataSet dataSet1;
        public testerDataSetTableAdapters.questionTableAdapter questionTableAdapter1;
        private BindingSource fKresultvariantanswerBindingSource;
        private BindingSource questionOPKBindingSource;
        private testerDataSetTableAdapters.OPKTableAdapter oPKTableAdapter;
        private BindingSource questionQuestionTypesBindingSource;
        private BindingSource questionTypesBindingSource;
        private BindingSource oPKBindingSource;
        public testerDataSetTableAdapters.Question_TypesTableAdapter question_TypesTableAdapter1;
        private FormsStyle formsStyle1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabControl tabControl3;
        private TabPage tabPage2;
        private DataGridView dataGridView7;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn4;
        internal DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private TabControl tabControl2;
        private TabPage tabPage4;
        private TabControl tabControl4;
        private TabPage tabPage7;
        private DataGridView dataGridView8;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private LinkLabel linkLabel2;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label4;
        private Label label6;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox4;
        private TabPage tabPage5;
        internal DataGridView dataGridView2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private Panel panel1;
        private TabControl tabControl5;
        private TabPage tabPage9;
        private LinkLabel linkLabel3;
        private Label label7;
        private Button button3;
        private TextBox textBox5;
        private CheckBox checkBox1;
        private TabPage tabPage11;
        private Button btnExport;
        internal DataGridView dataGridView6;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn resultidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn answeridDataGridViewTextBoxColumn;
        internal DataGridView dataGridView3;
        private DataGridViewTextBoxColumn test_idColumn;
        private DataGridViewTextBoxColumn markColumn;
        private DataGridViewTextBoxColumn stColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn atDataGridViewTextBoxColumn;
        internal DataGridView dataGridView5;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn2;
        private DataGridViewCheckBoxColumn correctDataGridViewCheckBoxColumn1;
        internal DataGridView dataGridView4;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private TabPage tabPage3;
        private CustomStyles.CustomTextBox textBox1;
        private CustomButton customButton2;
        private CustomButton customButton1;
        private LinkLabel linkLabel1;
        private CustomStyles.CustomTextBox numericUpDown1;
        private CustomStyles.CustomTextBox textBox2;
        private ToolStripMenuItem Группы;
        private ToolStripMenuItem Пользователи;
    }
}