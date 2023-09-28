using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Entidades
{
    public class Aluno
    {
        public string Nome { get; private set; }
        public string Sexo { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public List<PlanoTreinamento> PlanoTreinamentos { get; private set; }
        public Aluno(string nome, string sexo, DateTime dataNascimento)
        {
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            PlanoTreinamentos = new List<PlanoTreinamento>();

        }

        public void AdicionarTreinamentoAluno()
        {
            PlanoTreinamentos.Add(new PlanoTreinamento());

        }
    }
}
