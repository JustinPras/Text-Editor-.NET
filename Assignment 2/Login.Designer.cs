namespace Assignment_2
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameLbl = new System.Windows.Forms.Label();
            this.userTxtBox = new System.Windows.Forms.TextBox();
            this.pwLbl = new System.Windows.Forms.Label();
            this.pwTxtBox = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.newUserBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(192, 92);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(63, 15);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "Username:";
            // 
            // userTxtBox
            // 
            this.userTxtBox.Location = new System.Drawing.Point(261, 89);
            this.userTxtBox.Name = "userTxtBox";
            this.userTxtBox.Size = new System.Drawing.Size(100, 23);
            this.userTxtBox.TabIndex = 1;
            // 
            // pwLbl
            // 
            this.pwLbl.AutoSize = true;
            this.pwLbl.Location = new System.Drawing.Point(192, 135);
            this.pwLbl.Name = "pwLbl";
            this.pwLbl.Size = new System.Drawing.Size(60, 15);
            this.pwLbl.TabIndex = 2;
            this.pwLbl.Text = "Password:";
            // 
            // pwTxtBox
            // 
            this.pwTxtBox.Location = new System.Drawing.Point(261, 132);
            this.pwTxtBox.Name = "pwTxtBox";
            this.pwTxtBox.Size = new System.Drawing.Size(100, 23);
            this.pwTxtBox.TabIndex = 3;
            this.pwTxtBox.UseSystemPasswordChar = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(180, 205);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.closeApp);
            // 
            // newUserBtn
            // 
            this.newUserBtn.Location = new System.Drawing.Point(270, 205);
            this.newUserBtn.Name = "newUserBtn";
            this.newUserBtn.Size = new System.Drawing.Size(75, 23);
            this.newUserBtn.TabIndex = 5;
            this.newUserBtn.Text = "New User";
            this.newUserBtn.UseVisualStyleBackColor = true;
            this.newUserBtn.Click += new System.EventHandler(this.addNewUser);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(361, 205);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.login);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.newUserBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.pwTxtBox);
            this.Controls.Add(this.pwLbl);
            this.Controls.Add(this.userTxtBox);
            this.Controls.Add(this.usernameLbl);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label usernameLbl;
        private TextBox userTxtBox;
        private Label pwLbl;
        private TextBox pwTxtBox;
        private Button exitBtn;
        private Button newUserBtn;
        private Button loginBtn;
    }
}