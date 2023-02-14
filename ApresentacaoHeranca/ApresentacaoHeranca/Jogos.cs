using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentacaoHeranca
{
    class Jogos
    {
        public string nome;
        public string franquia;
        public double preco;
        public string rate;
        public double calcPromocao(double desconto)
        {
            double res;
            res = preco - desconto;
            return res;
        }
    }
}