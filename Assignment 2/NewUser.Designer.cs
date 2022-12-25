namespace Assignment_2
{
    partial class NewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submitBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.pwTxtBox = new System.Windows.Forms.TextBox();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.pwLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.rpwLbl = new System.Windows.Forms.Label();
            this.rpwTxtBox = new System.Windows.Forms.TextBox();
            this.fNameLbl = new System.Windows.Forms.Label();
            this.lNameLbl = new System.Windows.Forms.Label();
            this.fNameTxtBox = new System.Windows.Forms.TextBox();
            this.lNameTxtBox = new System.Windows.Forms.TextBox();
            this.DOBPicker = new System.Windows.Forms.DateTimePicker();
            this.DOBLbl = new System.Windows.Forms.Label();
            this.userTypeBox = new System.Windows.Forms.ComboBox();
            this.userTypeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(316, 265);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 24;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.createUser);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(187, 265);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 23;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.exitWindow);
            // 
            // pwTxtBox
            // 
            this.pwTxtBox.Location = new System.Drawing.Point(162, 100);
            this.pwTxtBox.Name = "pwTxtBox";
            this.pwTxtBox.Size = new System.Drawing.Size(100, 23);
            this.pwTxtBox.TabIndex = 10;
            this.pwTxtBox.UseSystemPasswordChar = true;
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Location = new System.Drawing.Point(162, 57);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(100, 23);
            this.usernameTxtBox.TabIndex = 8;
            // 
            // pwLbl
            // 
            this.pwLbl.AutoSize = true;
            this.pwLbl.Location = new System.Drawing.Point(96, 108);
            this.pwLbl.Name = "pwLbl";
            this.pwLbl.Size = new System.Drawing.Size(60, 15);
            this.pwLbl.TabIndex = 9;
            this.pwLbl.Text = "Password:";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(96, 65);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(63, 15);
            this.usernameLbl.TabIndex = 7;
            this.usernameLbl.Text = "Username:";
            // 
            // rpwLbl
            // 
            this.rpwLbl.AutoSize = true;
            this.rpwLbl.Location = new System.Drawing.Point(48, 149);
            this.rpwLbl.Name = "rpwLbl";
            this.rpwLbl.Size = new System.Drawing.Size(108, 15);
            this.rpwLbl.TabIndex = 14;
            this.rpwLbl.Text = "Re-Enter Password:";
            // 
            // rpwTxtBox
            // 
            this.rpwTxtBox.Location = new System.Drawing.Point(162, 141);
            this.rpwTxtBox.Name = "rpwTxtBox";
            this.rpwTxtBox.Size = new System.Drawing.Size(100, 23);
            this.rpwTxtBox.TabIndex = 15;
            this.rpwTxtBox.UseSystemPasswordChar = true;
            // 
            // fNameLbl
            // 
            this.fNameLbl.AutoSize = true;
            this.fNameLbl.Location = new System.Drawing.Point(316, 43);
            this.fNameLbl.Name = "fNameLbl";
            this.fNameLbl.Size = new System.Drawing.Size(67, 15);
            this.fNameLbl.TabIndex = 16;
            this.fNameLbl.Text = "First Name:";
            // 
            // lNameLbl
            // 
            this.lNameLbl.AutoSize = true;
            this.lNameLbl.Location = new System.Drawing.Point(316, 84);
            this.lNameLbl.Name = "lNameLbl";
            this.lNameLbl.Size = new System.Drawing.Size(66, 15);
            this.lNameLbl.TabIndex = 17;
            this.lNameLbl.Text = "Last Name:";
            // 
            // fNameTxtBox
            // 
            this.fNameTxtBox.Location = new System.Drawing.Point(398, 40);
            this.fNameTxtBox.Name = "fNameTxtBox";
            this.fNameTxtBox.Size = new System.Drawing.Size(100, 23);
            this.fNameTxtBox.TabIndex = 18;
            // 
            // lNameTxtBox
            // 
            this.lNameTxtBox.Location = new System.Drawing.Point(398, 81);
            this.lNameTxtBox.Name = "lNameTxtBox";
            this.lNameTxtBox.Size = new System.Drawing.Size(100, 23);
            this.lNameTxtBox.TabIndex = 19;
            // 
            // DOBPicker
            // 
            this.DOBPicker.CustomFormat = "dd-MM-yyyy";
            this.DOBPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOBPicker.Location = new System.Drawing.Point(398, 121);
            this.DOBPicker.MaxDate = new System.DateTime(2022, 10, 18, 17, 29, 53, 0);
            this.DOBPicker.Name = "DOBPicker";
            this.DOBPicker.Size = new System.Drawing.Size(100, 23);
            this.DOBPicker.TabIndex = 20;
            this.DOBPicker.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // DOBLbl
            // 
            this.DOBLbl.AutoSize = true;
            this.DOBLbl.Location = new System.Drawing.Point(316, 127);
            this.DOBLbl.Name = "DOBLbl";
            this.DOBLbl.Size = new System.Drawing.Size(76, 15);
            this.DOBLbl.TabIndex = 21;
            this.DOBLbl.Text = "Date of Birth:";
            // 
            // userTypeBox
            // 
            this.userTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userTypeBox.FormattingEnabled = true;
            this.userTypeBox.Items.AddRange(new object[] {
            "View",
            "Edit"});
            this.userTypeBox.Location = new System.Drawing.Point(398, 164);
            this.userTypeBox.Name = "userTypeBox";
            this.userTypeBox.Size = new System.Drawing.Size(100, 23);
            this.userTypeBox.TabIndex = 22;
            // 
            // userTypeLbl
            // 
            this.userTypeLbl.AutoSize = true;
            this.userTypeLbl.Location = new System.Drawing.Point(316, 167);
            this.userTypeLbl.Name = "userTypeLbl";
            this.userTypeLbl.Size = new System.Drawing.Size(62, 15);
            this.userTypeLbl.TabIndex = 23;
            this.userTypeLbl.Text = "User-Type:";
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.userTypeLbl);
            this.Controls.Add(this.userTypeBox);
            this.Controls.Add(this.DOBLbl);
            this.Controls.Add(this.DOBPicker);
            this.Controls.Add(this.lNameTxtBox);
            this.Controls.Add(this.fNameTxtBox);
            this.Controls.Add(this.lNameLbl);
            this.Controls.Add(this.fNameLbl);
            this.Controls.Add(this.rpwTxtBox);
            this.Controls.Add(this.rpwLbl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.pwTxtBox);
            this.Controls.Add(this.pwLbl);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.usernameLbl);
            this.Name = "NewUser";
            this.Text = "Create New User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button submitBtn;
        private Button cancelBtn;
        private TextBox pwTxtBox;
        private TextBox usernameTxtBox;
        private Label pwLbl;
        private Label usernameLbl;
        private Label rpwLbl;
        private TextBox rpwTxtBox;
        private Label fNameLbl;
        private Label lNameLbl;
        private TextBox fNameTxtBox;
        private TextBox lNameTxtBox;
        private DateTimePicker DOBPicker;
        private Label DOBLbl;
        private ComboBox userTypeBox;
        private Label userTypeLbl;
    }
}