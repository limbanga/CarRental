namespace CarRental.Forms.Car
{
    partial class Add_UpdateCarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_UpdateCarForm));
            saveButton = new Button();
            label1 = new Label();
            nameCodeTextBox = new TextBox();
            brandTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            carTypeComboBox = new ComboBox();
            pricePerDayTextBox = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            speedWarningKitCheckBox = new CheckBox();
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
            FuelGroupBox = new GroupBox();
            ElectricityRadioButton = new RadioButton();
            dieselRadioButton = new RadioButton();
            gasolineRadioButton = new RadioButton();
            groupBox1.SuspendLayout();
            FuelGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Location = new Point(630, 456);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 43);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 1;
            label1.Text = "NameCode";
            // 
            // nameCodeTextBox
            // 
            nameCodeTextBox.Location = new Point(111, 40);
            nameCodeTextBox.Name = "nameCodeTextBox";
            nameCodeTextBox.Size = new Size(228, 27);
            nameCodeTextBox.TabIndex = 2;
            // 
            // brandTextBox
            // 
            brandTextBox.Location = new Point(111, 88);
            brandTextBox.Name = "brandTextBox";
            brandTextBox.Size = new Size(228, 27);
            brandTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 91);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 3;
            label2.Text = "Brand";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(407, 43);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "CarType";
            // 
            // carTypeComboBox
            // 
            carTypeComboBox.FormattingEnabled = true;
            carTypeComboBox.Location = new Point(520, 40);
            carTypeComboBox.Name = "carTypeComboBox";
            carTypeComboBox.Size = new Size(204, 28);
            carTypeComboBox.TabIndex = 6;
            // 
            // pricePerDayTextBox
            // 
            pricePerDayTextBox.Location = new Point(520, 91);
            pricePerDayTextBox.Name = "pricePerDayTextBox";
            pricePerDayTextBox.Size = new Size(204, 27);
            pricePerDayTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(407, 95);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 7;
            label4.Text = "Price per day";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(speedWarningKitCheckBox);
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
            groupBox1.Location = new Point(23, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(700, 211);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Feature";
            // 
            // speedWarningKitCheckBox
            // 
            speedWarningKitCheckBox.AutoSize = true;
            speedWarningKitCheckBox.Location = new Point(193, 166);
            speedWarningKitCheckBox.Name = "speedWarningKitCheckBox";
            speedWarningKitCheckBox.Size = new Size(154, 24);
            speedWarningKitCheckBox.TabIndex = 14;
            speedWarningKitCheckBox.Text = "Speed Warning Kit";
            speedWarningKitCheckBox.UseVisualStyleBackColor = true;
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
            // 
            // FuelGroupBox
            // 
            FuelGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FuelGroupBox.Controls.Add(ElectricityRadioButton);
            FuelGroupBox.Controls.Add(dieselRadioButton);
            FuelGroupBox.Controls.Add(gasolineRadioButton);
            FuelGroupBox.Location = new Point(23, 373);
            FuelGroupBox.Name = "FuelGroupBox";
            FuelGroupBox.Size = new Size(700, 66);
            FuelGroupBox.TabIndex = 10;
            FuelGroupBox.TabStop = false;
            FuelGroupBox.Text = "Fuel";
            // 
            // ElectricityRadioButton
            // 
            ElectricityRadioButton.AutoSize = true;
            ElectricityRadioButton.Location = new Point(568, 26);
            ElectricityRadioButton.Name = "ElectricityRadioButton";
            ElectricityRadioButton.Size = new Size(94, 24);
            ElectricityRadioButton.TabIndex = 3;
            ElectricityRadioButton.Text = "Electricity";
            ElectricityRadioButton.UseVisualStyleBackColor = true;
            // 
            // dieselRadioButton
            // 
            dieselRadioButton.AutoSize = true;
            dieselRadioButton.Location = new Point(292, 26);
            dieselRadioButton.Name = "dieselRadioButton";
            dieselRadioButton.Size = new Size(71, 24);
            dieselRadioButton.TabIndex = 2;
            dieselRadioButton.Text = "Diesel";
            dieselRadioButton.UseVisualStyleBackColor = true;
            // 
            // gasolineRadioButton
            // 
            gasolineRadioButton.AutoSize = true;
            gasolineRadioButton.Checked = true;
            gasolineRadioButton.Location = new Point(15, 26);
            gasolineRadioButton.Name = "gasolineRadioButton";
            gasolineRadioButton.Size = new Size(87, 24);
            gasolineRadioButton.TabIndex = 1;
            gasolineRadioButton.TabStop = true;
            gasolineRadioButton.Text = "Gasoline";
            gasolineRadioButton.UseVisualStyleBackColor = true;
            // 
            // Add_UpdateCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 508);
            Controls.Add(FuelGroupBox);
            Controls.Add(groupBox1);
            Controls.Add(pricePerDayTextBox);
            Controls.Add(label4);
            Controls.Add(carTypeComboBox);
            Controls.Add(label3);
            Controls.Add(brandTextBox);
            Controls.Add(label2);
            Controls.Add(nameCodeTextBox);
            Controls.Add(label1);
            Controls.Add(saveButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Add_UpdateCarForm";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add car";
            Load += Add_UpdateCarForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            FuelGroupBox.ResumeLayout(false);
            FuelGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private Label label1;
        private TextBox nameCodeTextBox;
        private TextBox brandTextBox;
        private Label label2;
        private Label label3;
        private ComboBox carTypeComboBox;
        private TextBox pricePerDayTextBox;
        private Label label4;
        private GroupBox groupBox1;
        private CheckBox speedWarningKitCheckBox;
        private CheckBox reversingCameraCheckBox;
        private CheckBox gPSCheckBox;
        private CheckBox spareTireCheckBox;
        private CheckBox dashCamCheckBox;
        private CheckBox blueToothCheckBox;
        private CheckBox camera360CheckBox;
        private CheckBox pickupTruckTrunkCoverCheckBox;
        private CheckBox uSBCheckBox;
        private CheckBox sunroofCheckBox;
        private CheckBox collisionSensorCheckBox;
        private CheckBox tireSensorCheckBox;
        private CheckBox marginalCameraCheckBox;
        private CheckBox mapCheckBox;
        private GroupBox FuelGroupBox;
        private RadioButton ElectricityRadioButton;
        private RadioButton dieselRadioButton;
        private RadioButton gasolineRadioButton;
    }
}