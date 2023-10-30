namespace CarRental.Forms.Statistic
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            applyButton = new Button();
            groupBox1 = new GroupBox();
            salesRadioButton = new RadioButton();
            quantityRadioButton = new RadioButton();
            groupBox2 = new GroupBox();
            yearRadioButton = new RadioButton();
            monthRadioButton = new RadioButton();
            yearComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            monthComboBox = new ComboBox();
            groupBox3 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // applyButton
            // 
            applyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            applyButton.Location = new Point(374, 358);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(91, 34);
            applyButton.TabIndex = 4;
            applyButton.Text = "Apply";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(salesRadioButton);
            groupBox1.Controls.Add(quantityRadioButton);
            groupBox1.Location = new Point(23, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 71);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Report";
            // 
            // salesRadioButton
            // 
            salesRadioButton.AutoSize = true;
            salesRadioButton.Location = new Point(300, 26);
            salesRadioButton.Name = "salesRadioButton";
            salesRadioButton.Size = new Size(64, 24);
            salesRadioButton.TabIndex = 1;
            salesRadioButton.Text = "Sales";
            salesRadioButton.UseVisualStyleBackColor = true;
            // 
            // quantityRadioButton
            // 
            quantityRadioButton.AutoSize = true;
            quantityRadioButton.Checked = true;
            quantityRadioButton.Location = new Point(71, 26);
            quantityRadioButton.Name = "quantityRadioButton";
            quantityRadioButton.Size = new Size(86, 24);
            quantityRadioButton.TabIndex = 0;
            quantityRadioButton.TabStop = true;
            quantityRadioButton.Text = "Quantity";
            quantityRadioButton.UseVisualStyleBackColor = true;
            quantityRadioButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(yearRadioButton);
            groupBox2.Controls.Add(monthRadioButton);
            groupBox2.Location = new Point(23, 110);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(440, 71);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "By";
            // 
            // yearRadioButton
            // 
            yearRadioButton.AutoSize = true;
            yearRadioButton.Location = new Point(300, 26);
            yearRadioButton.Name = "yearRadioButton";
            yearRadioButton.Size = new Size(58, 24);
            yearRadioButton.TabIndex = 1;
            yearRadioButton.Text = "Year";
            yearRadioButton.UseVisualStyleBackColor = true;
            yearRadioButton.CheckedChanged += yearRadioButton_CheckedChanged;
            // 
            // monthRadioButton
            // 
            monthRadioButton.AutoSize = true;
            monthRadioButton.Checked = true;
            monthRadioButton.Location = new Point(71, 26);
            monthRadioButton.Name = "monthRadioButton";
            monthRadioButton.Size = new Size(73, 24);
            monthRadioButton.TabIndex = 0;
            monthRadioButton.TabStop = true;
            monthRadioButton.Text = "Month";
            monthRadioButton.UseVisualStyleBackColor = true;
            // 
            // yearComboBox
            // 
            yearComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Location = new Point(72, 302);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(151, 28);
            yearComboBox.TabIndex = 7;
            yearComboBox.SelectedIndexChanged += yearComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(25, 306);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 8;
            label1.Text = "Year";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(256, 307);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 10;
            label2.Text = "Month";
            // 
            // monthComboBox
            // 
            monthComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            monthComboBox.FormattingEnabled = true;
            monthComboBox.Location = new Point(312, 303);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(151, 28);
            monthComboBox.TabIndex = 9;
            monthComboBox.SelectedIndexChanged += monthComboBox_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(radioButton3);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Location = new Point(25, 204);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(440, 71);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Group by";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(176, 29);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(83, 24);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "CarType";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(325, 29);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(91, 24);
            radioButton1.TabIndex = 1;
            radioButton1.Text = "CarBrand";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Location = new Point(27, 29);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(66, 24);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "None";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 415);
            Controls.Add(groupBox3);
            Controls.Add(label2);
            Controls.Add(monthComboBox);
            Controls.Add(label1);
            Controls.Add(yearComboBox);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(applyButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConfigForm";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "ConfigForm";
            Load += ConfigForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button applyButton;
        private GroupBox groupBox1;
        private RadioButton quantityRadioButton;
        private RadioButton salesRadioButton;
        private GroupBox groupBox2;
        private RadioButton yearRadioButton;
        private RadioButton monthRadioButton;
        private ComboBox yearComboBox;
        private Label label1;
        private Label label2;
        private ComboBox monthComboBox;
        private GroupBox groupBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}