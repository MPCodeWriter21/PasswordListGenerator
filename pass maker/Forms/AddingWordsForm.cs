using System;
using System.Windows.Forms;

namespace pass_maker.Forms
{
    public partial class AddingWordsForm : Form
    {
        public bool cancel = false;

        public AddingWordsForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
        }

        private void AddingWordsForm_LocationChanged(object sender, EventArgs e)
        {
            MainForm form = (MainForm)Owner;
            form.Left = Left - (form.Width / 2) + (Width / 2);
            form.Top = Top - (form.Height / 2) + (Height / 2);
        }
    }
}
