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
            this.numberIDNameLabel = new System.Windows.Forms.Label();
            this.numberIDLabel = new System.Windows.Forms.Label();
            this.abgScoreNameLabel = new System.Windows.Forms.Label();
            this.avgScoreLabel = new System.Windows.Forms.Label();
            this.ageNameLabel = new System.Windows.Forms.Label();
            this.pictureArea = new System.Windows.Forms.PictureBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArea)).BeginInit();
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
            this.studentNameListBox.SelectedIndexChanged += new System.EventHandler(this.studentNameListBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numberIDNameLabel);
            this.panel1.Controls.Add(this.numberIDLabel);
            this.panel1.Controls.Add(this.abgScoreNameLabel);
            this.panel1.Controls.Add(this.ageeLabel);
            this.panel1.Controls.Add(this.avgScoreLabel);
            this.panel1.Controls.Add(this.ageNameLabel);
            this.panel1.Controls.Add(this.pictureArea);
            this.panel1.Controls.Add(this.ageLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(144, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 450);
            this.panel1.TabIndex = 3;
            // 
            // numberIDNameLabel
            // 
            this.numberIDNameLabel.AutoSize = true;
            this.numberIDNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberIDNameLabel.Location = new System.Drawing.Point(6, 125);
            this.numberIDNameLabel.Name = "numberIDNameLabel";
            this.numberIDNameLabel.Size = new System.Drawing.Size(126, 20);
            this.numberIDNameLabel.TabIndex = 1;
            this.numberIDNameLabel.Text = "№ студ. билета";
            // 
            // numberIDLabel
            // 
            this.numberIDLabel.AutoSize = true;
            this.numberIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberIDLabel.Location = new System.Drawing.Point(148, 125);
            this.numberIDLabel.Name = "numberIDLabel";
            this.numberIDLabel.Size = new System.Drawing.Size(51, 20);
            this.numberIDLabel.TabIndex = 1;
            this.numberIDLabel.Text = "label1";
            // 
            // abgScoreNameLabel
            // 
            this.abgScoreNameLabel.AutoSize = true;
            this.abgScoreNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.abgScoreNameLabel.Location = new System.Drawing.Point(6, 72);
            this.abgScoreNameLabel.Name = "abgScoreNameLabel";
            this.abgScoreNameLabel.Size = new System.Drawing.Size(75, 20);
            this.abgScoreNameLabel.TabIndex = 1;
            this.abgScoreNameLabel.Text = "Ср. балл";
            // 
            // avgScoreLabel
            // 
            this.avgScoreLabel.AutoSize = true;
            this.avgScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avgScoreLabel.Location = new System.Drawing.Point(148, 72);
            this.avgScoreLabel.Name = "avgScoreLabel";
            this.avgScoreLabel.Size = new System.Drawing.Size(51, 20);
            this.avgScoreLabel.TabIndex = 1;
            this.avgScoreLabel.Text = "label1";
            // 
            // ageNameLabel
            // 
            this.ageNameLabel.AutoSize = true;
            this.ageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageNameLabel.Location = new System.Drawing.Point(6, 22);
            this.ageNameLabel.Name = "ageNameLabel";
            this.ageNameLabel.Size = new System.Drawing.Size(72, 20);
            this.ageNameLabel.TabIndex = 1;
            this.ageNameLabel.Text = "Возраст";
            // 
            // pictureArea
            // 
            this.pictureArea.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureArea.Location = new System.Drawing.Point(0, 0);
            this.pictureArea.Name = "pictureArea";
            this.pictureArea.Size = new System.Drawing.Size(656, 450);
            this.pictureArea.TabIndex = 0;
            this.pictureArea.TabStop = false;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLabel.Location = new System.Drawing.Point(148, 22);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(51, 20);
            this.ageLabel.TabIndex = 1;
            this.ageLabel.Text = "label1";
            // 
            // ageeLabel
            // 
            this.ageeLabel.AutoSize = true;
            this.ageeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageeLabel.Location = new System.Drawing.Point(148, 22);
            this.ageeLabel.Name = "ageeLabel";
            this.ageeLabel.Size = new System.Drawing.Size(51, 20);
            this.ageeLabel.TabIndex = 1;
            this.ageeLabel.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.studentNameListBox);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Students";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox studentNameListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureArea;
        private System.Windows.Forms.Label numberIDLabel;
        private System.Windows.Forms.Label avgScoreLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label numberIDNameLabel;
        private System.Windows.Forms.Label abgScoreNameLabel;
        private System.Windows.Forms.Label ageNameLabel;
        private System.Windows.Forms.Label ageeLabel;
    }
}

