using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace LimTextEditor
{
    public partial class Login : Form
    {
        public Login()
        {
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        private void RegisterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenRegisterView();
        }

        private void LoginUser()
        {
            List<Account> accounts = Admin.GetCurrentDatabase();

            Account loggedInAccount = null;

            foreach(Account account in accounts)
            {
                if (account.Username == UsernameTextBox.Text && account.Password == PasswordTextBox.Text)
                {
                    loggedInAccount = account;
                    break;
                }
            }

            if (loggedInAccount != null)
            {
                MessageBox.Show("Welcome", "Login Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //Hide the login screen, open the text editor and send the account object to the next login screen.
                Hide();
                TextEditor textEditor = new TextEditor();
                textEditor.MyAccount = loggedInAccount;
                textEditor.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username/Password or Account does not exist.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OpenRegisterView()
        {
            Register register = new Register();
            register.Show();
        }


        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginUser();
            }
        }
    }
}
