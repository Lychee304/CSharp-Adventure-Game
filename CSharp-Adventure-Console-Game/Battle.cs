using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// probably not gonna use this

namespace CSharp_Adventure_Console_Game
{
    internal class Battle
    {
        private string _bName; // battle name
        private int _aOBTurn; // amount of battle turn
        private string _bWin; // battle winner


        public Battle(string bName, int aOBTurn, string bWin)
        {
            _bName = bName;
            _aOBTurn = aOBTurn;
            _bWin = bWin;
        }


        public void DisplayBName()
        {
            Console.WriteLine(_bName);
        }



        public int AmountTurn()
        {
            return _aOBTurn;
        }



        public void Winner() // its you, you are the winner :)
        {
            Console.WriteLine(_bWin);
        }
    }
}
