namespace WindowsFormsApplication4
{
    partial class Form1
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
            this.PhoneListBox = new System.Windows.Forms.ListBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.BatteryCapacityLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.WeigthLabel = new System.Windows.Forms.Label();
            this.PriceTrackBar = new System.Windows.Forms.TrackBar();
            this.CoolFactorLabel = new System.Windows.Forms.Label();
            this.BatteryCapacityTrackBar = new System.Windows.Forms.TrackBar();
            this.MemoryTrackBar = new System.Windows.Forms.TrackBar();
            this.WeigthTrackBar = new System.Windows.Forms.TrackBar();
            this.CoolFactorTrackBar = new System.Windows.Forms.TrackBar();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ReleaseDateLabel = new System.Windows.Forms.Label();
            this.ReleaseDateUpDown = new System.Windows.Forms.NumericUpDown();
            this.CurrentPriceLabel = new System.Windows.Forms.Label();
            this.CurrentBatteryLabel = new System.Windows.Forms.Label();
            this.CurrentMemoryLabel = new System.Windows.Forms.Label();
            this.CurrentWeigthLabel = new System.Windows.Forms.Label();
            this.CurrentCoolFactorLabel = new System.Windows.Forms.Label();
            this.IsSpecializedCheckBox = new System.Windows.Forms.CheckBox();
            this.PhonePanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PriceTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatteryCapacityTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoryTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeigthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoolFactorTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReleaseDateUpDown)).BeginInit();
            this.PhonePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PhoneListBox
            // 
            this.PhoneListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneListBox.FormattingEnabled = true;
            this.PhoneListBox.ItemHeight = 16;
            this.PhoneListBox.Location = new System.Drawing.Point(698, 302);
            this.PhoneListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhoneListBox.Name = "PhoneListBox";
            this.PhoneListBox.Size = new System.Drawing.Size(328, 340);
            this.PhoneListBox.TabIndex = 0;
            this.PhoneListBox.SelectedIndexChanged += new System.EventHandler(this.PhoneListBox_SelectedIndexChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(212, 91);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(303, 24);
            this.CategoryComboBox.TabIndex = 1;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.Location = new System.Drawing.Point(37, 95);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(148, 16);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "Категория телефона:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(36, 175);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(44, 16);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "Цена:";
            // 
            // BatteryCapacityLabel
            // 
            this.BatteryCapacityLabel.AutoSize = true;
            this.BatteryCapacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BatteryCapacityLabel.Location = new System.Drawing.Point(37, 250);
            this.BatteryCapacityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BatteryCapacityLabel.Name = "BatteryCapacityLabel";
            this.BatteryCapacityLabel.Size = new System.Drawing.Size(163, 16);
            this.BatteryCapacityLabel.TabIndex = 4;
            this.BatteryCapacityLabel.Text = "Емкость аккумулятора:";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemoryLabel.Location = new System.Drawing.Point(36, 322);
            this.MemoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(187, 16);
            this.MemoryLabel.TabIndex = 5;
            this.MemoryLabel.Text = "Объем внутренней памяти:";
            // 
            // WeigthLabel
            // 
            this.WeigthLabel.AutoSize = true;
            this.WeigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeigthLabel.Location = new System.Drawing.Point(37, 391);
            this.WeigthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WeigthLabel.Name = "WeigthLabel";
            this.WeigthLabel.Size = new System.Drawing.Size(35, 16);
            this.WeigthLabel.TabIndex = 6;
            this.WeigthLabel.Text = "Вес:";
            // 
            // PriceTrackBar
            // 
            this.PriceTrackBar.Location = new System.Drawing.Point(236, 164);
            this.PriceTrackBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PriceTrackBar.Name = "PriceTrackBar";
            this.PriceTrackBar.Size = new System.Drawing.Size(139, 45);
            this.PriceTrackBar.TabIndex = 7;
            this.PriceTrackBar.TickFrequency = 0;
            this.PriceTrackBar.Scroll += new System.EventHandler(this.PriceTrackBar_Scroll);
            // 
            // CoolFactorLabel
            // 
            this.CoolFactorLabel.AutoSize = true;
            this.CoolFactorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoolFactorLabel.Location = new System.Drawing.Point(37, 455);
            this.CoolFactorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CoolFactorLabel.Name = "CoolFactorLabel";
            this.CoolFactorLabel.Size = new System.Drawing.Size(123, 16);
            this.CoolFactorLabel.TabIndex = 8;
            this.CoolFactorLabel.Text = "Фактор крутости:";
            // 
            // BatteryCapacityTrackBar
            // 
            this.BatteryCapacityTrackBar.Location = new System.Drawing.Point(236, 239);
            this.BatteryCapacityTrackBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BatteryCapacityTrackBar.Name = "BatteryCapacityTrackBar";
            this.BatteryCapacityTrackBar.Size = new System.Drawing.Size(139, 45);
            this.BatteryCapacityTrackBar.TabIndex = 9;
            this.BatteryCapacityTrackBar.TickFrequency = 0;
            this.BatteryCapacityTrackBar.Scroll += new System.EventHandler(this.BatteryCapacityTrackBar_Scroll);
            // 
            // MemoryTrackBar
            // 
            this.MemoryTrackBar.Location = new System.Drawing.Point(239, 322);
            this.MemoryTrackBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MemoryTrackBar.Name = "MemoryTrackBar";
            this.MemoryTrackBar.Size = new System.Drawing.Size(139, 45);
            this.MemoryTrackBar.TabIndex = 10;
            this.MemoryTrackBar.TickFrequency = 0;
            this.MemoryTrackBar.Scroll += new System.EventHandler(this.MemoryTrackBar_Scroll);
            // 
            // WeigthTrackBar
            // 
            this.WeigthTrackBar.Location = new System.Drawing.Point(239, 385);
            this.WeigthTrackBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WeigthTrackBar.Name = "WeigthTrackBar";
            this.WeigthTrackBar.Size = new System.Drawing.Size(139, 45);
            this.WeigthTrackBar.TabIndex = 11;
            this.WeigthTrackBar.TickFrequency = 0;
            this.WeigthTrackBar.Scroll += new System.EventHandler(this.WeigthTrackBar_Scroll);
            // 
            // CoolFactorTrackBar
            // 
            this.CoolFactorTrackBar.Location = new System.Drawing.Point(239, 448);
            this.CoolFactorTrackBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CoolFactorTrackBar.Name = "CoolFactorTrackBar";
            this.CoolFactorTrackBar.Size = new System.Drawing.Size(139, 45);
            this.CoolFactorTrackBar.TabIndex = 12;
            this.CoolFactorTrackBar.TickFrequency = 0;
            this.CoolFactorTrackBar.Scroll += new System.EventHandler(this.CoolFactorTrackBar_Scroll);
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelLabel.Location = new System.Drawing.Point(695, 282);
            this.ModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(161, 16);
            this.ModelLabel.TabIndex = 13;
            this.ModelLabel.Text = "Подходяшие модели:";
            // 
            // ReleaseDateLabel
            // 
            this.ReleaseDateLabel.AutoSize = true;
            this.ReleaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReleaseDateLabel.Location = new System.Drawing.Point(37, 527);
            this.ReleaseDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReleaseDateLabel.Name = "ReleaseDateLabel";
            this.ReleaseDateLabel.Size = new System.Drawing.Size(93, 16);
            this.ReleaseDateLabel.TabIndex = 14;
            this.ReleaseDateLabel.Text = "Дата выхода:";
            // 
            // ReleaseDateUpDown
            // 
            this.ReleaseDateUpDown.Location = new System.Drawing.Point(235, 518);
            this.ReleaseDateUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReleaseDateUpDown.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.ReleaseDateUpDown.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.ReleaseDateUpDown.Name = "ReleaseDateUpDown";
            this.ReleaseDateUpDown.Size = new System.Drawing.Size(160, 22);
            this.ReleaseDateUpDown.TabIndex = 16;
            this.ReleaseDateUpDown.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.ReleaseDateUpDown.ValueChanged += new System.EventHandler(this.ReleaseDateUpDown_ValueChanged);
            // 
            // CurrentPriceLabel
            // 
            this.CurrentPriceLabel.AutoSize = true;
            this.CurrentPriceLabel.Location = new System.Drawing.Point(393, 175);
            this.CurrentPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentPriceLabel.Name = "CurrentPriceLabel";
            this.CurrentPriceLabel.Size = new System.Drawing.Size(35, 16);
            this.CurrentPriceLabel.TabIndex = 17;
            this.CurrentPriceLabel.Text = "До 1";
            // 
            // CurrentBatteryLabel
            // 
            this.CurrentBatteryLabel.AutoSize = true;
            this.CurrentBatteryLabel.Location = new System.Drawing.Point(400, 250);
            this.CurrentBatteryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentBatteryLabel.Name = "CurrentBatteryLabel";
            this.CurrentBatteryLabel.Size = new System.Drawing.Size(35, 16);
            this.CurrentBatteryLabel.TabIndex = 18;
            this.CurrentBatteryLabel.Text = "От 1";
            // 
            // CurrentMemoryLabel
            // 
            this.CurrentMemoryLabel.AutoSize = true;
            this.CurrentMemoryLabel.Location = new System.Drawing.Point(400, 322);
            this.CurrentMemoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentMemoryLabel.Name = "CurrentMemoryLabel";
            this.CurrentMemoryLabel.Size = new System.Drawing.Size(35, 16);
            this.CurrentMemoryLabel.TabIndex = 19;
            this.CurrentMemoryLabel.Text = "От 1";
            // 
            // CurrentWeigthLabel
            // 
            this.CurrentWeigthLabel.AutoSize = true;
            this.CurrentWeigthLabel.Location = new System.Drawing.Point(399, 391);
            this.CurrentWeigthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentWeigthLabel.Name = "CurrentWeigthLabel";
            this.CurrentWeigthLabel.Size = new System.Drawing.Size(35, 16);
            this.CurrentWeigthLabel.TabIndex = 20;
            this.CurrentWeigthLabel.Text = "От 1";
            // 
            // CurrentCoolFactorLabel
            // 
            this.CurrentCoolFactorLabel.AutoSize = true;
            this.CurrentCoolFactorLabel.Location = new System.Drawing.Point(401, 455);
            this.CurrentCoolFactorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentCoolFactorLabel.Name = "CurrentCoolFactorLabel";
            this.CurrentCoolFactorLabel.Size = new System.Drawing.Size(35, 16);
            this.CurrentCoolFactorLabel.TabIndex = 21;
            this.CurrentCoolFactorLabel.Text = "От 1";
            // 
            // IsSpecializedCheckBox
            // 
            this.IsSpecializedCheckBox.AutoSize = true;
            this.IsSpecializedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsSpecializedCheckBox.Location = new System.Drawing.Point(161, 588);
            this.IsSpecializedCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IsSpecializedCheckBox.Name = "IsSpecializedCheckBox";
            this.IsSpecializedCheckBox.Size = new System.Drawing.Size(180, 20);
            this.IsSpecializedCheckBox.TabIndex = 22;
            this.IsSpecializedCheckBox.Text = "Специальный телефон:";
            this.IsSpecializedCheckBox.UseVisualStyleBackColor = true;
            this.IsSpecializedCheckBox.CheckStateChanged += new System.EventHandler(this.IsSpecializedCheckBox_CheckStateChanged);
            // 
            // PhonePanel
            // 
            this.PhonePanel.Controls.Add(this.label7);
            this.PhonePanel.Controls.Add(this.label1);
            this.PhonePanel.Controls.Add(this.label6);
            this.PhonePanel.Controls.Add(this.label5);
            this.PhonePanel.Controls.Add(this.label4);
            this.PhonePanel.Controls.Add(this.label3);
            this.PhonePanel.Controls.Add(this.label2);
            this.PhonePanel.Location = new System.Drawing.Point(697, 13);
            this.PhonePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhonePanel.Name = "PhonePanel";
            this.PhonePanel.Size = new System.Drawing.Size(395, 222);
            this.PhonePanel.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(4, 198);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Дата выхода:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Характеристики выбранной модели:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(4, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Фактор крутости:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Вес:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(4, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Объем внутренней памяти:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Емкость аккумулятора:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Цена:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(229, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "Подбор сотового телефона";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 660);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PhonePanel);
            this.Controls.Add(this.IsSpecializedCheckBox);
            this.Controls.Add(this.CurrentCoolFactorLabel);
            this.Controls.Add(this.CurrentWeigthLabel);
            this.Controls.Add(this.CurrentMemoryLabel);
            this.Controls.Add(this.CurrentBatteryLabel);
            this.Controls.Add(this.CurrentPriceLabel);
            this.Controls.Add(this.ReleaseDateUpDown);
            this.Controls.Add(this.ReleaseDateLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.CoolFactorTrackBar);
            this.Controls.Add(this.WeigthTrackBar);
            this.Controls.Add(this.MemoryTrackBar);
            this.Controls.Add(this.BatteryCapacityTrackBar);
            this.Controls.Add(this.CoolFactorLabel);
            this.Controls.Add(this.PriceTrackBar);
            this.Controls.Add(this.WeigthLabel);
            this.Controls.Add(this.MemoryLabel);
            this.Controls.Add(this.BatteryCapacityLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.PhoneListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PriceTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatteryCapacityTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoryTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeigthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoolFactorTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReleaseDateUpDown)).EndInit();
            this.PhonePanel.ResumeLayout(false);
            this.PhonePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PhoneListBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label BatteryCapacityLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label WeigthLabel;
        private System.Windows.Forms.TrackBar PriceTrackBar;
        private System.Windows.Forms.Label CoolFactorLabel;
        private System.Windows.Forms.TrackBar BatteryCapacityTrackBar;
        private System.Windows.Forms.TrackBar MemoryTrackBar;
        private System.Windows.Forms.TrackBar WeigthTrackBar;
        private System.Windows.Forms.TrackBar CoolFactorTrackBar;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ReleaseDateLabel;
        private System.Windows.Forms.NumericUpDown ReleaseDateUpDown;
        private System.Windows.Forms.Label CurrentPriceLabel;
        private System.Windows.Forms.Label CurrentBatteryLabel;
        private System.Windows.Forms.Label CurrentMemoryLabel;
        private System.Windows.Forms.Label CurrentWeigthLabel;
        private System.Windows.Forms.Label CurrentCoolFactorLabel;
        private System.Windows.Forms.CheckBox IsSpecializedCheckBox;
        private System.Windows.Forms.Panel PhonePanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}

