using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAtributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fruta.quantidade);
            Fruta maca = new Fruta("TipoA");
            Console.WriteLine(Fruta.quantidade);
            Fruta pera = new Fruta("TipoB");
            Console.WriteLine(pera.getQuantidade()); // se quisermos chamar pelo object

            Console.ReadLine();
        }
    }
}
