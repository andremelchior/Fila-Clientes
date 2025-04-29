using pratica_vetor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila
{
    class FilaCliente
    {
        private Cliente[] clientes = new Cliente[10];
        private int quantidade = 0;

        public void adicionarCliente(Cliente c)
        {
            if (quantidade >= clientes.Length)
            {
                Console.WriteLine("A fila está cheia!");
            }

            clientes[quantidade++] = c;
            ordenarFila();
        }

        public void mostrarFila()
        {
            if (quantidade == 0)
            {
                Console.WriteLine("A fila está vazia.");
            }

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("{0}º na fila: ", i + 1);
                clientes[i].exibirDados();
            }
        }

        public void atenderCliente()
        {
            if (quantidade == 0)
            {
                Console.WriteLine("A fila está vazia.");
            }
            else
            {
                Console.WriteLine("Chamando próximo da fila: ");
                clientes[0].exibirDados();

                for (int i = 1; i < quantidade; i++)
                {
                    clientes[i - 1] = clientes[i];
                }

                quantidade--;
            }
        }

        private void ordenarFila()
        {
            for (int i = 0; i < quantidade - 1; i++)
            {
                for (int j = i + 1; j < quantidade; j++)
                {
                    if (clientes[i].Prioridade > clientes[j].Prioridade)
                    {
                        Cliente aux = clientes[i];
                        clientes[i] = clientes[j];
                        clientes[j] = aux;
                    }
                }
            }
        }

    }
}
