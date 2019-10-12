using System;
using System.Drawing;
using System.Windows.Forms;

namespace LimTextEditor
{
    public partial class TextEditor : Form
    {
        public Account MyAccount { get; set; }
        private string currentFilePath = "";
        private int currentFontSize;

        public TextEditor()
        {
            InitializeComponent();
            fontComboBox.SelectedIndex = 0;
            currentFontSize = Convert.ToInt32(fontComboBox.SelectedItem.ToString());
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

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CutText();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyText();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteText();
        }

        private void FontComboBox_TextUpdate(Object sender, EventArgs e)
        {
            ChangeFontSize();
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
            //If the text is not saved to any file, run save as.
            if (currentFilePath == "")
            {
                SaveAsFile();
            } 
            else
            {
                //Otherwise, save over the current file.
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
            //If the specific button is pressed; make that button selected and deselect the other buttons.
            switch (type) {
                case "Bold":
                    if (boldTopButton.Checked == false)
                    {
                        mainRichTextBox.SelectionFont = new Font(mainRichTextBox.Font.FontFamily, currentFontSize, FontStyle.Bold);
                        boldTopButton.Checked = true;
                        italicsTopToolStripButton.Checked = false;
                        underlineTopToolStripButton.Checked = false;
                    }
                    else
                    {
                        mainRichTextBox.SelectionFont = new Font(mainRichTextBox.Font.FontFamily, currentFontSize, FontStyle.Regular);
                        boldTopButton.Checked = false;
                    }
                    break;
                
                case "Italics":
                    if (italicsTopToolStripButton.Checked == false)
                    {
                        mainRichTextBox.SelectionFont = new Font(mainRichTextBox.Font.FontFamily, currentFontSize, FontStyle.Italic);
                        italicsTopToolStripButton.Checked = true;
                        boldTopButton.Checked = false;
                        underlineTopToolStripButton.Checked = false;
                    }
                    else
                    {
                        mainRichTextBox.SelectionFont = new Font(mainRichTextBox.Font.FontFamily, currentFontSize, FontStyle.Regular);
                        italicsTopToolStripButton.Checked = false;
                    }
                    break;
                
                case "Underline":
                    if (underlineTopToolStripButton.Checked == false)
                    {
                        mainRichTextBox.SelectionFont = new Font(mainRichTextBox.Font.FontFamily, currentFontSize, FontStyle.Underline);
                        underlineTopToolStripButton.Checked = true;
                        boldTopButton.Checked = false;
                        italicsTopToolStripButton.Checked = false;
                    }
                    else
                    {
                        mainRichTextBox.SelectionFont = new Font(mainRichTextBox.Font.FontFamily, currentFontSize, FontStyle.Regular);
                        underlineTopToolStripButton.Checked = false;
                    }
                    break;
            }
        }

        //Change the Form text on the top to include what file path you are editing.
        private void ChangeFormTitle()
        {
            this.Text = "Lim Text Editor " + currentFilePath;
        }

        private void CutText()
        {
            mainRichTextBox.Cut();
        }

        private void CopyText()
        {
            mainRichTextBox.Copy();
        }

        private void PasteText()
        {
            mainRichTextBox.Paste();
        }
        
        public void ChangeFontSize()
        {
            object selectedItem = fontComboBox.SelectedItem;

            if (selectedItem != null)
            {
                bool isNumeric = int.TryParse(selectedItem.ToString(), out int number);

                if (isNumeric)
                {
                    mainRichTextBox.SelectionFont = new Font(mainRichTextBox.Font.FontFamily, number);
                    currentFontSize = Convert.ToInt32(selectedItem.ToString());
                }
            }
        }

        public void FontSizeAtCursor()
        {
            string fontSize = mainRichTextBox.SelectionFont.Size.ToString();

            if (mainRichTextBox.SelectionFont != null)
            {
                fontComboBox.SelectedItem = fontSize;
            }
            else
            {
                fontComboBox.SelectedIndex = -1;
            }
        }

        private void MainRichTextBox_SelectionChanged(object sender, EventArgs e)
        {
            FontSizeAtCursor();
        }
    }
}