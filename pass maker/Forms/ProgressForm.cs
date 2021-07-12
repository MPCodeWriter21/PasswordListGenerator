using System;
using System.Windows.Forms;

namespace pass_maker.Forms
{
    public partial class ProgressForm : Form
    {
        public bool cancel = false;
        public bool paused = false;
        public ProgressForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cancel = true;
        }

        private void ProgressForm_LocationChanged(object sender, EventArgs e)
        {
            MainForm form = (MainForm)Owner;
            form.Left = Left - (form.Width / 2) + (Width / 2);
            form.Top = Top - (form.Height / 2) + (Height / 2);
        }

        private void btnPauseResume_Click(object sender, EventArgs e)
        {
            if (!paused)
            {
                btnPauseResume.Text = "Resume";
                btnPauseResume.Enabled = false;
            }
            else
            {
                MainForm form = (MainForm)Owner;
                form.passwordGenerationStartTime = DateTimeOffset.Now;
                btnPauseResume.Text = "Pause";
            }
            paused = !paused;
        }
    }
}
