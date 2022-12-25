using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    /* The class Editor is responsible for the "Text Editor" screen and
     * allows the user to edit text files. */
    public partial class Editor : Form
    {

        /* The enum UserType is used to decide whether or not the user is allowed to edit using the text editor */
        enum UserType
        {
            VIEW,
            EDIT
        }

        private UserType userType;
        private FileManager fileManager;
        private string userName, userTypeString, filePath;
        public Editor(string userName, string userTypeString, FileManager fileManager)
        {
            InitializeComponent();
            this.fileManager = fileManager;
            this.userName = userName;
            this.userTypeString = userTypeString;
            userNameDisplay.Text = "User Name: " + this.userName;
            if (this.userTypeString.Equals("View"))
            {
                this.userType = UserType.VIEW;
                richTextBox.ReadOnly = true;
                this.Text = "Text Editor (Read Only)";
            }
            else if (this.userTypeString.Equals("Edit"))
            {
                this.userType = UserType.EDIT;
                richTextBox.ReadOnly = false;
                this.Text = "Text Editor";
            }
        }

        /* newFile(object sender, EventArgs e) opens another text editor window if the user has "Edit" permissions,
         * and tells the user they don't have permissions if they have "View" permissions */
        private void newFile(object sender, EventArgs e)
        {
            switch (userType)
            {
                case UserType.VIEW:
                    MessageBox.Show("You don't have the permissions to create a new file!", "Insufficient Permissions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case UserType.EDIT:
                    Editor editor = new Editor(this.userName, this.userTypeString, this.fileManager);
                    editor.Show();
                    break;
            }
        }

        /* openFile(object sender, EventArgs e) opens a dialog box prompting the user to select a file to import to the text editor */
        private void openFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open a Text File";
            DialogResult dr = openFileDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                richTextBox.Text = File.ReadAllText(filePath);
            }
        }

        /* saveFile(object sender, EventArgs e) saves the file if it already exists,
         * If the file was newly created then a "Save as" dialog box will open */
        private void saveFile(object sender, EventArgs e)
        {
            if (filePath != null)
            {
                File.WriteAllTextAsync(filePath, richTextBox.Text);
            }
            else
            {
                saveAsFile(sender, e);
            }
        }

        /* saveAsFile(object sender, EventArgs e) opens a dialog box
         * prompting the user to choose where to save the file, what type of file to save it as, and what to name the file */
        private void saveAsFile(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save a File";
            saveFileDialog.Filter = "Text File (*.txt) | *.txt | Rich Text File (*.rtf) | *.rtf | All Files (*.*) | *.*";
            DialogResult dr = saveFileDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                File.WriteAllTextAsync(filePath, richTextBox.Text);
            }
        }

        /* When the "Logout" button is clicked, 
         * logout(object sender, EventArgs e) will close the text editor and open the login screen */
        private void logout(object sender, EventArgs e)
        {
            Login login = new Login(this.fileManager);
            login.Show();
            this.Close();
        }

        /* cutText(object sender, EventArgs e) is responsible for copying the selected text to clipboard and then removing said text */
        private void cutText(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText != "")
            {
                Clipboard.SetText(richTextBox.SelectedText);
                richTextBox.SelectedText = "";
            }
        }

        /* copyText(object sender, EventArgs e) is responsible for copying the selected text to clipboard */
        private void copyText(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText != "")
            {
                Clipboard.SetText(richTextBox.SelectedText);
            }
        }

        /* pasteText(object sender, EventArgs e) is responsible for pasting the most previous copied text from clipboard to the rich text box */
        private void pasteText(object sender, EventArgs e)
        {
            switch(userType)
            {
                case UserType.VIEW:
                    break;
                case UserType.EDIT:
                    richTextBox.SelectedText = Clipboard.GetText();
                    break;
            }
        }

        /* When the "About..." button is clicked
         * about(object sender, EventArgs e) will give information to the user about who created the program and what version the user is using */
        private void about(object sender, EventArgs e)
        {
            MessageBox.Show("Made by: Justin Praseuthsouk\nVersion: 1.0 (2022)\nAssessment Task 2", "About...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /* toggleBold(object sender, EventArgs e) is responsible for changing the currently selected text to bold if it isn't already and vice versa */
        private void toggleBold(object sender, EventArgs e)
        {
            switch (userType)
            {
                case UserType.VIEW:
                    break;
                case UserType.EDIT:
                    Font newFont;
                    Font currentFont = richTextBox.SelectionFont;

                    if (currentFont.Bold)
                    {
                        newFont = new Font(currentFont, currentFont.Style & ~FontStyle.Bold);
                    }
                    else
                    {
                        newFont = new Font(currentFont, currentFont.Style | FontStyle.Bold);
                    }

                    richTextBox.SelectionFont = newFont;
                    richTextBox.Focus();
                    break;
            }
        }

        /* toggleItalic(object sender, EventArgs e) is responsible for changing the currently selected text to italic if it isn't already and vice versa */
        private void toggleItalic(object sender, EventArgs e)
        {
            switch (userType)
            {
                case UserType.VIEW:
                    break;
                case UserType.EDIT:
                    Font newFont;
                    Font currentFont = richTextBox.SelectionFont;

                    if (currentFont.Italic)
                    {
                        newFont = new Font(currentFont, currentFont.Style & ~FontStyle.Italic);
                    }
                    else
                    {
                        newFont = new Font(currentFont, currentFont.Style | FontStyle.Italic);
                    }

                    richTextBox.SelectionFont = newFont;
                    richTextBox.Focus();
                    break;
            }
        }

        /* toggleUnderline(object sender, EventArgs e) is responsible for make the currently selected text underlined if it isn't already and vice versa */
        private void toggleUnderline(object sender, EventArgs e)
        {
            switch (userType)
            {
                case UserType.VIEW:
                    break;
                case UserType.EDIT:
                    Font newFont;
                    Font currentFont = richTextBox.SelectionFont;

                    if (currentFont.Underline)
                    {
                        newFont = new Font(currentFont, currentFont.Style & ~FontStyle.Underline);
                    }
                    else
                    {
                        newFont = new Font(currentFont, currentFont.Style | FontStyle.Underline);
                    }

                    richTextBox.SelectionFont = newFont;
                    richTextBox.Focus();
                    break;
            }
        }

        /* fontChange(object sender, EventArgs e) is responsible for changing the currently selected text to the font size the user has chosen,
         * and will also keep the newly typed text to that same font size */
        private void fontChange(object sender, EventArgs e)
        {
            switch (userType)
            {
                case UserType.VIEW:
                    break;
                case UserType.EDIT:
                    int fontSize = (fontSizeSelection.SelectedIndex + 4) * 2;
                    richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.SelectionFont.FontFamily, fontSize);
                    break;
            }
        }
    }
}
