using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Star
{
    class Trivias
    {
        //string trivias[] = new string[10]
        //trivias[r.Next(0, 10)] //

        // Criar um método para as perguntas aparecerem no programa principal, relacionado as respostas dadas a cada trivia.
        // respostaTrivia1 -
        public int pontos = 100;
        public int dinheiro = 100;

        public string trivia1 = "Fazer Música" + "Comprar Bens" + "Ensaiar" + "Fazer Festa e Arruaça";
        public string trivia2 = "Fazer Show" + "Fazer Música" + "Ensaiar" + "Gravar Música";
        public string trivia3 = "Fazer Música" + "Ir no Médico" + "Comprar Bens" + "Tirar 3 dias de Folga";
        public string trivia4 = "Fazer Show" + "Gravar Disco" + "Fazendo Festa e Arruaça" + "Ensaiar";
        public string trivia5 = "Gravar Música" + "Ensaiar" + "Fazer 10 Shows" + "Comprar Bens";
        public string trivia6 = "Fazer Música" + "Gravar Música" + "Fechando Tour" + "Ensaiar";
        public string trivia7 = "Gravar Disco" + "Fazer Show" + "Tirar Férias de 30 Dias" + "Comprar Bens";
        public string trivia8 = "Fechando Tour" + "Fazer 10 Shows" + "Fazer Festas e Arruaça" + "Gravar Música";
        public string trivia9 = "Ir no Médico" + "Tirar 3 dias de Folga" + "Ensaiar" + "Fazer 10 Shows";
        public string trivia10 = "Gravar Música" + "Fazer Música" + "Comprar Bens" + "Fazer Show";

        public Trivias()
        {

        }
        public Trivias(string trivia1)

        {
            string cifrao = "$";
            for (int i = 0; i < dinheiro; i++)
            {
                Console.Write(cifrao);
            }

            if (trivia1 == "Fazer Música")
            {
                pontos = pontos + 3;
            }
            if (trivia1 == "Comprar Bens")
            {
                Console.WriteLine("Qual Bem?");
                string opcao;
                Console.Write("Casa" + "Apartamento" + "Carro" + "Avião" + "Fazenda" + "Estúdio" + "Tour Bus");
                opcao = Console.ReadLine();
                if (opcao == "Casa")
                {
                    dinheiro = dinheiro - 200;
                    Console.WriteLine("-$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Apartamento")
                {
                    dinheiro = dinheiro - 700;
                    Console.WriteLine("-$$$$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Carro")
                {
                    dinheiro = dinheiro - 400;
                    Console.WriteLine("-$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Avião")
                {
                    dinheiro = dinheiro - 1300;
                    Console.WriteLine("-$$$$$$$$$$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Fazenda")
                {
                    dinheiro = dinheiro - 1100;
                    Console.WriteLine("-$$$$$$$$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Estúdio")
                {
                    dinheiro = dinheiro - 900;
                    Console.WriteLine("-$$$$$$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Tour Bus")
                {
                    dinheiro = dinheiro - 700;
                    Console.WriteLine("-$$$$$$$");
                    pontos = pontos - 2;
                }
            }

            if (trivia1 == "Ensaiar")
            {
                pontos = pontos - 2;
                dinheiro = dinheiro - 100;
                Console.WriteLine("-$");
            }
            if (trivia1 == "Fazer Festa e Arruaça")
            {
                pontos = pontos - 5;
                dinheiro = dinheiro - 300;
                Console.WriteLine("-$$$");
            }
            string trivia2;
            trivia2 = Console.ReadLine();
            if (trivia2 == "Fazer Show")
            {
                pontos = pontos + 7;
                dinheiro = dinheiro + 200;
                Console.WriteLine("$$");
            }
            if (trivia2 == "Fazer Música")
            {
                pontos = pontos + 3;
            }
            if (trivia2 == "Ensaiar")
            {
                pontos = pontos - 2;
                dinheiro = dinheiro - 100;
                Console.WriteLine("-$");
            }
            if (trivia2 == "Gravar Música")
            {
                pontos = pontos - 4;
                dinheiro = dinheiro - 200;
                Console.WriteLine("-$$");
            }
            string trivia3;
            trivia3 = Console.ReadLine();
            if (trivia3 == "Fazer Música")
            {
                pontos = pontos + 3;
            }
            if (trivia3 == "Ir no Médico")
            {
                pontos = pontos + 30;
                dinheiro = dinheiro - 300;
                Console.WriteLine("-$$$");
            }
            if (trivia3 == "Comprar Bens")
            {
                Console.WriteLine("Qual Bem?");
                string opcao;
                Console.Write("Casa" + "Apartamento" + "Carro" + "Avião" + "Fazenda" + "Estúdio" + "Tour Bus");
                opcao = Console.ReadLine();

                if (opcao == "Casa")
                {
                    dinheiro = dinheiro - 200;
                    Console.WriteLine("-$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Apartamento")
                {
                    dinheiro = dinheiro - 700;
                    Console.WriteLine("-$$$$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Carro")
                {
                    dinheiro = dinheiro - 400;
                    Console.WriteLine("-$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Avião")
                {
                    dinheiro = dinheiro - 1300;
                    Console.WriteLine("-$$$$$$$$$$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Fazenda")
                {
                    dinheiro = dinheiro - 1100;
                    Console.WriteLine("-$$$$$$$$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Estúdio")
                {
                    dinheiro = dinheiro - 900;
                    Console.WriteLine("-$$$$$$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Tour Bus")
                {
                    dinheiro = dinheiro - 700;
                    Console.WriteLine("-$$$$$$$");
                    pontos = pontos - 2;
                }
            }
            if (trivia3 == "Tirar 3 dias de Folga")
            {
                dinheiro = dinheiro - 300;
                Console.WriteLine("-$$$");
                pontos = pontos + 5;
            }

            string trivia4;
            trivia4 = Console.ReadLine();
            if (trivia4 == "Fazer Show")
            {
                pontos = pontos + 7;
                dinheiro = dinheiro + 200;
                Console.WriteLine("$$");
            }
            if (trivia4 == "Gravar Disco")
            {
                pontos = pontos - 10;
                dinheiro = dinheiro - 500;
                Console.WriteLine("-$$$$$");
            }
            if (trivia4 == "Fazendo Festa e Arruaça")
            {
                pontos = pontos - 5;
                dinheiro = dinheiro - 300;
                Console.WriteLine("-$$$");
            }
            if (trivia4 == "Ensaiar")
            {
                pontos = pontos - 2;
                dinheiro = dinheiro - 100;
                Console.WriteLine("-$");
            }

            string trivia5;
            trivia5 = Console.ReadLine();
            if (trivia5 == "Gravar Música")
            {
                pontos = pontos - 4;
                dinheiro = dinheiro - 200;
                Console.WriteLine("-$$");
            }
            if (trivia5 == "Ensaiar")
            {
                pontos = pontos - 2;
                dinheiro = dinheiro - 100;
                Console.WriteLine("-$");
            }
            if (trivia5 == "Fazer 10 Shows")
            {
                pontos = pontos - 10;
                dinheiro = dinheiro + 500;
                Console.WriteLine("$$$$$");
            }
            if (trivia5 == "Comprar Bens")
            {
                Console.WriteLine("Qual Bem?");
                string opcao;
                Console.Write("Casa" + "Apartamento" + "Carro" + "Avião" + "Fazenda" + "Estúdio" + "Tour Bus");
                opcao = Console.ReadLine();
                if (opcao == "Casa")
                {
                    dinheiro = dinheiro - 200;
                    Console.WriteLine("-$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Apartamento")
                {
                    dinheiro = dinheiro - 700;
                    Console.WriteLine("-$$$$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Carro")
                {
                    dinheiro = dinheiro - 400;
                    Console.WriteLine("-$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Avião")
                {
                    dinheiro = dinheiro - 1300;
                    Console.WriteLine("-$$$$$$$$$$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Fazenda")
                {
                    dinheiro = dinheiro - 1100;
                    Console.WriteLine("-$$$$$$$$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Estúdio")
                {
                    dinheiro = dinheiro - 900;
                    Console.WriteLine("-$$$$$$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Tour Bus")
                {
                    dinheiro = dinheiro - 700;
                    Console.WriteLine("-$$$$$$$");
                    pontos = pontos - 2;
                }
            }
            string trivia6;
            trivia6 = Console.ReadLine();
            if (trivia6 == "Fazer Música")
            {
                pontos = pontos + 3;
            }
            if (trivia6 == "Gravar Música")
            {
                pontos = pontos - 4;
                dinheiro = dinheiro - 200;
                Console.WriteLine("-$$");
            }
            if (trivia6 == "Fechando Tour")
            {
                pontos = pontos - 5;
                dinheiro = dinheiro + 600;
                Console.WriteLine("$$$$$$");
            }
            if (trivia6 == "Ensaiar")
            {
                pontos = pontos - 2;
                dinheiro = dinheiro - 100;
                Console.WriteLine("-$");
            }
            string trivia7;
            trivia7 = Console.ReadLine();
            if (trivia7 == "Gravar Disco")
            {
                pontos = pontos - 10;
                dinheiro = dinheiro - 500;
                Console.WriteLine("-$$$$$$");
            }
            if (trivia7 == "Fazer Show")
            {
                pontos = pontos + 7;
                dinheiro = dinheiro + 200;
                Console.WriteLine("$$");
            }
            if (trivia7 == "Tirar Férias de 30 Dias")
            {
                pontos = pontos + 50;
                dinheiro = dinheiro - 500;
                Console.WriteLine("-$$$$$");
            }
            if (trivia7 == "Comprar Bens")
            {
                Console.WriteLine("Qual Bem?");
                string opcao;
                Console.Write("Casa" + "Apartamento" + "Carro" + "Avião" + "Fazenda" + "Estúdio" + "Tour Bus");
                opcao = Console.ReadLine();
                if (opcao == "Casa")
                {
                    dinheiro = dinheiro - 200;
                    Console.WriteLine("-$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Apartamento")
                {
                    dinheiro = dinheiro - 700;
                    Console.WriteLine("-$$$$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Carro")
                {
                    dinheiro = dinheiro - 400;
                    Console.WriteLine("-$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Avião")
                {
                    dinheiro = dinheiro - 1300;
                    Console.WriteLine("-$$$$$$$$$$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Fazenda")
                {
                    dinheiro = dinheiro - 1100;
                    Console.WriteLine("-$$$$$$$$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Estúdio")
                {
                    dinheiro = dinheiro - 900;
                    Console.WriteLine("-$$$$$$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Tour Bus")
                {
                    dinheiro = dinheiro - 700;
                    Console.WriteLine("-$$$$$$$");
                    pontos = pontos - 2;
                }
            }
            string trivia8;
            trivia8 = Console.ReadLine();
            if (trivia8 == "Fechando Tour")
            {
                pontos = pontos - 5;
                dinheiro = dinheiro + 600;
                Console.WriteLine("$$$$$$");
            }
            if (trivia8 == "Fazer 10 Shows")
            {
                pontos = pontos - 10;
                dinheiro = dinheiro + 500;
                Console.WriteLine("$$$$$");
            }
            if (trivia8 == "Fazer Festa e Arruaça")
            {
                pontos = pontos - 5;
                dinheiro = dinheiro - 300;
                Console.WriteLine("-$$$");
            }
            if (trivia8 == "Gravar Música")
            {
                pontos = pontos - 4;
                dinheiro = dinheiro - 200;
                Console.WriteLine("-$$");
            }
            string trivia9;
            trivia9 = Console.ReadLine();
            if (trivia9 == "Ir no Médico")
            {
                pontos = pontos + 30;
                dinheiro = dinheiro - 300;
                Console.WriteLine("-$$$");
            }
            if (trivia9 == "Tirar 3 dias de Folga")
            {
                dinheiro = dinheiro - 300;
                Console.WriteLine("-$$$");
                pontos = pontos + 5;
            }
            if (trivia9 == "Ensaiar")
            {
                pontos = pontos - 2;
                dinheiro = dinheiro - 100;
                Console.WriteLine("-$");
            }
            if (trivia9 == "Fazer 10 Shows")
            {
                pontos = pontos - 10;
                dinheiro = dinheiro + 500;
                Console.WriteLine("$$$$$");
            }
            string trivia10;
            trivia10 = Console.ReadLine();
            if (trivia10 == "Gravar Música")
            {
                pontos = pontos - 4;
                dinheiro = dinheiro - 200;
                Console.WriteLine("-$$");
            }
            if (trivia10 == "Fazer Música")
            {
                pontos = pontos + 3;
            }
            if (trivia10 == "Comprar Bens")
            {
                Console.WriteLine("Qual Bem?");
                string opcao;
                Console.Write("Casa" + "Apartamento" + "Carro" + "Avião" + "Fazenda" + "Estúdio" + "Tour Bus");
                opcao = Console.ReadLine();
                if (opcao == "Casa")
                {
                    dinheiro = dinheiro - 200;
                    Console.WriteLine("-$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Apartamento")
                {
                    dinheiro = dinheiro - 700;
                    Console.WriteLine("-$$$$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Carro")
                {
                    dinheiro = dinheiro - 400;
                    Console.WriteLine("-$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Avião")
                {
                    dinheiro = dinheiro - 1300;
                    Console.WriteLine("-$$$$$$$$$$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Fazenda")
                {
                    dinheiro = dinheiro - 1100;
                    Console.WriteLine("-$$$$$$$$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Estúdio")
                {
                    dinheiro = dinheiro - 900;
                    Console.WriteLine("-$$$$$$$$$");
                    pontos = pontos - 2;
                }
                if (opcao == "Tour Bus")
                {
                    dinheiro = dinheiro - 700;
                    Console.WriteLine("-$$$$$$$");
                    pontos = pontos - 2;
                }
            }
            if (trivia10 == "Fazer Show")
            {
                pontos = pontos + 7;
                dinheiro = dinheiro + 200;
                Console.WriteLine("$$");
            }
        }
    }

}
