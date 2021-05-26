using System;
namespace ExPoo.Classes
{
    public class Elevador
    {
        public int TotalAndar;
        public int CapacidadePessoas;
        public int PessoasAtual = 0;
        public int AndarAtual = 0;
         
        public virtual void Inicializar(){
            Console.WriteLine("Quantos andares tem no prédio?");
            TotalAndar = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Qual a capacidade máxima de pessoas do elevador");
            CapacidadePessoas = int.Parse(Console.ReadLine());
        }
        
        public virtual void Entrar(){
            Console.WriteLine("Quantas pessosa iram entrar no elevador?");
            int EntrarPessoasElevador = int.Parse(Console.ReadLine());
            if (EntrarPessoasElevador + PessoasAtual > CapacidadePessoas)
            {
                Console.WriteLine("Desculpe o elevador esta cheio!");
            }
            else
            {   
                PessoasAtual = EntrarPessoasElevador + PessoasAtual;
                Console.WriteLine($"Tem {PessoasAtual} pessoas no elevador atualmente");
            }
        }
        public virtual void Sair(){
            Console.WriteLine("Quantas pessosa iram sair do elevador?");
            int SairPessoasElevador = int.Parse(Console.ReadLine());
            if (SairPessoasElevador - PessoasAtual <= 0)
            {
                Console.WriteLine("O elevador esta vazio");
            }
            else
            {
                PessoasAtual = PessoasAtual - SairPessoasElevador;
                Console.WriteLine($"Tem {PessoasAtual} pessoas no elevador atualmente");
            }
        }
        public void Subir(){
            Console.WriteLine("Quantos andares deseja subir?");
            int SubirElevador = int.Parse(Console.ReadLine());
            if (SubirElevador + AndarAtual > TotalAndar)
            {
                Console.WriteLine("estamos no ultimo andar ;)");
            }
            else
            {   
                AndarAtual = SubirElevador + AndarAtual;
                Console.WriteLine($"estamos no {AndarAtual}º andar");
            }
        }
        public void Decer(){
            Console.WriteLine("Quantos andares deseja descer?");
            int DecerElevador = int.Parse(Console.ReadLine());
            if (DecerElevador - AndarAtual < TotalAndar)
            {
                Console.WriteLine("estamos no terrio andar ;)");
            }
            else
            {
                AndarAtual = DecerElevador - AndarAtual;
                Console.WriteLine($"estamos no {AndarAtual}º andar");
            }
        }
    }
}