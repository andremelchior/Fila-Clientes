using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratica_vetor
{
    class Pessoa
    {
        public string nome; //atributo
        public string Nome { get; set; } //propriedade

        public int idade;
        public int Idade { get; set; }

        public string cpf;
        public string Cpf { get; set; }

        public double peso;
        public double altura;


        public virtual void cadastrar()
        {

            Console.WriteLine("Digite o seu nome: ");
            this.Nome = Console.ReadLine();

            while (this.Nome == null)
            {
                Console.Write("Nome inválido! Digite novamente: ");
                this.Nome = Console.ReadLine();
            }

            Console.WriteLine("Digite sua idade: ");
            this.Idade = int.Parse(Console.ReadLine());

            while(this.Idade < 0)
            {
                Console.Write("Idade inválida! Digite novamente: ");
                this.Idade = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite o seu CPF: ");
            this.Cpf = Console.ReadLine();
        }
        public virtual void exibirDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Idade: " + this.Idade);
            Console.WriteLine("CPF: " + this.Cpf);
        }

    }
}