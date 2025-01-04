namespace Tester
{
    partial class TestCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestCreation));
            this.label8 = new System.Windows.Forms.Label();
            this.formsStyle1 = new Tester.FormsStyle(this.components);
            this.textBox6 = new Tester.CustomStyles.CustomTextBox();
            this.numericUpDown2 = new Tester.CustomStyles.CustomTextBox();
            this.textBox7 = new Tester.CustomStyles.CustomTextBox();
            this.customButton1 = new Tester.CustomButton();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(230, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Описание теста";
            // 
            // formsStyle1
            // 
            this.formsStyle1.form = this;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderColor = System.Drawing.Color.DarkBlue;
            this.textBox6.BorderColorNotActive = System.Drawing.Color.DarkGray;
            this.textBox6.Font = new System.Drawing.Font("Arial", 11.5F);
            this.textBox6.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(25, 31);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(509, 53);
            this.textBox6.TabIndex = 19;
            this.textBox6.Text = "";
            this.textBox6.TextPreview = "Название теста";
            this.textBox6.UseSystemPasswordChars = false;
            this.textBox6.VerticalOffset = 8;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.White;
            this.numericUpDown2.BorderColor = System.Drawing.Color.DarkBlue;
            this.numericUpDown2.BorderColorNotActive = System.Drawing.Color.DarkGray;
            this.numericUpDown2.Font = new System.Drawing.Font("Arial", 11.5F);
            this.numericUpDown2.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.numericUpDown2.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown2.Location = new System.Drawing.Point(25, 99);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(180, 53);
            this.numericUpDown2.TabIndex = 20;
            this.numericUpDown2.Text = "";
            this.numericUpDown2.TextPreview = "Длительность теста";
            this.numericUpDown2.UseSystemPasswordChars = false;
            this.numericUpDown2.VerticalOffset = 8;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderColor = System.Drawing.Color.DarkBlue;
            this.textBox7.BorderColorNotActive = System.Drawing.Color.DarkGray;
            this.textBox7.Font = new System.Drawing.Font("Arial", 11.5F);
            this.textBox7.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(25, 172);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(509, 288);
            this.textBox7.TabIndex = 21;
            this.textBox7.Text = "";
            this.textBox7.TextPreview = "Описание теста";
            this.textBox7.UseSystemPasswordChars = false;
            this.textBox7.VerticalOffset = 8;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.DarkBlue;
            this.customButton1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customButton1.ForeColor = System.Drawing.Color.Chartreuse;
            this.customButton1.Location = new System.Drawing.Point(25, 488);
            this.customButton1.Name = "customButton1";
            this.customButton1.RoundingEnabled = true;
            this.customButton1.RoundingPercent = 30;
            this.customButton1.Size = new System.Drawing.Size(509, 76);
            this.customButton1.TabIndex = 22;
            this.customButton1.Text = "Добавить тест";
            this.customButton1.Click += new System.EventHandler(this.button4_Click);
            // 
            // TestCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(562, 601);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestCreation";
            this.Text = "Создание теста";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private FormsStyle formsStyle1;
        private CustomStyles.CustomTextBox textBox6;
        private CustomButton customButton1;
        private CustomStyles.CustomTextBox textBox7;
        private CustomStyles.CustomTextBox numericUpDown2;
    }
}