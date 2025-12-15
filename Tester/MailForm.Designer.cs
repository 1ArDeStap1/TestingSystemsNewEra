namespace Tester
{
    partial class MailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smtpServerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smtpPortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smtpUsernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smtpUserpasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smtpSendFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smtpSenderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminNetworkDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testerDataSet = new Tester.testerDataSet();
            this.adminNetworkDataTableAdapter = new Tester.testerDataSetTableAdapters.adminNetworkDataTableAdapter();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.customTextBox1 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.customTextBox2 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.customTextBox3 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.customTextBox4 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.customTextBox5 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.customTextBox6 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.customTextBox7 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminNetworkDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerDataSet)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.smtpServerDataGridViewTextBoxColumn,
            this.smtpPortDataGridViewTextBoxColumn,
            this.smtpUsernameDataGridViewTextBoxColumn,
            this.smtpUserpasswordDataGridViewTextBoxColumn,
            this.smtpSendFromDataGridViewTextBoxColumn,
            this.smtpSenderNameDataGridViewTextBoxColumn,
            this.sendToDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adminNetworkDataBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(30, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(845, 87);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // smtpServerDataGridViewTextBoxColumn
            // 
            this.smtpServerDataGridViewTextBoxColumn.DataPropertyName = "smtpServer";
            this.smtpServerDataGridViewTextBoxColumn.HeaderText = "smtp сервер";
            this.smtpServerDataGridViewTextBoxColumn.Name = "smtpServerDataGridViewTextBoxColumn";
            this.smtpServerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // smtpPortDataGridViewTextBoxColumn
            // 
            this.smtpPortDataGridViewTextBoxColumn.DataPropertyName = "smtpPort";
            this.smtpPortDataGridViewTextBoxColumn.HeaderText = "smtp порт";
            this.smtpPortDataGridViewTextBoxColumn.Name = "smtpPortDataGridViewTextBoxColumn";
            this.smtpPortDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // smtpUsernameDataGridViewTextBoxColumn
            // 
            this.smtpUsernameDataGridViewTextBoxColumn.DataPropertyName = "smtpUsername";
            this.smtpUsernameDataGridViewTextBoxColumn.HeaderText = "smtp Пользователь";
            this.smtpUsernameDataGridViewTextBoxColumn.Name = "smtpUsernameDataGridViewTextBoxColumn";
            this.smtpUsernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // smtpUserpasswordDataGridViewTextBoxColumn
            // 
            this.smtpUserpasswordDataGridViewTextBoxColumn.DataPropertyName = "smtpUserpassword";
            this.smtpUserpasswordDataGridViewTextBoxColumn.HeaderText = "smtp Пароль";
            this.smtpUserpasswordDataGridViewTextBoxColumn.Name = "smtpUserpasswordDataGridViewTextBoxColumn";
            this.smtpUserpasswordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // smtpSendFromDataGridViewTextBoxColumn
            // 
            this.smtpSendFromDataGridViewTextBoxColumn.DataPropertyName = "smtpSendFrom";
            this.smtpSendFromDataGridViewTextBoxColumn.HeaderText = "smtp Отправитель";
            this.smtpSendFromDataGridViewTextBoxColumn.Name = "smtpSendFromDataGridViewTextBoxColumn";
            this.smtpSendFromDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // smtpSenderNameDataGridViewTextBoxColumn
            // 
            this.smtpSenderNameDataGridViewTextBoxColumn.DataPropertyName = "smtpSenderName";
            this.smtpSenderNameDataGridViewTextBoxColumn.HeaderText = "smtp Имя отправителя";
            this.smtpSenderNameDataGridViewTextBoxColumn.Name = "smtpSenderNameDataGridViewTextBoxColumn";
            this.smtpSenderNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sendToDataGridViewTextBoxColumn
            // 
            this.sendToDataGridViewTextBoxColumn.DataPropertyName = "SendTo";
            this.sendToDataGridViewTextBoxColumn.HeaderText = "Кому отправить";
            this.sendToDataGridViewTextBoxColumn.Name = "sendToDataGridViewTextBoxColumn";
            this.sendToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminNetworkDataBindingSource
            // 
            this.adminNetworkDataBindingSource.DataMember = "adminNetworkData";
            this.adminNetworkDataBindingSource.DataSource = this.testerDataSet;
            // 
            // testerDataSet
            // 
            this.testerDataSet.DataSetName = "testerDataSet";
            this.testerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminNetworkDataTableAdapter
            // 
            this.adminNetworkDataTableAdapter.ClearBeforeFill = true;
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(18, 642);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(176, 36);
            this.materialButton1.TabIndex = 20;
            this.materialButton1.Text = "Сохранить данные";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customTextBox1
            // 
            this.customTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customTextBox1.AnimateReadOnly = false;
            this.customTextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.customTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.customTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.adminNetworkDataBindingSource, "SendTo", true));
            this.customTextBox1.Depth = 0;
            this.customTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customTextBox1.HideSelection = true;
            this.customTextBox1.LeadingIcon = null;
            this.customTextBox1.Location = new System.Drawing.Point(17, 143);
            this.customTextBox1.MaxLength = 32767;
            this.customTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.PasswordChar = '\0';
            this.customTextBox1.PrefixSuffixText = null;
            this.customTextBox1.ReadOnly = false;
            this.customTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customTextBox1.SelectedText = "";
            this.customTextBox1.SelectionLength = 0;
            this.customTextBox1.SelectionStart = 0;
            this.customTextBox1.ShortcutsEnabled = true;
            this.customTextBox1.Size = new System.Drawing.Size(412, 48);
            this.customTextBox1.TabIndex = 21;
            this.customTextBox1.TabStop = false;
            this.customTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customTextBox1.TrailingIcon = null;
            this.customTextBox1.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(27, 118);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(123, 19);
            this.materialLabel1.TabIndex = 22;
            this.materialLabel1.Text = "Кому отправить";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(469, 118);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(100, 19);
            this.materialLabel2.TabIndex = 24;
            this.materialLabel2.Text = "SMTP сервер";
            // 
            // customTextBox2
            // 
            this.customTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customTextBox2.AnimateReadOnly = false;
            this.customTextBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.customTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.customTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminNetworkDataBindingSource, "smtpServer", true));
            this.customTextBox2.Depth = 0;
            this.customTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customTextBox2.HideSelection = true;
            this.customTextBox2.LeadingIcon = null;
            this.customTextBox2.Location = new System.Drawing.Point(463, 143);
            this.customTextBox2.MaxLength = 32767;
            this.customTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.PasswordChar = '\0';
            this.customTextBox2.PrefixSuffixText = null;
            this.customTextBox2.ReadOnly = false;
            this.customTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customTextBox2.SelectedText = "";
            this.customTextBox2.SelectionLength = 0;
            this.customTextBox2.SelectionStart = 0;
            this.customTextBox2.ShortcutsEnabled = true;
            this.customTextBox2.Size = new System.Drawing.Size(412, 48);
            this.customTextBox2.TabIndex = 23;
            this.customTextBox2.TabStop = false;
            this.customTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customTextBox2.TrailingIcon = null;
            this.customTextBox2.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(468, 207);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(84, 19);
            this.materialLabel3.TabIndex = 26;
            this.materialLabel3.Text = "SMTP порт";
            // 
            // customTextBox3
            // 
            this.customTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customTextBox3.AnimateReadOnly = false;
            this.customTextBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.customTextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.customTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminNetworkDataBindingSource, "smtpPort", true));
            this.customTextBox3.Depth = 0;
            this.customTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customTextBox3.HideSelection = true;
            this.customTextBox3.LeadingIcon = null;
            this.customTextBox3.Location = new System.Drawing.Point(462, 232);
            this.customTextBox3.MaxLength = 32767;
            this.customTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.PasswordChar = '\0';
            this.customTextBox3.PrefixSuffixText = null;
            this.customTextBox3.ReadOnly = false;
            this.customTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customTextBox3.SelectedText = "";
            this.customTextBox3.SelectionLength = 0;
            this.customTextBox3.SelectionStart = 0;
            this.customTextBox3.ShortcutsEnabled = true;
            this.customTextBox3.Size = new System.Drawing.Size(412, 48);
            this.customTextBox3.TabIndex = 25;
            this.customTextBox3.TabStop = false;
            this.customTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customTextBox3.TrailingIcon = null;
            this.customTextBox3.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(469, 296);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(154, 19);
            this.materialLabel4.TabIndex = 28;
            this.materialLabel4.Text = "SMTP пользователь";
            // 
            // customTextBox4
            // 
            this.customTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customTextBox4.AnimateReadOnly = false;
            this.customTextBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.customTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.customTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminNetworkDataBindingSource, "smtpUsername", true));
            this.customTextBox4.Depth = 0;
            this.customTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customTextBox4.HideSelection = true;
            this.customTextBox4.LeadingIcon = null;
            this.customTextBox4.Location = new System.Drawing.Point(463, 321);
            this.customTextBox4.MaxLength = 32767;
            this.customTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.customTextBox4.Name = "customTextBox4";
            this.customTextBox4.PasswordChar = '\0';
            this.customTextBox4.PrefixSuffixText = null;
            this.customTextBox4.ReadOnly = false;
            this.customTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customTextBox4.SelectedText = "";
            this.customTextBox4.SelectionLength = 0;
            this.customTextBox4.SelectionStart = 0;
            this.customTextBox4.ShortcutsEnabled = true;
            this.customTextBox4.Size = new System.Drawing.Size(412, 48);
            this.customTextBox4.TabIndex = 27;
            this.customTextBox4.TabStop = false;
            this.customTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customTextBox4.TrailingIcon = null;
            this.customTextBox4.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(469, 384);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(103, 19);
            this.materialLabel5.TabIndex = 30;
            this.materialLabel5.Text = "SMTP пароль";
            // 
            // customTextBox5
            // 
            this.customTextBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customTextBox5.AnimateReadOnly = false;
            this.customTextBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.customTextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.customTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.adminNetworkDataBindingSource, "smtpUserpassword", true));
            this.customTextBox5.Depth = 0;
            this.customTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customTextBox5.HideSelection = true;
            this.customTextBox5.LeadingIcon = null;
            this.customTextBox5.Location = new System.Drawing.Point(463, 409);
            this.customTextBox5.MaxLength = 32767;
            this.customTextBox5.MouseState = MaterialSkin.MouseState.OUT;
            this.customTextBox5.Name = "customTextBox5";
            this.customTextBox5.PasswordChar = '\0';
            this.customTextBox5.PrefixSuffixText = null;
            this.customTextBox5.ReadOnly = false;
            this.customTextBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customTextBox5.SelectedText = "";
            this.customTextBox5.SelectionLength = 0;
            this.customTextBox5.SelectionStart = 0;
            this.customTextBox5.ShortcutsEnabled = true;
            this.customTextBox5.Size = new System.Drawing.Size(412, 48);
            this.customTextBox5.TabIndex = 29;
            this.customTextBox5.TabStop = false;
            this.customTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customTextBox5.TrailingIcon = null;
            this.customTextBox5.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(468, 476);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(95, 19);
            this.materialLabel6.TabIndex = 32;
            this.materialLabel6.Text = "SMTP Почта";
            this.materialLabel6.Click += new System.EventHandler(this.materialLabel6_Click);
            // 
            // customTextBox6
            // 
            this.customTextBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customTextBox6.AnimateReadOnly = false;
            this.customTextBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.customTextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.customTextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.adminNetworkDataBindingSource, "smtpSendFrom", true));
            this.customTextBox6.Depth = 0;
            this.customTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customTextBox6.HideSelection = true;
            this.customTextBox6.LeadingIcon = null;
            this.customTextBox6.Location = new System.Drawing.Point(462, 501);
            this.customTextBox6.MaxLength = 32767;
            this.customTextBox6.MouseState = MaterialSkin.MouseState.OUT;
            this.customTextBox6.Name = "customTextBox6";
            this.customTextBox6.PasswordChar = '\0';
            this.customTextBox6.PrefixSuffixText = null;
            this.customTextBox6.ReadOnly = false;
            this.customTextBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customTextBox6.SelectedText = "";
            this.customTextBox6.SelectionLength = 0;
            this.customTextBox6.SelectionStart = 0;
            this.customTextBox6.ShortcutsEnabled = true;
            this.customTextBox6.Size = new System.Drawing.Size(412, 48);
            this.customTextBox6.TabIndex = 31;
            this.customTextBox6.TabStop = false;
            this.customTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customTextBox6.TrailingIcon = null;
            this.customTextBox6.UseSystemPasswordChar = false;
            this.customTextBox6.Click += new System.EventHandler(this.materialTextBox21_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(468, 573);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(181, 19);
            this.materialLabel7.TabIndex = 34;
            this.materialLabel7.Text = "SMTP Имя отправителя";
            // 
            // customTextBox7
            // 
            this.customTextBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customTextBox7.AnimateReadOnly = false;
            this.customTextBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.customTextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.customTextBox7.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.adminNetworkDataBindingSource, "smtpSenderName", true));
            this.customTextBox7.Depth = 0;
            this.customTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customTextBox7.HideSelection = true;
            this.customTextBox7.LeadingIcon = null;
            this.customTextBox7.Location = new System.Drawing.Point(462, 598);
            this.customTextBox7.MaxLength = 32767;
            this.customTextBox7.MouseState = MaterialSkin.MouseState.OUT;
            this.customTextBox7.Name = "customTextBox7";
            this.customTextBox7.PasswordChar = '\0';
            this.customTextBox7.PrefixSuffixText = null;
            this.customTextBox7.ReadOnly = false;
            this.customTextBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customTextBox7.SelectedText = "";
            this.customTextBox7.SelectionLength = 0;
            this.customTextBox7.SelectionStart = 0;
            this.customTextBox7.ShortcutsEnabled = true;
            this.customTextBox7.Size = new System.Drawing.Size(412, 48);
            this.customTextBox7.TabIndex = 33;
            this.customTextBox7.TabStop = false;
            this.customTextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customTextBox7.TrailingIcon = null;
            this.customTextBox7.UseSystemPasswordChar = false;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialButton2);
            this.materialCard1.Controls.Add(this.dataGridView1);
            this.materialCard1.Controls.Add(this.materialLabel7);
            this.materialCard1.Controls.Add(this.customTextBox1);
            this.materialCard1.Controls.Add(this.customTextBox7);
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Controls.Add(this.materialLabel6);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.customTextBox6);
            this.materialCard1.Controls.Add(this.customTextBox5);
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.customTextBox2);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.customTextBox3);
            this.materialCard1.Controls.Add(this.customTextBox4);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(911, 698);
            this.materialCard1.TabIndex = 35;
            // 
            // materialButton2
            // 
            this.materialButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(30, 309);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(262, 60);
            this.materialButton2.TabIndex = 35;
            this.materialButton2.Text = "Указать путь для сохранения результатов тестирования";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(945, 804);
            this.Controls.Add(this.materialCard1);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MailForm";
            this.Text = "MailForm";
            this.Load += new System.EventHandler(this.MailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminNetworkDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerDataSet)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private testerDataSet testerDataSet;
        private System.Windows.Forms.BindingSource adminNetworkDataBindingSource;
        private testerDataSetTableAdapters.adminNetworkDataTableAdapter adminNetworkDataTableAdapter;
        private MaterialSkin.Controls.MaterialTextBox2 customTextBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 customTextBox4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 customTextBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 customTextBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox2 customTextBox6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 customTextBox5;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox2 customTextBox7;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smtpServerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smtpPortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smtpUsernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smtpUserpasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smtpSendFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smtpSenderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sendToDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}