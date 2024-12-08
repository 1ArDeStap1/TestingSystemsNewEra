namespace Tester
{
    partial class AuthForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.formsStyle1 = new Tester.FormsStyle(this.components);
            this.textBox1 = new Tester.CustomStyles.CustomTextBox();
            this.textBox2 = new Tester.CustomStyles.CustomTextBox();
            this.Войти = new Tester.CustomButton();
            this.SuspendLayout();
            // 
            // formsStyle1
            // 
            this.formsStyle1.form = this;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderColor = System.Drawing.Color.DarkBlue;
            this.textBox1.BorderColorNotActive = System.Drawing.Color.DarkGray;
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.5F);
            this.textBox1.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(12, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(476, 48);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextInput = "";
            this.textBox1.TextPreview = "Логин";
            this.textBox1.UseSystemPasswordChars = false;
            this.textBox1.VerticalOffset = 10;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderColor = System.Drawing.Color.DarkBlue;
            this.textBox2.BorderColorNotActive = System.Drawing.Color.DarkGray;
            this.textBox2.Font = new System.Drawing.Font("Arial", 11.5F);
            this.textBox2.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(12, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(476, 49);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextInput = "";
            this.textBox2.TextPreview = "Пароль";
            this.textBox2.UseSystemPasswordChars = false;
            this.textBox2.VerticalOffset = 20;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // Войти
            // 
            this.Войти.BackColor = System.Drawing.Color.DarkBlue;
            this.Войти.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Войти.ForeColor = System.Drawing.Color.Chartreuse;
            this.Войти.Location = new System.Drawing.Point(282, 198);
            this.Войти.Name = "Войти";
            this.Войти.RoundingEnabled = true;
            this.Войти.RoundingPercent = 30;
            this.Войти.Size = new System.Drawing.Size(206, 52);
            this.Войти.TabIndex = 2;
            this.Войти.Text = "Войти";
            this.Войти.Click += new System.EventHandler(this.button1_Click);
            // 
            // AuthForm
            // 
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(510, 281);
            this.Controls.Add(this.Войти);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthForm";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private FormsStyle formsStyle;
        private CustomStyles.CustomTextBox customTextBox1;
        private CustomStyles.CustomTextBox customTextBox2;
        private CustomButton customButton2;
        private FormsStyle formsStyle1;
        private CustomStyles.CustomTextBox textBox1;
        private CustomStyles.CustomTextBox textBox2;
        private CustomButton Войти;
    }
}

