namespace NasledWinForms
{
    partial class MainForm
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
            this.StudentsInfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.HomoSapiensInfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudentsInfoRichTextBox
            // 
            this.StudentsInfoRichTextBox.Location = new System.Drawing.Point(48, 85);
            this.StudentsInfoRichTextBox.Name = "StudentsInfoRichTextBox";
            this.StudentsInfoRichTextBox.Size = new System.Drawing.Size(179, 130);
            this.StudentsInfoRichTextBox.TabIndex = 0;
            this.StudentsInfoRichTextBox.Text = "";
            // 
            // HomoSapiensInfoRichTextBox
            // 
            this.HomoSapiensInfoRichTextBox.Location = new System.Drawing.Point(281, 85);
            this.HomoSapiensInfoRichTextBox.Name = "HomoSapiensInfoRichTextBox";
            this.HomoSapiensInfoRichTextBox.Size = new System.Drawing.Size(179, 130);
            this.HomoSapiensInfoRichTextBox.TabIndex = 0;
            this.HomoSapiensInfoRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Студенты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Человек разумный";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 277);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HomoSapiensInfoRichTextBox);
            this.Controls.Add(this.StudentsInfoRichTextBox);
            this.Name = "MainForm";
            this.Text = "Информация о существах";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox StudentsInfoRichTextBox;
        private System.Windows.Forms.RichTextBox HomoSapiensInfoRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

