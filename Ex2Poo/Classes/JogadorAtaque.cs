using System;
namespace Ex2Poo.Classes
{
    public class JogadorAtaque: JogadorDeFut
    {
        public override void TempoRestante(){
           int aposentado = 35 - RetorneIdade();
           if (aposentado >= 35)
           {
               Console.WriteLine("Você deveria ou já esta aposentado");
           }
           else
           {
                Console.WriteLine($"ainda faltam {aposentado} ano(S) para se aposentar");
           }
        }
    }
}