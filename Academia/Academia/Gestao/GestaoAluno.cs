using Academia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Gestao
{
    public class GestaoAluno
    {
        public List<Aluno> ListaAlunos { get; set; }

        public GestaoAluno()
        {
            ListaAlunos = new List<Aluno>();
        }

        public void CadastrarAluno(Aluno aluno)
        {
            ListaAlunos.Add(aluno);
        }
    }
}
