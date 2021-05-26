using System;
namespace Ex2Poo.Classes
{
    public class JogadorMeio: JogadorDeFut
    {
        public override void TempoRestante(){
           int aposentado = 38 - RetorneIdade();
           if (aposentado >= 38)
           {
               Console.WriteLine("Você deveria ou já esta aposentado");
           }
           else
           {
                Console.WriteLine($"ainda faltam {aposentado} ano(s) para se aposentar");
           }
        }
    }
}