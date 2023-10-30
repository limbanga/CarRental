namespace CarRental.Forms.Customer
{
    partial class Add_UpdateCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_UpdateCustomerForm));
            label1 = new Label();
            nameTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            label2 = new Label();
            addressTextBox = new TextBox();
            label3 = new Label();
            saveButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(159, 17);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(196, 27);
            nameTextBox.TabIndex = 1;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(159, 79);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(196, 27);
            phoneNumberTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 82);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 2;
            label2.Text = "Phone number";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(159, 145);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(196, 27);
            addressTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 148);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 4;
            label3.Text = "Address";
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Location = new Point(255, 204);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // Add_UpdateCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 256);
            Controls.Add(saveButton);
            Controls.Add(addressTextBox);
            Controls.Add(label3);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Add_UpdateCustomerForm";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add customer";
            Load += Add_UpdateCustomerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameTextBox;
        private TextBox phoneNumberTextBox;
        private Label label2;
        private TextBox addressTextBox;
        private Label label3;
        private Button saveButton;
    }
}