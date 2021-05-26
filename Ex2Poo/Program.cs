using System;
using Ex2Poo.Classes;

namespace Ex2Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            JogadorDefesa d = new JogadorDefesa();
            JogadorAtaque a = new JogadorAtaque();
            JogadorMeio m = new JogadorMeio();


            Console.WriteLine($@"Qual seu tipo de jogador?
1- Jogador de Ataque

2- Jogador de Defesa

3- Jogador Meio");
            string TipoJogador = Console.ReadLine();
            switch (TipoJogador)
            {
                case "1":
                    Console.WriteLine("Qual seu nome?");
                    a.Nome = Console.ReadLine();
                    
                    Console.WriteLine("Em que ano naceu?");
                    a.DataNacimento = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Qual a sua nacionalidade?");
                    a.Nacionalidade = Console.ReadLine();
                    
                    Console.WriteLine("Qual seu tamanho?");
                    a.Altura = Console.ReadLine();
                    
                    Console.WriteLine("Qual seu peso?");
                    a.Peso = Console.ReadLine();
                    
                    Console.WriteLine($@"{a.Dado()}
{a.RetorneIdade()}
---------------------------------------
Tempo restante de aposentadoria");
                    a.TempoRestante();
                    break;
                case "2":
                    Console.WriteLine("Qual seu nome?");
                    d.Nome = Console.ReadLine();
                    
                    Console.WriteLine("Em que ano naceu?");
                    d.DataNacimento = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Qual a sua nacionalidade?");
                    d.Nacionalidade = Console.ReadLine();
                    
                    Console.WriteLine("Qual seu tamanho?");
                    d.Altura = Console.ReadLine();
                    
                    Console.WriteLine("Qual seu peso?");
                    d.Peso = Console.ReadLine();
                    
                    Console.WriteLine($@"{d.Dado()}
{d.RetorneIdade()}
---------------------------------------
Tempo restante de aposentadoria");
                    d.TempoRestante();
                    break;
                case "3":
                    Console.WriteLine("Qual seu nome?");
                    m.Nome = Console.ReadLine();
                    
                    Console.WriteLine("Em que ano naceu?");
                    m.DataNacimento = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Qual a sua nacionalidade?");
                    m.Nacionalidade = Console.ReadLine();
                    
                    Console.WriteLine("Qual seu tamanho?");
                    m.Altura = Console.ReadLine();
                    
                    Console.WriteLine("Qual seu peso?");
                    m.Peso = Console.ReadLine();

                    Console.WriteLine($@"{m.Dado()}
{m.RetorneIdade()}
---------------------------------------
Tempo restante de aposentadoria");
                    m.TempoRestante();
                    break;
                default:
                    break;
            }




        }
    }
}
