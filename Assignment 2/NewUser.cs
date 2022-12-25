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
    /* The class NewUser is responsible for the "Create a New User" screen 
     * and prompting the user to add a new User to the database */
    public partial class NewUser : Form
    {

        private FileManager fileManager;
        public NewUser(FileManager fileManager)
        {
            InitializeComponent();
            this.fileManager = fileManager;
        }

        /* When the user clicks on the "Exit" button, 
         * exitWindow(object sender, EventArgs e) is used to close the New User window and re-open the login screen*/
        private void exitWindow(object sender, EventArgs e)
        {
            Login login = new Login(this.fileManager);
            login.Show();
            this.Close();
        }

        /* When the user clicks on the "Submit" button,
         * createUser(object sender, EventArgs e) is called to verify the details are inputted correctly and decide whether or not to create a new user.
         * If the details are not inputted correctly, a new window will pop-up telling the user of their mistake */
        private void createUser(object sender, EventArgs e)
        {
            string userName = usernameTxtBox.Text;
            string password = pwTxtBox.Text;
            string rPassword = rpwTxtBox.Text;
            string fName = capitiliseFirstLetter(fNameTxtBox.Text);
            string lName = capitiliseFirstLetter(lNameTxtBox.Text);
            string DOB = DOBPicker.Text;
            string userType = userTypeBox.Text;
            if (!boxesEmpty())
            {
                if (!password.Equals(rPassword) && !fileManager.validateUserName(userName))
                {
                    MessageBox.Show("Passwords do not match and Username is already taken!\n" + "Please re-enter details.", "Bad Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!password.Equals(rPassword))
                {
                    MessageBox.Show("Passwords do not match!\n" + "Please re-enter details.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!fileManager.validateUserName(userName))
                {
                    MessageBox.Show("Username already taken!\n" + "Please re-enter details.", "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    fileManager.addNewUser(userName, password, userType, fName, lName, DOB);
                    MessageBox.Show("User has successfully been created!", "User Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login login = new Login(this.fileManager);
                    login.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Missing information!\n" + "Please re-enter details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /* boxesEmpty() checks if the user has left any of the text boxes empty */
        private bool boxesEmpty()
        {
            if (String.IsNullOrEmpty(usernameTxtBox.Text) || String.IsNullOrEmpty(pwTxtBox.Text)
                || String.IsNullOrEmpty(rpwTxtBox.Text) || String.IsNullOrEmpty(fNameTxtBox.Text)
                || String.IsNullOrEmpty(lNameTxtBox.Text) || String.IsNullOrEmpty(DOBPicker.Text)
                || String.IsNullOrEmpty(userTypeBox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /* capitiliseFirstLettter(string name) is used to capitilise the first letter of the user's inputted first name and last name */
        private string capitiliseFirstLetter(string name)
        {
            char[] letters = name.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            return new string(letters);
        }
    }
}
