using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BINGO
{
    public partial class DrawNumber : Form
    {
        private char letter;
        private int number;
        private Timer t;
        private bool canNowClose;
        public DrawNumber()
        {
            InitializeComponent();
        }

        public void SetDisplay(char letter, int number)
        {
            this.letter = letter;
            this.number = number;
        }

        private void DrawNumber_Load(object sender, EventArgs e)
        {
            progressBar.Hide();
            TimerStart1(100);
            ////if(progressBar.Value == max)
            //    lblLetter.Text = "" + letter;
            ////TimerStart(300);
            //if (progressBar.Value == max)
            //    lblNumber.Text = "" + number;
            //TimerStart(500);
            //if (progressBar.Value == max)
            //    Close();
        }
        int max;
        private void TimerStart1(int max)
        {
            t = new Timer();
            this.max = max;
            t.Interval = 1;
            t.Tick += ProgressBarLoad;
            t.Enabled = true;
            progressBar.Value = 0;
            progressBar.Maximum = max;
            progressBar.Step = 1;
            progressBar.Minimum = 0;
            t.Start();
            //while (progressBar.Value <= 1000)
            //{
            //    t.Start();
            //}
        }
        private void TimerStart2(int max)
        {
            t = new Timer();
            this.max = max;
            t.Interval = 1;
            t.Tick += ProgressBarLoad2;
            t.Enabled = true;
            progressBar.Value = 0;
            progressBar.Maximum = max;
            progressBar.Step = 1;
            progressBar.Minimum = 0;
            t.Start();
            //while (progressBar.Value <= 1000)
            //{
            //    t.Start();
            //}
        }

        private void TimerStart3(int max)
        {
            t = new Timer();
            this.max = max;
            t.Interval = 1;
            t.Tick += ProgressBarLoad3;
            t.Enabled = true;
            progressBar.Value = 0;
            progressBar.Maximum = max;
            progressBar.Step = 1;
            progressBar.Minimum = 0;
            t.Start();
            //while (progressBar.Value <= 1000)
            //{
            //    t.Start();
            //}
        }

        private void ProgressBarLoad(object sender, EventArgs e)
        {
            if (progressBar.Value < max)
                progressBar.PerformStep();
            else
            {
                lblLetter.Text = "" + letter;
                t.Stop();
                TimerStart2(200);
            }
        }
        private void ProgressBarLoad2(object sender, EventArgs e)
        {
            if (progressBar.Value < max)
                progressBar.PerformStep();
            else
            {
                lblNumber.Text = "" + number;
                t.Stop();
                TimerStart3(100);
            }
        }
        private void ProgressBarLoad3(object sender, EventArgs e)
        {
            if (progressBar.Value < max)
                progressBar.PerformStep();
            else
            {
                t.Stop();
                lblPressToContinue.Text = "Click anywhere to continue";
                canNowClose = true;
            }
        }

        private void DrawNumber_Click(object sender, EventArgs e)
        {
            TrapClose();
        }

        private void LblLetter_Click(object sender, EventArgs e)
        {
            TrapClose();
        }

        private void LblNumber_Click(object sender, EventArgs e)
        {
            TrapClose();
        }

        private void TrapClose()
        {
            if (canNowClose)
                Close();
        }

        private void LblPressToContinue_Click(object sender, EventArgs e)
        {
            TrapClose();
        }
    }
}
