using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratica_vetor
{
    class Cliente : Pessoa
    {
        public int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public int Prioridade { get; set; }

        public override void cadastrar()
        {
            base.cadastrar();
            Console.WriteLine("Digite o seu id: ");
            this.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua prioridade (1 - Prioritário | 2 - Normal): ");
            this.Prioridade = int.Parse(Console.ReadLine());

            while (this.Prioridade != 1 && this.Prioridade != 2)
            {
                Console.WriteLine("Erro! Digite a prioridade corretamente (1 - Prioritário | 2 - Normal): \n");
                this.Prioridade = int.Parse(Console.ReadLine());
            }
        }

        public override void exibirDados()
        {
            base.exibirDados();
            Console.WriteLine("ID: " + this.Id);

            if (this.Prioridade == 1)
            {
                Console.WriteLine("Tipo: Preferencial\n");
            } 
            else
            {
                Console.WriteLine("Tipo: Normal\n");
            }
        }
    }
}