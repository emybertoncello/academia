using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Entidades
{
    public class Treinamento
    {
        public string Nome { get; private set; }
        public List<Treino> Treinos { get; private set; }
        public string Duracao { get; private set; }

        public Treinamento(string nome, string duracao)
        {
            Nome = nome;
            Treinos = new List<Treino>();
            Duracao = duracao;
        }

        public void CadastrarTreino(Treino treino)
        {
            Treinos.Add(treino);
        }
    }
}
