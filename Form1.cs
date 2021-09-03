using System;

using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            LabelTime.Text = DateTime.Now.ToString("HH:mm");
            labelSecond.Text = DateTime.Now.ToString("ss");
            labelDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            labelDay.Text = DateTime.Now.ToString("dddd");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void labelSecond_Click(object sender, EventArgs e)
        {

        }
    }
}
