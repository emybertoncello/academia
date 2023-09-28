using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Entidades
{
    public class Treino
    {
        public string Nome { get; set; }
        public List<Exercicio> Exercicios { get; set; }

        public Treino(string nome)
        {
            Nome = nome;
            Exercicios = new();
        }

        public void CadastrarExercicio(Exercicio exercicio)
        {
            Exercicios.Add(exercicio);
        }
    }
}
