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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adminNetworkDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testerDataSet = new Tester.testerDataSet();
            this.adminNetworkDataTableAdapter = new Tester.testerDataSetTableAdapters.adminNetworkDataTableAdapter();
            this.ExtendedOptions = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smtpServerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smtpPortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smtpUsernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smtpUserpasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smtpSendFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smtpSenderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customTextBox7 = new Tester.CustomStyles.CustomTextBox();
            this.customTextBox6 = new Tester.CustomStyles.CustomTextBox();
            this.customTextBox5 = new Tester.CustomStyles.CustomTextBox();
            this.customTextBox4 = new Tester.CustomStyles.CustomTextBox();
            this.customTextBox3 = new Tester.CustomStyles.CustomTextBox();
            this.customTextBox2 = new Tester.CustomStyles.CustomTextBox();
            this.customButton2 = new Tester.CustomButton();
            this.customTextBox1 = new Tester.CustomStyles.CustomTextBox();
            this.formsStyle1 = new Tester.FormsStyle(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminNetworkDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(353, 86);
            this.dataGridView1.TabIndex = 0;
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
            // ExtendedOptions
            // 
            this.ExtendedOptions.BackColor = System.Drawing.Color.Transparent;
            this.ExtendedOptions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExtendedOptions.BackgroundImage")));
            this.ExtendedOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExtendedOptions.FlatAppearance.BorderSize = 0;
            this.ExtendedOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExtendedOptions.ForeColor = System.Drawing.Color.Transparent;
            this.ExtendedOptions.Image = ((System.Drawing.Image)(resources.GetObject("ExtendedOptions.Image")));
            this.ExtendedOptions.Location = new System.Drawing.Point(372, 12);
            this.ExtendedOptions.Name = "ExtendedOptions";
            this.ExtendedOptions.Size = new System.Drawing.Size(52, 52);
            this.ExtendedOptions.TabIndex = 13;
            this.ExtendedOptions.UseVisualStyleBackColor = false;
            this.ExtendedOptions.Click += new System.EventHandler(this.ExtendedOptions_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // smtpServerDataGridViewTextBoxColumn
            // 
            this.smtpServerDataGridViewTextBoxColumn.DataPropertyName = "smtpServer";
            this.smtpServerDataGridViewTextBoxColumn.HeaderText = "smtpServer";
            this.smtpServerDataGridViewTextBoxColumn.Name = "smtpServerDataGridViewTextBoxColumn";
            this.smtpServerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // smtpPortDataGridViewTextBoxColumn
            // 
            this.smtpPortDataGridViewTextBoxColumn.DataPropertyName = "smtpPort";
            this.smtpPortDataGridViewTextBoxColumn.HeaderText = "smtpPort";
            this.smtpPortDataGridViewTextBoxColumn.Name = "smtpPortDataGridViewTextBoxColumn";
            this.smtpPortDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // smtpUsernameDataGridViewTextBoxColumn
            // 
            this.smtpUsernameDataGridViewTextBoxColumn.DataPropertyName = "smtpUsername";
            this.smtpUsernameDataGridViewTextBoxColumn.HeaderText = "smtpUsername";
            this.smtpUsernameDataGridViewTextBoxColumn.Name = "smtpUsernameDataGridViewTextBoxColumn";
            this.smtpUsernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // smtpUserpasswordDataGridViewTextBoxColumn
            // 
            this.smtpUserpasswordDataGridViewTextBoxColumn.DataPropertyName = "smtpUserpassword";
            this.smtpUserpasswordDataGridViewTextBoxColumn.HeaderText = "smtpUserpassword";
            this.smtpUserpasswordDataGridViewTextBoxColumn.Name = "smtpUserpasswordDataGridViewTextBoxColumn";
            this.smtpUserpasswordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // smtpSendFromDataGridViewTextBoxColumn
            // 
            this.smtpSendFromDataGridViewTextBoxColumn.DataPropertyName = "smtpSendFrom";
            this.smtpSendFromDataGridViewTextBoxColumn.HeaderText = "smtpSendFrom";
            this.smtpSendFromDataGridViewTextBoxColumn.Name = "smtpSendFromDataGridViewTextBoxColumn";
            this.smtpSendFromDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // smtpSenderNameDataGridViewTextBoxColumn
            // 
            this.smtpSenderNameDataGridViewTextBoxColumn.DataPropertyName = "smtpSenderName";
            this.smtpSenderNameDataGridViewTextBoxColumn.HeaderText = "smtpSenderName";
            this.smtpSenderNameDataGridViewTextBoxColumn.Name = "smtpSenderNameDataGridViewTextBoxColumn";
            this.smtpSenderNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sendToDataGridViewTextBoxColumn
            // 
            this.sendToDataGridViewTextBoxColumn.DataPropertyName = "SendTo";
            this.sendToDataGridViewTextBoxColumn.HeaderText = "SendTo";
            this.sendToDataGridViewTextBoxColumn.Name = "sendToDataGridViewTextBoxColumn";
            this.sendToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customTextBox7
            // 
            this.customTextBox7.BackColor = System.Drawing.Color.White;
            this.customTextBox7.BorderColor = System.Drawing.Color.DarkBlue;
            this.customTextBox7.BorderColorNotActive = System.Drawing.Color.DarkGray;
            this.customTextBox7.Font = new System.Drawing.Font("Arial", 11.5F);
            this.customTextBox7.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.customTextBox7.ForeColor = System.Drawing.Color.Black;
            this.customTextBox7.Location = new System.Drawing.Point(446, 334);
            this.customTextBox7.Name = "customTextBox7";
            this.customTextBox7.Size = new System.Drawing.Size(411, 51);
            this.customTextBox7.TabIndex = 19;
            this.customTextBox7.text = null;
            this.customTextBox7.TextPreview = "SMTP Имя отправителя";
            this.customTextBox7.UseSystemPasswordChars = false;
            this.customTextBox7.VerticalOffset = 8;
            // 
            // customTextBox6
            // 
            this.customTextBox6.BackColor = System.Drawing.Color.White;
            this.customTextBox6.BorderColor = System.Drawing.Color.DarkBlue;
            this.customTextBox6.BorderColorNotActive = System.Drawing.Color.DarkGray;
            this.customTextBox6.Font = new System.Drawing.Font("Arial", 11.5F);
            this.customTextBox6.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.customTextBox6.ForeColor = System.Drawing.Color.Black;
            this.customTextBox6.Location = new System.Drawing.Point(446, 277);
            this.customTextBox6.Name = "customTextBox6";
            this.customTextBox6.Size = new System.Drawing.Size(411, 51);
            this.customTextBox6.TabIndex = 18;
            this.customTextBox6.text = null;
            this.customTextBox6.TextPreview = "SMTP Почта отправителя";
            this.customTextBox6.UseSystemPasswordChars = false;
            this.customTextBox6.VerticalOffset = 8;
            // 
            // customTextBox5
            // 
            this.customTextBox5.BackColor = System.Drawing.Color.White;
            this.customTextBox5.BorderColor = System.Drawing.Color.DarkBlue;
            this.customTextBox5.BorderColorNotActive = System.Drawing.Color.DarkGray;
            this.customTextBox5.Font = new System.Drawing.Font("Arial", 11.5F);
            this.customTextBox5.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.customTextBox5.ForeColor = System.Drawing.Color.Black;
            this.customTextBox5.Location = new System.Drawing.Point(446, 220);
            this.customTextBox5.Name = "customTextBox5";
            this.customTextBox5.Size = new System.Drawing.Size(411, 51);
            this.customTextBox5.TabIndex = 17;
            this.customTextBox5.text = null;
            this.customTextBox5.TextPreview = "SMTP password";
            this.customTextBox5.UseSystemPasswordChars = false;
            this.customTextBox5.VerticalOffset = 8;
            // 
            // customTextBox4
            // 
            this.customTextBox4.BackColor = System.Drawing.Color.White;
            this.customTextBox4.BorderColor = System.Drawing.Color.DarkBlue;
            this.customTextBox4.BorderColorNotActive = System.Drawing.Color.DarkGray;
            this.customTextBox4.Font = new System.Drawing.Font("Arial", 11.5F);
            this.customTextBox4.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.customTextBox4.ForeColor = System.Drawing.Color.Black;
            this.customTextBox4.Location = new System.Drawing.Point(446, 163);
            this.customTextBox4.Name = "customTextBox4";
            this.customTextBox4.Size = new System.Drawing.Size(411, 51);
            this.customTextBox4.TabIndex = 16;
            this.customTextBox4.text = null;
            this.customTextBox4.TextPreview = "SMTP Username";
            this.customTextBox4.UseSystemPasswordChars = false;
            this.customTextBox4.VerticalOffset = 8;
            // 
            // customTextBox3
            // 
            this.customTextBox3.BackColor = System.Drawing.Color.White;
            this.customTextBox3.BorderColor = System.Drawing.Color.DarkBlue;
            this.customTextBox3.BorderColorNotActive = System.Drawing.Color.DarkGray;
            this.customTextBox3.Font = new System.Drawing.Font("Arial", 11.5F);
            this.customTextBox3.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.customTextBox3.ForeColor = System.Drawing.Color.Black;
            this.customTextBox3.Location = new System.Drawing.Point(446, 106);
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.Size = new System.Drawing.Size(411, 51);
            this.customTextBox3.TabIndex = 15;
            this.customTextBox3.text = null;
            this.customTextBox3.TextPreview = "SMTP Port";
            this.customTextBox3.UseSystemPasswordChars = false;
            this.customTextBox3.VerticalOffset = 8;
            // 
            // customTextBox2
            // 
            this.customTextBox2.BackColor = System.Drawing.Color.White;
            this.customTextBox2.BorderColor = System.Drawing.Color.DarkBlue;
            this.customTextBox2.BorderColorNotActive = System.Drawing.Color.DarkGray;
            this.customTextBox2.Font = new System.Drawing.Font("Arial", 11.5F);
            this.customTextBox2.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.customTextBox2.ForeColor = System.Drawing.Color.Black;
            this.customTextBox2.Location = new System.Drawing.Point(446, 49);
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Size = new System.Drawing.Size(411, 51);
            this.customTextBox2.TabIndex = 14;
            this.customTextBox2.text = null;
            this.customTextBox2.TextPreview = "SMTP server";
            this.customTextBox2.UseSystemPasswordChars = false;
            this.customTextBox2.VerticalOffset = 8;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.DarkBlue;
            this.customButton2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customButton2.ForeColor = System.Drawing.Color.Chartreuse;
            this.customButton2.Location = new System.Drawing.Point(13, 194);
            this.customButton2.Margin = new System.Windows.Forms.Padding(4);
            this.customButton2.Name = "customButton2";
            this.customButton2.RoundingEnabled = true;
            this.customButton2.RoundingPercent = 30;
            this.customButton2.Size = new System.Drawing.Size(411, 57);
            this.customButton2.TabIndex = 12;
            this.customButton2.Text = "Сохранить";
            this.customButton2.Click += new System.EventHandler(this.button1_Click);
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.Color.White;
            this.customTextBox1.BorderColor = System.Drawing.Color.DarkBlue;
            this.customTextBox1.BorderColorNotActive = System.Drawing.Color.DarkGray;
            this.customTextBox1.Font = new System.Drawing.Font("Arial", 11.5F);
            this.customTextBox1.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.customTextBox1.ForeColor = System.Drawing.Color.Black;
            this.customTextBox1.Location = new System.Drawing.Point(12, 104);
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Size = new System.Drawing.Size(412, 51);
            this.customTextBox1.TabIndex = 3;
            this.customTextBox1.text = null;
            this.customTextBox1.TextPreview = "Введите свою почту";
            this.customTextBox1.UseSystemPasswordChars = false;
            this.customTextBox1.VerticalOffset = 8;
            // 
            // formsStyle1
            // 
            this.formsStyle1.form = this;
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(875, 415);
            this.Controls.Add(this.customTextBox7);
            this.Controls.Add(this.customTextBox6);
            this.Controls.Add(this.customTextBox5);
            this.Controls.Add(this.customTextBox4);
            this.Controls.Add(this.customTextBox3);
            this.Controls.Add(this.customTextBox2);
            this.Controls.Add(this.ExtendedOptions);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MailForm";
            this.Text = "MailForm";
            this.Load += new System.EventHandler(this.MailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminNetworkDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private testerDataSet testerDataSet;
        private System.Windows.Forms.BindingSource adminNetworkDataBindingSource;
        private testerDataSetTableAdapters.adminNetworkDataTableAdapter adminNetworkDataTableAdapter;
        private CustomStyles.CustomTextBox customTextBox1;
        private CustomButton customButton2;
        private System.Windows.Forms.Button ExtendedOptions;
        private CustomStyles.CustomTextBox customTextBox2;
        private CustomStyles.CustomTextBox customTextBox3;
        private CustomStyles.CustomTextBox customTextBox4;
        private CustomStyles.CustomTextBox customTextBox5;
        private CustomStyles.CustomTextBox customTextBox6;
        private CustomStyles.CustomTextBox customTextBox7;
        private FormsStyle formsStyle1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smtpServerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smtpPortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smtpUsernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smtpUserpasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smtpSendFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smtpSenderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sendToDataGridViewTextBoxColumn;
    }
}