namespace CarRental.Forms.Auth
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            label1 = new Label();
            saveButton = new Button();
            oldPasswordTextBox = new TextBox();
            newPasswordTextBox = new TextBox();
            label2 = new Label();
            confirmTextBox = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 30);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Old password";
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Location = new Point(245, 235);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // oldPasswordTextBox
            // 
            oldPasswordTextBox.Location = new Point(152, 30);
            oldPasswordTextBox.Name = "oldPasswordTextBox";
            oldPasswordTextBox.Size = new Size(187, 27);
            oldPasswordTextBox.TabIndex = 2;
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Location = new Point(152, 104);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.Size = new Size(187, 27);
            newPasswordTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 104);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 3;
            label2.Text = "New password";
            // 
            // confirmTextBox
            // 
            confirmTextBox.Location = new Point(152, 178);
            confirmTextBox.Name = "confirmTextBox";
            confirmTextBox.Size = new Size(187, 27);
            confirmTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 178);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "Confirm";
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 287);
            Controls.Add(confirmTextBox);
            Controls.Add(label3);
            Controls.Add(newPasswordTextBox);
            Controls.Add(label2);
            Controls.Add(oldPasswordTextBox);
            Controls.Add(saveButton);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChangePasswordForm";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Change password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button saveButton;
        private TextBox oldPasswordTextBox;
        private TextBox newPasswordTextBox;
        private Label label2;
        private TextBox confirmTextBox;
        private Label label3;
    }
}