using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Site record = new Site("Record", "Cofina", "test");
            Site sapo = new Site("Sapo", "Empresa Sapo", "Online");
            // Definir valores especificos cortar acesso sera forçar valores que desejo
            // Online, Offlne, Manutenção

            Console.WriteLine(record.Estado);
            Console.ReadLine();
        }
    }
}
