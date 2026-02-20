namespace FirstMVCProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuToolStrip = new System.Windows.Forms.ToolStrip();
            this.RemoveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AddToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MyUserTableView = new FirstMVCProject.UsersTableView();
            this.MyUsersTableView = new FirstMVCProject.UsersTableView();
            this.MenuToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyUserTableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyUsersTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuToolStrip
            // 
            this.MenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveToolStripButton,
            this.AddToolStripButton});
            this.MenuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuToolStrip.Name = "MenuToolStrip";
            this.MenuToolStrip.Size = new System.Drawing.Size(800, 35);
            this.MenuToolStrip.TabIndex = 0;
            this.MenuToolStrip.Text = "toolStrip1";
            // 
            // RemoveToolStripButton
            // 
            this.RemoveToolStripButton.AutoSize = false;
            this.RemoveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveToolStripButton.Image")));
            this.RemoveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveToolStripButton.Name = "RemoveToolStripButton";
            this.RemoveToolStripButton.Size = new System.Drawing.Size(32, 32);
            this.RemoveToolStripButton.Text = "Удаление пользователя";
            this.RemoveToolStripButton.Click += new System.EventHandler(this.RemoveToolStripButton_Click);
            // 
            // AddToolStripButton
            // 
            this.AddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AddToolStripButton.Image")));
            this.AddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddToolStripButton.Name = "AddToolStripButton";
            this.AddToolStripButton.Size = new System.Drawing.Size(23, 32);
            this.AddToolStripButton.Text = "Добавление пользователя";
            this.AddToolStripButton.Click += new System.EventHandler(this.AddToolStripButton_Click);
            // 
            // MyUserTableView
            // 
            this.MyUserTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyUserTableView.Dock = System.Windows.Forms.DockStyle.Top;
            this.MyUserTableView.Location = new System.Drawing.Point(0, 35);
            this.MyUserTableView.Name = "MyUserTableView";
            this.MyUserTableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyUserTableView.Size = new System.Drawing.Size(800, 150);
            this.MyUserTableView.TabIndex = 1;
            // 
            // MyUsersTableView
            // 
            this.MyUsersTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyUsersTableView.Dock = System.Windows.Forms.DockStyle.Top;
            this.MyUsersTableView.Location = new System.Drawing.Point(0, 35);
            this.MyUsersTableView.Name = "MyUsersTableView";
            this.MyUsersTableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyUsersTableView.Size = new System.Drawing.Size(800, 150);
            this.MyUsersTableView.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MyUserTableView);
            this.Controls.Add(this.MenuToolStrip);
            this.Name = "MainForm";
            this.Text = "Таблица";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.MenuToolStrip.ResumeLayout(false);
            this.MenuToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyUserTableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyUsersTableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MenuToolStrip;
        private System.Windows.Forms.ToolStripButton RemoveToolStripButton;
        private UsersTableView MyUsersTableView;
        private System.Windows.Forms.ToolStripButton AddToolStripButton;
        private UsersTableView MyUserTableView;
    }
}

