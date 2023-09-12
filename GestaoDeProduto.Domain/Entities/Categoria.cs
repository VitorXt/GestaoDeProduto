using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Domain.Entities
{
    public class Categoria
    {

        #region - Construtores

        public Categoria(int codigo, string descrição, bool ativo)
        {
            Codigo = codigo;
            Descrição = descrição;
            Ativo = ativo;
        }

        #endregion

        #region - Propriedades

        public int Codigo { get; private set; }
        public String Descrição { get; private set; }
        public bool Ativo { get; private set; }

        #endregion
    }
}
