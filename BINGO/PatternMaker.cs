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
    public partial class PatternMaker : Form
    {
        private Control[,] board;
        private bool[,] clicked;
        private Control[] buttons, labels;
        private BINGO from;
        public PatternMaker(BINGO from)
        {
            this.from = from;
            InitializeComponent();
        }

        private void BtnPattern1_Click(object sender, EventArgs e)
        {
            BingoPattern.SelectedPattern = 0;
            PatternMaker_Load(sender, e);
        }

        private void BtnPattern2_Click(object sender, EventArgs e)
        {
            BingoPattern.SelectedPattern = 1;
            PatternMaker_Load(sender, e);
        }

        private void BtnPattern3_Click(object sender, EventArgs e)
        {
            BingoPattern.SelectedPattern = 2;
            PatternMaker_Load(sender, e);
        }

        private void BtnPattern4_Click(object sender, EventArgs e)
        {
            BingoPattern.SelectedPattern = 3;
            PatternMaker_Load(sender, e);
        }

        private void BtnPattern5_Click(object sender, EventArgs e)
        {
            BingoPattern.SelectedPattern = 4;
            PatternMaker_Load(sender, e);
        }

        private void BtnPattern6_Click(object sender, EventArgs e)
        {
            BingoPattern.SelectedPattern = 5;
            PatternMaker_Load(sender, e);
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(0, 4);
            PatternMaker_Load(sender, e);
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(1, 4);
            PatternMaker_Load(sender, e);
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(2, 4);
            PatternMaker_Load(sender, e);
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(3, 4);
            PatternMaker_Load(sender, e);
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(4, 4);
            PatternMaker_Load(sender, e);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(0, 3);
            PatternMaker_Load(sender, e);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(1, 3);
            PatternMaker_Load(sender, e);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(2, 3);
            PatternMaker_Load(sender, e);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(3, 3);
            PatternMaker_Load(sender, e);
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(4, 3);
            PatternMaker_Load(sender, e);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(0, 2);
            PatternMaker_Load(sender, e);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(1, 2);
            PatternMaker_Load(sender, e);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(2, 2);
            PatternMaker_Load(sender, e);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(3, 2);
            PatternMaker_Load(sender, e);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(4, 2);
            PatternMaker_Load(sender, e);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(0, 1);
            PatternMaker_Load(sender, e);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(1, 1);
            PatternMaker_Load(sender, e);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(2, 1);
            PatternMaker_Load(sender, e);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(3, 1);
            PatternMaker_Load(sender, e);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(4, 1);
            PatternMaker_Load(sender, e);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(4, 0);
            PatternMaker_Load(sender, e);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(3, 0);
            PatternMaker_Load(sender, e);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(2, 0);
            PatternMaker_Load(sender, e);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(1, 0);
            PatternMaker_Load(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BingoPattern.Patterns[BingoPattern.SelectedPattern].MarkAsPattern(0, 0);
            PatternMaker_Load(sender, e);
        }

        int checkCount = 0;
        private void BtnSavePatterns_Click(object sender, EventArgs e)
        {
            checkCount = 0;
            foreach(BingoPattern a in BingoPattern.Patterns)
            {
                if (a.CheckIfPatternMinimum())
                    checkCount++;
            }
            MessageBox.Show("" + checkCount);
            if (checkCount == 6)
            {
                BingoPattern.SelectedPattern = 0;       //// always start with first saved pattern.
                from.BINGO_Load(sender, e);
                this.Close();
            }
            else
                MessageBox.Show("Please fill all Six Patterns with at least One (1) Vertical, Horizontal or Diagonal Pattern", "Fill Pattern");
        }

        private void ValidateClose(object sender, EventArgs e)
        {
            if (checkCount == 6)
            {
            }
            else
            {
                MessageBox.Show("Please fill all Six Patterns with at least One (1) Vertical, Horizontal or Diagonal Pattern", "Fill Pattern");
            }
        }

        private void PatternMaker_Load(object sender, EventArgs e)
        {
            FormClosing += ValidateClose;
            string a = "";
            string name;
            int counter=1;
            board = new Control[5, 5];
            clicked = new bool[5, 5];
            buttons = new Control[6];
            labels = new Control[6];
            for (int i=0; i < 6; ++i)
            {
                buttons[i] = Controls.Find("btnPattern"+(i+1),true)[0];
                labels[i] = Controls.Find("b" + (i + 1), true)[0];
                if (i == BingoPattern.SelectedPattern)
                    labels[i].ForeColor = Color.DarkViolet;
                else
                    labels[i].ForeColor = Color.Black;
            }

            for(int i=0; i<5; ++i)
            {
                for(int ii=0; ii<5; ++ii)
                {
                    name = "button" + counter;
                    board[i,ii] = Controls.Find(name, true)[0];
                    if(BingoPattern.Patterns[BingoPattern.SelectedPattern].GetPattern()[i,ii])
                        board[i, ii].BackColor = Color.Green;
                    else
                        board[i, ii].BackColor = Color.White;
                    counter++;
                }
            }
        }
    }
}
