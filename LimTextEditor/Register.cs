using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimTextEditor
{
    public partial class Register : Form
    {
        public Register()
        {
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            InitializeComponent();

        }

        private void Register_Load(object sender, EventArgs e)
        {
            userTypeComboBox.Items.Add("View");
            userTypeComboBox.Items.Add("Edit");
        }

        private void AttemptRegister()
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string userType = userTypeComboBox.Text;
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string dateOfBirth = dobDateTimePicker.ToString();

            List<Object> fields = new List<object>{ usernameTextBox, passwordTextBox, userTypeComboBox, firstNameTextBox, lastNameTextBox, dobDateTimePicker };

            foreach (Object field in fields)
            {

            }
        }
    }
}
