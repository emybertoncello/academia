using Academia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Gestao
{
    public class GestaoTreinamento
    {
        public List<PlanoTreinamento> PlanoTreinamentos { get; set; }

        public GestaoTreinamento()
        {
            PlanoTreinamentos = new List<PlanoTreinamento>();
        }
        public void CadastrarTreinamento(PlanoTreinamento planoTreinamento)
        {
            PlanoTreinamentos.Add(planoTreinamento);
        }
    }
}
