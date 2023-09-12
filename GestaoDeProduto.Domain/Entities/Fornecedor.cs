using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Domain.Entities
{
    public class Fornecedor
    {

        #region - Construtores

        public Fornecedor(int codigo, string razaoSocial, int cNPJ, DateTime dataCadastro, string emailContato, bool ativo)
        {
            Codigo = codigo;
            RazaoSocial = razaoSocial;
            CNPJ = cNPJ;
            DataCadastro = dataCadastro;
            EmailContato = emailContato;
            Ativo = ativo;
        }

        #endregion

        #region - Propriedades

        public int Codigo { get; private set; }
        public String RazaoSocial { get; private set; }
        public int CNPJ { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string EmailContato { get; private set; }
        public bool Ativo { get; private set; }

        #endregion
    }
}
