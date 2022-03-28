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
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.lblregisterwithLicensKey = new System.Windows.Forms.Label();
            this.lblRegisterUsername = new System.Windows.Forms.Label();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.lblLicenseKey = new System.Windows.Forms.Label();
            this.registerUsernameTextbox = new System.Windows.Forms.TextBox();
            this.registerPasswordTextbox = new System.Windows.Forms.TextBox();
            this.licenseKeyTextbox = new System.Windows.Forms.TextBox();
            this.registernewUserButton = new System.Windows.Forms.Button();
            this.secretAnswerRegisterTextbox = new System.Windows.Forms.TextBox();
            this.lblsecretAnswer = new System.Windows.Forms.Label();
            this.secretQuestionRegisterTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(70, 36);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(63, 12);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(70, 72);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(62, 12);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(74, 51);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(240, 21);
            this.usernameTextbox.TabIndex = 2;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(74, 87);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(240, 21);
            this.passwordTextbox.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(74, 146);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(240, 28);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // forgotPasswordLabel
            // 
            this.forgotPasswordLabel.AutoSize = true;
            this.forgotPasswordLabel.Location = new System.Drawing.Point(208, 121);
            this.forgotPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forgotPasswordLabel.Name = "forgotPasswordLabel";
            this.forgotPasswordLabel.Size = new System.Drawing.Size(106, 12);
            this.forgotPasswordLabel.TabIndex = 5;
            this.forgotPasswordLabel.Text = "Forgot password?";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(74, 179);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(240, 30);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register new user";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.label1);
            this.pnlRegister.Controls.Add(this.secretQuestionRegisterTextbox);
            this.pnlRegister.Controls.Add(this.lblsecretAnswer);
            this.pnlRegister.Controls.Add(this.secretAnswerRegisterTextbox);
            this.pnlRegister.Controls.Add(this.licenseKeyTextbox);
            this.pnlRegister.Controls.Add(this.registernewUserButton);
            this.pnlRegister.Controls.Add(this.registerPasswordTextbox);
            this.pnlRegister.Controls.Add(this.registerUsernameTextbox);
            this.pnlRegister.Controls.Add(this.lblLicenseKey);
            this.pnlRegister.Controls.Add(this.lblRegisterPassword);
            this.pnlRegister.Controls.Add(this.lblRegisterUsername);
            this.pnlRegister.Controls.Add(this.lblregisterwithLicensKey);
            this.pnlRegister.Location = new System.Drawing.Point(12, 12);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(367, 224);
            this.pnlRegister.TabIndex = 7;
            // 
            // lblregisterwithLicensKey
            // 
            this.lblregisterwithLicensKey.AutoSize = true;
            this.lblregisterwithLicensKey.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblregisterwithLicensKey.Location = new System.Drawing.Point(56, 0);
            this.lblregisterwithLicensKey.Name = "lblregisterwithLicensKey";
            this.lblregisterwithLicensKey.Size = new System.Drawing.Size(264, 19);
            this.lblregisterwithLicensKey.TabIndex = 0;
            this.lblregisterwithLicensKey.Text = "Register now with License Key!";
            // 
            // lblRegisterUsername
            // 
            this.lblRegisterUsername.AutoSize = true;
            this.lblRegisterUsername.Location = new System.Drawing.Point(43, 33);
            this.lblRegisterUsername.Name = "lblRegisterUsername";
            this.lblRegisterUsername.Size = new System.Drawing.Size(67, 12);
            this.lblRegisterUsername.TabIndex = 1;
            this.lblRegisterUsername.Text = "Username:";
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.Location = new System.Drawing.Point(44, 94);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(66, 12);
            this.lblRegisterPassword.TabIndex = 2;
            this.lblRegisterPassword.Text = "Password:";
            // 
            // lblLicenseKey
            // 
            this.lblLicenseKey.AutoSize = true;
            this.lblLicenseKey.Location = new System.Drawing.Point(30, 159);
            this.lblLicenseKey.Name = "lblLicenseKey";
            this.lblLicenseKey.Size = new System.Drawing.Size(80, 12);
            this.lblLicenseKey.TabIndex = 3;
            this.lblLicenseKey.Text = "License Key:";
            // 
            // registerUsernameTextbox
            // 
            this.registerUsernameTextbox.Location = new System.Drawing.Point(24, 48);
            this.registerUsernameTextbox.Name = "registerUsernameTextbox";
            this.registerUsernameTextbox.Size = new System.Drawing.Size(117, 21);
            this.registerUsernameTextbox.TabIndex = 4;
            // 
            // registerPasswordTextbox
            // 
            this.registerPasswordTextbox.Location = new System.Drawing.Point(24, 109);
            this.registerPasswordTextbox.Name = "registerPasswordTextbox";
            this.registerPasswordTextbox.Size = new System.Drawing.Size(117, 21);
            this.registerPasswordTextbox.TabIndex = 5;
            // 
            // licenseKeyTextbox
            // 
            this.licenseKeyTextbox.Location = new System.Drawing.Point(143, 150);
            this.licenseKeyTextbox.Name = "licenseKeyTextbox";
            this.licenseKeyTextbox.Size = new System.Drawing.Size(184, 21);
            this.licenseKeyTextbox.TabIndex = 6;
            // 
            // registernewUserButton
            // 
            this.registernewUserButton.Location = new System.Drawing.Point(32, 186);
            this.registernewUserButton.Name = "registernewUserButton";
            this.registernewUserButton.Size = new System.Drawing.Size(295, 30);
            this.registernewUserButton.TabIndex = 7;
            this.registernewUserButton.Text = "Register";
            this.registernewUserButton.UseVisualStyleBackColor = true;
            this.registernewUserButton.Click += new System.EventHandler(this.registernewUserButton_Click);
            // 
            // secretAnswerRegisterTextbox
            // 
            this.secretAnswerRegisterTextbox.Location = new System.Drawing.Point(198, 109);
            this.secretAnswerRegisterTextbox.Name = "secretAnswerRegisterTextbox";
            this.secretAnswerRegisterTextbox.Size = new System.Drawing.Size(129, 21);
            this.secretAnswerRegisterTextbox.TabIndex = 8;
            // 
            // lblsecretAnswer
            // 
            this.lblsecretAnswer.AutoSize = true;
            this.lblsecretAnswer.Location = new System.Drawing.Point(241, 94);
            this.lblsecretAnswer.Name = "lblsecretAnswer";
            this.lblsecretAnswer.Size = new System.Drawing.Size(52, 12);
            this.lblsecretAnswer.TabIndex = 9;
            this.lblsecretAnswer.Text = "Answer:";
            // 
            // secretQuestionRegisterTextbox
            // 
            this.secretQuestionRegisterTextbox.Location = new System.Drawing.Point(198, 51);
            this.secretQuestionRegisterTextbox.Name = "secretQuestionRegisterTextbox";
            this.secretQuestionRegisterTextbox.Size = new System.Drawing.Size(129, 21);
            this.secretQuestionRegisterTextbox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "Secret Question";
            // 
            // SomerenUILogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 244);
            this.Controls.Add(this.pnlRegister);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.forgotPasswordLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SomerenUILogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.SomerenUILogin_Load);
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
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
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.TextBox licenseKeyTextbox;
        private System.Windows.Forms.Button registernewUserButton;
        private System.Windows.Forms.TextBox registerPasswordTextbox;
        private System.Windows.Forms.TextBox registerUsernameTextbox;
        private System.Windows.Forms.Label lblLicenseKey;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.Label lblRegisterUsername;
        private System.Windows.Forms.Label lblregisterwithLicensKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox secretQuestionRegisterTextbox;
        private System.Windows.Forms.Label lblsecretAnswer;
        private System.Windows.Forms.TextBox secretAnswerRegisterTextbox;
    }
}