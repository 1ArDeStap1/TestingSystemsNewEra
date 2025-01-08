namespace Tester
{
    partial class Opk_Result_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opk_Result_Form));
            this.formsStyle1 = new Tester.FormsStyle(this.components);
            this.opk_resultTableAdapter1 = new Tester.testerDataSetTableAdapters.opk_resultTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.opkresultBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testerDataSet = new Tester.testerDataSet();
            this.opk_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allquestionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opkpercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complition_percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opkresultBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // formsStyle1
            // 
            this.formsStyle1.form = this;
            // 
            // opk_resultTableAdapter1
            // 
            this.opk_resultTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.opk_Name,
            this.idDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.correctsDataGridViewTextBoxColumn,
            this.allquestionsDataGridViewTextBoxColumn,
            this.opkpercentDataGridViewTextBoxColumn,
            this.resultidDataGridViewTextBoxColumn,
            this.resultdescriptionDataGridViewTextBoxColumn,
            this.complition_percent});
            this.dataGridView1.DataSource = this.opkresultBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(670, 476);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            // 
            // opkresultBindingSource1
            // 
            this.opkresultBindingSource1.DataMember = "opk_result";
            this.opkresultBindingSource1.DataSource = this.testerDataSet;
            // 
            // testerDataSet
            // 
            this.testerDataSet.DataSetName = "testerDataSet";
            this.testerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // opk_Name
            // 
            this.opk_Name.DataPropertyName = "Name";
            this.opk_Name.HeaderText = "Название Компетенции";
            this.opk_Name.Name = "opk_Name";
            this.opk_Name.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            this.useridDataGridViewTextBoxColumn.Visible = false;
            // 
            // correctsDataGridViewTextBoxColumn
            // 
            this.correctsDataGridViewTextBoxColumn.DataPropertyName = "corrects";
            this.correctsDataGridViewTextBoxColumn.HeaderText = "Кол-во правильных";
            this.correctsDataGridViewTextBoxColumn.Name = "correctsDataGridViewTextBoxColumn";
            this.correctsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // allquestionsDataGridViewTextBoxColumn
            // 
            this.allquestionsDataGridViewTextBoxColumn.DataPropertyName = "all_questions";
            this.allquestionsDataGridViewTextBoxColumn.HeaderText = "Всего вопросов";
            this.allquestionsDataGridViewTextBoxColumn.Name = "allquestionsDataGridViewTextBoxColumn";
            this.allquestionsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opkpercentDataGridViewTextBoxColumn
            // 
            this.opkpercentDataGridViewTextBoxColumn.DataPropertyName = "opk_percent";
            this.opkpercentDataGridViewTextBoxColumn.HeaderText = "Процент освоения";
            this.opkpercentDataGridViewTextBoxColumn.Name = "opkpercentDataGridViewTextBoxColumn";
            this.opkpercentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultidDataGridViewTextBoxColumn
            // 
            this.resultidDataGridViewTextBoxColumn.DataPropertyName = "result_id";
            this.resultidDataGridViewTextBoxColumn.HeaderText = "result_id";
            this.resultidDataGridViewTextBoxColumn.Name = "resultidDataGridViewTextBoxColumn";
            this.resultidDataGridViewTextBoxColumn.ReadOnly = true;
            this.resultidDataGridViewTextBoxColumn.Visible = false;
            // 
            // resultdescriptionDataGridViewTextBoxColumn
            // 
            this.resultdescriptionDataGridViewTextBoxColumn.DataPropertyName = "result_description";
            this.resultdescriptionDataGridViewTextBoxColumn.HeaderText = "Результат";
            this.resultdescriptionDataGridViewTextBoxColumn.Name = "resultdescriptionDataGridViewTextBoxColumn";
            this.resultdescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // complition_percent
            // 
            this.complition_percent.DataPropertyName = "complition_percent";
            this.complition_percent.HeaderText = "Требуемый процент для освоения";
            this.complition_percent.Name = "complition_percent";
            this.complition_percent.ReadOnly = true;
            // 
            // Opk_Result_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(694, 500);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Opk_Result_Form";
            this.Text = "Освоение компетенций";
            this.Load += new System.EventHandler(this.Opk_Result_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opkresultBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FormsStyle formsStyle1;
        private testerDataSetTableAdapters.opk_resultTableAdapter opk_resultTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private testerDataSet testerDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn opkidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource opkresultBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn opk_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allquestionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opkpercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complition_percent;
    }
}