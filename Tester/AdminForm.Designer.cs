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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.ToolStripMenu = new System.Windows.Forms.MenuStrip();
            this.Группы = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеПочтойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьБазуДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьБазуДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testerDataSet = new Tester.testerDataSet();
            this.dataSet1 = new System.Data.DataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correct = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.btnShowOpk_Result = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.test_idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.OPK_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.testTableAdapter = new Tester.testerDataSetTableAdapters.testTableAdapter();
            this.answerTableAdapter = new Tester.testerDataSetTableAdapters.answerTableAdapter();
            this.resultTableAdapter = new Tester.testerDataSetTableAdapters.resultTableAdapter();
            this.result_answerTableAdapter = new Tester.testerDataSetTableAdapters.result_answerTableAdapter();
            this.questionTableAdapter1 = new Tester.testerDataSetTableAdapters.questionTableAdapter();
            this.oPKTableAdapter = new Tester.testerDataSetTableAdapters.OPKTableAdapter();
            this.question_TypesTableAdapter1 = new Tester.testerDataSetTableAdapters.Question_TypesTableAdapter();
            this.adminNetworkDataTableAdapter1 = new Tester.testerDataSetTableAdapters.adminNetworkDataTableAdapter();
            this.usersTableAdapter1 = new Tester.testerDataSetTableAdapters.usersTableAdapter();
            this.groupTableAdapter1 = new Tester.testerDataSetTableAdapters.groupTableAdapter();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialMultiLineTextBox21 = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKquestiontestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.questionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKanswerquestionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKquestiontestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKanswerquestionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKresultvariantresultBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKresulttestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKresultvariantresultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKresultvariantanswerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionOPKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionQuestionTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionTypesBindingSource)).BeginInit();
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
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKquestiontestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKanswerquestionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKquestiontestBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKanswerquestionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKresultvariantresultBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKresulttestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKresultvariantresultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKresultvariantanswerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionOPKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionQuestionTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStripMenu
            // 
            this.ToolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ToolStripMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStripMenu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Группы,
            this.управлениеПочтойToolStripMenuItem,
            this.сохранитьБазуДанныхToolStripMenuItem,
            this.загрузитьБазуДанныхToolStripMenuItem,
            this.toolStripMenuItem1});
            this.ToolStripMenu.Location = new System.Drawing.Point(255, 64);
            this.ToolStripMenu.Name = "ToolStripMenu";
            this.ToolStripMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.ToolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ToolStripMenu.Size = new System.Drawing.Size(490, 24);
            this.ToolStripMenu.TabIndex = 0;
            this.ToolStripMenu.Text = "Группы";
            // 
            // Группы
            // 
            this.Группы.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Группы.ForeColor = System.Drawing.Color.Black;
            this.Группы.Name = "Группы";
            this.Группы.Size = new System.Drawing.Size(72, 20);
            this.Группы.Text = "ГРУППЫ";
            this.Группы.Click += new System.EventHandler(this.группыToolStripMenuItem_Click);
            // 
            // управлениеПочтойToolStripMenuItem
            // 
            this.управлениеПочтойToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.управлениеПочтойToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.управлениеПочтойToolStripMenuItem.Name = "управлениеПочтойToolStripMenuItem";
            this.управлениеПочтойToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.управлениеПочтойToolStripMenuItem.Text = "РАССЫЛКА";
            this.управлениеПочтойToolStripMenuItem.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // сохранитьБазуДанныхToolStripMenuItem
            // 
            this.сохранитьБазуДанныхToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сохранитьБазуДанныхToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.сохранитьБазуДанныхToolStripMenuItem.Name = "сохранитьБазуДанныхToolStripMenuItem";
            this.сохранитьБазуДанныхToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.сохранитьБазуДанныхToolStripMenuItem.Text = "СОХРАНИТЬ ДАННЫЕ";
            this.сохранитьБазуДанныхToolStripMenuItem.Click += new System.EventHandler(this.сохранитьБазуДанныхToolStripMenuItem_Click);
            // 
            // загрузитьБазуДанныхToolStripMenuItem
            // 
            this.загрузитьБазуДанныхToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.загрузитьБазуДанныхToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.загрузитьБазуДанныхToolStripMenuItem.Name = "загрузитьБазуДанныхToolStripMenuItem";
            this.загрузитьБазуДанныхToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
            this.загрузитьБазуДанныхToolStripMenuItem.Text = "ЗАГРУЗИТЬ ДАННЫЕ";
            this.загрузитьБазуДанныхToolStripMenuItem.Click += new System.EventHandler(this.загрузитьБазуДанныхToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
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
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Grid.AutoGenerateColumns = false;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid.BackgroundColor = System.Drawing.Color.White;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.ColumnHeadersHeight = 25;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.Grid.DataSource = this.testBindingSource;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Grid.Location = new System.Drawing.Point(13, 116);
            this.Grid.Margin = new System.Windows.Forms.Padding(4);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Grid.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.Grid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(211, 519);
            this.Grid.TabIndex = 9;
            this.Grid.TabStop = false;
            this.Grid.SelectionChanged += new System.EventHandler(this.Grid_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idDataGridViewTextBoxColumn.HeaderText = "№";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 44;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
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
            // testBindingSource
            // 
            this.testBindingSource.DataMember = "test";
            this.testBindingSource.DataSource = this.testerDataSet;
            // 
            // testerDataSet
            // 
            this.testerDataSet.CaseSensitive = true;
            this.testerDataSet.DataSetName = "testerDataSet";
            this.testerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Location = new System.Drawing.Point(866, 64);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(508, 45);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(500, 17);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Информация о тесте";
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
            this.tabPage2.Size = new System.Drawing.Size(500, 17);
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
            this.dataGridView7.Location = new System.Drawing.Point(24, 137);
            this.dataGridView7.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView7.MultiSelect = false;
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.ReadOnly = true;
            this.dataGridView7.RowHeadersVisible = false;
            this.dataGridView7.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView7.Size = new System.Drawing.Size(205, 307);
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
            // oPKBindingSource
            // 
            this.oPKBindingSource.DataMember = "OPK";
            this.oPKBindingSource.DataSource = this.testerDataSet;
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
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(223, 600);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.TabStop = false;
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
            // questionTypesBindingSource
            // 
            this.questionTypesBindingSource.DataMember = "Question_Types";
            this.questionTypesBindingSource.DataSource = this.testerDataSet;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fKquestiontestBindingSource, "id", true));
            this.linkLabel2.LinkColor = System.Drawing.Color.Red;
            this.linkLabel2.Location = new System.Drawing.Point(7, 526);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(97, 15);
            this.linkLabel2.TabIndex = 25;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Удалить вопрос";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
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
            this.button2.Location = new System.Drawing.Point(118, 520);
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
            this.label5.Location = new System.Drawing.Point(7, 428);
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
            this.textBox4.Location = new System.Drawing.Point(7, 445);
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
            this.id,
            this.description,
            this.correct,
            this.idDataGridViewTextBoxColumn2,
            this.descriptionDataGridViewTextBoxColumn1,
            this.correctDataGridViewCheckBoxColumn,
            this.questionidDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKanswerquestionBindingSource1;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.Location = new System.Drawing.Point(4, 118);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(838, 452);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.TabStop = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // correct
            // 
            this.correct.DataPropertyName = "correct";
            this.correct.HeaderText = "correct";
            this.correct.Name = "correct";
            this.correct.ReadOnly = true;
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
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.fKanswerquestionBindingSource1, "correct", true));
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
            this.tabPage11.Controls.Add(this.btnShowOpk_Result);
            this.tabPage11.Controls.Add(this.btnExport);
            this.tabPage11.Controls.Add(this.dataGridView6);
            this.tabPage11.Controls.Add(this.dataGridView3);
            this.tabPage11.Controls.Add(this.dataGridView5);
            this.tabPage11.Controls.Add(this.dataGridView4);
            this.tabPage11.Location = new System.Drawing.Point(4, 24);
            this.tabPage11.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage11.Size = new System.Drawing.Size(500, 17);
            this.tabPage11.TabIndex = 2;
            this.tabPage11.Text = "Результаты";
            // 
            // btnShowOpk_Result
            // 
            this.btnShowOpk_Result.Location = new System.Drawing.Point(8, 476);
            this.btnShowOpk_Result.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowOpk_Result.Name = "btnShowOpk_Result";
            this.btnShowOpk_Result.Size = new System.Drawing.Size(242, 56);
            this.btnShowOpk_Result.TabIndex = 12;
            this.btnShowOpk_Result.Text = "Посмотреть результат освоения компетенций";
            this.btnShowOpk_Result.UseVisualStyleBackColor = true;
            this.btnShowOpk_Result.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(328, 476);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(200, 56);
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
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView6.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView6.Size = new System.Drawing.Size(133, 71);
            this.dataGridView6.TabIndex = 11;
            this.dataGridView6.TabStop = false;
            this.dataGridView6.Visible = false;
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
            this.user_id,
            this.atDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.fKresulttestBindingSource;
            this.dataGridView3.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView3.Location = new System.Drawing.Point(4, 4);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(524, 464);
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
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "user_id";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            this.user_id.Visible = false;
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
            this.dataGridView5.Location = new System.Drawing.Point(823, 4);
            this.dataGridView5.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView5.MultiSelect = false;
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView5.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(259, 528);
            this.dataGridView5.TabIndex = 11;
            this.dataGridView5.TabStop = false;
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
            this.nameDataGridViewTextBoxColumn3,
            this.OPK_id});
            this.dataGridView4.DataSource = this.fKquestiontestBindingSource1;
            this.dataGridView4.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView4.Location = new System.Drawing.Point(536, 4);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersVisible = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView4.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(278, 528);
            this.dataGridView4.TabIndex = 10;
            this.dataGridView4.TabStop = false;
            // 
            // OPK_id
            // 
            this.OPK_id.DataPropertyName = "OPK_id";
            this.OPK_id.HeaderText = "Компетенция";
            this.OPK_id.Name = "OPK_id";
            this.OPK_id.ReadOnly = true;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testBindingSource, "name", true));
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(17, 46);
            this.materialTextBox1.MaxLength = 100;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(613, 50);
            this.materialTextBox1.TabIndex = 9;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // materialButton3
            // 
            this.materialButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(19, 474);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(91, 36);
            this.materialButton3.TabIndex = 8;
            this.materialButton3.Text = "УДАЛИТЬ ";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.linkLabel1_LinkClicked);
            // 
            // materialButton2
            // 
            this.materialButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(277, 474);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(101, 36);
            this.materialButton2.TabIndex = 7;
            this.materialButton2.Text = "ИЗМЕНИТЬ";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(530, 474);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(100, 36);
            this.materialButton1.TabIndex = 6;
            this.materialButton1.Text = "ДОБАВИТЬ";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
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
            // oPKTableAdapter
            // 
            this.oPKTableAdapter.ClearBeforeFill = true;
            // 
            // question_TypesTableAdapter1
            // 
            this.question_TypesTableAdapter1.ClearBeforeFill = true;
            // 
            // adminNetworkDataTableAdapter1
            // 
            this.adminNetworkDataTableAdapter1.ClearBeforeFill = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // groupTableAdapter1
            // 
            this.groupTableAdapter1.ClearBeforeFill = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(72, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 29);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "ТЕСТЫ";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(27, 129);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(199, 19);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Время прохождения теста";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.White;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(27, 229);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(118, 19);
            this.materialLabel4.TabIndex = 14;
            this.materialLabel4.Text = "Описание теста";
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testBindingSource, "time", true));
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(17, 151);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(613, 50);
            this.materialTextBox2.TabIndex = 15;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(27, 24);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(118, 19);
            this.materialLabel3.TabIndex = 16;
            this.materialLabel3.Text = "Название теста";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialMultiLineTextBox21);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialTextBox2);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.materialButton2);
            this.materialCard1.Controls.Add(this.materialButton3);
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialTextBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(238, 116);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(651, 519);
            this.materialCard1.TabIndex = 18;
            // 
            // materialMultiLineTextBox21
            // 
            this.materialMultiLineTextBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialMultiLineTextBox21.AnimateReadOnly = false;
            this.materialMultiLineTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMultiLineTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialMultiLineTextBox21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialMultiLineTextBox21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testBindingSource, "description", true));
            this.materialMultiLineTextBox21.Depth = 0;
            this.materialMultiLineTextBox21.HideSelection = true;
            this.materialMultiLineTextBox21.Location = new System.Drawing.Point(17, 251);
            this.materialMultiLineTextBox21.MaxLength = 32767;
            this.materialMultiLineTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMultiLineTextBox21.Name = "materialMultiLineTextBox21";
            this.materialMultiLineTextBox21.PasswordChar = '\0';
            this.materialMultiLineTextBox21.ReadOnly = false;
            this.materialMultiLineTextBox21.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.materialMultiLineTextBox21.SelectedText = "";
            this.materialMultiLineTextBox21.SelectionLength = 0;
            this.materialMultiLineTextBox21.SelectionStart = 0;
            this.materialMultiLineTextBox21.ShortcutsEnabled = true;
            this.materialMultiLineTextBox21.Size = new System.Drawing.Size(613, 205);
            this.materialMultiLineTextBox21.TabIndex = 19;
            this.materialMultiLineTextBox21.TabStop = false;
            this.materialMultiLineTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMultiLineTextBox21.UseSystemPasswordChar = false;
            // 
            // materialButton4
            // 
            this.materialButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialButton4.AutoSize = false;
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(45, 309);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(91, 36);
            this.materialButton4.TabIndex = 20;
            this.materialButton4.Text = "TEST";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
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
            // fKquestiontestBindingSource
            // 
            this.fKquestiontestBindingSource.DataMember = "FK_question_test";
            this.fKquestiontestBindingSource.DataSource = this.testBindingSource;
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
            this.pictureBox1.Size = new System.Drawing.Size(561, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // correctDataGridViewCheckBoxColumn
            // 
            this.correctDataGridViewCheckBoxColumn.DataPropertyName = "correct";
            this.correctDataGridViewCheckBoxColumn.HeaderText = "correct";
            this.correctDataGridViewCheckBoxColumn.Name = "correctDataGridViewCheckBoxColumn";
            this.correctDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // questionidDataGridViewTextBoxColumn
            // 
            this.questionidDataGridViewTextBoxColumn.DataPropertyName = "question_id";
            this.questionidDataGridViewTextBoxColumn.HeaderText = "question_id";
            this.questionidDataGridViewTextBoxColumn.Name = "questionidDataGridViewTextBoxColumn";
            this.questionidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKanswerquestionBindingSource1
            // 
            this.fKanswerquestionBindingSource1.DataMember = "FK_answer_question";
            this.fKanswerquestionBindingSource1.DataSource = this.fKquestiontestBindingSource1;
            // 
            // fKquestiontestBindingSource1
            // 
            this.fKquestiontestBindingSource1.DataMember = "FK_question_test";
            this.fKquestiontestBindingSource1.DataSource = this.testBindingSource;
            // 
            // fKanswerquestionBindingSource
            // 
            this.fKanswerquestionBindingSource.DataSource = this.fKquestiontestBindingSource;
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
            // fKresultvariantresultBindingSource1
            // 
            this.fKresultvariantresultBindingSource1.DataMember = "FK_result_variant_result";
            this.fKresultvariantresultBindingSource1.DataSource = this.fKresulttestBindingSource;
            // 
            // fKresulttestBindingSource
            // 
            this.fKresulttestBindingSource.DataMember = "FK_result_test";
            this.fKresulttestBindingSource.DataSource = this.testBindingSource;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "№";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            this.idDataGridViewTextBoxColumn3.Visible = false;
            this.idDataGridViewTextBoxColumn3.Width = 43;
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
            // questionQuestionTypesBindingSource
            // 
            this.questionQuestionTypesBindingSource.DataSource = this.fKquestiontestBindingSource;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 648);
            this.Controls.Add(this.materialButton4);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.materialLabel1);
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
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.Activated += new System.EventHandler(this.AdminForm_Activated);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ToolStripMenu.ResumeLayout(false);
            this.ToolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionTypesBindingSource)).EndInit();
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
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKquestiontestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKanswerquestionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKquestiontestBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKanswerquestionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKresultvariantresultBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKresulttestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKresultvariantresultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKresultvariantanswerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionOPKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionQuestionTypesBindingSource)).EndInit();
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
        private TabControl tabControl1;
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
        internal DataGridView dataGridView5;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn2;
        private DataGridViewCheckBoxColumn correctDataGridViewCheckBoxColumn1;
        internal DataGridView dataGridView4;
        private ToolStripMenuItem Группы;
        private Button btnShowOpk_Result;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn OPK_id;
        private DataGridViewTextBoxColumn test_idColumn;
        private DataGridViewTextBoxColumn markColumn;
        private DataGridViewTextBoxColumn stColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn user_id;
        private DataGridViewTextBoxColumn atDataGridViewTextBoxColumn;
        private ToolStripMenuItem управлениеПочтойToolStripMenuItem;
        private testerDataSetTableAdapters.adminNetworkDataTableAdapter adminNetworkDataTableAdapter1;
        internal DataGridView dataGridView2;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn description;
        private DataGridViewCheckBoxColumn correct;
        private ToolStripMenuItem сохранитьБазуДанныхToolStripMenuItem;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn correctDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn questionidDataGridViewTextBoxColumn;
        private ToolStripMenuItem загрузитьБазуДанныхToolStripMenuItem;
        private testerDataSetTableAdapters.usersTableAdapter usersTableAdapter1;
        private testerDataSetTableAdapters.groupTableAdapter groupTableAdapter1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private TabPage tabPage1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 materialMultiLineTextBox21;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private ToolStripMenuItem toolStripMenuItem1;
        private MaterialSkin.Controls.MaterialButton materialButton4;
    }
}