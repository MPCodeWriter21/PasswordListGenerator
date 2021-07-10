namespace pass_maker.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.richTxtWords = new System.Windows.Forms.RichTextBox();
            this.richTxtMethods1 = new System.Windows.Forms.RichTextBox();
            this.richTxtResults = new System.Windows.Forms.RichTextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.richTxtMethods2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chboxMultiThread = new System.Windows.Forms.CheckBox();
            this.linkLabelCodeWriter21 = new System.Windows.Forms.LinkLabel();
            this.chboxFilterLength = new System.Windows.Forms.CheckBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.txtMinLength = new System.Windows.Forms.TextBox();
            this.txtMaxLength = new System.Windows.Forms.TextBox();
            this.lblMaxThread = new System.Windows.Forms.Label();
            this.txtMaxThread = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWordListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.splitAListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyPasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutPasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telegramChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chboxSplitList = new System.Windows.Forms.CheckBox();
            this.lblSplitCount = new System.Windows.Forms.Label();
            this.txtMaxPassCount = new System.Windows.Forms.TextBox();
            this.lblMaxPassCount = new System.Windows.Forms.Label();
            this.chboxLimitMaxPassCount = new System.Windows.Forms.CheckBox();
            this.txtPartCount = new System.Windows.Forms.TextBox();
            this.btnAddWords = new System.Windows.Forms.Button();
            this.lblResultsCount = new System.Windows.Forms.Label();
            this.lblWordsCount = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTxtWords
            // 
            this.richTxtWords.Location = new System.Drawing.Point(13, 66);
            this.richTxtWords.Name = "richTxtWords";
            this.richTxtWords.Size = new System.Drawing.Size(280, 280);
            this.richTxtWords.TabIndex = 0;
            this.richTxtWords.Text = "";
            this.richTxtWords.TextChanged += new System.EventHandler(this.richTxtWords_TextChanged);
            // 
            // richTxtMethods1
            // 
            this.richTxtMethods1.Location = new System.Drawing.Point(299, 66);
            this.richTxtMethods1.Name = "richTxtMethods1";
            this.richTxtMethods1.Size = new System.Drawing.Size(236, 280);
            this.richTxtMethods1.TabIndex = 1;
            this.richTxtMethods1.Text = resources.GetString("richTxtMethods1.Text");
            // 
            // richTxtResults
            // 
            this.richTxtResults.Location = new System.Drawing.Point(541, 66);
            this.richTxtResults.Name = "richTxtResults";
            this.richTxtResults.ReadOnly = true;
            this.richTxtResults.Size = new System.Drawing.Size(256, 388);
            this.richTxtResults.TabIndex = 2;
            this.richTxtResults.Text = "";
            this.richTxtResults.TextChanged += new System.EventHandler(this.richTxtResults_TextChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(541, 468);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(256, 30);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // richTxtMethods2
            // 
            this.richTxtMethods2.Location = new System.Drawing.Point(299, 352);
            this.richTxtMethods2.Name = "richTxtMethods2";
            this.richTxtMethods2.Size = new System.Drawing.Size(236, 146);
            this.richTxtMethods2.TabIndex = 4;
            this.richTxtMethods2.Text = "!\n@\n#\n$\n%\n.\n_\n*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Words:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Methods:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Results(for short lists):";
            // 
            // chboxMultiThread
            // 
            this.chboxMultiThread.AutoSize = true;
            this.chboxMultiThread.Checked = true;
            this.chboxMultiThread.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chboxMultiThread.Location = new System.Drawing.Point(12, 356);
            this.chboxMultiThread.Name = "chboxMultiThread";
            this.chboxMultiThread.Size = new System.Drawing.Size(85, 17);
            this.chboxMultiThread.TabIndex = 8;
            this.chboxMultiThread.Text = "Multi Thread";
            this.chboxMultiThread.UseVisualStyleBackColor = true;
            this.chboxMultiThread.CheckedChanged += new System.EventHandler(this.chboxMultiThread_CheckedChanged);
            // 
            // linkLabelCodeWriter21
            // 
            this.linkLabelCodeWriter21.AutoSize = true;
            this.linkLabelCodeWriter21.Font = new System.Drawing.Font("Broadway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCodeWriter21.Location = new System.Drawing.Point(709, 41);
            this.linkLabelCodeWriter21.Name = "linkLabelCodeWriter21";
            this.linkLabelCodeWriter21.Size = new System.Drawing.Size(88, 12);
            this.linkLabelCodeWriter21.TabIndex = 9;
            this.linkLabelCodeWriter21.TabStop = true;
            this.linkLabelCodeWriter21.Text = "CodeWriter21";
            this.linkLabelCodeWriter21.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCodeWriter21_LinkClicked);
            // 
            // chboxFilterLength
            // 
            this.chboxFilterLength.AutoSize = true;
            this.chboxFilterLength.Location = new System.Drawing.Point(143, 354);
            this.chboxFilterLength.Name = "chboxFilterLength";
            this.chboxFilterLength.Size = new System.Drawing.Size(84, 17);
            this.chboxFilterLength.TabIndex = 10;
            this.chboxFilterLength.Text = "Filter Length";
            this.chboxFilterLength.UseVisualStyleBackColor = true;
            this.chboxFilterLength.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Enabled = false;
            this.lblMin.Location = new System.Drawing.Point(139, 380);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(63, 13);
            this.lblMin.TabIndex = 11;
            this.lblMin.Text = "Min Length:";
            this.lblMin.Visible = false;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Enabled = false;
            this.lblMax.Location = new System.Drawing.Point(140, 406);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(66, 13);
            this.lblMax.TabIndex = 11;
            this.lblMax.Text = "Max Length:";
            this.lblMax.Visible = false;
            // 
            // txtMinLength
            // 
            this.txtMinLength.Enabled = false;
            this.txtMinLength.Location = new System.Drawing.Point(208, 377);
            this.txtMinLength.Name = "txtMinLength";
            this.txtMinLength.Size = new System.Drawing.Size(84, 20);
            this.txtMinLength.TabIndex = 12;
            this.txtMinLength.Text = "1";
            this.txtMinLength.Visible = false;
            this.txtMinLength.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtMinLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtMaxLength
            // 
            this.txtMaxLength.Enabled = false;
            this.txtMaxLength.Location = new System.Drawing.Point(208, 403);
            this.txtMaxLength.Name = "txtMaxLength";
            this.txtMaxLength.Size = new System.Drawing.Size(84, 20);
            this.txtMaxLength.TabIndex = 12;
            this.txtMaxLength.Text = "1";
            this.txtMaxLength.Visible = false;
            this.txtMaxLength.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtMaxLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lblMaxThread
            // 
            this.lblMaxThread.AutoSize = true;
            this.lblMaxThread.Location = new System.Drawing.Point(8, 380);
            this.lblMaxThread.Name = "lblMaxThread";
            this.lblMaxThread.Size = new System.Drawing.Size(72, 13);
            this.lblMaxThread.TabIndex = 11;
            this.lblMaxThread.Text = "Max Threads:";
            // 
            // txtMaxThread
            // 
            this.txtMaxThread.Location = new System.Drawing.Point(11, 403);
            this.txtMaxThread.Name = "txtMaxThread";
            this.txtMaxThread.Size = new System.Drawing.Size(84, 20);
            this.txtMaxThread.TabIndex = 12;
            this.txtMaxThread.Text = "21";
            this.txtMaxThread.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtMaxThread.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWordListToolStripMenuItem,
            this.toolStripMenuItem1,
            this.splitAListToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openWordListToolStripMenuItem
            // 
            this.openWordListToolStripMenuItem.Name = "openWordListToolStripMenuItem";
            this.openWordListToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.openWordListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openWordListToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.openWordListToolStripMenuItem.Text = "Open Word List";
            this.openWordListToolStripMenuItem.ToolTipText = "You can import a wordlist from a text document!";
            this.openWordListToolStripMenuItem.Click += new System.EventHandler(this.openWordListToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(198, 6);
            // 
            // splitAListToolStripMenuItem
            // 
            this.splitAListToolStripMenuItem.Name = "splitAListToolStripMenuItem";
            this.splitAListToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.splitAListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.splitAListToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.splitAListToolStripMenuItem.Text = "Split A List";
            this.splitAListToolStripMenuItem.ToolTipText = "You can split a password list/combo to more parts!";
            this.splitAListToolStripMenuItem.Click += new System.EventHandler(this.splitAListToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(198, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Exits";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyPasswordsToolStripMenuItem,
            this.cutPasswordsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.copyWordsToolStripMenuItem,
            this.cutWordsToolStripMenuItem,
            this.pasteWordsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyPasswordsToolStripMenuItem
            // 
            this.copyPasswordsToolStripMenuItem.Name = "copyPasswordsToolStripMenuItem";
            this.copyPasswordsToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.copyPasswordsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.copyPasswordsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.copyPasswordsToolStripMenuItem.Text = "Copy Passwords";
            this.copyPasswordsToolStripMenuItem.ToolTipText = "Copies the passwords in results box";
            this.copyPasswordsToolStripMenuItem.Click += new System.EventHandler(this.copyPasswordsToolStripMenuItem_Click);
            // 
            // cutPasswordsToolStripMenuItem
            // 
            this.cutPasswordsToolStripMenuItem.Name = "cutPasswordsToolStripMenuItem";
            this.cutPasswordsToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.cutPasswordsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.cutPasswordsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.cutPasswordsToolStripMenuItem.Text = "Cut Passwords";
            this.cutPasswordsToolStripMenuItem.ToolTipText = "Cuts the passwords in results box";
            this.cutPasswordsToolStripMenuItem.Click += new System.EventHandler(this.cutPasswordsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(222, 6);
            // 
            // copyWordsToolStripMenuItem
            // 
            this.copyWordsToolStripMenuItem.Name = "copyWordsToolStripMenuItem";
            this.copyWordsToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.copyWordsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.copyWordsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.copyWordsToolStripMenuItem.Text = "Copy Words";
            this.copyWordsToolStripMenuItem.Click += new System.EventHandler(this.copyWordsToolStripMenuItem_Click);
            // 
            // cutWordsToolStripMenuItem
            // 
            this.cutWordsToolStripMenuItem.Name = "cutWordsToolStripMenuItem";
            this.cutWordsToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.cutWordsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.cutWordsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.cutWordsToolStripMenuItem.Text = "Cut Words";
            this.cutWordsToolStripMenuItem.Click += new System.EventHandler(this.cutWordsToolStripMenuItem_Click);
            // 
            // pasteWordsToolStripMenuItem
            // 
            this.pasteWordsToolStripMenuItem.Name = "pasteWordsToolStripMenuItem";
            this.pasteWordsToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.pasteWordsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.pasteWordsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.pasteWordsToolStripMenuItem.Text = "Paste Words";
            this.pasteWordsToolStripMenuItem.Click += new System.EventHandler(this.pasteWordsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blogToolStripMenuItem,
            this.telegramChannelToolStripMenuItem,
            this.supportUsToolStripMenuItem,
            this.toolStripMenuItem4,
            this.gitHubToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // blogToolStripMenuItem
            // 
            this.blogToolStripMenuItem.Name = "blogToolStripMenuItem";
            this.blogToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.blogToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.blogToolStripMenuItem.Text = "Blog";
            this.blogToolStripMenuItem.Click += new System.EventHandler(this.blogToolStripMenuItem_Click);
            // 
            // telegramChannelToolStripMenuItem
            // 
            this.telegramChannelToolStripMenuItem.Name = "telegramChannelToolStripMenuItem";
            this.telegramChannelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.telegramChannelToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.telegramChannelToolStripMenuItem.Text = "Telegram Channel";
            this.telegramChannelToolStripMenuItem.Click += new System.EventHandler(this.telegramChannelToolStripMenuItem_Click);
            // 
            // supportUsToolStripMenuItem
            // 
            this.supportUsToolStripMenuItem.Enabled = false;
            this.supportUsToolStripMenuItem.Name = "supportUsToolStripMenuItem";
            this.supportUsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.supportUsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.supportUsToolStripMenuItem.Text = "Support Us";
            this.supportUsToolStripMenuItem.Click += new System.EventHandler(this.supportUsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(206, 6);
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.gitHubToolStripMenuItem_Click);
            // 
            // chboxSplitList
            // 
            this.chboxSplitList.AutoSize = true;
            this.chboxSplitList.Checked = true;
            this.chboxSplitList.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chboxSplitList.Location = new System.Drawing.Point(13, 437);
            this.chboxSplitList.Name = "chboxSplitList";
            this.chboxSplitList.Size = new System.Drawing.Size(65, 17);
            this.chboxSplitList.TabIndex = 8;
            this.chboxSplitList.Text = "Split List";
            this.chboxSplitList.UseVisualStyleBackColor = true;
            this.chboxSplitList.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // lblSplitCount
            // 
            this.lblSplitCount.AutoSize = true;
            this.lblSplitCount.Location = new System.Drawing.Point(9, 461);
            this.lblSplitCount.Name = "lblSplitCount";
            this.lblSplitCount.Size = new System.Drawing.Size(88, 13);
            this.lblSplitCount.TabIndex = 11;
            this.lblSplitCount.Text = "Each Part Count:";
            // 
            // txtMaxPassCount
            // 
            this.txtMaxPassCount.Enabled = false;
            this.txtMaxPassCount.Location = new System.Drawing.Point(142, 484);
            this.txtMaxPassCount.Name = "txtMaxPassCount";
            this.txtMaxPassCount.Size = new System.Drawing.Size(84, 20);
            this.txtMaxPassCount.TabIndex = 16;
            this.txtMaxPassCount.Text = "21000";
            this.txtMaxPassCount.Visible = false;
            this.txtMaxPassCount.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtMaxPassCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lblMaxPassCount
            // 
            this.lblMaxPassCount.AutoSize = true;
            this.lblMaxPassCount.Enabled = false;
            this.lblMaxPassCount.Location = new System.Drawing.Point(139, 461);
            this.lblMaxPassCount.Name = "lblMaxPassCount";
            this.lblMaxPassCount.Size = new System.Drawing.Size(103, 13);
            this.lblMaxPassCount.TabIndex = 15;
            this.lblMaxPassCount.Text = "Max PassList Count:";
            this.lblMaxPassCount.Visible = false;
            // 
            // chboxLimitMaxPassCount
            // 
            this.chboxLimitMaxPassCount.AutoSize = true;
            this.chboxLimitMaxPassCount.Location = new System.Drawing.Point(143, 437);
            this.chboxLimitMaxPassCount.Name = "chboxLimitMaxPassCount";
            this.chboxLimitMaxPassCount.Size = new System.Drawing.Size(132, 17);
            this.chboxLimitMaxPassCount.TabIndex = 14;
            this.chboxLimitMaxPassCount.Text = "Limit Passwords Count";
            this.chboxLimitMaxPassCount.UseVisualStyleBackColor = true;
            this.chboxLimitMaxPassCount.CheckedChanged += new System.EventHandler(this.chboxMaxPassCount_CheckedChanged);
            // 
            // txtPartCount
            // 
            this.txtPartCount.Location = new System.Drawing.Point(11, 484);
            this.txtPartCount.Name = "txtPartCount";
            this.txtPartCount.Size = new System.Drawing.Size(84, 20);
            this.txtPartCount.TabIndex = 17;
            this.txtPartCount.Text = "2100";
            this.txtPartCount.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtPartCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // btnAddWords
            // 
            this.btnAddWords.Location = new System.Drawing.Point(336, 468);
            this.btnAddWords.Name = "btnAddWords";
            this.btnAddWords.Size = new System.Drawing.Size(150, 30);
            this.btnAddWords.TabIndex = 18;
            this.btnAddWords.Text = "Add Words";
            this.btnAddWords.UseVisualStyleBackColor = true;
            this.btnAddWords.Click += new System.EventHandler(this.btnAddWords_Click);
            // 
            // lblResultsCount
            // 
            this.lblResultsCount.AutoSize = true;
            this.lblResultsCount.Location = new System.Drawing.Point(653, 41);
            this.lblResultsCount.Name = "lblResultsCount";
            this.lblResultsCount.Size = new System.Drawing.Size(0, 13);
            this.lblResultsCount.TabIndex = 19;
            // 
            // lblWordsCount
            // 
            this.lblWordsCount.AutoSize = true;
            this.lblWordsCount.Location = new System.Drawing.Point(60, 41);
            this.lblWordsCount.Name = "lblWordsCount";
            this.lblWordsCount.Size = new System.Drawing.Size(0, 13);
            this.lblWordsCount.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 512);
            this.Controls.Add(this.lblWordsCount);
            this.Controls.Add(this.lblResultsCount);
            this.Controls.Add(this.btnAddWords);
            this.Controls.Add(this.txtPartCount);
            this.Controls.Add(this.txtMaxPassCount);
            this.Controls.Add(this.lblMaxPassCount);
            this.Controls.Add(this.chboxLimitMaxPassCount);
            this.Controls.Add(this.txtMaxThread);
            this.Controls.Add(this.lblSplitCount);
            this.Controls.Add(this.txtMaxLength);
            this.Controls.Add(this.txtMinLength);
            this.Controls.Add(this.lblMaxThread);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.chboxSplitList);
            this.Controls.Add(this.chboxFilterLength);
            this.Controls.Add(this.linkLabelCodeWriter21);
            this.Controls.Add(this.chboxMultiThread);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTxtMethods2);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.richTxtResults);
            this.Controls.Add(this.richTxtMethods1);
            this.Controls.Add(this.richTxtWords);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(825, 551);
            this.MinimumSize = new System.Drawing.Size(825, 551);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password List Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWordListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem splitAListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.RichTextBox richTxtWords;
        public System.Windows.Forms.RichTextBox richTxtMethods1;
        public System.Windows.Forms.RichTextBox richTxtResults;
        public System.Windows.Forms.Button btnGenerate;
        public System.Windows.Forms.RichTextBox richTxtMethods2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckBox chboxMultiThread;
        public System.Windows.Forms.LinkLabel linkLabelCodeWriter21;
        public System.Windows.Forms.CheckBox chboxFilterLength;
        public System.Windows.Forms.Label lblMin;
        public System.Windows.Forms.Label lblMax;
        public System.Windows.Forms.TextBox txtMinLength;
        public System.Windows.Forms.TextBox txtMaxLength;
        public System.Windows.Forms.Label lblMaxThread;
        public System.Windows.Forms.TextBox txtMaxThread;
        public System.Windows.Forms.CheckBox chboxSplitList;
        public System.Windows.Forms.Label lblSplitCount;
        public System.Windows.Forms.TextBox txtMaxPassCount;
        public System.Windows.Forms.Label lblMaxPassCount;
        public System.Windows.Forms.CheckBox chboxLimitMaxPassCount;
        public System.Windows.Forms.TextBox txtPartCount;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportUsToolStripMenuItem;
        private System.Windows.Forms.Button btnAddWords;
        private System.Windows.Forms.Label lblResultsCount;
        private System.Windows.Forms.Label lblWordsCount;
        private System.Windows.Forms.ToolStripMenuItem copyPasswordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutPasswordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem copyWordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutWordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteWordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telegramChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
    }
}

