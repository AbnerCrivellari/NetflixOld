using System;
using System.Collections.Generic;
using System.Linq;

namespace NetflixOld
{
    class Program
    {
        public static List<string> listaFilmes = new List<string>();

        static void Main(string[] args)
        {
            int menu = 0;

            do
            {
                menu = ExibirMenu();
                switch (menu)
                {
                    case 1:
                        Cadastrar();
                        break;
                    case 2:
                        ExibirLista();
                        break;
                    case 3:
                        Console.WriteLine("Pesquisar");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Deletar");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Sair");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        Console.ReadKey();
                        break;
                }

            } while (menu != 5);
        }

        static int ExibirMenu()
        {
            Console.WriteLine("Bem Vindo ao Administrativo Old Netflix!");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1. Cadastrar um filme");
            Console.WriteLine("2. Exibir todos os Filmes");
            Console.WriteLine("3. Pesquisar por um filme");
            Console.WriteLine("4. Remover um filme");
            Console.WriteLine("5. Sair");
            Console.WriteLine("Menu: ");
            var resultado = Console.ReadLine();

            int inteiro = 0;

            if (int.TryParse(resultado, out inteiro))
                return inteiro;
            else
            {
                Console.WriteLine("Opção deve ser um numero!");
                Console.ReadKey();
                return 5;
            }
        }

        static void Cadastrar()
        {
            Console.Clear();
            Console.WriteLine("Bem Vindo ao Old Netflix!");
            Console.WriteLine("Por favor informe o nome do filme a ser cadastrado:");

            var result = Console.ReadLine();


            if (!string.IsNullOrEmpty(result))
            {
                listaFilmes.Add(result);

                Console.WriteLine("Filme Cadastrado com sucesso. Pressione enter para voltar");
            }
            else
                Console.WriteLine("Erro ao cadastrar. Nome vazio ou nulo.");

            Console.ReadKey();
            Console.Clear();
        }

        static void ExibirLista()
        {

            Console.Clear();
            Console.WriteLine("Bem Vindo ao Old Netflix!");
            Console.WriteLine("Catalogo de Filmes:");

            if (listaFilmes.Any())
            {
                for (int i = 0; i < listaFilmes.Count(); i++)
                {
                    Console.WriteLine($"{i} - {listaFilmes[i]}");
                }

                Console.WriteLine("########### Fim da Lista ##############");
            }
            else
            {
                Console.WriteLine("NAO HA FILMES CADASTRADOS");
            }

            Console.ReadKey();
            Console.Clear();

        }
    }
}

