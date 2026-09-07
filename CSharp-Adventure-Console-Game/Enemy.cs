using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Adventure_Console_Game
{
    internal class Enemy
    {

        private string _eName; // enemy name
        public int Health { get; set; }

        private int _eAP; // enemy attack points
        private string _eL1; // enemy lines, as in lines it says during battle
        private string _eL2;
        private string _eL3;
        private string _eDM; // enemy death message            or electronic dance music


        public Enemy(string eName, int eHP, int eAP, string eL1, string eL2, string eL3, string eDM) 
        {
            _eName = eName;
            Health = eHP;
            _eAP = eAP;
            _eL1 = eL1;
            _eL2 = eL2;
            _eL3 = eL3;
            _eDM = eDM;
        }


        public void SayName()
        {
            Console.WriteLine(_eName);
        }



        public int Attack()
        {
            return _eAP;
        }




        public string Talk()
        {

            Random ernd = new Random();
            int eTalk = ernd.Next(1, 4);


            if (eTalk == 1)
                return _eL1;
            else if (eTalk == 2)
                return _eL2;
            else
                return _eL3;
        }




        public void LastWord()
        {
            Console.WriteLine(_eDM);
        }
    }
}





