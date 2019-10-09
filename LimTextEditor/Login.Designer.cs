using System;
using System.Windows.Forms;

namespace LimTextEditor
{
    partial class Login
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.registerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(287, 422);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(140, 41);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(329, 243);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(171, 29);
            this.UsernameTextBox.TabIndex = 2;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(208, 243);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(102, 25);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(208, 308);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(98, 25);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(329, 308);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(171, 29);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(325, 164);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(60, 25);
            this.LoginLabel.TabIndex = 6;
            this.LoginLabel.Text = "Login";
            // 
            // registerLinkLabel
            // 
            this.registerLinkLabel.AutoSize = true;
            this.registerLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLinkLabel.Location = new System.Drawing.Point(245, 369);
            this.registerLinkLabel.Name = "registerLinkLabel";
            this.registerLinkLabel.Size = new System.Drawing.Size(230, 20);
            this.registerLinkLabel.TabIndex = 7;
            this.registerLinkLabel.TabStop = true;
            this.registerLinkLabel.Text = "Not a member? Register here";
            this.registerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLinkLabel_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 599);
            this.Controls.Add(this.registerLinkLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.LoginButton);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.LinkLabel registerLinkLabel;
    }
}

