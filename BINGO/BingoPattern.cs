using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BINGO
{
    class BingoPattern
    {
        private bool[,] pattern = new bool[5,5];
        public static BingoPattern[] Patterns = new BingoPattern[]{         // 6 default patterns
            new BingoPattern(),
            new BingoPattern(),
            new BingoPattern(),
            new BingoPattern(),
            new BingoPattern(),
            new BingoPattern()
        };
        public static int SelectedPattern { get; set; }

        public void MarkAsPattern(int xIndex, int yIndex)
        {
            pattern[yIndex, xIndex] = !pattern[yIndex, xIndex];
        }
        public bool[,] GetPattern() { return pattern; }

        public bool CheckIfPatternMinimum()
        {
            return VerticalPatternCount() ||
                   HorizontalPatternCount() ||
                   LeftDiagonalPatternCount() ||
                   RightDiagonalPatternCount();
        }
        private bool VerticalPatternCount()
        {
            int a = 0;
            int patternCount = 0;
            for (int i = 0; i < 5; ++i)
            {
                a = 0;
                for (int ii = 0; ii < 5; ++ii)
                {
                    if (pattern[ii, i])
                        a++;
                    if (a == 5)
                        patternCount++;
                }
            }
            return patternCount > 0;
        }
        private bool HorizontalPatternCount()
        {
            int a = 0;
            int patternCount = 0;
            for (int i = 0; i < 5; ++i)
            {
                a = 0;
                for (int ii = 0; ii < 5; ++ii)
                {
                    if (pattern[i, ii])
                        a++;
                    if (a == 5)
                        patternCount++;
                }
            }
            return patternCount > 0;
        }
        private bool LeftDiagonalPatternCount()
        {
            int a = 0;
            int patternCount = 0;
            int i, j;
            for (i = 0; i < 5; ++i)
            {
                if (pattern[i, i])
                    a++;
            }
            if (a == 5)
                patternCount++;
            return patternCount > 0;
        }
        private bool RightDiagonalPatternCount()
        {
            int a = 0;
            int patternCount = 0;
            int i, j;
            i = 0;
            j = 4;
            do
            {
                //MessageBox.Show(String.Format("{0},{1}", i, j));
                if (pattern[i, j])
                    a++;
            }
            while (i++ < j--);
            if (a == 5)
                patternCount++;
            return patternCount > 0;
        }
        public void ResetPattern()
        {
            for(int i=0; i<5; ++i)
            {
                for(int ii=0; ii<5; ++ii)
                {
                    pattern[i, ii] = false;
                }
            }
        }
        public static void ResetAllPatterns() {
            foreach(BingoPattern a in Patterns)
            {

            }
        }
    }
}
