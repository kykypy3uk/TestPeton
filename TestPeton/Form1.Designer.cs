namespace TestPeton
{
    partial class Form1
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.CheckTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(13, 13);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox.Size = new System.Drawing.Size(359, 142);
            this.TextBox.TabIndex = 0;
            // 
            // CheckTypeComboBox
            // 
            this.CheckTypeComboBox.FormattingEnabled = true;
            this.CheckTypeComboBox.Items.AddRange(new object[] {
            "Обычный текст",
            "Номер телефона",
            "Почтовый адрес"});
            this.CheckTypeComboBox.Location = new System.Drawing.Point(13, 162);
            this.CheckTypeComboBox.Name = "CheckTypeComboBox";
            this.CheckTypeComboBox.Size = new System.Drawing.Size(278, 21);
            this.CheckTypeComboBox.TabIndex = 1;
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(297, 161);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 23);
            this.CheckButton.TabIndex = 2;
            this.CheckButton.Text = "Проверить";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 194);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.CheckTypeComboBox);
            this.Controls.Add(this.TextBox);
            this.Name = "Form1";
            this.Text = "Тестовое";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.ComboBox CheckTypeComboBox;
        private System.Windows.Forms.Button CheckButton;
    }
}

