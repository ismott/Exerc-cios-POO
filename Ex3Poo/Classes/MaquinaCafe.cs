using System;
namespace Ex3Poo.Classes
{
    public class MaquinaCafe
    {
        public int AcucarDisponivel = 100;

        public void FazerCafe(int quant){
            if (quant <= AcucarDisponivel && quant > 0)
            {
                AcucarDisponivel = quant - AcucarDisponivel; 
                Console.WriteLine("café feito, com açucar;)");
            }
            else if (quant <= 0)
            {
                Console.WriteLine("café feito, sem açucar;)");
            }
            else if (quant > AcucarDisponivel)
            {
                Console.WriteLine("Não tem açucar o suficiente para fazer seu cafézinho (;-;)");
            }
        }
        public void FazerCafe(){
            AcucarDisponivel = AcucarDisponivel - 10;
            Console.WriteLine("Café feito, usando 10g de açucar");
        }

        public string VisualizarAcucarDiponivel(){
            return $"{AcucarDisponivel}g";
        }    
    }
}