﻿namespace GenericRepositoryEF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(53, 79);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(80, 33);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "button1";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(53, 21);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(127, 23);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(53, 50);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(127, 23);
            txtPassword.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 198);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(btnLogin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUserName;
        private TextBox txtPassword;
    }
}
