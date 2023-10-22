namespace CarRental.Forms.Auth
{
    partial class LoginForm
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
            label1 = new Label();
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            label2 = new Label();
            loginButton = new Button();
            showPasswordCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "User name";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(123, 23);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(172, 27);
            userNameTextBox.TabIndex = 1;
            userNameTextBox.Text = "admin";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(123, 79);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(172, 27);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.Text = "admin";
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 79);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(204, 170);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 29);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.Location = new Point(23, 129);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(134, 24);
            showPasswordCheckBox.TabIndex = 5;
            showPasswordCheckBox.Text = "Show password";
            showPasswordCheckBox.UseVisualStyleBackColor = true;
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 222);
            Controls.Add(showPasswordCheckBox);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(userNameTextBox);
            Controls.Add(label1);
            Name = "LoginForm";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "LoginForm";
            FormClosing += LoginForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Label label2;
        private Button loginButton;
        private CheckBox showPasswordCheckBox;
    }
}