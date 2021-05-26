using System;
namespace Ex2Poo.Classes
{
    public class JogadorDeFut
    {
        public string Nome;
        public int DataNacimento;
        public string Nacionalidade;
        public string Peso; 
        public string Altura; 
        public string Dado(){
            return $@"Nome:{Nome} 
Data de nacimento: {DataNacimento}
Peso: {Peso} 
Alatura: {Altura}
Idade: {RetorneIdade()}";
        }
        public int RetorneIdade(){
            return DateTime.Now.Year - DataNacimento;
        }
        public virtual void TempoRestante(){
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