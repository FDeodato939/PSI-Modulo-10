using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentacaoHeranca
{
    class AtaqueDeDefensa : Jogos
    {
        public bool alterarGraficos;
        public double calcPrecoDasArmas(double custoPistol, double custoSentinela)
        {
            double res;
            res = custoPistol + custoSentinela;
            return res;
        }
    }
}