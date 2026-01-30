namespace LR_3_Variant5
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
            this.GroupDishListBox = new System.Windows.Forms.ListBox();
            this.DishMenuComboBox = new System.Windows.Forms.ComboBox();
            this.PhotoOfDishPictureBox = new System.Windows.Forms.PictureBox();
            this.ExplanationLabel = new System.Windows.Forms.Label();
            this.QuantityOfOrderTextBox = new System.Windows.Forms.TextBox();
            this.OrderButton = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.PriceInfoLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.DescriptionInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoOfDishPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupDishListBox
            // 
            this.GroupDishListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupDishListBox.FormattingEnabled = true;
            this.GroupDishListBox.Location = new System.Drawing.Point(0, 0);
            this.GroupDishListBox.Name = "GroupDishListBox";
            this.GroupDishListBox.Size = new System.Drawing.Size(98, 450);
            this.GroupDishListBox.TabIndex = 0;
            this.GroupDishListBox.SelectedIndexChanged += new System.EventHandler(this.GroupDishListBox_SelectedIndexChanged);
            // 
            // DishMenuComboBox
            // 
            this.DishMenuComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.DishMenuComboBox.FormattingEnabled = true;
            this.DishMenuComboBox.Location = new System.Drawing.Point(98, 0);
            this.DishMenuComboBox.Name = "DishMenuComboBox";
            this.DishMenuComboBox.Size = new System.Drawing.Size(121, 21);
            this.DishMenuComboBox.TabIndex = 1;
            this.DishMenuComboBox.SelectedIndexChanged += new System.EventHandler(this.DishMenuComboBox_SelectedIndexChanged);
            // 
            // PhotoOfDishPictureBox
            // 
            this.PhotoOfDishPictureBox.Location = new System.Drawing.Point(272, 0);
            this.PhotoOfDishPictureBox.Name = "PhotoOfDishPictureBox";
            this.PhotoOfDishPictureBox.Size = new System.Drawing.Size(528, 334);
            this.PhotoOfDishPictureBox.TabIndex = 2;
            this.PhotoOfDishPictureBox.TabStop = false;
            // 
            // ExplanationLabel
            // 
            this.ExplanationLabel.AutoSize = true;
            this.ExplanationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExplanationLabel.Location = new System.Drawing.Point(113, 314);
            this.ExplanationLabel.Name = "ExplanationLabel";
            this.ExplanationLabel.Size = new System.Drawing.Size(148, 20);
            this.ExplanationLabel.TabIndex = 3;
            this.ExplanationLabel.Text = "Количество Блюд";
            // 
            // QuantityOfOrderTextBox
            // 
            this.QuantityOfOrderTextBox.Location = new System.Drawing.Point(136, 349);
            this.QuantityOfOrderTextBox.Name = "QuantityOfOrderTextBox";
            this.QuantityOfOrderTextBox.Size = new System.Drawing.Size(100, 20);
            this.QuantityOfOrderTextBox.TabIndex = 4;
            // 
            // OrderButton
            // 
            this.OrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderButton.Location = new System.Drawing.Point(136, 384);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(101, 43);
            this.OrderButton.TabIndex = 5;
            this.OrderButton.Text = "Заказать";
            this.OrderButton.UseVisualStyleBackColor = true;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionLabel.Location = new System.Drawing.Point(333, 384);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(83, 20);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Описание";
            // 
            // PriceInfoLabel
            // 
            this.PriceInfoLabel.AutoSize = true;
            this.PriceInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceInfoLabel.Location = new System.Drawing.Point(132, 244);
            this.PriceInfoLabel.Name = "PriceInfoLabel";
            this.PriceInfoLabel.Size = new System.Drawing.Size(87, 20);
            this.PriceInfoLabel.TabIndex = 3;
            this.PriceInfoLabel.Text = "Цена (руб)";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(162, 277);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(48, 20);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "Цена";
            // 
            // DescriptionInfoLabel
            // 
            this.DescriptionInfoLabel.AutoSize = true;
            this.DescriptionInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionInfoLabel.Location = new System.Drawing.Point(469, 349);
            this.DescriptionInfoLabel.Name = "DescriptionInfoLabel";
            this.DescriptionInfoLabel.Size = new System.Drawing.Size(83, 20);
            this.DescriptionInfoLabel.TabIndex = 3;
            this.DescriptionInfoLabel.Text = "Описание";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.QuantityOfOrderTextBox);
            this.Controls.Add(this.DescriptionInfoLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.PriceInfoLabel);
            this.Controls.Add(this.ExplanationLabel);
            this.Controls.Add(this.PhotoOfDishPictureBox);
            this.Controls.Add(this.DishMenuComboBox);
            this.Controls.Add(this.GroupDishListBox);
            this.Name = "MainForm";
            this.Text = "Меню ресторана";
            ((System.ComponentModel.ISupportInitialize)(this.PhotoOfDishPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox GroupDishListBox;
        private System.Windows.Forms.ComboBox DishMenuComboBox;
        private System.Windows.Forms.PictureBox PhotoOfDishPictureBox;
        private System.Windows.Forms.Label ExplanationLabel;
        private System.Windows.Forms.TextBox QuantityOfOrderTextBox;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label PriceInfoLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label DescriptionInfoLabel;
    }
}

