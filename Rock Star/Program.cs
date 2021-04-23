using System;
using System.Collections.Generic;

namespace Rock_Star
{
    class Program
    {
        public static MontarBanda MontarBanda { get; private set; }

       

        static void Main(string[] args)
        {
            VidaPersonagem vida = new VidaPersonagem();
            Trivias trivias = new Trivias();
            Console.WriteLine("Digite Seu Nome: ");
            Console.ReadLine();
            Console.WriteLine();

            vida.Dinheiro();
            

            MontarBanda banda = new MontarBanda();
            Console.WriteLine("Nome da Sua Banda: ");
            banda.Nome = Console.ReadLine();
            
            Console.WriteLine("Quantos Integrantes?");
            banda.quantidadeIntegrantes = int.Parse(Console.ReadLine());

            Console.WriteLine("O Que você deseja Fazer: " + trivias.trivia1);
            string trivia1;
            trivia1 = Console.ReadLine();

            //string trivias[] = new string[10]
            //trivias[r.Next(0, 10)] //



















        }
    }
}
