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
            saveButton = new Button();
            label1 = new Label();
            nameCodeTextBox = new TextBox();
            brandTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            carTypeComboBox = new ComboBox();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Location = new Point(261, 198);
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
            label1.Location = new Point(37, 36);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 1;
            label1.Text = "NameCode";
            // 
            // nameCodeTextBox
            // 
            nameCodeTextBox.Location = new Point(127, 33);
            nameCodeTextBox.Name = "nameCodeTextBox";
            nameCodeTextBox.Size = new Size(228, 27);
            nameCodeTextBox.TabIndex = 2;
            // 
            // brandTextBox
            // 
            brandTextBox.Location = new Point(127, 81);
            brandTextBox.Name = "brandTextBox";
            brandTextBox.Size = new Size(228, 27);
            brandTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 84);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 3;
            label2.Text = "Brand";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 138);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "CarType";
            // 
            // carTypeComboBox
            // 
            carTypeComboBox.FormattingEnabled = true;
            carTypeComboBox.Location = new Point(127, 138);
            carTypeComboBox.Name = "carTypeComboBox";
            carTypeComboBox.Size = new Size(228, 28);
            carTypeComboBox.TabIndex = 6;
            // 
            // Add_UpdateCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 239);
            Controls.Add(carTypeComboBox);
            Controls.Add(label3);
            Controls.Add(brandTextBox);
            Controls.Add(label2);
            Controls.Add(nameCodeTextBox);
            Controls.Add(label1);
            Controls.Add(saveButton);
            Name = "Add_UpdateCarForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add car";
            Load += Add_UpdateCarForm_Load;
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
    }
}