using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Entidades
{
    public class PlanoTreinamento
    {
        public int Id { get; set; }
        public List<Treinamento> Treinamentos { get; private set; }

        public PlanoTreinamento()
        {
            Treinamentos = new List<Treinamento>();
        }
        public void CadastrarTreinamento(Treinamento treinamento)
        {
            Treinamentos.Add(treinamento);
        }
    }
}
