using System;
using Ex3Poo.Classes;

namespace Ex3Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe m = new MaquinaCafe();
            bool loop = true;
            do
            {    
            Console.WriteLine(@"Qual café você gostaria de fazer?
1- café padrão

2- café com quantidade especifica de açucar

3- visualizar quantidade de açucar disponivel

4- sair");
            string menu = Console.ReadLine();
            switch (menu)
            {
                case "1":
                    m.FazerCafe();
                    break;
                case "2":
                    Console.WriteLine("Quanto de açucar gostaria? (caso seja 0g ele vira sem açucar)");
                    int quant_cafe = int.Parse(Console.ReadLine());
                    m.FazerCafe(quant_cafe);
                    break;
                case "3":
                    Console.WriteLine(m.VisualizarAcucarDiponivel());
                    break;
                case "4":
                    Console.WriteLine("Bom café!");
                    loop = false;
                    break;
                default:
                    Console.WriteLine("Resposta invalida");
                    break;
            }
            } while (loop == true);  
        }
    }
}
