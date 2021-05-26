using System;
using ExPoo.Classes;

namespace ExPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            ElevadorSocial social = new ElevadorSocial();
            ElevadorDeServico servico = new ElevadorDeServico();
            bool repetir_menu = false;

            do
            {  
            Console.WriteLine($@"Qual elevador deseja entrar?
1- Elevador social

2- Elevador de serviço");

            string EscolhaElevador = Console.ReadLine();
            switch (EscolhaElevador)
            {
                case "1":
                    social.Inicializar();
                    do
                    {

                        Console.WriteLine($@"O que deseja Fazer?
1- Entrar

2- Sair

3- Subir

4- Descer

5- Trocar de elevador");
                        string OpcaoElevador1 = Console.ReadLine();
                        switch (OpcaoElevador1)
                        {
                            case "1":
                                social.Entrar();
                                repetir_menu = true;
                                break;
                            case "2":
                                social.Sair();
                                repetir_menu = true;
                                break;
                            case "3":
                                social.Subir();
                                repetir_menu = true;
                                break;
                            case "4":
                                social.Decer();
                                repetir_menu = true;
                                break;
                            case "5":
                                repetir_menu = false;
                                break;
                            default:
                                Console.WriteLine("Resposta invalida tente novamente");
                                repetir_menu = true;
                                break;
                        }
                    } while (repetir_menu == true);
                    break;
                case "2":
                    servico.Inicializar();
                    do
                    {

                        Console.WriteLine($@"O que deseja Fazer?
1- Entrar

2- Sair

3- Subir

4- Descer

5- Trocar de elevador");
                        string OpcaoElevador1 = Console.ReadLine();
                        switch (OpcaoElevador1)
                        {
                            case "1":
                                servico.Entrar();
                                repetir_menu = true;
                                break;
                            case "2":
                                servico.Sair();
                                repetir_menu = true;
                                break;
                            case "3":
                                servico.Subir();
                                repetir_menu = true;
                                break;
                            case "4":
                                servico.Decer();
                                repetir_menu = true;
                                break;
                            case "5":
                                repetir_menu = false;
                                break;
                            default:
                                Console.WriteLine("Resposta invalida tente novamente");
                                repetir_menu = true;
                                break;
                        }
                    } while (repetir_menu == true);
                    break;
                default:
                    break;
            }
            } while (repetir_menu == false);

        }
    }
}
