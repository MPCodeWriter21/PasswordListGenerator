using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace pass_maker.Forms
{
    public partial class SplitterForm : Form
    {
        public SplitterForm()
        {
            InitializeComponent();
        }

        private void Fix()
        {
            lblPasswordsCount.Visible = lblPasswordsCount.Enabled = txtPasswordsCount.Visible = txtPasswordsCount.Enabled = radioPasswordsCount.Checked;
            lblPartsCount.Visible = lblPartsCount.Enabled = txtPartsCount.Visible = txtPartsCount.Enabled = radioSplitPartsCount.Checked;
            if (radioPasswordsCount.Checked)
            {
                radioPasswordsCount.Top = 110;
            }
            else
            {
                radioPasswordsCount.Top = 133;
            }
            lblPasswordsCount.Top = radioPasswordsCount.Top + 26;
            txtPasswordsCount.Top = radioPasswordsCount.Top + 23;
        }

        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Filter = "Text Document|*.txt";
            openFD.Multiselect = false;
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    lblListCount.Text = File.ReadAllLines(openFD.FileName).Length.ToString();
                    txtInputPath.Text = openFD.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Couldn't open selected file:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFD = new SaveFileDialog();
            saveFD.Filter = "Text Document|*.txt|All Files|*.*";
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                txtOutputPath.Text = saveFD.FileName;
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).TextLength == 0)
                ((TextBox)sender).Text = "1";
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (e.KeyChar != '\b'))
                e.Handled = true;
        }

        private void linkLabelCodeWriter21_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://COdeWriter21.bloogsky.com");
        }

        private void splitterForm_Load(object sender, EventArgs e)
        {
            Fix();
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            Fix();
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            if (txtInputPath.Text == "" || txtOutputPath.Text == "")
            {
                MessageBox.Show("Please enter Input and Output path!!", "Where?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!File.Exists(txtInputPath.Text))
            {
                MessageBox.Show("The Input File doesn't exist any more!", "Where Is List?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<string> lst = File.ReadAllLines(txtInputPath.Text).ToList<string>();
            if (radioPasswordsCount.Checked)
            {
                try
                {
                    int splitCount = int.Parse(txtPasswordsCount.Text);
                    if (lst.Count <= splitCount)
                    {
                        MessageBox.Show("Can't split a list with " + lst.Count.ToString() + " lines to more parts with " + splitCount.ToString() + " lines!!", "Small Input or Big Parts?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        string p = txtOutputPath.Text;
                        int i = 1;
                        string path;
                        while (!(lst.Count <= splitCount))
                        {
                            List<string> tmp = lst.GetRange(splitCount, lst.Count - splitCount);
                            if (p.Contains(".") && p.LastIndexOf(".") > p.LastIndexOf("\\"))
                                path = p.Substring(0, p.LastIndexOf('.')) + " (" + i.ToString() + ")" + p.Substring(p.LastIndexOf('.'));
                            else
                                path = p + " (" + i.ToString() + ")";
                            File.WriteAllLines(path, lst.GetRange(0, splitCount));
                            lst = tmp;
                            i++;
                        }
                        if (p.Contains(".") && p.LastIndexOf(".") > p.LastIndexOf("\\"))
                            path = p.Substring(0, p.LastIndexOf('.')) + " (" + i.ToString() + ")" + p.Substring(p.LastIndexOf('.'));
                        else
                            path = p + " (" + i.ToString() + ")";
                        File.WriteAllLines(path, lst);
                        MessageBox.Show("List splitted to " + i.ToString() + " parts!", "Splitted!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Please enter a smaller number for Count Of Passwords in each file!", "Couldn't Split!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (radioSplitPartsCount.Checked)
            {
                try
                {
                    int splitCount = (lst.Count / int.Parse(txtPartsCount.Text)) == ((float)lst.Count / (float)int.Parse(txtPartsCount.Text)) ? (lst.Count / int.Parse(txtPartsCount.Text)) : (lst.Count / int.Parse(txtPartsCount.Text)) + 1;
                    if (lst.Count <= splitCount)
                    {
                        MessageBox.Show("Can't split a list with " + lst.Count.ToString() + " lines to more parts with " + splitCount.ToString() + " lines!!", "Small Input or Big Parts?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        string p = txtOutputPath.Text;
                        int i = 1;
                        string path;
                        while (!(lst.Count <= splitCount))
                        {
                            List<string> tmp = lst.GetRange(splitCount, lst.Count - splitCount);
                            if (p.Contains(".") && p.LastIndexOf(".") > p.LastIndexOf("\\"))
                                path = p.Substring(0, p.LastIndexOf('.')) + " (" + i.ToString() + ")" + p.Substring(p.LastIndexOf('.'));
                            else
                                path = p + " (" + i.ToString() + ")";
                            File.WriteAllLines(path, lst.GetRange(0, splitCount));
                            lst = tmp;
                            i++;
                        }
                        if (p.Contains(".") && p.LastIndexOf(".") > p.LastIndexOf("\\"))
                            path = p.Substring(0, p.LastIndexOf('.')) + " (" + i.ToString() + ")" + p.Substring(p.LastIndexOf('.'));
                        else
                            path = p + " (" + i.ToString() + ")";
                        File.WriteAllLines(path, lst);
                        MessageBox.Show("List splitted to " + i.ToString() + " parts with " + splitCount.ToString() + " lines!!", "Splitted!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Please enter a smaller number for Count Of Parts!", "Couldn't Split!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
