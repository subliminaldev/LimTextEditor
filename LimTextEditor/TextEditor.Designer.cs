namespace LimTextEditor
{
    partial class TextEditor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveAsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.boldTopButton = new System.Windows.Forms.ToolStripButton();
            this.italicsTopToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.underlineTopToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.userNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.cutSideButton = new System.Windows.Forms.ToolStripButton();
            this.copySideToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteSideToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2313, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::LimTextEditor.Properties.Resources._new;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::LimTextEditor.Properties.Resources.open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::LimTextEditor.Properties.Resources.if_save_173091;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::LimTextEditor.Properties.Resources.document_save_as;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::LimTextEditor.Properties.Resources.gnome_logout;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(66, 34);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::LimTextEditor.Properties.Resources.if_clipboard_cut_42190;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(327, 52);
            this.cutToolStripMenuItem.Text = "Cut        Ctrl+X";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::LimTextEditor.Properties.Resources.if_icon_ios7_copy_outline_211732;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(327, 52);
            this.copyToolStripMenuItem.Text = "Copy     Ctrl+C";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::LimTextEditor.Properties.Resources.if_paste_3671826;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(327, 52);
            this.pasteToolStripMenuItem.Text = "Paste     Ctrl+V";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(74, 34);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::LimTextEditor.Properties.Resources.infoIcon;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.saveAsToolStripButton,
            this.toolStripSeparator3,
            this.boldTopButton,
            this.italicsTopToolStripButton,
            this.underlineTopToolStripButton,
            this.toolStripComboBox1,
            this.toolStripButton8,
            this.toolStripSeparator4,
            this.userNameToolStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(2313, 50);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewToolStripButton
            // 
            this.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewToolStripButton.Image = global::LimTextEditor.Properties.Resources.new1;
            this.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolStripButton.Name = "NewToolStripButton";
            this.NewToolStripButton.Size = new System.Drawing.Size(44, 44);
            this.NewToolStripButton.Text = "New File";
            this.NewToolStripButton.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = global::LimTextEditor.Properties.Resources.open;
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(44, 44);
            this.openToolStripButton.Text = "Open File";
            this.openToolStripButton.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = global::LimTextEditor.Properties.Resources.if_save_173091;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(44, 44);
            this.saveToolStripButton.Text = "Save File";
            this.saveToolStripButton.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripButton
            // 
            this.saveAsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAsToolStripButton.Image = global::LimTextEditor.Properties.Resources.document_save_as;
            this.saveAsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsToolStripButton.Name = "saveAsToolStripButton";
            this.saveAsToolStripButton.Size = new System.Drawing.Size(44, 44);
            this.saveAsToolStripButton.Text = "Save As";
            this.saveAsToolStripButton.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 50);
            // 
            // boldTopButton
            // 
            this.boldTopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldTopButton.Image = global::LimTextEditor.Properties.Resources.font_bold;
            this.boldTopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldTopButton.Name = "boldTopButton";
            this.boldTopButton.Size = new System.Drawing.Size(44, 44);
            this.boldTopButton.Text = "Bold";
            this.boldTopButton.Click += new System.EventHandler(this.BoldTopButton_Click);
            // 
            // italicsTopToolStripButton
            // 
            this.italicsTopToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicsTopToolStripButton.Image = global::LimTextEditor.Properties.Resources.font_italic;
            this.italicsTopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicsTopToolStripButton.Name = "italicsTopToolStripButton";
            this.italicsTopToolStripButton.Size = new System.Drawing.Size(44, 44);
            this.italicsTopToolStripButton.Text = "Italics";
            this.italicsTopToolStripButton.Click += new System.EventHandler(this.ItalicsTopToolStripButton_Click);
            // 
            // underlineTopToolStripButton
            // 
            this.underlineTopToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineTopToolStripButton.Image = global::LimTextEditor.Properties.Resources._105_underline;
            this.underlineTopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineTopToolStripButton.Name = "underlineTopToolStripButton";
            this.underlineTopToolStripButton.Size = new System.Drawing.Size(44, 44);
            this.underlineTopToolStripButton.Text = "Underline";
            this.underlineTopToolStripButton.Click += new System.EventHandler(this.UnderlineTopToolStripButton_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(134, 50);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::LimTextEditor.Properties.Resources.infoIcon;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(44, 44);
            this.toolStripButton8.Text = "toolStripButton8";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 50);
            // 
            // userNameToolStripLabel
            // 
            this.userNameToolStripLabel.Name = "userNameToolStripLabel";
            this.userNameToolStripLabel.Size = new System.Drawing.Size(111, 44);
            this.userNameToolStripLabel.Text = "Username:";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutSideButton,
            this.copySideToolStripButton,
            this.pasteSideToolStripButton});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(0, 88);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip2.Size = new System.Drawing.Size(54, 1498);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // cutSideButton
            // 
            this.cutSideButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutSideButton.Image = global::LimTextEditor.Properties.Resources.if_clipboard_cut_42190;
            this.cutSideButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutSideButton.Name = "cutSideButton";
            this.cutSideButton.Size = new System.Drawing.Size(53, 44);
            this.cutSideButton.Text = "Cut";
            this.cutSideButton.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // copySideToolStripButton
            // 
            this.copySideToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copySideToolStripButton.Image = global::LimTextEditor.Properties.Resources.if_icon_ios7_copy_outline_211732;
            this.copySideToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copySideToolStripButton.Name = "copySideToolStripButton";
            this.copySideToolStripButton.Size = new System.Drawing.Size(53, 44);
            this.copySideToolStripButton.Text = "Copy";
            this.copySideToolStripButton.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteSideToolStripButton
            // 
            this.pasteSideToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteSideToolStripButton.Image = global::LimTextEditor.Properties.Resources.if_paste_3671826;
            this.pasteSideToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteSideToolStripButton.Name = "pasteSideToolStripButton";
            this.pasteSideToolStripButton.Size = new System.Drawing.Size(53, 44);
            this.pasteSideToolStripButton.Text = "Paste";
            this.pasteSideToolStripButton.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // mainRichTextBox
            // 
            this.mainRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.mainRichTextBox.Location = new System.Drawing.Point(82, 133);
            this.mainRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.mainRichTextBox.Name = "mainRichTextBox";
            this.mainRichTextBox.Size = new System.Drawing.Size(3103, 2428);
            this.mainRichTextBox.TabIndex = 3;
            this.mainRichTextBox.Text = "";
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2313, 1586);
            this.Controls.Add(this.mainRichTextBox);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TextEditor";
            this.Text = "Lim Text Editor";
            this.Load += new System.EventHandler(this.TextEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton saveAsToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton boldTopButton;
        private System.Windows.Forms.ToolStripButton italicsTopToolStripButton;
        private System.Windows.Forms.ToolStripButton underlineTopToolStripButton;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel userNameToolStripLabel;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton cutSideButton;
        private System.Windows.Forms.ToolStripButton copySideToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteSideToolStripButton;
        private System.Windows.Forms.RichTextBox mainRichTextBox;
    }
}