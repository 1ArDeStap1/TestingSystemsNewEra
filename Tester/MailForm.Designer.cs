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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.testerDataSet = new Tester.testerDataSet();
            this.adminNetworkDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminNetworkDataTableAdapter = new Tester.testerDataSetTableAdapters.adminNetworkDataTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smtpServerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smtpPortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smtpUsernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smtpUserpasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smtpSendFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smtpSenderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminNetworkDataBindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(803, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // testerDataSet
            // 
            this.testerDataSet.DataSetName = "testerDataSet";
            this.testerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminNetworkDataBindingSource
            // 
            this.adminNetworkDataBindingSource.DataMember = "adminNetworkData";
            this.adminNetworkDataBindingSource.DataSource = this.testerDataSet;
            // 
            // adminNetworkDataTableAdapter
            // 
            this.adminNetworkDataTableAdapter.ClearBeforeFill = true;
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
            // 
            // smtpPortDataGridViewTextBoxColumn
            // 
            this.smtpPortDataGridViewTextBoxColumn.DataPropertyName = "smtpPort";
            this.smtpPortDataGridViewTextBoxColumn.HeaderText = "smtpPort";
            this.smtpPortDataGridViewTextBoxColumn.Name = "smtpPortDataGridViewTextBoxColumn";
            // 
            // smtpUsernameDataGridViewTextBoxColumn
            // 
            this.smtpUsernameDataGridViewTextBoxColumn.DataPropertyName = "smtpUsername";
            this.smtpUsernameDataGridViewTextBoxColumn.HeaderText = "smtpUsername";
            this.smtpUsernameDataGridViewTextBoxColumn.Name = "smtpUsernameDataGridViewTextBoxColumn";
            // 
            // smtpUserpasswordDataGridViewTextBoxColumn
            // 
            this.smtpUserpasswordDataGridViewTextBoxColumn.DataPropertyName = "smtpUserpassword";
            this.smtpUserpasswordDataGridViewTextBoxColumn.HeaderText = "smtpUserpassword";
            this.smtpUserpasswordDataGridViewTextBoxColumn.Name = "smtpUserpasswordDataGridViewTextBoxColumn";
            // 
            // smtpSendFromDataGridViewTextBoxColumn
            // 
            this.smtpSendFromDataGridViewTextBoxColumn.DataPropertyName = "smtpSendFrom";
            this.smtpSendFromDataGridViewTextBoxColumn.HeaderText = "smtpSendFrom";
            this.smtpSendFromDataGridViewTextBoxColumn.Name = "smtpSendFromDataGridViewTextBoxColumn";
            // 
            // smtpSenderNameDataGridViewTextBoxColumn
            // 
            this.smtpSenderNameDataGridViewTextBoxColumn.DataPropertyName = "smtpSenderName";
            this.smtpSenderNameDataGridViewTextBoxColumn.HeaderText = "smtpSenderName";
            this.smtpSenderNameDataGridViewTextBoxColumn.Name = "smtpSenderNameDataGridViewTextBoxColumn";
            // 
            // sendToDataGridViewTextBoxColumn
            // 
            this.sendToDataGridViewTextBoxColumn.DataPropertyName = "SendTo";
            this.sendToDataGridViewTextBoxColumn.HeaderText = "SendTo";
            this.sendToDataGridViewTextBoxColumn.Name = "sendToDataGridViewTextBoxColumn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(843, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 67);
            this.button1.TabIndex = 2;
            this.button1.Text = "PING";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MailForm";
            this.Text = "MailForm";
            this.Load += new System.EventHandler(this.MailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminNetworkDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private testerDataSet testerDataSet;
        private System.Windows.Forms.BindingSource adminNetworkDataBindingSource;
        private testerDataSetTableAdapters.adminNetworkDataTableAdapter adminNetworkDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smtpServerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smtpPortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smtpUsernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smtpUserpasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smtpSendFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smtpSenderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sendToDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}