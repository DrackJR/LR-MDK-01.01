namespace ConstWinForm
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
            this.studentNameListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.avgScoreLabel = new System.Windows.Forms.Label();
            this.numberIDLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentNameListBox
            // 
            this.studentNameListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.studentNameListBox.FormattingEnabled = true;
            this.studentNameListBox.Location = new System.Drawing.Point(0, 0);
            this.studentNameListBox.Name = "studentNameListBox";
            this.studentNameListBox.Size = new System.Drawing.Size(144, 450);
            this.studentNameListBox.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numberIDLabel);
            this.panel1.Controls.Add(this.avgScoreLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ageLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(144, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 450);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(126, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(48, 58);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(35, 13);
            this.ageLabel.TabIndex = 1;
            this.ageLabel.Text = "label1";
            // 
            // avgScoreLabel
            // 
            this.avgScoreLabel.AutoSize = true;
            this.avgScoreLabel.Location = new System.Drawing.Point(48, 88);
            this.avgScoreLabel.Name = "avgScoreLabel";
            this.avgScoreLabel.Size = new System.Drawing.Size(35, 13);
            this.avgScoreLabel.TabIndex = 1;
            this.avgScoreLabel.Text = "label1";
            // 
            // numberIDLabel
            // 
            this.numberIDLabel.AutoSize = true;
            this.numberIDLabel.Location = new System.Drawing.Point(48, 124);
            this.numberIDLabel.Name = "numberIDLabel";
            this.numberIDLabel.Size = new System.Drawing.Size(35, 13);
            this.numberIDLabel.TabIndex = 1;
            this.numberIDLabel.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.studentNameListBox);
            this.Name = "MainForm";
            this.Text = "Students";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox studentNameListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label numberIDLabel;
        private System.Windows.Forms.Label avgScoreLabel;
        private System.Windows.Forms.Label ageLabel;
    }
}

