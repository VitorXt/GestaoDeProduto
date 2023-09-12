using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Application.ViewModels
{
    public class NovoProdutoViewModel
    {
        public String Nome { get;  set; }
        public int Estoque { get;  set; }
        public decimal Valor { get;  set; }
        public DateTime DataCadastro { get;  set; }
        public bool Ativo { get;  set; }
    }
}
