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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_UpdateBookingForm));
            customerComboBox = new ComboBox();
            customerEntityBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            carComboBox = new ComboBox();
            carEntityBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            SpeedWarningKitCheckBox = new CheckBox();
            reversingCameraCheckBox = new CheckBox();
            gPSCheckBox = new CheckBox();
            spareTireCheckBox = new CheckBox();
            dashCamCheckBox = new CheckBox();
            blueToothCheckBox = new CheckBox();
            camera360CheckBox = new CheckBox();
            pickupTruckTrunkCoverCheckBox = new CheckBox();
            uSBCheckBox = new CheckBox();
            sunroofCheckBox = new CheckBox();
            collisionSensorCheckBox = new CheckBox();
            tireSensorCheckBox = new CheckBox();
            marginalCameraCheckBox = new CheckBox();
            mapCheckBox = new CheckBox();
            rentAtDateTimePicker = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            returnAtDateTimePicker = new DateTimePicker();
            FuelGroupBox = new GroupBox();
            electricityRadioButton = new RadioButton();
            dieselRadioButton = new RadioButton();
            gasolineRadioButton = new RadioButton();
            allRadioButton = new RadioButton();
            addButton = new Button();
            priceLabel = new Label();
            clearFillterButton = new Button();
            label5 = new Label();
            label6 = new Label();
            departureRichTextBox = new RichTextBox();
            DestinationRichTextBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)customerEntityBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carEntityBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            FuelGroupBox.SuspendLayout();
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
            carComboBox.DataSource = carEntityBindingSource;
            carComboBox.DisplayMember = "NameCode";
            carComboBox.FormattingEnabled = true;
            carComboBox.Location = new Point(493, 41);
            carComboBox.Name = "carComboBox";
            carComboBox.Size = new Size(238, 28);
            carComboBox.TabIndex = 2;
            carComboBox.ValueMember = "Id";
            carComboBox.SelectedIndexChanged += carComboBox_SelectedIndexChanged;
            // 
            // carEntityBindingSource
            // 
            carEntityBindingSource.DataSource = typeof(Entities.CarEntity);
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(SpeedWarningKitCheckBox);
            groupBox1.Controls.Add(reversingCameraCheckBox);
            groupBox1.Controls.Add(gPSCheckBox);
            groupBox1.Controls.Add(spareTireCheckBox);
            groupBox1.Controls.Add(dashCamCheckBox);
            groupBox1.Controls.Add(blueToothCheckBox);
            groupBox1.Controls.Add(camera360CheckBox);
            groupBox1.Controls.Add(pickupTruckTrunkCoverCheckBox);
            groupBox1.Controls.Add(uSBCheckBox);
            groupBox1.Controls.Add(sunroofCheckBox);
            groupBox1.Controls.Add(collisionSensorCheckBox);
            groupBox1.Controls.Add(tireSensorCheckBox);
            groupBox1.Controls.Add(marginalCameraCheckBox);
            groupBox1.Controls.Add(mapCheckBox);
            groupBox1.Location = new Point(23, 192);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(708, 211);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Feature";
            // 
            // SpeedWarningKitCheckBox
            // 
            SpeedWarningKitCheckBox.AutoSize = true;
            SpeedWarningKitCheckBox.Location = new Point(193, 166);
            SpeedWarningKitCheckBox.Name = "SpeedWarningKitCheckBox";
            SpeedWarningKitCheckBox.Size = new Size(154, 24);
            SpeedWarningKitCheckBox.TabIndex = 14;
            SpeedWarningKitCheckBox.Text = "Speed Warning Kit";
            SpeedWarningKitCheckBox.UseVisualStyleBackColor = true;
            SpeedWarningKitCheckBox.CheckedChanged += SpeedWarningKitCheckBox_CheckedChanged;
            // 
            // reversingCameraCheckBox
            // 
            reversingCameraCheckBox.AutoSize = true;
            reversingCameraCheckBox.Location = new Point(15, 166);
            reversingCameraCheckBox.Name = "reversingCameraCheckBox";
            reversingCameraCheckBox.Size = new Size(148, 24);
            reversingCameraCheckBox.TabIndex = 12;
            reversingCameraCheckBox.Text = "Reversing camera";
            reversingCameraCheckBox.UseVisualStyleBackColor = true;
            reversingCameraCheckBox.CheckedChanged += reversingCameraCheckBox_CheckedChanged;
            // 
            // gPSCheckBox
            // 
            gPSCheckBox.AutoSize = true;
            gPSCheckBox.Location = new Point(568, 35);
            gPSCheckBox.Name = "gPSCheckBox";
            gPSCheckBox.Size = new Size(57, 24);
            gPSCheckBox.TabIndex = 11;
            gPSCheckBox.Text = "GPS";
            gPSCheckBox.UseVisualStyleBackColor = true;
            gPSCheckBox.CheckedChanged += gPSCheckBox_CheckedChanged;
            // 
            // spareTireCheckBox
            // 
            spareTireCheckBox.AutoSize = true;
            spareTireCheckBox.Location = new Point(568, 79);
            spareTireCheckBox.Name = "spareTireCheckBox";
            spareTireCheckBox.Size = new Size(101, 24);
            spareTireCheckBox.TabIndex = 10;
            spareTireCheckBox.Text = "Spare tires";
            spareTireCheckBox.UseVisualStyleBackColor = true;
            spareTireCheckBox.CheckedChanged += spareTireCheckBox_CheckedChanged;
            // 
            // dashCamCheckBox
            // 
            dashCamCheckBox.AutoSize = true;
            dashCamCheckBox.Location = new Point(395, 79);
            dashCamCheckBox.Name = "dashCamCheckBox";
            dashCamCheckBox.Size = new Size(92, 24);
            dashCamCheckBox.TabIndex = 9;
            dashCamCheckBox.Text = "Dashcam";
            dashCamCheckBox.UseVisualStyleBackColor = true;
            dashCamCheckBox.CheckedChanged += dashCamCheckBox_CheckedChanged;
            // 
            // blueToothCheckBox
            // 
            blueToothCheckBox.AutoSize = true;
            blueToothCheckBox.Location = new Point(395, 35);
            blueToothCheckBox.Name = "blueToothCheckBox";
            blueToothCheckBox.Size = new Size(96, 24);
            blueToothCheckBox.TabIndex = 8;
            blueToothCheckBox.Text = "Bluetooth";
            blueToothCheckBox.UseVisualStyleBackColor = true;
            blueToothCheckBox.CheckedChanged += blueToothCheckBox_CheckedChanged;
            // 
            // camera360CheckBox
            // 
            camera360CheckBox.AutoSize = true;
            camera360CheckBox.Location = new Point(568, 120);
            camera360CheckBox.Name = "camera360CheckBox";
            camera360CheckBox.Size = new Size(110, 24);
            camera360CheckBox.TabIndex = 7;
            camera360CheckBox.Text = "Camera 360";
            camera360CheckBox.UseVisualStyleBackColor = true;
            camera360CheckBox.CheckedChanged += camera360CheckBox_CheckedChanged;
            // 
            // pickupTruckTrunkCoverCheckBox
            // 
            pickupTruckTrunkCoverCheckBox.AutoSize = true;
            pickupTruckTrunkCoverCheckBox.Location = new Point(193, 120);
            pickupTruckTrunkCoverCheckBox.Name = "pickupTruckTrunkCoverCheckBox";
            pickupTruckTrunkCoverCheckBox.Size = new Size(187, 24);
            pickupTruckTrunkCoverCheckBox.TabIndex = 6;
            pickupTruckTrunkCoverCheckBox.Text = "Pickup truck trunk cover";
            pickupTruckTrunkCoverCheckBox.UseVisualStyleBackColor = true;
            pickupTruckTrunkCoverCheckBox.CheckedChanged += pickupTruckTrunkCoverCheckBox_CheckedChanged;
            // 
            // uSBCheckBox
            // 
            uSBCheckBox.AutoSize = true;
            uSBCheckBox.Location = new Point(193, 79);
            uSBCheckBox.Name = "uSBCheckBox";
            uSBCheckBox.Size = new Size(58, 24);
            uSBCheckBox.TabIndex = 5;
            uSBCheckBox.Text = "USB";
            uSBCheckBox.UseVisualStyleBackColor = true;
            uSBCheckBox.CheckedChanged += uSBCheckBox_CheckedChanged;
            // 
            // sunroofCheckBox
            // 
            sunroofCheckBox.AutoSize = true;
            sunroofCheckBox.Location = new Point(193, 35);
            sunroofCheckBox.Name = "sunroofCheckBox";
            sunroofCheckBox.Size = new Size(83, 24);
            sunroofCheckBox.TabIndex = 4;
            sunroofCheckBox.Text = "Sunroof";
            sunroofCheckBox.UseVisualStyleBackColor = true;
            sunroofCheckBox.CheckedChanged += sunroofCheckBox_CheckedChanged;
            // 
            // collisionSensorCheckBox
            // 
            collisionSensorCheckBox.AutoSize = true;
            collisionSensorCheckBox.Location = new Point(395, 120);
            collisionSensorCheckBox.Name = "collisionSensorCheckBox";
            collisionSensorCheckBox.Size = new Size(134, 24);
            collisionSensorCheckBox.TabIndex = 3;
            collisionSensorCheckBox.Text = "Collision sensor";
            collisionSensorCheckBox.UseVisualStyleBackColor = true;
            collisionSensorCheckBox.CheckedChanged += collisionSensorCheckBox_CheckedChanged;
            // 
            // tireSensorCheckBox
            // 
            tireSensorCheckBox.AutoSize = true;
            tireSensorCheckBox.Location = new Point(15, 120);
            tireSensorCheckBox.Name = "tireSensorCheckBox";
            tireSensorCheckBox.Size = new Size(102, 24);
            tireSensorCheckBox.TabIndex = 2;
            tireSensorCheckBox.Text = "Tire sensor";
            tireSensorCheckBox.UseVisualStyleBackColor = true;
            tireSensorCheckBox.CheckedChanged += tireSensorCheckBox_CheckedChanged;
            // 
            // marginalCameraCheckBox
            // 
            marginalCameraCheckBox.AutoSize = true;
            marginalCameraCheckBox.Location = new Point(15, 79);
            marginalCameraCheckBox.Name = "marginalCameraCheckBox";
            marginalCameraCheckBox.Size = new Size(143, 24);
            marginalCameraCheckBox.TabIndex = 1;
            marginalCameraCheckBox.Text = "Marginal camera";
            marginalCameraCheckBox.UseVisualStyleBackColor = true;
            marginalCameraCheckBox.CheckedChanged += marginalCameraCheckBox_CheckedChanged;
            // 
            // mapCheckBox
            // 
            mapCheckBox.AutoSize = true;
            mapCheckBox.Location = new Point(15, 35);
            mapCheckBox.Name = "mapCheckBox";
            mapCheckBox.Size = new Size(61, 24);
            mapCheckBox.TabIndex = 0;
            mapCheckBox.Text = "Map";
            mapCheckBox.UseVisualStyleBackColor = true;
            mapCheckBox.CheckedChanged += mapCheckBox_CheckedChanged;
            // 
            // rentAtDateTimePicker
            // 
            rentAtDateTimePicker.Location = new Point(103, 116);
            rentAtDateTimePicker.Name = "rentAtDateTimePicker";
            rentAtDateTimePicker.Size = new Size(239, 27);
            rentAtDateTimePicker.TabIndex = 5;
            rentAtDateTimePicker.ValueChanged += rentAtDateTimePicker_ValueChanged;
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
            // 
            // returnAtDateTimePicker
            // 
            returnAtDateTimePicker.Location = new Point(493, 118);
            returnAtDateTimePicker.Name = "returnAtDateTimePicker";
            returnAtDateTimePicker.Size = new Size(238, 27);
            returnAtDateTimePicker.TabIndex = 7;
            returnAtDateTimePicker.ValueChanged += returnAtDateTimePicker_ValueChanged;
            // 
            // FuelGroupBox
            // 
            FuelGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FuelGroupBox.Controls.Add(electricityRadioButton);
            FuelGroupBox.Controls.Add(dieselRadioButton);
            FuelGroupBox.Controls.Add(gasolineRadioButton);
            FuelGroupBox.Controls.Add(allRadioButton);
            FuelGroupBox.Location = new Point(23, 420);
            FuelGroupBox.Name = "FuelGroupBox";
            FuelGroupBox.Size = new Size(708, 66);
            FuelGroupBox.TabIndex = 9;
            FuelGroupBox.TabStop = false;
            FuelGroupBox.Text = "Fuel";
            // 
            // electricityRadioButton
            // 
            electricityRadioButton.AutoSize = true;
            electricityRadioButton.Location = new Point(568, 26);
            electricityRadioButton.Name = "electricityRadioButton";
            electricityRadioButton.Size = new Size(94, 24);
            electricityRadioButton.TabIndex = 3;
            electricityRadioButton.Text = "Electricity";
            electricityRadioButton.UseVisualStyleBackColor = true;
            electricityRadioButton.CheckedChanged += electricityRadioButton_CheckedChanged;
            // 
            // dieselRadioButton
            // 
            dieselRadioButton.AutoSize = true;
            dieselRadioButton.Location = new Point(393, 26);
            dieselRadioButton.Name = "dieselRadioButton";
            dieselRadioButton.Size = new Size(71, 24);
            dieselRadioButton.TabIndex = 2;
            dieselRadioButton.Text = "Diesel";
            dieselRadioButton.UseVisualStyleBackColor = true;
            dieselRadioButton.CheckedChanged += dieselRadioButton_CheckedChanged;
            // 
            // gasolineRadioButton
            // 
            gasolineRadioButton.AutoSize = true;
            gasolineRadioButton.Location = new Point(189, 26);
            gasolineRadioButton.Name = "gasolineRadioButton";
            gasolineRadioButton.Size = new Size(87, 24);
            gasolineRadioButton.TabIndex = 1;
            gasolineRadioButton.Text = "Gasoline";
            gasolineRadioButton.UseVisualStyleBackColor = true;
            gasolineRadioButton.CheckedChanged += gasolineRadioButton_CheckedChanged;
            // 
            // allRadioButton
            // 
            allRadioButton.AutoSize = true;
            allRadioButton.Checked = true;
            allRadioButton.Location = new Point(15, 26);
            allRadioButton.Name = "allRadioButton";
            allRadioButton.Size = new Size(48, 24);
            allRadioButton.TabIndex = 0;
            allRadioButton.TabStop = true;
            allRadioButton.Text = "All";
            allRadioButton.UseVisualStyleBackColor = true;
            allRadioButton.CheckedChanged += allRadioButton_CheckedChanged;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addButton.Location = new Point(637, 735);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 10;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // priceLabel
            // 
            priceLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            priceLabel.Location = new Point(23, 739);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(518, 28);
            priceLabel.TabIndex = 12;
            priceLabel.Text = "25/10/2023 - 26/10/2023,      $24 x 2 days,      Total: $48\r\n";
            // 
            // clearFillterButton
            // 
            clearFillterButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clearFillterButton.Location = new Point(637, 157);
            clearFillterButton.Name = "clearFillterButton";
            clearFillterButton.Size = new Size(94, 29);
            clearFillterButton.TabIndex = 13;
            clearFillterButton.Text = "Clear fillter";
            clearFillterButton.UseVisualStyleBackColor = true;
            clearFillterButton.Click += clearFillterButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 501);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 14;
            label5.Text = "Departure";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(421, 501);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 15;
            label6.Text = "Destination";
            // 
            // departureRichTextBox
            // 
            departureRichTextBox.Anchor = AnchorStyles.Left;
            departureRichTextBox.Location = new Point(23, 532);
            departureRichTextBox.Name = "departureRichTextBox";
            departureRichTextBox.Size = new Size(319, 162);
            departureRichTextBox.TabIndex = 16;
            departureRichTextBox.Text = "";
            // 
            // DestinationRichTextBox
            // 
            DestinationRichTextBox.Anchor = AnchorStyles.Right;
            DestinationRichTextBox.Location = new Point(418, 532);
            DestinationRichTextBox.Name = "DestinationRichTextBox";
            DestinationRichTextBox.Size = new Size(310, 162);
            DestinationRichTextBox.TabIndex = 17;
            DestinationRichTextBox.Text = "";
            // 
            // Add_UpdateBookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 787);
            Controls.Add(DestinationRichTextBox);
            Controls.Add(departureRichTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(clearFillterButton);
            Controls.Add(priceLabel);
            Controls.Add(addButton);
            Controls.Add(FuelGroupBox);
            Controls.Add(label4);
            Controls.Add(returnAtDateTimePicker);
            Controls.Add(label3);
            Controls.Add(rentAtDateTimePicker);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(carComboBox);
            Controls.Add(label1);
            Controls.Add(customerComboBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Add_UpdateBookingForm";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add booking";
            Load += Add_UpdateBookingForm_Load;
            ((System.ComponentModel.ISupportInitialize)customerEntityBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)carEntityBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            FuelGroupBox.ResumeLayout(false);
            FuelGroupBox.PerformLayout();
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
        private CheckBox tireSensorCheckBox;
        private CheckBox marginalCameraCheckBox;
        private CheckBox mapCheckBox;
        private CheckBox dashCamCheckBox;
        private CheckBox blueToothCheckBox;
        private CheckBox camera360CheckBox;
        private CheckBox pickupTruckTrunkCoverCheckBox;
        private CheckBox uSBCheckBox;
        private CheckBox sunroofCheckBox;
        private CheckBox collisionSensorCheckBox;
        private GroupBox FuelGroupBox;
        private RadioButton electricityRadioButton;
        private RadioButton dieselRadioButton;
        private RadioButton gasolineRadioButton;
        private RadioButton allRadioButton;
        private Button addButton;
        private CheckBox gPSCheckBox;
        private CheckBox spareTireCheckBox;
        private Label priceLabel;
        private BindingSource customerEntityBindingSource;
        private BindingSource carEntityBindingSource;
        private CheckBox SpeedWarningKitCheckBox;
        private CheckBox reversingCameraCheckBox;
        private Button clearFillterButton;
        private Label label5;
        private Label label6;
        private RichTextBox departureRichTextBox;
        private RichTextBox DestinationRichTextBox;
    }
}