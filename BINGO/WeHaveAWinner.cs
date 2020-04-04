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
    public partial class WeHaveAWinner : Form
    {
        private Timer timer;
        private bool switcher = false;
        private BINGO from;
        public WeHaveAWinner(BINGO from)
        {
            this.from = from;
            InitializeComponent();
        }

        private void WeHaveAWinner_Load(object sender, EventArgs e)
        {
            TimerStart();
        }

        private void TimerStart()
        {
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += BlinkLabel;
            timer.Start();
        }

        private void BlinkLabel(object sender, EventArgs a)
        {
            switcher = !switcher;
            winnerLabel.Text = switcher ? "" : "BINGO!";
        }

        private void WinnerLabel_Click(object sender, EventArgs e)
        {
            from.Reset(sender,e);
            Close();
        }
    }
}
