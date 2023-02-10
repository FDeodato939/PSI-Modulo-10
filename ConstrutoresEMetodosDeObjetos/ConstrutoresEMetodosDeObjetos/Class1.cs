using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutoresEMetodosDeObjetos
{
    internal class Jogo
    {
        public string title;
        public string company;
        public int sales;

        public Jogo(string aTitle, string ACompany, int nrSales)
        {
            title = aTitle;
            company = ACompany;
            sales = nrSales;
        }
        public bool Breakeven()
        {
            if (sales >= 10000)
            {
                return true;
            }
            return false;
        }
        public string WhichCompany()
        {
            string ChangeCompany = "Change Company";
            string CorrectCompany = "Correct Company";

            if (company == "Bioware")
            {
                return ChangeCompany;
            }
            return CorrectCompany;
        }
    }
}
