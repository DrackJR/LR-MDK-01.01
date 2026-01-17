namespace WinFormsTest
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
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.ListPanel = new System.Windows.Forms.Panel();
            this.PicturePanel = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.FileNamesListBox = new System.Windows.Forms.ListBox();
            this.PictureArea = new System.Windows.Forms.PictureBox();
            this.ButtonsPanel.SuspendLayout();
            this.ListPanel.SuspendLayout();
            this.PicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureArea)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.DeleteButton);
            this.ButtonsPanel.Controls.Add(this.EditButton);
            this.ButtonsPanel.Controls.Add(this.LoadButton);
            this.ButtonsPanel.Controls.Add(this.SaveButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 374);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(800, 76);
            this.ButtonsPanel.TabIndex = 0;
            // 
            // ListPanel
            // 
            this.ListPanel.Controls.Add(this.FileNamesListBox);
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListPanel.Location = new System.Drawing.Point(0, 0);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(200, 374);
            this.ListPanel.TabIndex = 1;
            // 
            // PicturePanel
            // 
            this.PicturePanel.Controls.Add(this.PictureArea);
            this.PicturePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicturePanel.Location = new System.Drawing.Point(200, 0);
            this.PicturePanel.Name = "PicturePanel";
            this.PicturePanel.Size = new System.Drawing.Size(600, 374);
            this.PicturePanel.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(87, 23);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(113, 41);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(261, 23);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(113, 41);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Загрузить";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(437, 23);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(113, 41);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(604, 23);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(113, 41);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // FileNamesListBox
            // 
            this.FileNamesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileNamesListBox.FormattingEnabled = true;
            this.FileNamesListBox.Location = new System.Drawing.Point(0, 0);
            this.FileNamesListBox.Name = "FileNamesListBox";
            this.FileNamesListBox.Size = new System.Drawing.Size(200, 374);
            this.FileNamesListBox.TabIndex = 0;
            this.FileNamesListBox.SelectedIndexChanged += new System.EventHandler(this.FileNamesListBox_SelectedIndexChanged);
            // 
            // PictureArea
            // 
            this.PictureArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureArea.Location = new System.Drawing.Point(0, 0);
            this.PictureArea.Name = "PictureArea";
            this.PictureArea.Size = new System.Drawing.Size(600, 374);
            this.PictureArea.TabIndex = 0;
            this.PictureArea.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PicturePanel);
            this.Controls.Add(this.ListPanel);
            this.Controls.Add(this.ButtonsPanel);
            this.Name = "MainForm";
            this.Text = "Test";
            this.ButtonsPanel.ResumeLayout(false);
            this.ListPanel.ResumeLayout(false);
            this.PicturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.Panel PicturePanel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ListBox FileNamesListBox;
        private System.Windows.Forms.PictureBox PictureArea;
    }
}

