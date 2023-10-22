namespace CarRental.Forms.Booking
{
    partial class Add_UpdateBookingForm
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
            customerComboBox = new ComboBox();
            customerEntityBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            carComboBox = new ComboBox();
            groupBox1 = new GroupBox();
            checkBox12 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            rentAtDateTimePicker = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            returnAtDateTimePicker = new DateTimePicker();
            groupBox2 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)customerEntityBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // customerComboBox
            // 
            customerComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            customerComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            customerComboBox.DataSource = customerEntityBindingSource;
            customerComboBox.DisplayMember = "ComboboxDisplay";
            customerComboBox.FormattingEnabled = true;
            customerComboBox.Location = new Point(103, 45);
            customerComboBox.Name = "customerComboBox";
            customerComboBox.Size = new Size(239, 28);
            customerComboBox.TabIndex = 0;
            customerComboBox.ValueMember = "Id";
            // 
            // customerEntityBindingSource
            // 
            customerEntityBindingSource.DataSource = typeof(Entities.CustomerEntity);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 47);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 44);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 3;
            label2.Text = "Car";
            // 
            // carComboBox
            // 
            carComboBox.FormattingEnabled = true;
            carComboBox.Location = new Point(493, 41);
            carComboBox.Name = "carComboBox";
            carComboBox.Size = new Size(238, 28);
            carComboBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(checkBox12);
            groupBox1.Controls.Add(checkBox11);
            groupBox1.Controls.Add(checkBox10);
            groupBox1.Controls.Add(checkBox9);
            groupBox1.Controls.Add(checkBox8);
            groupBox1.Controls.Add(checkBox7);
            groupBox1.Controls.Add(checkBox6);
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(23, 176);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(708, 176);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Feature";
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Location = new Point(453, 35);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(61, 24);
            checkBox12.TabIndex = 11;
            checkBox12.Text = "map";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(453, 79);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(61, 24);
            checkBox11.TabIndex = 10;
            checkBox11.Text = "map";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(313, 79);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(61, 24);
            checkBox10.TabIndex = 9;
            checkBox10.Text = "map";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(313, 35);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(61, 24);
            checkBox9.TabIndex = 8;
            checkBox9.Text = "map";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(453, 120);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(61, 24);
            checkBox8.TabIndex = 7;
            checkBox8.Text = "map";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(159, 120);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(61, 24);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "map";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(159, 79);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(61, 24);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "map";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(159, 35);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(61, 24);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "map";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(314, 120);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(61, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "map";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(15, 120);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(61, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "map";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(15, 79);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(61, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "map";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(15, 35);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(61, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "map";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // rentAtDateTimePicker
            // 
            rentAtDateTimePicker.Location = new Point(103, 116);
            rentAtDateTimePicker.Name = "rentAtDateTimePicker";
            rentAtDateTimePicker.Size = new Size(239, 27);
            rentAtDateTimePicker.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 118);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 6;
            label3.Text = "Rent at";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(418, 121);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 8;
            label4.Text = "Return at";
            label4.Click += label4_Click;
            // 
            // returnAtDateTimePicker
            // 
            returnAtDateTimePicker.Location = new Point(493, 118);
            returnAtDateTimePicker.Name = "returnAtDateTimePicker";
            returnAtDateTimePicker.Size = new Size(238, 27);
            returnAtDateTimePicker.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(23, 358);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(708, 66);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fuel";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(453, 26);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(117, 24);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(309, 26);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(117, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(159, 26);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(15, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(637, 444);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(513, 450);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 12;
            label5.Text = "Total: $3464";
            // 
            // Add_UpdateBookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 501);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(returnAtDateTimePicker);
            Controls.Add(label3);
            Controls.Add(rentAtDateTimePicker);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(carComboBox);
            Controls.Add(label1);
            Controls.Add(customerComboBox);
            Name = "Add_UpdateBookingForm";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add booking";
            Load += Add_UpdateBookingForm_Load;
            ((System.ComponentModel.ISupportInitialize)customerEntityBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox customerComboBox;
        private Label label1;
        private Label label2;
        private ComboBox carComboBox;
        private GroupBox groupBox1;
        private DateTimePicker rentAtDateTimePicker;
        private Label label3;
        private Label label4;
        private DateTimePicker returnAtDateTimePicker;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox10;
        private CheckBox checkBox9;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private GroupBox groupBox2;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private CheckBox checkBox12;
        private CheckBox checkBox11;
        private Label label5;
        private BindingSource customerEntityBindingSource;
    }
}