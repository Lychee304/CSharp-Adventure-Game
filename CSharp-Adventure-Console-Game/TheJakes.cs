using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Adventure_Console_Game
{
    internal class TheJakes : Enemy
    {
        public TheJakes(string eName, int eHP, int eAP, string eL1, string eL2, string eL3, string eDM) : base(eName, eHP, eAP, eL1, eL2, eL3, eDM)
        {
        }
    }
}
