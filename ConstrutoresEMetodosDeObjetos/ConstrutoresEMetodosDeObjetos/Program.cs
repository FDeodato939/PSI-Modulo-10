using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutoresEMetodosDeObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogo Jogo1 = new Jogo("Mass Effect 3", "Bioware", 11000);
            Jogo Jogo2 = new Jogo("Borderlands 3", "2x", 9000);

            //Jogo1.title = "Marvel's Guardians of the Galaxy",

            Console.WriteLine(Jogo1.title);
            Console.WriteLine(Jogo2.company);

            Console.WriteLine(Jogo1.Breakeven());
            Console.WriteLine(Jogo2.Breakeven());
            Console.WriteLine(Jogo1.WhichCompany());
            Console.WriteLine(Jogo2.WhichCompany());

            Console.ReadLine();
        }
    }
}
