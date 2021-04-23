using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Star
{
    class VidaPersonagem
    {
        public int pontos = 100;
        public int dinheiro = 100;
        

        public void Dinheiro()
        {

            for (int i = 0; i < dinheiro; i++)
            {
                string cifrao = "$";
                Console.Write(cifrao);
                Console.WriteLine("\n");
                dinheiro = dinheiro - 4;
            }
            

            for (int i = 0; i<dinheiro; i++)
             {
                string cifrao = "$";
                Console.Write(cifrao);
             } 
        }

       
        
        
        
        public string fazerMusica;
        public string discoOuro;
        public string discoPlatina;
        public string feriasCompletas;
        public string folga;
        public string montarBanda;
        public string irNoMedico;


        public string fechandoTour;
        public string fazendoDezShows;
        public string comprarBens;
        public string fazerArruaca;
        public string serPreso;
        public string ficarNegativo;
        public string gravandoDisco;
        public string ensaiando;



           





    }


}
