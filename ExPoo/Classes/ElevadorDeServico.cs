using System;
namespace ExPoo.Classes
{
    public class ElevadorDeServico: Elevador
    {
        public override void Inicializar()
        {
            Console.WriteLine("Quantos andares tem no prédio?");
            TotalAndar = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Qual a capacidade máxima de caixas do elevador");
            CapacidadePessoas = int.Parse(Console.ReadLine());
        }

        public override void Entrar()
        {
            Console.WriteLine("Quantas caixas iram serão carregadas para o elevador?");
            int EntrarPessoasElevador = int.Parse(Console.ReadLine());
            if (EntrarPessoasElevador + PessoasAtual > CapacidadePessoas)
            {
                Console.WriteLine("Desculpe o elevador esta cheio!");
            }
            else
            {
                PessoasAtual = EntrarPessoasElevador + PessoasAtual;
                Console.WriteLine($"Tem {PessoasAtual} caixas no elevador atualmente");
            }
        }

        public override void Sair()
        {
            Console.WriteLine("Quantas caixas iram ser descarregadas do elevador?");
            int SairPessoasElevador = int.Parse(Console.ReadLine());
            if (SairPessoasElevador - PessoasAtual <= 0)
            {
                Console.WriteLine("O elevador esta vazio");
            }
            else
            {       
                PessoasAtual = SairPessoasElevador - PessoasAtual;
                Console.WriteLine($"Tem {PessoasAtual} pessoas no elevador atualmente");
            }
        }
    }
}