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
            label4 = new Label();
            returnAtDateTimePicker = new DateTimePicker();
            label3 = new Label();
            rentAtDateTimePicker = new DateTimePicker();
            addButton = new Button();
            priceLabel = new Label();
            carEntityBindingSource = new BindingSource(components);
            label2 = new Label();
            carComboBox = new ComboBox();
            label1 = new Label();
            customerEntityBindingSource = new BindingSource(components);
            customerComboBox = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)carEntityBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerEntityBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(421, 99);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 22;
            label4.Text = "Return at";
            // 
            // returnAtDateTimePicker
            // 
            returnAtDateTimePicker.Enabled = false;
            returnAtDateTimePicker.Location = new Point(496, 96);
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
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addButton.Location = new Point(616, 378);
            addButton.Name = "addButton";
            addButton.Size = new Size(118, 35);
            addButton.TabIndex = 24;
            addButton.Text = "CheckOut";
            addButton.UseVisualStyleBackColor = true;
            // 
            // priceLabel
            // 
            priceLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(26, 225);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(374, 20);
            priceLabel.TabIndex = 25;
            priceLabel.Text = "25/10/2023 - 26/10/2023,      $24 x 2 days,      Total: $48\r\n";
            // 
            // carEntityBindingSource
            // 
            carEntityBindingSource.DataSource = typeof(Entities.CarEntity);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(424, 22);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 17;
            label2.Text = "Car";
            // 
            // carComboBox
            // 
            carComboBox.DataSource = carEntityBindingSource;
            carComboBox.DisplayMember = "NameCode";
            carComboBox.Enabled = false;
            carComboBox.FormattingEnabled = true;
            carComboBox.Location = new Point(496, 19);
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
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(26, 320);
            label8.Name = "label8";
            label8.Size = new Size(374, 20);
            label8.TabIndex = 28;
            label8.Text = "25/10/2023 - 26/10/2023,      $24 x 2 days,      Total: $48\r\n";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(26, 363);
            label9.Name = "label9";
            label9.Size = new Size(109, 31);
            label9.TabIndex = 31;
            label9.Text = "Total Fee";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(496, 182);
            label10.Name = "label10";
            label10.Size = new Size(141, 28);
            label10.TabIndex = 32;
            label10.Text = "Real Return At";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(496, 229);
            label11.Name = "label11";
            label11.Size = new Size(85, 20);
            label11.TabIndex = 33;
            label11.Text = "20/10/2020";
            // 
            // CheckoutBookingNoteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 435);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(returnAtDateTimePicker);
            Controls.Add(label3);
            Controls.Add(rentAtDateTimePicker);
            Controls.Add(addButton);
            Controls.Add(priceLabel);
            Controls.Add(label2);
            Controls.Add(carComboBox);
            Controls.Add(label1);
            Controls.Add(customerComboBox);
            Name = "CheckoutBookingNoteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CheckoutBookingNote";
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
        private Button addButton;
        private Label priceLabel;
        private BindingSource carEntityBindingSource;
        private Label label2;
        private ComboBox carComboBox;
        private Label label1;
        private BindingSource customerEntityBindingSource;
        private ComboBox customerComboBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}