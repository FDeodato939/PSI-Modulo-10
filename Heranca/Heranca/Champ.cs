using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Champ : Minion
    {
        public void Block()
        {
            Console.WriteLine("Bloqueou atace");
        }
        public override void Special()
        {
            Console.WriteLine("Usou Ultimate");
        }
    }
}
