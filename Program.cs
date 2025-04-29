using Fila;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratica_vetor
{
    class Program
    {
        static void Main(string[] args)
        {

            string op;
            int i = 0;
            FilaCliente fila = new FilaCliente();
            Cliente[] cliente = new Cliente[9];

            do
            {
                Console.Clear();
                Console.WriteLine("\n Programa: Fila de Clientes de Banco\n");
                Console.WriteLine("\n Digite uma opção: \n");
                Console.WriteLine("  --------------------------- ");
                Console.WriteLine(" |   (1) - CADASTRAR CLIENTE |");
                Console.WriteLine(" |   (2) - ENTRAR NA FILA    |");
                Console.WriteLine(" |   (3) - MOSTRAR FILA      |");
                Console.WriteLine(" |   (4) - ATENDER CLIENTE   |");
                Console.WriteLine(" |   (Q) - SAIR DO PROGRAMA  |");
                Console.WriteLine("  --------------------------- \n");
                op = Console.ReadLine().ToUpper();


                switch (op)
                {
                    case "1":
                        if (i < cliente.Length)
                        {
                            cliente[i] = new Cliente();
                            cliente[i].cadastrar();
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("Limite de cadastro atingido!");
                        }
                        break;
                    case "2":
                        if (i == 0)
                        {
                            Console.WriteLine("Não há clientes cadastrados!");
                            break;
                        }

                        Console.WriteLine("Digite o número do cliente que irá entrar na fila (1 a {0}): ", i);
                        int nr_cliente = int.Parse(Console.ReadLine());

                        if (nr_cliente >= 1 && nr_cliente <= i && cliente[nr_cliente - 1] != null)
                        {
                            fila.adicionarCliente(cliente[nr_cliente - 1]);
                        }
                        else
                        {
                            Console.WriteLine("Número inválido ou não cadastrado!");
                        }

                        break;
                    case "3":
                        fila.mostrarFila();
                        break;
                    case "4":
                        fila.atenderCliente();
                        break;
                    case "Q":
                        Console.WriteLine("Encerrando...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();

            } while (op != "q".ToUpper());

        }
    }
}