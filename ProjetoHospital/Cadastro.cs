using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHospital
{
    internal class Cadastro
    {
        public int idade;
        public string nome;
        public string cep;
        public string cpf;
        public PrioridadePaciente prioridade;
        public void cadastro()
        {
            Console.WriteLine("Cadastro");
            Console.Write("Digite o nome do paciente: ");
            nome = Console.ReadLine();
            Console.Write("Digite a idade do paciente: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu CEP: ");
            cep = Console.ReadLine();
            Console.WriteLine("Digite seu CPF: ");
            cpf = Console.ReadLine();
            prioridade = new PrioridadePaciente(); // Inicializando a prioridade
            prioridade.DefinirPrioridade();
        }

    }
}
