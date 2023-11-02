namespace CarRental.Forms.Staff
{
    partial class Add_UpdateStaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_UpdateStaffForm));
            label1 = new Label();
            loginNametextBox = new TextBox();
            passwordTextBox = new TextBox();
            label2 = new Label();
            togglePasswordCheckBox = new CheckBox();
            roleComboBox = new ComboBox();
            label3 = new Label();
            saveButton = new Button();
            isLockedcheckBox = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Login name";
            // 
            // loginNametextBox
            // 
            loginNametextBox.Location = new Point(130, 17);
            loginNametextBox.Name = "loginNametextBox";
            loginNametextBox.Size = new Size(246, 27);
            loginNametextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(130, 136);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(246, 27);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.Click += passwordTextBox_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 139);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // togglePasswordCheckBox
            // 
            togglePasswordCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            togglePasswordCheckBox.AutoSize = true;
            togglePasswordCheckBox.Location = new Point(23, 186);
            togglePasswordCheckBox.Name = "togglePasswordCheckBox";
            togglePasswordCheckBox.Size = new Size(134, 24);
            togglePasswordCheckBox.TabIndex = 4;
            togglePasswordCheckBox.Text = "Show password";
            togglePasswordCheckBox.UseVisualStyleBackColor = true;
            togglePasswordCheckBox.CheckedChanged += togglePasswordCheckBox_CheckedChanged;
            // 
            // roleComboBox
            // 
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Location = new Point(130, 77);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(246, 28);
            roleComboBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 80);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 6;
            label3.Text = "Role";
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Location = new Point(286, 259);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // isLockedcheckBox
            // 
            isLockedcheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            isLockedcheckBox.AutoSize = true;
            isLockedcheckBox.Location = new Point(23, 236);
            isLockedcheckBox.Name = "isLockedcheckBox";
            isLockedcheckBox.Size = new Size(92, 24);
            isLockedcheckBox.TabIndex = 8;
            isLockedcheckBox.Text = "Is Locked";
            isLockedcheckBox.UseVisualStyleBackColor = true;
            // 
            // Add_UpdateStaffForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 313);
            Controls.Add(isLockedcheckBox);
            Controls.Add(saveButton);
            Controls.Add(label3);
            Controls.Add(roleComboBox);
            Controls.Add(togglePasswordCheckBox);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(loginNametextBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Add_UpdateStaffForm";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add staff";
            Load += Add_UpdateStaffForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox loginNametextBox;
        private TextBox passwordTextBox;
        private Label label2;
        private CheckBox togglePasswordCheckBox;
        private ComboBox roleComboBox;
        private Label label3;
        private Button saveButton;
        private CheckBox isLockedcheckBox;
    }
}