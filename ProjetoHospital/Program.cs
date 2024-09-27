using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //teste
            FilaPaciente fila = new FilaPaciente();
            fila.vetor(10);
            string opcao = "";
            while (true)
            {
                Console.WriteLine("1. Cadastrar Paciente");
                Console.WriteLine("2. Listar Pacientes");
                Console.WriteLine("3. Atender Paciente");
                Console.WriteLine("Clique q para sair");
                opcao = Console.ReadLine();
                if (opcao == "q")
                {
                    break;
                }
                switch (opcao)
                {

                    case "1":

                        Cadastro novoPaciente = new Cadastro();
                        novoPaciente.cadastro();
                        fila.InserirPaciente(novoPaciente);
                        
                        Console.ReadKey();
                        break;
                    case "2":
                        fila.ListarPaciente();
                        Console.ReadKey();
                        break;
                    case "3":
                        fila.AtenderPaciente();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("digito errado");
                        
                        break;

                }

            }

        }
    }
}
