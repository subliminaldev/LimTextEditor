using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private string currentFilePath = "";

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

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SOMETHING.
        }

        private void BoldTopButton_Click(object sender, EventArgs e)
        {
            FormatText("Bold");
        }

        private void ItalicsTopToolStripButton_Click(object sender, EventArgs e)
        {
            FormatText("Italics");
        }

        private void UnderlineTopToolStripButton_Click(object sender, EventArgs e)
        {
            FormatText("Underline");
        }

        public void NewFile()
        {
            currentFilePath = "";
            mainRichTextBox.Clear();
            ChangeFormTitle();
        }

        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Open a Rich Text File";
            openFileDialog.Filter = "Rtf Files (*.rtf) | *.rtf";

            DialogResult dr = openFileDialog.ShowDialog();
            string filePath = openFileDialog.FileName;

            if (dr == DialogResult.OK)
            {
                mainRichTextBox.LoadFile(filePath);
                currentFilePath = filePath;
                ChangeFormTitle();
            }
        }

        private void SaveFile()
        {
            if (currentFilePath == "")
            {
                SaveAsFile();
            } 
            else
            {
                string fileName = currentFilePath;
                mainRichTextBox.SaveFile(fileName, RichTextBoxStreamType.RichText);
            }
        }

        private void SaveAsFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Rtf Files (*.rtf) | *.rtf";

            DialogResult dr = saveFileDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                mainRichTextBox.SaveFile(filePath, RichTextBoxStreamType.RichText);
                currentFilePath = filePath;
                ChangeFormTitle();
            }
        }

        public void FormatText(string type)
        {
            switch (type) {
                case "Bold":
                    if (boldTopButton.Checked == false)
                    {
                        mainRichTextBox.SelectionFont = new Font(mainRichTextBox.Font, FontStyle.Bold);
                        boldTopButton.Checked = true;
                        italicsTopToolStripButton.Checked = false;
                        underlineTopToolStripButton.Checked = false;
                    }
                    else
                    {
                        mainRichTextBox.SelectionFont = new Font(mainRichTextBox.Font, FontStyle.Regular);
                        boldTopButton.Checked = false;
                    }
                    break;
                
                case "Italics":
                    if (italicsTopToolStripButton.Checked == false)
                    {
                        mainRichTextBox.SelectionFont = new Font(mainRichTextBox.Font, FontStyle.Italic);
                        italicsTopToolStripButton.Checked = true;
                        boldTopButton.Checked = false;
                        underlineTopToolStripButton.Checked = false;
                    }
                    else
                    {
                        mainRichTextBox.SelectionFont = new Font(mainRichTextBox.Font, FontStyle.Regular);
                        italicsTopToolStripButton.Checked = false;
                    }
                    break;
                
                case "Underline":
                    if (underlineTopToolStripButton.Checked == false)
                    {
                        mainRichTextBox.SelectionFont = new Font(mainRichTextBox.Font, FontStyle.Underline);
                        underlineTopToolStripButton.Checked = true;
                        boldTopButton.Checked = false;
                        italicsTopToolStripButton.Checked = false;
                    }
                    else
                    {
                        mainRichTextBox.SelectionFont = new Font(mainRichTextBox.Font, FontStyle.Regular);
                        underlineTopToolStripButton.Checked = false;
                    }
                    break;
            }
        }

        private void ChangeFormTitle()
        {
            this.Text = "Lim Text Editor " + currentFilePath;
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(mainRichTextBox.SelectedText);
                mainRichTextBox.SelectedText = string.Empty;
            }
            catch (ArgumentNullException)
            {
                //Makes the clipboard empty if no text is selected.
                Clipboard.Clear();
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(mainRichTextBox.SelectedText);
            }
            catch (ArgumentNullException)
            {
                //Makes the clipboard empty if no text is selected.
                Clipboard.Clear();
            }
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string copiedText = Clipboard.GetText();

            try
            {
                mainRichTextBox.Text = mainRichTextBox.Text.Insert(mainRichTextBox.SelectionStart, copiedText);
            }
            catch (ArgumentNullException)
            {
                //Do nothing.
            }  
        }
    }
}
