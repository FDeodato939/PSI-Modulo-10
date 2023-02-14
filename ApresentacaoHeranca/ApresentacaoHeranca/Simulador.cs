using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentacaoHeranca
{
    class Simulador : Jogos
    {
        public bool volante;
        public double calcPrecoDosPerifericos(double custoDasRodas, double custoDoMotor, double custoDaPintura)
        {
            double res;
            res = custoDasRodas + custoDoMotor + custoDaPintura;
            return res;
        }
    }
}