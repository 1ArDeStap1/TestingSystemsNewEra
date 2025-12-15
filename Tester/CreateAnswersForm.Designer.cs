namespace Tester
{
    partial class CreateAnswersForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correct = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.answerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testerDataSet = new Tester.testerDataSet();
            this.answerTableAdapter = new Tester.testerDataSetTableAdapters.answerTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.testidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPKidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionTableAdapter = new Tester.testerDataSetTableAdapters.questionTableAdapter();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.checkBox2 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.textBox10 = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.textBox1 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label1 = new System.Windows.Forms.Label();
            this.AnswerPoints = new System.Windows.Forms.NumericUpDown();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.LeftVal = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.matchingpairsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton6 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.RightVal = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.MatchingPairsTable = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lefttextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.righttextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraoptionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matching_pairsTableAdapter = new Tester.testerDataSetTableAdapters.matching_pairsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerPoints)).BeginInit();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchingpairsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatchingPairsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(80)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn,
            this.correct});
            this.dataGridView1.DataSource = this.answerBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 63);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(286, 505);
            this.dataGridView1.TabIndex = 14;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "ОТВЕТ";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correct
            // 
            this.correct.DataPropertyName = "correct";
            this.correct.HeaderText = "ПРАВИЛЬНЫЙ";
            this.correct.Name = "correct";
            this.correct.ReadOnly = true;
            // 
            // answerBindingSource
            // 
            this.answerBindingSource.DataMember = "FK_answer_question";
            this.answerBindingSource.DataSource = this.questionBindingSource;
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataMember = "question";
            this.questionBindingSource.DataSource = this.testerDataSet;
            // 
            // testerDataSet
            // 
            this.testerDataSet.DataSetName = "testerDataSet";
            this.testerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // answerTableAdapter
            // 
            this.answerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn1,
            this.imageDataGridViewImageColumn,
            this.testidDataGridViewTextBoxColumn,
            this.oPKidDataGridViewTextBoxColumn,
            this.typeidDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.questionBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(24, 434);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(228, 121);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "image";
            this.imageDataGridViewImageColumn.HeaderText = "image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            // 
            // testidDataGridViewTextBoxColumn
            // 
            this.testidDataGridViewTextBoxColumn.DataPropertyName = "test_id";
            this.testidDataGridViewTextBoxColumn.HeaderText = "test_id";
            this.testidDataGridViewTextBoxColumn.Name = "testidDataGridViewTextBoxColumn";
            this.testidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oPKidDataGridViewTextBoxColumn
            // 
            this.oPKidDataGridViewTextBoxColumn.DataPropertyName = "OPK_id";
            this.oPKidDataGridViewTextBoxColumn.HeaderText = "OPK_id";
            this.oPKidDataGridViewTextBoxColumn.Name = "oPKidDataGridViewTextBoxColumn";
            this.oPKidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeidDataGridViewTextBoxColumn
            // 
            this.typeidDataGridViewTextBoxColumn.DataPropertyName = "Type_id";
            this.typeidDataGridViewTextBoxColumn.HeaderText = "Type_id";
            this.typeidDataGridViewTextBoxColumn.Name = "typeidDataGridViewTextBoxColumn";
            this.typeidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // questionTableAdapter
            // 
            this.questionTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(867, 25);
            this.fillBy1ToolStrip.TabIndex = 16;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Visible = false;
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(276, 428);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(151, 36);
            this.materialButton1.TabIndex = 17;
            this.materialButton1.Text = "ИЗМЕНИТЬ ОТВЕТ";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.answerBindingSource, "correct", true));
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.answerBindingSource, "correct", true));
            this.checkBox2.Depth = 0;
            this.checkBox2.Location = new System.Drawing.Point(728, 169);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Ripple = true;
            this.checkBox2.Size = new System.Drawing.Size(123, 37);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "ВЕРНЫЙ";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // materialButton2
            // 
            this.materialButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(523, 428);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(149, 36);
            this.materialButton2.TabIndex = 19;
            this.materialButton2.Text = "ДОБАВИТЬ ОТВЕТ";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox10
            // 
            this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox10.AnimateReadOnly = false;
            this.textBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBox10.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBox10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.answerBindingSource, "description", true));
            this.textBox10.Depth = 0;
            this.textBox10.HideSelection = true;
            this.textBox10.Location = new System.Drawing.Point(41, 169);
            this.textBox10.MaxLength = 32767;
            this.textBox10.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox10.Name = "textBox10";
            this.textBox10.PasswordChar = '\0';
            this.textBox10.ReadOnly = false;
            this.textBox10.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox10.SelectedText = "";
            this.textBox10.SelectionLength = 0;
            this.textBox10.SelectionStart = 0;
            this.textBox10.ShortcutsEnabled = true;
            this.textBox10.Size = new System.Drawing.Size(631, 233);
            this.textBox10.TabIndex = 20;
            this.textBox10.TabStop = false;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox10.UseSystemPasswordChar = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.AnimateReadOnly = false;
            this.textBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.answerBindingSource, "description", true));
            this.textBox1.Depth = 0;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox1.HideSelection = true;
            this.textBox1.LeadingIcon = null;
            this.textBox1.Location = new System.Drawing.Point(38, 55);
            this.textBox1.MaxLength = 32767;
            this.textBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.PrefixSuffixText = null;
            this.textBox1.ReadOnly = false;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionLength = 0;
            this.textBox1.SelectionStart = 0;
            this.textBox1.ShortcutsEnabled = true;
            this.textBox1.Size = new System.Drawing.Size(631, 48);
            this.textBox1.TabIndex = 21;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox1.TrailingIcon = null;
            this.textBox1.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(35, 33);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(142, 19);
            this.materialLabel1.TabIndex = 22;
            this.materialLabel1.Text = "Правильный ответ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(38, 147);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(109, 19);
            this.materialLabel2.TabIndex = 23;
            this.materialLabel2.Text = "Введите ответ";
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.AnswerPoints);
            this.materialCard1.Controls.Add(this.materialCard2);
            this.materialCard1.Controls.Add(this.materialButton3);
            this.materialCard1.Controls.Add(this.textBox1);
            this.materialCard1.Controls.Add(this.materialButton2);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Controls.Add(this.checkBox2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.textBox10);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(301, 91);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(879, 474);
            this.materialCard1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(724, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Количество баллов";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // AnswerPoints
            // 
            this.AnswerPoints.Location = new System.Drawing.Point(728, 83);
            this.AnswerPoints.Name = "AnswerPoints";
            this.AnswerPoints.Size = new System.Drawing.Size(123, 20);
            this.AnswerPoints.TabIndex = 26;
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.LeftVal);
            this.materialCard2.Controls.Add(this.materialButton4);
            this.materialCard2.Controls.Add(this.materialButton5);
            this.materialCard2.Controls.Add(this.materialLabel3);
            this.materialCard2.Controls.Add(this.materialButton6);
            this.materialCard2.Controls.Add(this.materialLabel4);
            this.materialCard2.Controls.Add(this.RightVal);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(7, 3);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(879, 474);
            this.materialCard2.TabIndex = 25;
            // 
            // LeftVal
            // 
            this.LeftVal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftVal.AnimateReadOnly = false;
            this.LeftVal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LeftVal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.LeftVal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LeftVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matchingpairsBindingSource, "left_text", true));
            this.LeftVal.Depth = 0;
            this.LeftVal.HideSelection = true;
            this.LeftVal.Location = new System.Drawing.Point(37, 114);
            this.LeftVal.MaxLength = 32767;
            this.LeftVal.MouseState = MaterialSkin.MouseState.OUT;
            this.LeftVal.Name = "LeftVal";
            this.LeftVal.PasswordChar = '\0';
            this.LeftVal.ReadOnly = false;
            this.LeftVal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LeftVal.SelectedText = "";
            this.LeftVal.SelectionLength = 0;
            this.LeftVal.SelectionStart = 0;
            this.LeftVal.ShortcutsEnabled = true;
            this.LeftVal.Size = new System.Drawing.Size(378, 213);
            this.LeftVal.TabIndex = 25;
            this.LeftVal.TabStop = false;
            this.LeftVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LeftVal.UseSystemPasswordChar = false;
            // 
            // matchingpairsBindingSource
            // 
            this.matchingpairsBindingSource.DataMember = "matching_pairs";
            this.matchingpairsBindingSource.DataSource = this.testerDataSet;
            // 
            // materialButton4
            // 
            this.materialButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(37, 428);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(140, 36);
            this.materialButton4.TabIndex = 24;
            this.materialButton4.Text = "УДАЛИТЬ ОТВЕТ";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            // 
            // materialButton5
            // 
            this.materialButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton5.Depth = 0;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = null;
            this.materialButton5.Location = new System.Drawing.Point(713, 428);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton5.Size = new System.Drawing.Size(149, 36);
            this.materialButton5.TabIndex = 19;
            this.materialButton5.Text = "ДОБАВИТЬ ОТВЕТ";
            this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton5.UseAccentColor = false;
            this.materialButton5.UseVisualStyleBackColor = true;
            this.materialButton5.Click += new System.EventHandler(this.button6_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(470, 92);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(174, 19);
            this.materialLabel3.TabIndex = 23;
            this.materialLabel3.Text = "Текст правого столбца";
            // 
            // materialButton6
            // 
            this.materialButton6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.materialButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton6.Depth = 0;
            this.materialButton6.HighEmphasis = true;
            this.materialButton6.Icon = null;
            this.materialButton6.Location = new System.Drawing.Point(373, 428);
            this.materialButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton6.Name = "materialButton6";
            this.materialButton6.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton6.Size = new System.Drawing.Size(151, 36);
            this.materialButton6.TabIndex = 17;
            this.materialButton6.Text = "ИЗМЕНИТЬ ОТВЕТ";
            this.materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton6.UseAccentColor = false;
            this.materialButton6.UseVisualStyleBackColor = true;
            this.materialButton6.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(34, 92);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(164, 19);
            this.materialLabel4.TabIndex = 22;
            this.materialLabel4.Text = "Текст левого столбца";
            this.materialLabel4.Click += new System.EventHandler(this.materialLabel4_Click);
            // 
            // RightVal
            // 
            this.RightVal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightVal.AnimateReadOnly = false;
            this.RightVal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RightVal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.RightVal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RightVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matchingpairsBindingSource, "right_text", true));
            this.RightVal.Depth = 0;
            this.RightVal.HideSelection = true;
            this.RightVal.Location = new System.Drawing.Point(473, 114);
            this.RightVal.MaxLength = 32767;
            this.RightVal.MouseState = MaterialSkin.MouseState.OUT;
            this.RightVal.Name = "RightVal";
            this.RightVal.PasswordChar = '\0';
            this.RightVal.ReadOnly = false;
            this.RightVal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RightVal.SelectedText = "";
            this.RightVal.SelectionLength = 0;
            this.RightVal.SelectionStart = 0;
            this.RightVal.ShortcutsEnabled = true;
            this.RightVal.Size = new System.Drawing.Size(378, 213);
            this.RightVal.TabIndex = 20;
            this.RightVal.TabStop = false;
            this.RightVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RightVal.UseSystemPasswordChar = false;
            // 
            // materialButton3
            // 
            this.materialButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(41, 428);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(140, 36);
            this.materialButton3.TabIndex = 24;
            this.materialButton3.Text = "УДАЛИТЬ ОТВЕТ";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            // 
            // MatchingPairsTable
            // 
            this.MatchingPairsTable.AllowUserToAddRows = false;
            this.MatchingPairsTable.AllowUserToDeleteRows = false;
            this.MatchingPairsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MatchingPairsTable.AutoGenerateColumns = false;
            this.MatchingPairsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MatchingPairsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MatchingPairsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MatchingPairsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatchingPairsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.MatchingPairsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(80)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MatchingPairsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MatchingPairsTable.ColumnHeadersHeight = 25;
            this.MatchingPairsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.questionidDataGridViewTextBoxColumn,
            this.lefttextDataGridViewTextBoxColumn,
            this.righttextDataGridViewTextBoxColumn,
            this.extraoptionsDataGridViewTextBoxColumn});
            this.MatchingPairsTable.DataSource = this.matchingpairsBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MatchingPairsTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.MatchingPairsTable.EnableHeadersVisualStyles = false;
            this.MatchingPairsTable.GridColor = System.Drawing.SystemColors.Control;
            this.MatchingPairsTable.Location = new System.Drawing.Point(0, 63);
            this.MatchingPairsTable.MultiSelect = false;
            this.MatchingPairsTable.Name = "MatchingPairsTable";
            this.MatchingPairsTable.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MatchingPairsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.MatchingPairsTable.RowHeadersVisible = false;
            this.MatchingPairsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MatchingPairsTable.Size = new System.Drawing.Size(298, 505);
            this.MatchingPairsTable.TabIndex = 25;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Visible = false;
            // 
            // questionidDataGridViewTextBoxColumn
            // 
            this.questionidDataGridViewTextBoxColumn.DataPropertyName = "question_id";
            this.questionidDataGridViewTextBoxColumn.HeaderText = "question_id";
            this.questionidDataGridViewTextBoxColumn.Name = "questionidDataGridViewTextBoxColumn";
            this.questionidDataGridViewTextBoxColumn.ReadOnly = true;
            this.questionidDataGridViewTextBoxColumn.Visible = false;
            // 
            // lefttextDataGridViewTextBoxColumn
            // 
            this.lefttextDataGridViewTextBoxColumn.DataPropertyName = "left_text";
            this.lefttextDataGridViewTextBoxColumn.HeaderText = "Левый текст";
            this.lefttextDataGridViewTextBoxColumn.Name = "lefttextDataGridViewTextBoxColumn";
            this.lefttextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // righttextDataGridViewTextBoxColumn
            // 
            this.righttextDataGridViewTextBoxColumn.DataPropertyName = "right_text";
            this.righttextDataGridViewTextBoxColumn.HeaderText = "Правый текст";
            this.righttextDataGridViewTextBoxColumn.Name = "righttextDataGridViewTextBoxColumn";
            this.righttextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // extraoptionsDataGridViewTextBoxColumn
            // 
            this.extraoptionsDataGridViewTextBoxColumn.DataPropertyName = "extra_options";
            this.extraoptionsDataGridViewTextBoxColumn.HeaderText = "Доп";
            this.extraoptionsDataGridViewTextBoxColumn.Name = "extraoptionsDataGridViewTextBoxColumn";
            this.extraoptionsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matching_pairsTableAdapter
            // 
            this.matching_pairsTableAdapter.ClearBeforeFill = true;
            // 
            // CreateAnswersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 582);
            this.Controls.Add(this.MatchingPairsTable);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Name = "CreateAnswersForm";
            this.Text = "РЕДАКТОР ОТВЕТОВ";
            this.Deactivate += new System.EventHandler(this.CreateAnswersForm_Leave);
            this.Load += new System.EventHandler(this.CreateAnswersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerPoints)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchingpairsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatchingPairsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private testerDataSet testerDataSet;
        private testerDataSetTableAdapters.answerTableAdapter answerTableAdapter;
        internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private testerDataSetTableAdapters.questionTableAdapter questionTableAdapter;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPKidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeidDataGridViewTextBoxColumn;
        internal System.Windows.Forms.BindingSource answerBindingSource;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialSwitch checkBox2;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 textBox10;
        private MaterialSkin.Controls.MaterialTextBox2 textBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn correct;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        internal System.Windows.Forms.DataGridView MatchingPairsTable;
        private System.Windows.Forms.BindingSource matchingpairsBindingSource;
        private testerDataSetTableAdapters.matching_pairsTableAdapter matching_pairsTableAdapter;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton materialButton6;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 RightVal;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 LeftVal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lefttextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn righttextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraoptionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown AnswerPoints;
    }
}