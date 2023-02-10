using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAtributes
{
    internal class Fruta
    {
        public string tipo_fruta;
        public static int quantidade = 0; // Referente a classe, transversal a todos os objetos da classe
        public Fruta(string umTipo_fruta)
        {
            tipo_fruta = umTipo_fruta;
            // Sempre que é adicionada uma fruta este method é chamado garantidamente
            quantidade++;
        }
        public int getQuantidade()
        {
            return quantidade;
        }
    }
}
