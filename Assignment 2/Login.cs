namespace Assignment_2
{
    /* The class Login is responsible for the "Login" screen and
     * prompting the user to Login to the text editor */
    public partial class Login : Form
    {
        private FileManager fileManager;

        public Login(FileManager fileManager)
        {
            InitializeComponent();
            this.fileManager = fileManager;
        }
        /* When the user clicks on the "Exit" button, 
         * closeApp(object sender, EventArgs e) is used to close the application*/
        private void closeApp(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /* When the user clicks on the "New User" button, 
         * addNewuser(object sender, EventArgs e) is used to open the "Create a New User" window*/
        private void addNewUser(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser(this.fileManager);
            newUser.Show();
            this.Hide();
        }

        /* When the user clicks on the "Login" button, 
         * login(object sender, EventArgs e) is used to validate the user's login details
         * and either let the user into the text editor or tell them their details are invalid.*/
        private void login(object sender, EventArgs e)
        {
            string userName = userTxtBox.Text;
            string password = pwTxtBox.Text;

            
            bool loginValid = fileManager.validateLogin(userName, password);
            
            if (loginValid)
            {
                string type = fileManager.getUserType(userName);
                Editor editor = new Editor(userName, type, this.fileManager);
                editor.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login details are invalid!\n" + "Please re-enter details.", "Login Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}