using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BINGO
{
    class NumberGenerator : BINGO 
    {
        private static Random generator = new Random();
        private static bool[] generatedNumbers = new bool[76];
        private static int[,] generatorControler;
        private static bool[] columnsSelected = new bool[5];
        private static char charEquivalent;
        public static int GenerateRandomNumber(bool [] selectedRows) {
            int number = 75;
            int tryCount = 0;               ////////   here lies the generation of numbers

            generatedNumbers[75] = true;

            do
            {
                // number = (generator.Next() % 75);       //// generates a number and modulates to 75;
                int genRow = generator.Next(0,5);

                if(genRow == 0 && selectedRows[0] == true)
                    number = generator.Next(0, 15);
                else if(genRow == 1 && selectedRows[1] == true)
                    number = generator.Next(15, 30);
                else if(genRow == 2 && selectedRows[2] == true)
                    number = generator.Next(30, 45);
                else if(genRow == 3 && selectedRows[3] == true)
                    number = generator.Next(45, 60);
                else if(genRow == 4 && selectedRows[4] == true)
                    number = generator.Next(60, 75);

                ++tryCount;
                if (tryCount == 200) break;
            }
            while (generatedNumbers[number]);           //// check if the number has been generated.


            if (tryCount == 200)
                number = -2;
            else
            {
                SetCharEquivalent(number + 1);
                generatedNumbers[number] = true;
            }
            return number+1;
        }
        public static char GetCharEquivalent() {
            return charEquivalent;
        }

        public static void SetGeneratorControler(int[,] arg)
        {
            generatorControler = arg;
            int counter = 0;
        }

        public static bool[] GeneratedNumbers() { return generatedNumbers; }

        private static void SetCharEquivalent(int a) {
            if (61 <= a && a <= 75)
                charEquivalent = 'O';
            if (46 <= a && a <= 60)
                charEquivalent = 'G';
            if (31 <= a && a <= 45)
                charEquivalent = 'N';
            if (16 <= a && a <= 30)
                charEquivalent = 'I';
            if (1 <= a && a <= 15)
                charEquivalent = 'B';
        }

        public static void ResetGeneratedNumbers()
        {
            for (int i = 0; i < generatedNumbers.Length; ++i)
                generatedNumbers[i] = false;
        }

        public static void SetGeneratedNumbers(bool[] arg)
        {
            generatedNumbers = arg;
        }
    }
}
