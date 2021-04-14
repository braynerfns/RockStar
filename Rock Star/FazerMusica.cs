using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Star
{
    class FazerMusica
    {
        public string Titulo;
        public int quantidadeIntegrantes;
        
        Random rand = new Random();
        private static readonly Random rand1;
        int rating = rand1.Next(0, 9);

        
        public double Sucesso(double sucesso)
        {
            return quantidadeIntegrantes * rating;

            if (sucesso >= 50)
            {
                Console.WriteLine("Esta música é um Hit");
            }
            
            if (sucesso == 100)
            {
                Console.WriteLine("Esta música é um Big Hit!!!!");
            }

            if (sucesso <= 25)
            {
                Console.WriteLine("Esta Música é um Fracasso!!");
            }
        }

        // Hit >= 50.0;
        // Big Hit >= 100.0;
        // Fracasso <= 25.0;



    }
}
