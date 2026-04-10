namespace LR_PostgreSQL
{
    partial class AddEditForm
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
            this.CostNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.ExecutorTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.VenueTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CostNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CostNumericUpDown
            // 
            this.CostNumericUpDown.Location = new System.Drawing.Point(164, 89);
            this.CostNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CostNumericUpDown.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.CostNumericUpDown.Name = "CostNumericUpDown";
            this.CostNumericUpDown.Size = new System.Drawing.Size(255, 20);
            this.CostNumericUpDown.TabIndex = 14;
            this.CostNumericUpDown.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.CostNumericUpDown.ValueChanged += new System.EventHandler(this.CostNumericUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(59, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(35, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Исполнитель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(60, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Место проведения";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyButton.Location = new System.Drawing.Point(337, 140);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(91, 23);
            this.ApplyButton.TabIndex = 17;
            this.ApplyButton.Text = "Применить";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(241, 140);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(93, 23);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKButton.Location = new System.Drawing.Point(150, 140);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(88, 23);
            this.OKButton.TabIndex = 15;
            this.OKButton.Text = "ОК";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ExecutorTextBox
            // 
            this.ExecutorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExecutorTextBox.Location = new System.Drawing.Point(164, 64);
            this.ExecutorTextBox.Name = "ExecutorTextBox";
            this.ExecutorTextBox.Size = new System.Drawing.Size(255, 22);
            this.ExecutorTextBox.TabIndex = 13;
            this.ExecutorTextBox.TextChanged += new System.EventHandler(this.ExecutorTextBox_TextChanged);
            // 
            // DateTextBox
            // 
            this.DateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTextBox.Location = new System.Drawing.Point(164, 38);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(255, 22);
            this.DateTextBox.TabIndex = 8;
            this.DateTextBox.TextChanged += new System.EventHandler(this.DateTextBox_TextChanged);
            // 
            // VenueTextBox
            // 
            this.VenueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VenueTextBox.Location = new System.Drawing.Point(164, 12);
            this.VenueTextBox.Name = "VenueTextBox";
            this.VenueTextBox.Size = new System.Drawing.Size(255, 22);
            this.VenueTextBox.TabIndex = 7;
            this.VenueTextBox.TextChanged += new System.EventHandler(this.VenueTextBox_TextChanged);
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 175);
            this.Controls.Add(this.CostNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ExecutorTextBox);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.VenueTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditForm";
            this.Text = "AddEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.CostNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown CostNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox ExecutorTextBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.TextBox VenueTextBox;
    }
}