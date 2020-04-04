using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINGO
{
    class Round
    {

        public bool[,] ClickedCells { get; set; }
        public bool[] GeneratedNumbers { get; set; }

        public static List<Round> rounds = new List<Round>();
        public static Round currentRound;

        public static void SavePreviousRound(bool[,] clickedCells, bool[] generatedNumbers)
        {
            Round buffer = new Round();
            buffer.ClickedCells = clickedCells;
            buffer.GeneratedNumbers = generatedNumbers;
            Round.AddRound(buffer);
        }

        private static void AddRound(Round arg)
        {
            if (rounds != null)
                rounds.Add(arg);
        }
        public static Round GetPreviousRound()
        {
            try
            {
                currentRound = rounds[rounds.Count - 1];
                rounds.Remove(rounds[rounds.Count - 1]);    // pops the recent Round
            }
            catch(Exception e)
            {
                currentRound = null;
            }
            return currentRound;
        }
    }
}
