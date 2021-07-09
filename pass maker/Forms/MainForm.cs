using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace pass_maker.Forms
{
    public partial class MainForm : Form
    {
        ProgressForm progressForm = new ProgressForm();
        AddingWordsForm addingWordsForm = new AddingWordsForm();
        List<string> resultList = new List<string>();
        string[] methods = new string[0];
        string[] methods2 = new string[0];
        public int maxThread = 21;

        public MainForm()
        {
            InitializeComponent();
        }

        private void loadSettings()
        {
            var txtMinLengthText = Properties.Settings.Default.min.ToString();
            var txtMaxLengthText = Properties.Settings.Default.max.ToString();
            var richTxtWordsText = Properties.Settings.Default.words;
            var chboxMultiThreadChecked = Properties.Settings.Default.multiThread;
            var chboxLimitMaxPassCountChecked = Properties.Settings.Default.limitCount;
            var txtMaxPassCountText = Properties.Settings.Default.maxCount.ToString();
            var txtPartCountText = Properties.Settings.Default.splitCount.ToString();
            var chboxSplitListChecked = Properties.Settings.Default.split;
            var chboxFilterLengthChecked = Properties.Settings.Default.filterLength;
            maxThread = Properties.Settings.Default.maxThread;
            var txtMaxThreadText = Properties.Settings.Default.maxThread.ToString();

            txtMinLength.Text = txtMinLengthText;
            txtMaxLength.Text = txtMaxLengthText;
            richTxtWords.Text = richTxtWordsText;
            chboxMultiThread.Checked = chboxMultiThreadChecked;
            chboxLimitMaxPassCount.Checked = chboxLimitMaxPassCountChecked;
            txtMaxPassCount.Text = txtMaxPassCountText;
            txtPartCount.Text = txtPartCountText;
            chboxSplitList.Checked = chboxSplitListChecked;
            chboxFilterLength.Checked = chboxFilterLengthChecked;
            txtMaxThread.Text = txtMaxThreadText;
        }

        private void saveSettings()
        {
            Properties.Settings.Default.min = int.Parse(txtMinLength.Text);
            Properties.Settings.Default.max = int.Parse(txtMaxLength.Text);
            Properties.Settings.Default.words = richTxtWords.Text;
            string x = Properties.Settings.Default.words;
            Properties.Settings.Default.multiThread = chboxMultiThread.Checked;
            Properties.Settings.Default.limitCount = chboxLimitMaxPassCount.Checked;
            Properties.Settings.Default.maxCount = int.Parse(txtMaxPassCount.Text);
            Properties.Settings.Default.splitCount = int.Parse(txtPartCount.Text);
            Properties.Settings.Default.split = chboxSplitList.Checked;
            Properties.Settings.Default.filterLength = chboxFilterLength.Checked;
            Properties.Settings.Default.maxThread = maxThread;
            Properties.Settings.Default.Save();
        }

        private void fixRight()
        {
            if (chboxFilterLength.Checked || chboxLimitMaxPassCount.Checked)
            {
                btnAddWords.Top = 468;
            }
            if (linkLabelCodeWriter21.Location.Equals(new Point(8, 431)) && Height == 498)
            {
                linkLabelCodeWriter21.Location = new Point(12, 477);
            }
            if (!chboxFilterLength.Checked)
            {
                chboxLimitMaxPassCount.Top = 377;
            }
            else
            {
                chboxLimitMaxPassCount.Top = 437;
                if (linkLabelCodeWriter21.Location.Equals(new Point(140, 477)) && chboxLimitMaxPassCount.Checked)
                {
                    linkLabelCodeWriter21.Location = new Point(709, 41);
                }
            }
            if (linkLabelCodeWriter21.Location.Equals(new Point(709, 41)) && (!chboxLimitMaxPassCount.Checked || !chboxFilterLength.Checked))
            {
                linkLabelCodeWriter21.Location = new Point(140, 477);
            }
            lblMaxPassCount.Top = chboxLimitMaxPassCount.Top + 24;
            txtMaxPassCount.Top = lblMaxPassCount.Top + 23;
            if ((!chboxFilterLength.Checked) || (!chboxLimitMaxPassCount.Checked))
            {
                btnAddWords.Left = 143;
                if (linkLabelCodeWriter21.Left == 12)
                    btnAddWords.Top = 468;
                else if ((!chboxFilterLength.Checked) && (!chboxLimitMaxPassCount.Checked))
                    btnAddWords.Top = chboxLimitMaxPassCount.Top + 24;
                else if (linkLabelCodeWriter21.Left == 140)
                {
                    btnAddWords.Left = 336;
                    btnAddWords.Top = 468;
                }
            }
            if (chboxFilterLength.Checked && chboxLimitMaxPassCount.Checked)
            {
                btnAddWords.Left = 336;
                btnAddWords.Top = 468;
            }
            if (!chboxFilterLength.Checked && !chboxLimitMaxPassCount.Checked && !chboxMultiThread.Checked && !chboxSplitList.Checked)
            {
                MaximumSize = new Size(825, 498);
                MinimumSize = new Size(825, 498);
                richTxtResults.Height = 353;
                button1.Top = 424;
                btnAddWords.Top = 424;
                linkLabelCodeWriter21.Location = new Point(8, 431);
                richTxtMethods2.Height = 102;
            }
            else
            {
                MaximumSize = new Size(825, 551);
                MinimumSize = new Size(825, 551);
                richTxtResults.Height = 388;
                button1.Top = 468;
                if (!btnAddWords.Location.Equals(new Point(336, 468)))
                    richTxtMethods2.Height = 146;
                else
                    richTxtMethods2.Height = 102;
            }
        }

        private void fixLeft()
        {
            if (!chboxMultiThread.Checked)
            {
                chboxSplitList.Top = 377;
                linkLabelCodeWriter21.Location = new Point(12, 477);
            }
            else
            {
                chboxSplitList.Top = 437;
                if (chboxSplitList.Checked)
                {
                    linkLabelCodeWriter21.Location = new Point(140, 477);
                }
            }
            if (!chboxSplitList.Checked)
                linkLabelCodeWriter21.Location = new Point(12, 477);
            lblSplitCount.Top = chboxSplitList.Top + 24;
            txtPartCount.Top = lblSplitCount.Top + 23;
            fixRight();
        }

        private void AddWords()
        {
            string[] words = new string[0];
            Invoke(new Action(() =>
            {
                words = richTxtWords.Lines;
                Enabled = false;
                addingWordsForm = new AddingWordsForm();
                addingWordsForm.Owner = this;
                addingWordsForm.lblInputWords.Text = words.Length.ToString();
                addingWordsForm.Show();
            }));
            List<string> output = words.ToList();
            foreach (string word in words)
            {
                string tmp = word.ToLower();
                if (!output.Contains(tmp))
                    output.Add(tmp);
                tmp = word.ToUpper();
                if (!output.Contains(tmp))
                    output.Add(tmp);
                if (word.Length > 0)
                {
                    tmp = word[0].ToString().ToUpper() + word.Substring(1).ToLower();
                    if (!output.Contains(tmp))
                        output.Add(tmp);
                }
                Invoke(new Action(() =>
                {
                    addingWordsForm.lblNewWords.Text = (output.Count - words.Length).ToString();
                    addingWordsForm.lblTotalWords.Text = output.Count.ToString();
                    addingWordsForm.lblWord.Text = tmp;
                }));
                if (addingWordsForm.cancel)
                    break;
            }
            string[] chs = new string[] { "a:@", "a:4", "A:@", "A:4", "s:$", "S:$", "i:!", "i:1", "i:l", "i:I", "I:!", "I:1", "I:l", "I:i", "l:!", "l:1", "l:i", "l:I", "1:!", "1:i", "1:l", "1:I", "g:9", "G:6", "o:0", "O:0", "E:3", "e:3", "0:O", "0:o", "3:E", "4:A", "5:S", "5:s", "s:5", "S:5" };
            foreach (string i in chs)
            {
                string a = i.Split(':')[0];
                string b = i.Split(':')[1];
                string tmp = "";
                foreach (string word in output.ToArray())
                {
                    tmp = word.Replace(a, b);
                    if (!output.Contains(tmp))
                        output.Add(tmp);
                    if (addingWordsForm.cancel)
                        break;
                    Invoke(new Action(() =>
                    {
                        addingWordsForm.lblNewWords.Text = (output.Count - words.Length).ToString();
                        addingWordsForm.lblTotalWords.Text = output.Count.ToString();
                        addingWordsForm.lblWord.Text = tmp;
                    }));
                }
                if (addingWordsForm.cancel)
                    break;
            }
            Invoke(new Action(() =>
            {
                richTxtWords.Lines = output.ToArray();
                Enabled = true;
                addingWordsForm.Close();
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTxtWords.Text == "")
            {
                MessageBox.Show("Please enter some words to generate passwords!!", "No Word?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Thread t = new Thread(Start);
            t.Start();
        }

        private void Generate(object obj)
        {
            string word = (string)obj;

            bool limitCount = false;
            int maxCount = 0;
            Invoke(new Action(() =>
            {
                limitCount = chboxLimitMaxPassCount.Checked;
                maxCount = int.Parse(txtMaxPassCount.Text);
            }));
            foreach (string method in methods)
            {
                if (!resultList.Contains(word))
                    resultList.Add(word);
                if (!resultList.Contains(word + method))
                    resultList.Add(word + method);
                if (!resultList.Contains(method + word))
                    resultList.Add(method + word);
                foreach (string method2 in methods2)
                {
                    if (!resultList.Contains(word + method2 + method))
                        resultList.Add(word + method2 + method);
                    if (!resultList.Contains(word + method + method2))
                        resultList.Add(word + method + method2);

                    if (!resultList.Contains(method + method2 + word))
                        resultList.Add(method + method2 + word);
                    if (!resultList.Contains(method + word + method2))
                        resultList.Add(method + word + method2);

                    if (!resultList.Contains(method2 + word + method))
                        resultList.Add(method2 + word + method);
                    if (!resultList.Contains(method2 + method + word))
                        resultList.Add(method2 + method + word);

                    if (!resultList.Contains(method2 + word))
                        resultList.Add(method2 + word);
                    if (!resultList.Contains(word + method2))
                        resultList.Add(word + method2);
                }
                Invoke(new Action(() =>
                {
                    progressForm.lblCount.Text = resultList.Count.ToString();
                }));
                if (progressForm.cancel || (limitCount && resultList.Count >= maxCount))
                    break;
            }
        }

        private void Start()
        {
            try
            {
                List<string> Words = new List<string>();
                methods = new string[0];
                methods2 = new string[0];
                bool multiThread = true, limitCount = false, split = false, FilterLength = false;
                int min = 1, max = 1000, maxCount = 0, splitCount = 2100;
                Invoke(new Action(() =>
                {
                    min = int.Parse(txtMinLength.Text);
                    max = int.Parse(txtMaxLength.Text);
                    Words = richTxtWords.Lines.ToList();
                    methods = richTxtMethods1.Lines;
                    methods2 = richTxtMethods2.Lines;
                    multiThread = chboxMultiThread.Checked;
                    limitCount = chboxLimitMaxPassCount.Checked;
                    maxCount = int.Parse(txtMaxPassCount.Text);
                    splitCount = int.Parse(txtPartCount.Text);
                    split = chboxSplitList.Checked;
                    FilterLength = chboxFilterLength.Checked;
                    Enabled = false;
                    progressForm = new ProgressForm();
                    progressForm.Owner = this;
                    progressForm.Show();

                    int count = 0;
                    count += (Words.Count * methods2.Length * methods.Length);
                    count += (Words.Count * methods.Length * methods2.Length);
                    count += (methods.Length * methods2.Length * Words.Count);
                    count += (methods.Length * Words.Count * methods2.Length);
                    count += (methods2.Length * Words.Count * methods.Length);
                    count += (methods2.Length * methods.Length * Words.Count);
                    count += (Words.Count * methods.Length);
                    count += (methods.Length * Words.Count);
                    count += (Words.Count * methods2.Length);
                    count += (methods2.Length * Words.Count);
                    count += Words.Count;
                    progressForm.lblTarget.Text = "Target: " + count.ToString();
                }));
                resultList = new List<string>();
                {
                    List<string> tmp = new List<string>();
                    foreach (string word in Words)
                    {
                        if (!tmp.Contains(word))
                        {
                            tmp.Add(word);
                        }
                    }
                    Words.Clear();
                    Words.AddRange(tmp);
                }
                if (multiThread)
                {
                    List<Thread> threads = new List<Thread>();
                    foreach (string word in Words)
                    {

                        for (int i = 0; maxThread <= threads.Count; i++)
                        {
                            if (i == threads.Count)
                                i = 0;
                            if (!threads[i].IsAlive)
                            {
                                threads.RemoveAt(i);
                                break;
                            }
                        }
                        Thread thread = new Thread(Generate);
                        threads.Add(thread);
                        thread.Start(word);
                        if (progressForm.cancel || (limitCount && resultList.Count >= maxCount))
                            break;
                    }
                    for (int i = 0; i < threads.Count; i++)
                    {
                        while (threads[i].IsAlive)
                            continue;
                    }
                }
                else
                {
                    foreach (string word in Words)
                    {
                        Generate(word);
                        if (progressForm.cancel || (limitCount && resultList.Count >= maxCount))
                            break;
                    }
                }
                if (FilterLength)
                {
                    List<string> tmp = new List<string>();
                    tmp.AddRange(resultList);
                    resultList.Clear();
                    int n = tmp.Count / 100 + 1;
                    for (int i = 0; i < tmp.Count; i++)
                    {
                        string l = tmp[i];
                        if (l == null || l == "")
                            continue;
                        if ((l.Length >= min) && (l.Length <= max))
                            resultList.Add(l);
                        if (i % n == 0)
                        {
                            Invoke(new Action(() =>
                            {
                                progressForm.lblCount.Text = "Checking: " + (i * 100.0 / tmp.Count).ToString("0.00") + "%";
                            }));
                        }
                    }
                }
                Invoke(new Action(() =>
                {
                    progressForm.Enabled = false;
                }));
                if (limitCount && resultList.Count > maxCount)
                    resultList = resultList.GetRange(0, maxCount);
                else if (resultList.Count > 21000 || split)
                {
                    SaveFileDialog saveFD = new SaveFileDialog();
                    Invoke(new Action(() =>
                    {
                        saveFD.Filter = "Text Document|*.txt|All Files|*.*";
                        if (saveFD.ShowDialog() == DialogResult.OK)
                            if (split)
                            {
                                if (resultList.Count <= splitCount)
                                    File.WriteAllLines(saveFD.FileName, resultList);
                                else
                                {
                                    int i = 1;
                                    string path;
                                    while (resultList.Count > splitCount)
                                    {
                                        List<string> tmp = resultList.GetRange(0, splitCount);
                                        if (saveFD.FileName.Contains(".") && saveFD.FileName.LastIndexOf(".") > saveFD.FileName.LastIndexOf("\\"))
                                            path = saveFD.FileName.Substring(0, saveFD.FileName.LastIndexOf('.')) + " (" + i.ToString() + ")" + saveFD.FileName.Substring(saveFD.FileName.LastIndexOf('.'));
                                        else
                                            path = saveFD.FileName + " (" + i.ToString() + ")";
                                        File.WriteAllLines(path, tmp);
                                        resultList.RemoveRange(0, splitCount);
                                        i++;
                                    }
                                    if (resultList.Count > 0)
                                    {
                                        if (saveFD.FileName.Contains(".") && saveFD.FileName.LastIndexOf(".") > saveFD.FileName.LastIndexOf("\\"))
                                            path = saveFD.FileName.Substring(0, saveFD.FileName.LastIndexOf('.')) + " (" + i.ToString() + ")" + saveFD.FileName.Substring(saveFD.FileName.LastIndexOf('.'));
                                        else
                                            path = saveFD.FileName + " (" + i.ToString() + ")";
                                        File.WriteAllLines(path, resultList);
                                    }
                                }
                            }
                            else
                                File.WriteAllLines(saveFD.FileName, resultList);
                    }));
                }
                Invoke(new Action(() =>
                {
                    if (resultList.Count <= 21000)
                        richTxtResults.Lines = resultList.ToArray();
                    Enabled = true;
                    progressForm.Close();
                }));
                methods = new string[0];
                methods2 = new string[0];
                Words.Clear();
                resultList.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message + "\n" + e.Source, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabelCodeWriter21_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://COdeWriter21.blog.ir");
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                return;
            if ((!char.IsNumber(e.KeyChar)))
                e.Handled = true;
            TextBox Sender = ((TextBox)sender);
            if (Sender.SelectionLength < 1)
            {
                if (Sender.TextLength == 9)
                {
                    if ((!(int.Parse(Sender.Text) <= 214748364)) || (!(int.Parse(e.KeyChar.ToString()) <= 7)))
                        e.Handled = true;
                }
                if (Sender.TextLength > 9)
                    e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtMaxLength.Visible = txtMinLength.Visible = lblMax.Visible = lblMin.Visible = txtMaxLength.Enabled = txtMinLength.Enabled = lblMax.Enabled = lblMin.Enabled = chboxFilterLength.Checked;
            fixRight();
            saveSettings();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).TextLength == 0)
                ((TextBox)sender).Text = "1";
            string txt = "";
            foreach (char c in ((TextBox)sender).Text)
            {
                int x;
                if (int.TryParse(c.ToString(), out x))
                    txt += c;
            }
            ((TextBox)sender).Text = txt;
            maxThread = int.Parse(txtMaxThread.Text);
            saveSettings();
        }

        private void chboxMultiThread_CheckedChanged(object sender, EventArgs e)
        {
            lblMaxThread.Visible = txtMaxThread.Visible = lblMaxThread.Enabled = txtMaxThread.Enabled = chboxMultiThread.Checked;
            fixLeft();
            saveSettings();
        }

        private void txtMaxThread_Leave(object sender, EventArgs e)
        {
            maxThread = int.Parse(txtMaxThread.Text);
        }

        private void openWordListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenWordList();
        }

        private void OpenWordList()
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Multiselect = false;
            openFD.Filter = "Text Document|*.txt";
            openFD.Title = "Select a WordList";
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                string words = File.ReadAllText(openFD.FileName);
                if (words.Length < 1)
                    return;
                if (richTxtWords.Text.Length > 0)
                {
                    DialogResult result = MessageBox.Show("You want to\nClear current Words and open WordList\nor\nAppend WordList to the current Words?\nClear : Yes\nAppend : No", "Clear OR Append?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                        richTxtWords.Text = "";
                    else if (result == DialogResult.No)
                        richTxtWords.Text += "\n";
                    else
                        return;
                }
                richTxtWords.Text += words;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            txtPartCount.Enabled = lblSplitCount.Enabled = lblSplitCount.Visible = txtPartCount.Visible = chboxSplitList.Checked;
            fixLeft();
            saveSettings();
        }

        private void chboxMaxPassCount_CheckedChanged(object sender, EventArgs e)
        {
            txtMaxPassCount.Enabled = lblMaxPassCount.Enabled = lblMaxPassCount.Visible = txtMaxPassCount.Visible = chboxLimitMaxPassCount.Checked;
            fixRight();
            saveSettings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fixLeft();
            fixRight();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();
        }

        private void splitAListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplitterForm f = new SplitterForm();
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void blogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://COdeWriter21.blog.ir");
        }

        private void supportUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://COdeWriter21.blogsky.com/Support-Us");
        }

        private void btnAddWords_Click(object sender, EventArgs e)
        {
            Thread addWordsThread = new Thread(AddWords);
            addWordsThread.Start();
        }

        private void richTxtResults_TextChanged(object sender, EventArgs e)
        {
            lblResultsCount.Text = richTxtResults.Lines.Length.ToString();
        }

        private void richTxtWords_TextChanged(object sender, EventArgs e)
        {
            lblWordsCount.Text = richTxtWords.Lines.Length.ToString();
        }

        private void copyPasswordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTxtResults.Text == "")
            {
                MessageBox.Show("There is nothing to copy!!", "Which Password?!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Clipboard.SetText(richTxtResults.Text);
            MessageBox.Show("Passwords Coppied!!", "Coppied!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cutPasswordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTxtResults.Text == "")
            {
                MessageBox.Show("There is nothing to cut!!", "Which Password?!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Clipboard.SetText(richTxtResults.Text);
            richTxtResults.Text = "";
        }

        private void telegramChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/CodeWriter21");
        }

        private void copyWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTxtWords.Text == "")
            {
                MessageBox.Show("There is nothing to copy!!", "Which word?!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Clipboard.SetText(richTxtWords.Text);
            MessageBox.Show("Passwords Coppied!!", "Coppied!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cutWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTxtWords.Text == "")
            {
                MessageBox.Show("There is nothing to cut!!", "Which word?!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Clipboard.SetText(richTxtWords.Text);
            richTxtWords.Text = "";
        }

        private void pasteWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Clipboard.ContainsText())
            {
                MessageBox.Show("There is no text to paste!!", "Which word?!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (richTxtWords.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show("You want to\nClear current Words and Paste New Words\nor\nAppend New Words to the current Words?\nClear : Yes\nAppend : No", "Clear OR Append?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    richTxtWords.Text = "";
                else if (result == DialogResult.No)
                    richTxtWords.Text += "\n";
                else
                    return;
            }
            richTxtWords.Text += Clipboard.GetText();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            loadSettings();
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MPCodeWriter21/PasswordListGenerator");
        }
    }
}
