using System;
using System.Globalization;
using Data;
using System.Collections.Generic;

namespace ConsoleApp1
{

    class Menu { 
        public static void Executar()
        {
            //Cabecalho
            Cabecalho();
            //Opcoes 
            opcoes();
            //Menu
            menuOpcao();
            //rodape
            rodape();

        }

        private static void rodape()
        {
            Console.WriteLine("Saindo... Presione ENTER para sair");
        }

        private static void opcoes()
        {
            Console.WriteLine("\nOpções: \n\t1. Cadastro de Usuario \n\t2. Cadastro de produto \n\t0. Sair da aplicação");
        }

        private static void Cabecalho()
        {
            Console.WriteLine("**************** Havan Labs ****************");
            Console.WriteLine("************** Seja bem-vindo **************");
        }
        private static void menuOpcao()
        {

            int opcao = 0;
            TextInfo tC = new CultureInfo("pt-BR", false).TextInfo;

            do
            {

                Console.Write("\nDigite a opção desejada: ");
                opcao = Validacao.ValidaInteiros();

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Saindo da aplicação");
                        break;
                    case 1:
                        string resposta = "";
                        List<Usuario> usu = new List<Usuario>();
                        do
                        {
                            Console.Write("Para iniciar seu cadstro digite seu nome: ");
                            string nome = Validacao.validaStringEmBranco();
                            Console.Write("Digite seu sobrenome: ");
                            string sobrenome = Validacao.validaStringEmBranco();
                            Console.Write("Digite sua idade: ");
                            int idade = Validacao.ValidaInteiros();
                            Console.Write("Digite seu endereco de e-mail: ");
                            string email = Validacao.validaStringEmBranco();
                            Console.Write("Digite seu endereco de residencia: ");
                            string endereco = Validacao.validaStringEmBranco();

                            Usuario user = new Usuario(nome, sobrenome, idade, email, endereco);
                            usu.Add(user);
                            Console.WriteLine("Deseja cadastrar um novo usuario? (y/n)");
                            resposta = Console.ReadLine();

                        Console.WriteLine($"O cliente {tC.ToTitleCase(user.Nome) + " " + tC.ToTitleCase(user.Sobrenome)} possui {user.Idade} anos de idade reside em {tC.ToTitleCase(user.Endereco)} e seu endereço de E-mail é {user.Email} \n");

                        } while (resposta == "y");

                        break;
                    case 2:
                        Console.WriteLine("Em implementação (falta de dev)\n");
                        break;
                    default:
                        Console.WriteLine("\nOpção inexistente! Digite uma das opções apresentadas: ");
                        opcoes();
                        break;
                }
            } while (opcao < 0 || opcao > 2);

            //Console.WriteLine("Para sair tecle ENTER");
            //Console.ReadLine();

        }
    }
}