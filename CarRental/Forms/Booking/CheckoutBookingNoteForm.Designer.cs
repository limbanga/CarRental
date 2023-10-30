namespace CarRental.Forms.Booking
{
    partial class CheckoutBookingNoteForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutBookingNoteForm));
            label4 = new Label();
            returnAtDateTimePicker = new DateTimePicker();
            label3 = new Label();
            rentAtDateTimePicker = new DateTimePicker();
            checkoutButton = new Button();
            bookingFeeLabel = new Label();
            carEntityBindingSource = new BindingSource(components);
            label2 = new Label();
            carComboBox = new ComboBox();
            label1 = new Label();
            customerEntityBindingSource = new BindingSource(components);
            customerComboBox = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            overDueFeeLabel = new Label();
            totalFeeLabel = new Label();
            label10 = new Label();
            realReturnAtLabel = new Label();
            label8 = new Label();
            label9 = new Label();
            lateFeeRateTextBox = new TextBox();
            indemnityTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)carEntityBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerEntityBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(477, 99);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 22;
            label4.Text = "Return at";
            // 
            // returnAtDateTimePicker
            // 
            returnAtDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            returnAtDateTimePicker.Enabled = false;
            returnAtDateTimePicker.Location = new Point(552, 96);
            returnAtDateTimePicker.Name = "returnAtDateTimePicker";
            returnAtDateTimePicker.Size = new Size(238, 27);
            returnAtDateTimePicker.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 96);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 20;
            label3.Text = "Rent at";
            // 
            // rentAtDateTimePicker
            // 
            rentAtDateTimePicker.Enabled = false;
            rentAtDateTimePicker.Location = new Point(106, 94);
            rentAtDateTimePicker.Name = "rentAtDateTimePicker";
            rentAtDateTimePicker.Size = new Size(239, 27);
            rentAtDateTimePicker.TabIndex = 19;
            // 
            // checkoutButton
            // 
            checkoutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkoutButton.Location = new Point(672, 378);
            checkoutButton.Name = "checkoutButton";
            checkoutButton.Size = new Size(118, 35);
            checkoutButton.TabIndex = 24;
            checkoutButton.Text = "Checkout";
            checkoutButton.UseVisualStyleBackColor = true;
            checkoutButton.Click += checkoutButton_Click;
            // 
            // bookingFeeLabel
            // 
            bookingFeeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bookingFeeLabel.AutoSize = true;
            bookingFeeLabel.Location = new Point(26, 225);
            bookingFeeLabel.Name = "bookingFeeLabel";
            bookingFeeLabel.Size = new Size(374, 20);
            bookingFeeLabel.TabIndex = 25;
            bookingFeeLabel.Text = "25/10/2023 - 26/10/2023,      $24 x 2 days,      Total: $48\r\n";
            // 
            // carEntityBindingSource
            // 
            carEntityBindingSource.DataSource = typeof(Entities.CarEntity);
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(480, 22);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 17;
            label2.Text = "Car";
            // 
            // carComboBox
            // 
            carComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            carComboBox.DataSource = carEntityBindingSource;
            carComboBox.DisplayMember = "NameCode";
            carComboBox.Enabled = false;
            carComboBox.FormattingEnabled = true;
            carComboBox.Location = new Point(552, 19);
            carComboBox.Name = "carComboBox";
            carComboBox.Size = new Size(238, 28);
            carComboBox.TabIndex = 16;
            carComboBox.ValueMember = "Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 25);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 15;
            label1.Text = "Customer";
            // 
            // customerEntityBindingSource
            // 
            customerEntityBindingSource.DataSource = typeof(Entities.CustomerEntity);
            // 
            // customerComboBox
            // 
            customerComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            customerComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            customerComboBox.DataSource = customerEntityBindingSource;
            customerComboBox.DisplayMember = "ComboboxDisplay";
            customerComboBox.Enabled = false;
            customerComboBox.FormattingEnabled = true;
            customerComboBox.Location = new Point(106, 23);
            customerComboBox.Name = "customerComboBox";
            customerComboBox.Size = new Size(239, 28);
            customerComboBox.TabIndex = 14;
            customerComboBox.ValueMember = "Id";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 140);
            label5.Name = "label5";
            label5.Size = new Size(50, 31);
            label5.TabIndex = 26;
            label5.Text = "Bill";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(26, 182);
            label6.Name = "label6";
            label6.Size = new Size(126, 28);
            label6.TabIndex = 27;
            label6.Text = "Booking Fee";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(26, 277);
            label7.Name = "label7";
            label7.Size = new Size(128, 28);
            label7.TabIndex = 29;
            label7.Text = "Overdue Fee";
            // 
            // overDueFeeLabel
            // 
            overDueFeeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            overDueFeeLabel.AutoSize = true;
            overDueFeeLabel.Location = new Point(26, 320);
            overDueFeeLabel.Name = "overDueFeeLabel";
            overDueFeeLabel.Size = new Size(374, 20);
            overDueFeeLabel.TabIndex = 28;
            overDueFeeLabel.Text = "25/10/2023 - 26/10/2023,      $24 x 2 days,      Total: $48\r\n";
            // 
            // totalFeeLabel
            // 
            totalFeeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            totalFeeLabel.AutoSize = true;
            totalFeeLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            totalFeeLabel.Location = new Point(26, 363);
            totalFeeLabel.Name = "totalFeeLabel";
            totalFeeLabel.Size = new Size(109, 31);
            totalFeeLabel.TabIndex = 31;
            totalFeeLabel.Text = "Total Fee";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(477, 143);
            label10.Name = "label10";
            label10.Size = new Size(168, 31);
            label10.TabIndex = 32;
            label10.Text = "Real Return At";
            // 
            // realReturnAtLabel
            // 
            realReturnAtLabel.Anchor = AnchorStyles.Right;
            realReturnAtLabel.AutoSize = true;
            realReturnAtLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            realReturnAtLabel.Location = new Point(677, 146);
            realReturnAtLabel.Name = "realReturnAtLabel";
            realReturnAtLabel.Size = new Size(113, 28);
            realReturnAtLabel.TabIndex = 33;
            realReturnAtLabel.Text = "20/10/2020";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(477, 225);
            label8.Name = "label8";
            label8.Size = new Size(146, 31);
            label8.TabIndex = 34;
            label8.Text = "Late fee rate";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(477, 309);
            label9.Name = "label9";
            label9.Size = new Size(159, 31);
            label9.TabIndex = 35;
            label9.Text = "Indemnity ($)";
            // 
            // lateFeeRateTextBox
            // 
            lateFeeRateTextBox.Anchor = AnchorStyles.Right;
            lateFeeRateTextBox.Enabled = false;
            lateFeeRateTextBox.Location = new Point(665, 230);
            lateFeeRateTextBox.Name = "lateFeeRateTextBox";
            lateFeeRateTextBox.Size = new Size(125, 27);
            lateFeeRateTextBox.TabIndex = 36;
            lateFeeRateTextBox.TextChanged += lateFeeRateTextBox_TextChanged;
            // 
            // indemnityTextBox
            // 
            indemnityTextBox.Anchor = AnchorStyles.Right;
            indemnityTextBox.Enabled = false;
            indemnityTextBox.Location = new Point(665, 313);
            indemnityTextBox.Name = "indemnityTextBox";
            indemnityTextBox.Size = new Size(125, 27);
            indemnityTextBox.TabIndex = 37;
            indemnityTextBox.TextChanged += indemnity_TextChanged;
            // 
            // CheckoutBookingNoteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 435);
            Controls.Add(indemnityTextBox);
            Controls.Add(lateFeeRateTextBox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(realReturnAtLabel);
            Controls.Add(label10);
            Controls.Add(totalFeeLabel);
            Controls.Add(label7);
            Controls.Add(overDueFeeLabel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(returnAtDateTimePicker);
            Controls.Add(label3);
            Controls.Add(rentAtDateTimePicker);
            Controls.Add(checkoutButton);
            Controls.Add(bookingFeeLabel);
            Controls.Add(label2);
            Controls.Add(carComboBox);
            Controls.Add(label1);
            Controls.Add(customerComboBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CheckoutBookingNoteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Checkout";
            Load += CheckoutBookingNoteForm_Load;
            ((System.ComponentModel.ISupportInitialize)carEntityBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerEntityBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private DateTimePicker returnAtDateTimePicker;
        private Label label3;
        private DateTimePicker rentAtDateTimePicker;
        private Button checkoutButton;
        private Label bookingFeeLabel;
        private BindingSource carEntityBindingSource;
        private Label label2;
        private ComboBox carComboBox;
        private Label label1;
        private BindingSource customerEntityBindingSource;
        private ComboBox customerComboBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label overDueFeeLabel;
        private Label totalFeeLabel;
        private Label label10;
        private Label realReturnAtLabel;
        private Label label8;
        private Label label9;
        private TextBox lateFeeRateTextBox;
        private TextBox indemnityTextBox;
    }
}