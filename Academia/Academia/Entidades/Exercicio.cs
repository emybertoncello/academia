using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Entidades
{
    public class Exercicio
    {
        public string Nome { get; set; }
        public string GrupoMuscular { get; set; }
        public int Series { get; set; }
        public int Repeticoes { get; set; }

        public Exercicio(string nome, string grupoMuscular, int series, int repeticoes)
        {
            Nome = nome;
            GrupoMuscular = grupoMuscular;
            Series = series;
            Repeticoes = repeticoes;
        }
    }
}
