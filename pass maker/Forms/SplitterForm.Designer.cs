namespace pass_maker.Forms
{
    partial class SplitterForm
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
            this.txtInputPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseInput = new System.Windows.Forms.Button();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.radioSplitPartsCount = new System.Windows.Forms.RadioButton();
            this.lblPartsCount = new System.Windows.Forms.Label();
            this.txtPartsCount = new System.Windows.Forms.TextBox();
            this.radioPasswordsCount = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblListCount = new System.Windows.Forms.Label();
            this.lblPasswordsCount = new System.Windows.Forms.Label();
            this.txtPasswordsCount = new System.Windows.Forms.TextBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.linkLabelCodeWriter21 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtInputPath
            // 
            this.txtInputPath.Location = new System.Drawing.Point(85, 12);
            this.txtInputPath.Name = "txtInputPath";
            this.txtInputPath.ReadOnly = true;
            this.txtInputPath.Size = new System.Drawing.Size(265, 20);
            this.txtInputPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input List:";
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.Location = new System.Drawing.Point(356, 10);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseInput.TabIndex = 2;
            this.btnBrowseInput.Text = "Browse";
            this.btnBrowseInput.UseVisualStyleBackColor = true;
            this.btnBrowseInput.Click += new System.EventHandler(this.btnBrowseInput_Click);
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(85, 57);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.ReadOnly = true;
            this.txtOutputPath.Size = new System.Drawing.Size(265, 20);
            this.txtOutputPath.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output Path:";
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new System.Drawing.Point(356, 55);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOutput.TabIndex = 2;
            this.btnBrowseOutput.Text = "Browse";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // radioSplitPartsCount
            // 
            this.radioSplitPartsCount.AutoSize = true;
            this.radioSplitPartsCount.Checked = true;
            this.radioSplitPartsCount.Location = new System.Drawing.Point(15, 83);
            this.radioSplitPartsCount.Name = "radioSplitPartsCount";
            this.radioSplitPartsCount.Size = new System.Drawing.Size(126, 17);
            this.radioSplitPartsCount.TabIndex = 3;
            this.radioSplitPartsCount.TabStop = true;
            this.radioSplitPartsCount.Text = "Split By Cout Of Parts";
            this.radioSplitPartsCount.UseVisualStyleBackColor = true;
            this.radioSplitPartsCount.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // lblPartsCount
            // 
            this.lblPartsCount.AutoSize = true;
            this.lblPartsCount.Location = new System.Drawing.Point(16, 110);
            this.lblPartsCount.Name = "lblPartsCount";
            this.lblPartsCount.Size = new System.Drawing.Size(79, 13);
            this.lblPartsCount.TabIndex = 4;
            this.lblPartsCount.Text = "Count Of Parts:";
            // 
            // txtPartsCount
            // 
            this.txtPartsCount.Location = new System.Drawing.Point(101, 107);
            this.txtPartsCount.Name = "txtPartsCount";
            this.txtPartsCount.Size = new System.Drawing.Size(100, 20);
            this.txtPartsCount.TabIndex = 5;
            this.txtPartsCount.Text = "2";
            this.txtPartsCount.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtPartsCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // radioPasswordsCount
            // 
            this.radioPasswordsCount.AutoSize = true;
            this.radioPasswordsCount.Location = new System.Drawing.Point(15, 133);
            this.radioPasswordsCount.Name = "radioPasswordsCount";
            this.radioPasswordsCount.Size = new System.Drawing.Size(188, 17);
            this.radioPasswordsCount.TabIndex = 6;
            this.radioPasswordsCount.Text = "Split By Count Of Password In Part";
            this.radioPasswordsCount.UseVisualStyleBackColor = true;
            this.radioPasswordsCount.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Count:";
            // 
            // lblListCount
            // 
            this.lblListCount.AutoSize = true;
            this.lblListCount.Location = new System.Drawing.Point(126, 35);
            this.lblListCount.Name = "lblListCount";
            this.lblListCount.Size = new System.Drawing.Size(13, 13);
            this.lblListCount.TabIndex = 8;
            this.lblListCount.Text = "0";
            // 
            // lblPasswordsCount
            // 
            this.lblPasswordsCount.AutoSize = true;
            this.lblPasswordsCount.Location = new System.Drawing.Point(16, 159);
            this.lblPasswordsCount.Name = "lblPasswordsCount";
            this.lblPasswordsCount.Size = new System.Drawing.Size(106, 13);
            this.lblPasswordsCount.TabIndex = 4;
            this.lblPasswordsCount.Text = "Count Of Passwords:";
            // 
            // txtPasswordsCount
            // 
            this.txtPasswordsCount.Location = new System.Drawing.Point(128, 156);
            this.txtPasswordsCount.Name = "txtPasswordsCount";
            this.txtPasswordsCount.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordsCount.TabIndex = 5;
            this.txtPasswordsCount.Text = "2100";
            this.txtPasswordsCount.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtPasswordsCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(15, 154);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(416, 23);
            this.btnSplit.TabIndex = 11;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // linkLabelCodeWriter21
            // 
            this.linkLabelCodeWriter21.AutoSize = true;
            this.linkLabelCodeWriter21.Font = new System.Drawing.Font("Broadway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCodeWriter21.Location = new System.Drawing.Point(343, 88);
            this.linkLabelCodeWriter21.Name = "linkLabelCodeWriter21";
            this.linkLabelCodeWriter21.Size = new System.Drawing.Size(88, 12);
            this.linkLabelCodeWriter21.TabIndex = 12;
            this.linkLabelCodeWriter21.TabStop = true;
            this.linkLabelCodeWriter21.Text = "CodeWriter21";
            this.linkLabelCodeWriter21.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCodeWriter21_LinkClicked_1);
            // 
            // SplitterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 184);
            this.Controls.Add(this.linkLabelCodeWriter21);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.lblListCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioPasswordsCount);
            this.Controls.Add(this.txtPasswordsCount);
            this.Controls.Add(this.txtPartsCount);
            this.Controls.Add(this.lblPasswordsCount);
            this.Controls.Add(this.lblPartsCount);
            this.Controls.Add(this.radioSplitPartsCount);
            this.Controls.Add(this.btnBrowseOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseInput);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInputPath);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(459, 223);
            this.MinimumSize = new System.Drawing.Size(459, 223);
            this.Name = "SplitterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "splitterForm";
            this.Load += new System.EventHandler(this.splitterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseInput;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.RadioButton radioSplitPartsCount;
        private System.Windows.Forms.Label lblPartsCount;
        private System.Windows.Forms.TextBox txtPartsCount;
        private System.Windows.Forms.RadioButton radioPasswordsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblListCount;
        private System.Windows.Forms.Label lblPasswordsCount;
        private System.Windows.Forms.TextBox txtPasswordsCount;
        private System.Windows.Forms.Button btnSplit;
        public System.Windows.Forms.LinkLabel linkLabelCodeWriter21;
    }
}