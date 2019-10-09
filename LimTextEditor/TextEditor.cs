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
    public partial class TextEditor : Form
    {
        public Account MyAccount { get; set; }

        public TextEditor()
        {
            InitializeComponent();
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {

            //Make the text editor fill the screen.
            WindowState = FormWindowState.Maximized;
            mainRichTextBox.ReadOnly = true;

            userNameToolStripLabel.Text = "Username: " + MyAccount.Username;

            if (MyAccount.UserType == "Edit")
            {
                mainRichTextBox.ReadOnly = false;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
