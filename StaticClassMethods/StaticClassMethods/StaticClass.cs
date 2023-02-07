using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassMethods
{
    static class StaticClass //para não permitir criar novos objetos
    {
        public static void Hello(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
