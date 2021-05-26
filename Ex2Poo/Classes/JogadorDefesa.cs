using System;
namespace Ex2Poo.Classes
{
    public class JogadorDefesa: JogadorDeFut
    {
        public override void TempoRestante(){
           int aposentado = 40 - RetorneIdade();
           if (aposentado >= 40)
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