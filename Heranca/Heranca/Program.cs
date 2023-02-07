using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Minion azul = new Minion();
            azul.Auto();
            azul.Special();

            Champ thresh = new Champ();
            thresh.Auto();
            thresh.Special();
            thresh.Block();

            Console.ReadLine();
        }
    }
}
