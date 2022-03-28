namespace SomerenUI
{
    partial class SomerenUILogin
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.forgotPasswordLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.pnlForgotPassword = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.lblSecretQuestion = new System.Windows.Forms.Label();
            this.forgotPasswordTitleLabel = new System.Windows.Forms.Label();
            this.secretAnswerTextbox = new System.Windows.Forms.TextBox();
            this.btnNewPassword = new System.Windows.Forms.Button();
            this.pnlForgotPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(80, 48);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(70, 16);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(80, 96);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(67, 16);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(84, 68);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(273, 22);
            this.usernameTextbox.TabIndex = 2;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(84, 116);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(273, 22);
            this.passwordTextbox.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(84, 194);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(275, 37);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // forgotPasswordLabel
            // 
            this.forgotPasswordLabel.AutoSize = true;
            this.forgotPasswordLabel.Location = new System.Drawing.Point(237, 161);
            this.forgotPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forgotPasswordLabel.Name = "forgotPasswordLabel";
            this.forgotPasswordLabel.Size = new System.Drawing.Size(115, 16);
            this.forgotPasswordLabel.TabIndex = 5;
            this.forgotPasswordLabel.Text = "Forgot password?";
            this.forgotPasswordLabel.Click += new System.EventHandler(this.forgotPasswordLabel_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(84, 239);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(275, 39);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register new user";
            this.registerButton.UseVisualStyleBackColor = true;
            // 
            // pnlForgotPassword
            // 
            this.pnlForgotPassword.Controls.Add(this.btnCancel);
            this.pnlForgotPassword.Controls.Add(this.lblNewPassword);
            this.pnlForgotPassword.Controls.Add(this.tbxNewPassword);
            this.pnlForgotPassword.Controls.Add(this.lblSecretQuestion);
            this.pnlForgotPassword.Controls.Add(this.forgotPasswordTitleLabel);
            this.pnlForgotPassword.Controls.Add(this.secretAnswerTextbox);
            this.pnlForgotPassword.Controls.Add(this.btnNewPassword);
            this.pnlForgotPassword.Location = new System.Drawing.Point(0, 0);
            this.pnlForgotPassword.Name = "pnlForgotPassword";
            this.pnlForgotPassword.Size = new System.Drawing.Size(446, 324);
            this.pnlForgotPassword.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(84, 247);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(273, 37);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(81, 129);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(97, 16);
            this.lblNewPassword.TabIndex = 5;
            this.lblNewPassword.Text = "New Password";
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.Location = new System.Drawing.Point(84, 149);
            this.tbxNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.Size = new System.Drawing.Size(273, 22);
            this.tbxNewPassword.TabIndex = 4;
            // 
            // lblSecretQuestion
            // 
            this.lblSecretQuestion.AutoSize = true;
            this.lblSecretQuestion.Location = new System.Drawing.Point(81, 62);
            this.lblSecretQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecretQuestion.Name = "lblSecretQuestion";
            this.lblSecretQuestion.Size = new System.Drawing.Size(0, 16);
            this.lblSecretQuestion.TabIndex = 3;
            // 
            // forgotPasswordTitleLabel
            // 
            this.forgotPasswordTitleLabel.AutoSize = true;
            this.forgotPasswordTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.forgotPasswordTitleLabel.Location = new System.Drawing.Point(147, 19);
            this.forgotPasswordTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forgotPasswordTitleLabel.Name = "forgotPasswordTitleLabel";
            this.forgotPasswordTitleLabel.Size = new System.Drawing.Size(136, 20);
            this.forgotPasswordTitleLabel.TabIndex = 0;
            this.forgotPasswordTitleLabel.Text = "Forgot Password";
            // 
            // secretAnswerTextbox
            // 
            this.secretAnswerTextbox.Location = new System.Drawing.Point(84, 86);
            this.secretAnswerTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.secretAnswerTextbox.Name = "secretAnswerTextbox";
            this.secretAnswerTextbox.Size = new System.Drawing.Size(273, 22);
            this.secretAnswerTextbox.TabIndex = 2;
            // 
            // btnNewPassword
            // 
            this.btnNewPassword.Location = new System.Drawing.Point(84, 202);
            this.btnNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewPassword.Name = "btnNewPassword";
            this.btnNewPassword.Size = new System.Drawing.Size(273, 37);
            this.btnNewPassword.TabIndex = 4;
            this.btnNewPassword.Text = "Change Password";
            this.btnNewPassword.UseVisualStyleBackColor = true;
            this.btnNewPassword.Click += new System.EventHandler(this.btnNewPassword_Click);
            // 
            // SomerenUILogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 325);
            this.Controls.Add(this.pnlForgotPassword);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.forgotPasswordLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SomerenUILogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.SomerenUILogin_Load);
            this.pnlForgotPassword.ResumeLayout(false);
            this.pnlForgotPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label forgotPasswordLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Panel pnlForgotPassword;
        private System.Windows.Forms.Label forgotPasswordTitleLabel;
        private System.Windows.Forms.TextBox secretAnswerTextbox;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.Label lblSecretQuestion;
        private System.Windows.Forms.Button btnNewPassword;
        private System.Windows.Forms.Button btnCancel;
    }
}