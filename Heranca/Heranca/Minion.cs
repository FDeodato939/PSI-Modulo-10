using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Minion
    {
        public void Auto()
        {
            Console.WriteLine("Atacou");
        }
        public virtual void Special()
        {
            Console.WriteLine("Minion usou special");
        }
    }
}
