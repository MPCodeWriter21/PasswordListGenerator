
namespace pass_maker.Forms
{
    partial class AddingWordsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblNewWords = new System.Windows.Forms.Label();
            this.lblTotalWords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInputWords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Words:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "New Words:";
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancel.Location = new System.Drawing.Point(0, 120);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(248, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(12, 93);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(16, 13);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "...";
            // 
            // lblNewWords
            // 
            this.lblNewWords.AutoSize = true;
            this.lblNewWords.Location = new System.Drawing.Point(86, 37);
            this.lblNewWords.Name = "lblNewWords";
            this.lblNewWords.Size = new System.Drawing.Size(13, 13);
            this.lblNewWords.TabIndex = 0;
            this.lblNewWords.Text = "0";
            // 
            // lblTotalWords
            // 
            this.lblTotalWords.AutoSize = true;
            this.lblTotalWords.Location = new System.Drawing.Point(86, 65);
            this.lblTotalWords.Name = "lblTotalWords";
            this.lblTotalWords.Size = new System.Drawing.Size(13, 13);
            this.lblTotalWords.TabIndex = 0;
            this.lblTotalWords.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Words:";
            // 
            // lblInputWords
            // 
            this.lblInputWords.AutoSize = true;
            this.lblInputWords.Location = new System.Drawing.Point(86, 9);
            this.lblInputWords.Name = "lblInputWords";
            this.lblInputWords.Size = new System.Drawing.Size(13, 13);
            this.lblInputWords.TabIndex = 0;
            this.lblInputWords.Text = "0";
            // 
            // AddingWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 143);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblTotalWords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblInputWords);
            this.Controls.Add(this.lblNewWords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(264, 182);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(264, 182);
            this.Name = "AddingWordsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding Words...";
            this.LocationChanged += new System.EventHandler(this.AddingWordsForm_LocationChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblWord;
        public System.Windows.Forms.Label lblNewWords;
        public System.Windows.Forms.Label lblTotalWords;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblInputWords;
    }
}