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
            this.PhoneListBox.FormattingEnabled = true;
            this.PhoneListBox.Location = new System.Drawing.Point(633, 221);
            this.PhoneListBox.Name = "PhoneListBox";
            this.PhoneListBox.Size = new System.Drawing.Size(247, 303);
            this.PhoneListBox.TabIndex = 0;
            this.PhoneListBox.SelectedIndexChanged += new System.EventHandler(this.PhoneListBox_SelectedIndexChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(159, 74);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(228, 21);
            this.CategoryComboBox.TabIndex = 1;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(28, 77);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(115, 13);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "Категория телефона:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(27, 142);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(36, 13);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "Цена:";
            // 
            // BatteryCapacityLabel
            // 
            this.BatteryCapacityLabel.AutoSize = true;
            this.BatteryCapacityLabel.Location = new System.Drawing.Point(28, 203);
            this.BatteryCapacityLabel.Name = "BatteryCapacityLabel";
            this.BatteryCapacityLabel.Size = new System.Drawing.Size(128, 13);
            this.BatteryCapacityLabel.TabIndex = 4;
            this.BatteryCapacityLabel.Text = "Емкость аккумулятора:";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(27, 262);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(146, 13);
            this.MemoryLabel.TabIndex = 5;
            this.MemoryLabel.Text = "Объем внутренней памяти:";
            // 
            // WeigthLabel
            // 
            this.WeigthLabel.AutoSize = true;
            this.WeigthLabel.Location = new System.Drawing.Point(28, 318);
            this.WeigthLabel.Name = "WeigthLabel";
            this.WeigthLabel.Size = new System.Drawing.Size(29, 13);
            this.WeigthLabel.TabIndex = 6;
            this.WeigthLabel.Text = "Вес:";
            // 
            // PriceTrackBar
            // 
            this.PriceTrackBar.Location = new System.Drawing.Point(102, 133);
            this.PriceTrackBar.Name = "PriceTrackBar";
            this.PriceTrackBar.Size = new System.Drawing.Size(104, 45);
            this.PriceTrackBar.TabIndex = 7;
            this.PriceTrackBar.TickFrequency = 0;
            this.PriceTrackBar.Scroll += new System.EventHandler(this.PriceTrackBar_Scroll);
            // 
            // CoolFactorLabel
            // 
            this.CoolFactorLabel.AutoSize = true;
            this.CoolFactorLabel.Location = new System.Drawing.Point(28, 370);
            this.CoolFactorLabel.Name = "CoolFactorLabel";
            this.CoolFactorLabel.Size = new System.Drawing.Size(98, 13);
            this.CoolFactorLabel.TabIndex = 8;
            this.CoolFactorLabel.Text = "Фактор крутости:";
            // 
            // BatteryCapacityTrackBar
            // 
            this.BatteryCapacityTrackBar.Location = new System.Drawing.Point(176, 194);
            this.BatteryCapacityTrackBar.Name = "BatteryCapacityTrackBar";
            this.BatteryCapacityTrackBar.Size = new System.Drawing.Size(104, 45);
            this.BatteryCapacityTrackBar.TabIndex = 9;
            this.BatteryCapacityTrackBar.TickFrequency = 0;
            this.BatteryCapacityTrackBar.Scroll += new System.EventHandler(this.BatteryCapacityTrackBar_Scroll);
            // 
            // MemoryTrackBar
            // 
            this.MemoryTrackBar.Location = new System.Drawing.Point(194, 262);
            this.MemoryTrackBar.Name = "MemoryTrackBar";
            this.MemoryTrackBar.Size = new System.Drawing.Size(104, 45);
            this.MemoryTrackBar.TabIndex = 10;
            this.MemoryTrackBar.TickFrequency = 0;
            this.MemoryTrackBar.Scroll += new System.EventHandler(this.MemoryTrackBar_Scroll);
            // 
            // WeigthTrackBar
            // 
            this.WeigthTrackBar.Location = new System.Drawing.Point(102, 313);
            this.WeigthTrackBar.Name = "WeigthTrackBar";
            this.WeigthTrackBar.Size = new System.Drawing.Size(104, 45);
            this.WeigthTrackBar.TabIndex = 11;
            this.WeigthTrackBar.TickFrequency = 0;
            this.WeigthTrackBar.Scroll += new System.EventHandler(this.WeigthTrackBar_Scroll);
            // 
            // CoolFactorTrackBar
            // 
            this.CoolFactorTrackBar.Location = new System.Drawing.Point(147, 364);
            this.CoolFactorTrackBar.Name = "CoolFactorTrackBar";
            this.CoolFactorTrackBar.Size = new System.Drawing.Size(104, 45);
            this.CoolFactorTrackBar.TabIndex = 12;
            this.CoolFactorTrackBar.TickFrequency = 0;
            this.CoolFactorTrackBar.Scroll += new System.EventHandler(this.CoolFactorTrackBar_Scroll);
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(630, 203);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(114, 13);
            this.ModelLabel.TabIndex = 13;
            this.ModelLabel.Text = "Подходяшие модели:";
            // 
            // ReleaseDateLabel
            // 
            this.ReleaseDateLabel.AutoSize = true;
            this.ReleaseDateLabel.Location = new System.Drawing.Point(28, 428);
            this.ReleaseDateLabel.Name = "ReleaseDateLabel";
            this.ReleaseDateLabel.Size = new System.Drawing.Size(76, 13);
            this.ReleaseDateLabel.TabIndex = 14;
            this.ReleaseDateLabel.Text = "Дата выхода:";
            // 
            // ReleaseDateUpDown
            // 
            this.ReleaseDateUpDown.Location = new System.Drawing.Point(121, 426);
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
            this.ReleaseDateUpDown.Size = new System.Drawing.Size(120, 20);
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
            this.CurrentPriceLabel.Location = new System.Drawing.Point(220, 142);
            this.CurrentPriceLabel.Name = "CurrentPriceLabel";
            this.CurrentPriceLabel.Size = new System.Drawing.Size(31, 13);
            this.CurrentPriceLabel.TabIndex = 17;
            this.CurrentPriceLabel.Text = "До 1";
            // 
            // CurrentBatteryLabel
            // 
            this.CurrentBatteryLabel.AutoSize = true;
            this.CurrentBatteryLabel.Location = new System.Drawing.Point(300, 203);
            this.CurrentBatteryLabel.Name = "CurrentBatteryLabel";
            this.CurrentBatteryLabel.Size = new System.Drawing.Size(29, 13);
            this.CurrentBatteryLabel.TabIndex = 18;
            this.CurrentBatteryLabel.Text = "От 1";
            // 
            // CurrentMemoryLabel
            // 
            this.CurrentMemoryLabel.AutoSize = true;
            this.CurrentMemoryLabel.Location = new System.Drawing.Point(304, 262);
            this.CurrentMemoryLabel.Name = "CurrentMemoryLabel";
            this.CurrentMemoryLabel.Size = new System.Drawing.Size(29, 13);
            this.CurrentMemoryLabel.TabIndex = 19;
            this.CurrentMemoryLabel.Text = "От 1";
            // 
            // CurrentWeigthLabel
            // 
            this.CurrentWeigthLabel.AutoSize = true;
            this.CurrentWeigthLabel.Location = new System.Drawing.Point(222, 318);
            this.CurrentWeigthLabel.Name = "CurrentWeigthLabel";
            this.CurrentWeigthLabel.Size = new System.Drawing.Size(29, 13);
            this.CurrentWeigthLabel.TabIndex = 20;
            this.CurrentWeigthLabel.Text = "От 1";
            // 
            // CurrentCoolFactorLabel
            // 
            this.CurrentCoolFactorLabel.AutoSize = true;
            this.CurrentCoolFactorLabel.Location = new System.Drawing.Point(269, 370);
            this.CurrentCoolFactorLabel.Name = "CurrentCoolFactorLabel";
            this.CurrentCoolFactorLabel.Size = new System.Drawing.Size(29, 13);
            this.CurrentCoolFactorLabel.TabIndex = 21;
            this.CurrentCoolFactorLabel.Text = "От 1";
            // 
            // IsSpecializedCheckBox
            // 
            this.IsSpecializedCheckBox.AutoSize = true;
            this.IsSpecializedCheckBox.Location = new System.Drawing.Point(121, 478);
            this.IsSpecializedCheckBox.Name = "IsSpecializedCheckBox";
            this.IsSpecializedCheckBox.Size = new System.Drawing.Size(144, 17);
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
            this.PhonePanel.Location = new System.Drawing.Point(427, 12);
            this.PhonePanel.Name = "PhonePanel";
            this.PhonePanel.Size = new System.Drawing.Size(453, 180);
            this.PhonePanel.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Дата выхода:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Характеристики выбранной модели:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Фактор крутости:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Вес:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Объем внутренней памяти:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Емкость аккумулятора:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Цена:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 536);
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
    }
}

