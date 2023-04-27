namespace ITStep_WinForm1
{
    partial class Угадайка
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
            this.GuessButton = new System.Windows.Forms.Button();
            this.GuessTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GuessButton
            // 
            this.GuessButton.Location = new System.Drawing.Point(54, 98);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(100, 23);
            this.GuessButton.TabIndex = 0;
            this.GuessButton.Text = "Приступить";
            this.GuessButton.UseVisualStyleBackColor = true;
            this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // GuessTextBox
            // 
            this.GuessTextBox.Location = new System.Drawing.Point(54, 48);
            this.GuessTextBox.Name = "GuessTextBox";
            this.GuessTextBox.Size = new System.Drawing.Size(100, 20);
            this.GuessTextBox.TabIndex = 2;
            // 
            // Угадайка
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(211, 175);
            this.Controls.Add(this.GuessTextBox);
            this.Controls.Add(this.GuessButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Угадайка";
            this.Text = "Угадайка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Button GuessButton;
        private System.Windows.Forms.TextBox GuessTextBox;
    }
}

