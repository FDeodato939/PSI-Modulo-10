using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class Site
    {
        public string nome;
        public string dono;
        private string estado;
        
        public Site(string umNome, string umDono, string umEstado)
        {
            nome = umNome;
            dono = umDono;
            Estado = umEstado;
        }

        public string Estado // Igual ao atributo no construtor
        {
            get
            {
                return estado; // Igual ao atributo de classe
            }
            set
            {
                if (value == "Online" || value == "Offline" || value == "Manutenção")
                {
                    estado = value;
                }
                else
                {
                    estado = "Offline";
                }
            }
        }
    }
}