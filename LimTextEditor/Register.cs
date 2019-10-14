using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LimTextEditor
{
    public partial class Register : Form
    {
        public Register()
        {
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            //Ensures user cannot choose date in the future.
            dobDateTimePicker.MaxDate = DateTime.Now;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            AttemptRegister();
        }

        private void AttemptRegister()
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string userType = userTypeComboBox.Text;
            string dateOfBirth = dobDateTimePicker.Value.ToString("dd/MM/yy");

            List<TextBox> fields = new List<TextBox>{ usernameTextBox, passwordTextBox, rePasswordTextBox, firstNameTextBox, lastNameTextBox};

            if (!EmptyTextBoxFields(fields))
            {
                MessageBox.Show("Please address the fields highlighted in red.", "Invalid Details", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            else if (userType.Equals(""))
            {
                MessageBox.Show("Please input a user type.", "Invalid Details", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            else if (Admin.AccountExists(username))
            {
                MessageBox.Show("Username in use. Please try another one.", "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            else
            {
                if (password.Equals(rePasswordTextBox.Text))
                {
                    Account account = new Account(username, password, userType, firstName, lastName, dateOfBirth);
                    Admin.GetCurrentDatabase();
                    MessageBox.Show("Account Sucessfully created", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Passwords do not match", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private bool EmptyTextBoxFields(List<TextBox> fields)
        {
            bool correctDetails = true;

            foreach (TextBox field in fields)
            {
                if (field.Text.Equals(""))
                {
                    field.BackColor = Color.Red;
                    correctDetails = false;
                }

                else
                {
                    field.BackColor = Color.White;
                }
            }

            return correctDetails;
        }
    }
}
