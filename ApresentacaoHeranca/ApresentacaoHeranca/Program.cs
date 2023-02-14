using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentacaoHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Simulador Motor2 = new Simulador();
            Motor2.nome = "Motor 2: There is no LIMITS!";
            Motor2.franquia = "Motor's Series";
            Motor2.preco = 49.99;
            Motor2.rate = "Teens";
            Motor2.volante = true;

            Console.WriteLine("Nome do Jogo: " + Motor2.nome);
            Console.WriteLine("Franquia: " + Motor2.franquia);
            Console.WriteLine("Preço: " + Motor2.preco + " $");
            Console.WriteLine("Rating: " + Motor2.rate);
            Console.WriteLine("Promoção: " + Motor2.calcPromocao(20) + " %");
            Console.WriteLine("Tem Volante?: " + Motor2.volante);
            Console.WriteLine("Preço dos Perifericos (Selecionados): " + Motor2.calcPrecoDosPerifericos(29.99, 19.99, 49.99) + " $");


            AtaqueDeDefensa WarOfDuty4 = new AtaqueDeDefensa();
            WarOfDuty4.nome = "War Of Duty 4: The Return of The Robots";
            WarOfDuty4.franquia = "WOD's Series";
            WarOfDuty4.preco = 79.99;
            WarOfDuty4.rate = "Mature";
            WarOfDuty4.alterarGraficos = false;

            Console.WriteLine("Nome do Jogo: " + WarOfDuty4.nome);
            Console.WriteLine("Franquia: " + WarOfDuty4.franquia);
            Console.WriteLine("Preço: " + WarOfDuty4.preco + " $");
            Console.WriteLine("Rating: " + WarOfDuty4.rate);
            Console.WriteLine("Promoção: " + WarOfDuty4.calcPromocao(40) + " %");
            Console.WriteLine("Ligar Graficos 3D?: " + WarOfDuty4.alterarGraficos);
            Console.WriteLine("Preço dos Armas (Selecionadas): " + WarOfDuty4.calcPrecoDasArmas(9.99, 7.99) + " $");

            Console.ReadLine();
        }
    }
}