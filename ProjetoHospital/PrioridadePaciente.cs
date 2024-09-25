using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHospital
{
    internal class PrioridadePaciente
    {
        public int prioridade;
        public void DefinirPrioridade()
        {
            Console.WriteLine("Escolha a prioridade do paciente:");
            Console.WriteLine("1. Letal");
            Console.WriteLine("2. Grave");
            Console.WriteLine("3. Alto");
            Console.WriteLine("4. Médio");
            Console.WriteLine("5. Baixo");
            Console.WriteLine("6. Mínimo");
            Console.Write("Digite qual o numero voce é correspondente ");
            prioridade = int.Parse(Console.ReadLine());
        }
    }
}
