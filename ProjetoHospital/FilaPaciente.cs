using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHospital
{
    internal class FilaPaciente
    {
        private Cadastro[] fila;
        private int capacidade;
        private int contador;

        public void vetor(int Capacidade)
        {
            this.capacidade = Capacidade;
            fila = new Cadastro[Capacidade];
            contador = 0;
        }

        public void InserirPaciente(Cadastro paciente)
        {
            if (contador < capacidade)
            {
                fila[contador] = paciente;
                contador++;
        
            }
            else
            {
                Console.WriteLine("Erro");
            }
        }

        public void ListarPaciente()
        {
            Console.WriteLine("Lista de Pacientes:");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"[{i + 1}] Paciente: {fila[i].nome}, Idade: {fila[i].idade}, Prioridade: {fila[i].prioridade.prioridade}");
            }
        }

        public void AtenderPaciente()
        {
            if (contador > 0)
            {
                Cadastro pacienteAtendido = fila[0];
                for (int i = 1; i < contador; i++)
                {
                    fila[i - 1] = fila[i];
                }
                fila[contador - 1] = null;
                contador--;
                Console.WriteLine("Paciente Atendido :)");
            }
            else
            {
                Console.WriteLine("Não tem pacientes");
            }
        }
    }
    
}
