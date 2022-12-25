namespace Assignment_2
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dsaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutTopStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.copyTopStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteTopStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newBtn = new System.Windows.Forms.ToolStripButton();
            this.openBtn = new System.Windows.Forms.ToolStripButton();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.saveAsBtn = new System.Windows.Forms.ToolStripButton();
            this.toggleBoldBtn = new System.Windows.Forms.ToolStripButton();
            this.toggleItalicBtn = new System.Windows.Forms.ToolStripButton();
            this.toggleUnderlineBtn = new System.Windows.Forms.ToolStripButton();
            this.fontSizeSelection = new System.Windows.Forms.ToolStripComboBox();
            this.userNameDisplay = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.cutLeftStrip = new System.Windows.Forms.ToolStripButton();
            this.copyLeftStrip = new System.Windows.Forms.ToolStripButton();
            this.pasteLeftStrip = new System.Windows.Forms.ToolStripButton();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsaToolStripMenuItem,
            this.dsaToolStripMenuItem1,
            this.dsaToolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 20);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // dsaToolStripMenuItem
            // 
            this.dsaToolStripMenuItem.Name = "dsaToolStripMenuItem";
            this.dsaToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // dsaToolStripMenuItem1
            // 
            this.dsaToolStripMenuItem1.Name = "dsaToolStripMenuItem1";
            this.dsaToolStripMenuItem1.Size = new System.Drawing.Size(67, 22);
            // 
            // dsaToolStripMenuItem2
            // 
            this.dsaToolStripMenuItem2.Name = "dsaToolStripMenuItem2";
            this.dsaToolStripMenuItem2.Size = new System.Drawing.Size(67, 22);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(944, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuStrip,
            this.openMenuStrip,
            this.saveMenuStrip,
            this.saveAsMenuStrip,
            this.logoutMenuStrip});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newMenuStrip
            // 
            this.newMenuStrip.Image = ((System.Drawing.Image)(resources.GetObject("newMenuStrip.Image")));
            this.newMenuStrip.Name = "newMenuStrip";
            this.newMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMenuStrip.Size = new System.Drawing.Size(146, 22);
            this.newMenuStrip.Text = "New";
            this.newMenuStrip.Click += new System.EventHandler(this.newFile);
            // 
            // openMenuStrip
            // 
            this.openMenuStrip.Image = ((System.Drawing.Image)(resources.GetObject("openMenuStrip.Image")));
            this.openMenuStrip.Name = "openMenuStrip";
            this.openMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuStrip.Size = new System.Drawing.Size(146, 22);
            this.openMenuStrip.Text = "Open";
            this.openMenuStrip.Click += new System.EventHandler(this.openFile);
            // 
            // saveMenuStrip
            // 
            this.saveMenuStrip.Image = ((System.Drawing.Image)(resources.GetObject("saveMenuStrip.Image")));
            this.saveMenuStrip.Name = "saveMenuStrip";
            this.saveMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuStrip.Size = new System.Drawing.Size(146, 22);
            this.saveMenuStrip.Text = "Save";
            this.saveMenuStrip.Click += new System.EventHandler(this.saveFile);
            // 
            // saveAsMenuStrip
            // 
            this.saveAsMenuStrip.Image = ((System.Drawing.Image)(resources.GetObject("saveAsMenuStrip.Image")));
            this.saveAsMenuStrip.Name = "saveAsMenuStrip";
            this.saveAsMenuStrip.Size = new System.Drawing.Size(146, 22);
            this.saveAsMenuStrip.Text = "Save As";
            this.saveAsMenuStrip.Click += new System.EventHandler(this.saveAsFile);
            // 
            // logoutMenuStrip
            // 
            this.logoutMenuStrip.Image = ((System.Drawing.Image)(resources.GetObject("logoutMenuStrip.Image")));
            this.logoutMenuStrip.Name = "logoutMenuStrip";
            this.logoutMenuStrip.Size = new System.Drawing.Size(146, 22);
            this.logoutMenuStrip.Text = "Logout";
            this.logoutMenuStrip.Click += new System.EventHandler(this.logout);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutTopStrip,
            this.copyTopStrip,
            this.pasteTopStrip});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutTopStrip
            // 
            this.cutTopStrip.Image = ((System.Drawing.Image)(resources.GetObject("cutTopStrip.Image")));
            this.cutTopStrip.Name = "cutTopStrip";
            this.cutTopStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutTopStrip.Size = new System.Drawing.Size(144, 22);
            this.cutTopStrip.Text = "Cut";
            this.cutTopStrip.Click += new System.EventHandler(this.cutText);
            // 
            // copyTopStrip
            // 
            this.copyTopStrip.Image = global::Assignment_2.Properties.Resources.if_icon_ios7_copy_outline_211732;
            this.copyTopStrip.Name = "copyTopStrip";
            this.copyTopStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyTopStrip.Size = new System.Drawing.Size(144, 22);
            this.copyTopStrip.Text = "Copy";
            this.copyTopStrip.Click += new System.EventHandler(this.copyText);
            // 
            // pasteTopStrip
            // 
            this.pasteTopStrip.Image = global::Assignment_2.Properties.Resources.if_paste_3671826;
            this.pasteTopStrip.Name = "pasteTopStrip";
            this.pasteTopStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteTopStrip.Size = new System.Drawing.Size(144, 22);
            this.pasteTopStrip.Text = "Paste";
            this.pasteTopStrip.Click += new System.EventHandler(this.pasteText);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutButton});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutButton
            // 
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(116, 22);
            this.aboutButton.Text = "About...";
            this.aboutButton.Click += new System.EventHandler(this.about);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBtn,
            this.openBtn,
            this.saveBtn,
            this.saveAsBtn,
            this.toggleBoldBtn,
            this.toggleItalicBtn,
            this.toggleUnderlineBtn,
            this.fontSizeSelection,
            this.userNameDisplay});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(944, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newBtn
            // 
            this.newBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newBtn.Image = ((System.Drawing.Image)(resources.GetObject("newBtn.Image")));
            this.newBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(23, 22);
            this.newBtn.Text = "New";
            this.newBtn.Click += new System.EventHandler(this.newFile);
            // 
            // openBtn
            // 
            this.openBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openBtn.Image = ((System.Drawing.Image)(resources.GetObject("openBtn.Image")));
            this.openBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(23, 22);
            this.openBtn.Text = "Open";
            this.openBtn.Click += new System.EventHandler(this.openFile);
            // 
            // saveBtn
            // 
            this.saveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(23, 22);
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveFile);
            // 
            // saveAsBtn
            // 
            this.saveAsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAsBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveAsBtn.Image")));
            this.saveAsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsBtn.Name = "saveAsBtn";
            this.saveAsBtn.Size = new System.Drawing.Size(23, 22);
            this.saveAsBtn.Text = "Save As";
            this.saveAsBtn.Click += new System.EventHandler(this.saveAsFile);
            // 
            // toggleBoldBtn
            // 
            this.toggleBoldBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toggleBoldBtn.Image = ((System.Drawing.Image)(resources.GetObject("toggleBoldBtn.Image")));
            this.toggleBoldBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toggleBoldBtn.Name = "toggleBoldBtn";
            this.toggleBoldBtn.Size = new System.Drawing.Size(23, 22);
            this.toggleBoldBtn.Text = "Bold";
            this.toggleBoldBtn.Click += new System.EventHandler(this.toggleBold);
            // 
            // toggleItalicBtn
            // 
            this.toggleItalicBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toggleItalicBtn.Image = ((System.Drawing.Image)(resources.GetObject("toggleItalicBtn.Image")));
            this.toggleItalicBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toggleItalicBtn.Name = "toggleItalicBtn";
            this.toggleItalicBtn.Size = new System.Drawing.Size(23, 22);
            this.toggleItalicBtn.Text = "Italic";
            this.toggleItalicBtn.Click += new System.EventHandler(this.toggleItalic);
            // 
            // toggleUnderlineBtn
            // 
            this.toggleUnderlineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toggleUnderlineBtn.Image = ((System.Drawing.Image)(resources.GetObject("toggleUnderlineBtn.Image")));
            this.toggleUnderlineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toggleUnderlineBtn.Name = "toggleUnderlineBtn";
            this.toggleUnderlineBtn.Size = new System.Drawing.Size(23, 22);
            this.toggleUnderlineBtn.Text = "Underline";
            this.toggleUnderlineBtn.Click += new System.EventHandler(this.toggleUnderline);
            // 
            // fontSizeSelection
            // 
            this.fontSizeSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontSizeSelection.Items.AddRange(new object[] {
            "8 pt",
            "10 pt",
            "12 pt",
            "14 pt",
            "16 pt",
            "18 pt ",
            "20 pt"});
            this.fontSizeSelection.Name = "fontSizeSelection";
            this.fontSizeSelection.Size = new System.Drawing.Size(75, 25);
            this.fontSizeSelection.SelectedIndexChanged += new System.EventHandler(this.fontChange);
            // 
            // userNameDisplay
            // 
            this.userNameDisplay.Name = "userNameDisplay";
            this.userNameDisplay.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutLeftStrip,
            this.copyLeftStrip,
            this.pasteLeftStrip});
            this.toolStrip2.Location = new System.Drawing.Point(0, 49);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(24, 452);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // cutLeftStrip
            // 
            this.cutLeftStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutLeftStrip.Image = global::Assignment_2.Properties.Resources.if_clipboard_cut_42190;
            this.cutLeftStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutLeftStrip.Name = "cutLeftStrip";
            this.cutLeftStrip.Size = new System.Drawing.Size(21, 20);
            this.cutLeftStrip.Text = "Cut";
            this.cutLeftStrip.Click += new System.EventHandler(this.cutText);
            // 
            // copyLeftStrip
            // 
            this.copyLeftStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyLeftStrip.Image = global::Assignment_2.Properties.Resources.if_icon_ios7_copy_outline_2117321;
            this.copyLeftStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyLeftStrip.Name = "copyLeftStrip";
            this.copyLeftStrip.Size = new System.Drawing.Size(21, 20);
            this.copyLeftStrip.Text = "Copy";
            this.copyLeftStrip.Click += new System.EventHandler(this.copyText);
            // 
            // pasteLeftStrip
            // 
            this.pasteLeftStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteLeftStrip.Image = global::Assignment_2.Properties.Resources.if_paste_36718261;
            this.pasteLeftStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteLeftStrip.Name = "pasteLeftStrip";
            this.pasteLeftStrip.Size = new System.Drawing.Size(21, 20);
            this.pasteLeftStrip.Text = "Paste";
            this.pasteLeftStrip.Click += new System.EventHandler(this.pasteText);
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(27, 52);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ShowSelectionMargin = true;
            this.richTextBox.Size = new System.Drawing.Size(917, 449);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // Editor
            // 
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip2);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Editor";
            this.Text = "Text Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem dsaToolStripMenuItem;
        private ToolStripMenuItem dsaToolStripMenuItem1;
        private ToolStripMenuItem dsaToolStripMenuItem2;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newMenuStrip;
        private ToolStripMenuItem openMenuStrip;
        private ToolStripMenuItem saveMenuStrip;
        private ToolStripMenuItem saveAsMenuStrip;
        private ToolStripMenuItem logoutMenuStrip;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem cutTopStrip;
        private ToolStripMenuItem copyTopStrip;
        private ToolStripMenuItem pasteTopStrip;
        private ToolStripMenuItem aboutButton;
        private ToolStrip toolStrip1;
        private ToolStripButton newBtn;
        private ToolStripButton openBtn;
        private ToolStripButton saveBtn;
        private ToolStripButton saveAsBtn;
        private ToolStripButton toggleBoldBtn;
        private ToolStripButton toggleItalicBtn;
        private ToolStripButton toggleUnderlineBtn;
        private ToolStripComboBox fontSizeSelection;
        private ToolStripLabel userNameDisplay;
        private ToolStrip toolStrip2;
        private ToolStripButton cutLeftStrip;
        private ToolStripButton copyLeftStrip;
        private ToolStripButton pasteLeftStrip;
        private RichTextBox richTextBox;
    }
}