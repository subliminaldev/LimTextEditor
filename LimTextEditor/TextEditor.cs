using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimTextEditor
{
    public partial class TextEditor : Form
    {
        public Account MyAccount { get; set; }
        private bool Bolded = false;
        private bool Italised = false;
        private bool Underlined = false;

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

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Open a Rich Text File";
            openFileDialog.Filter = "Rtf Files (*.rtf) | *.rtf";

            DialogResult dr = openFileDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;

                //If the file exists, it will be replaced.
                //File.ReadAllText(fileName);
                mainRichTextBox.LoadFile(fileName);
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        private void BoldTopButton_Click(object sender, EventArgs e)
        {
            BoldText();
        }

        private void SaveAsFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Rtf Files (*.rtf) | *.rtf";

            DialogResult dr = saveFileDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                mainRichTextBox.SaveFile(fileName, RichTextBoxStreamType.RichText);
            }
        }

        public void BoldText()
        {
            if (!Bolded)
            {
                mainRichTextBox.SelectionFont = new Font(mainRichTextBox.Font, FontStyle.Bold);
                Bolded = true;
            } 
            else
            {
                mainRichTextBox.SelectionFont = new Font(mainRichTextBox.Font, FontStyle.Regular);
                Bolded = false;
            }
        }

        
    }
}
