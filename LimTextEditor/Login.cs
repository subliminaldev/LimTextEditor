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
    public partial class Login : Form
    {
        public Login()
        {
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenRegisterView();
        }

        private void LoginUser()
        {

        }

        private void OpenRegisterView()
        {
            Register register = new Register();

            register.Show();
        }
    }
}
