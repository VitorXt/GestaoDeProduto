using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Domain.Entities
{
    public class Produto
    {

        #region - Construtores

        public Produto(string nome, int estoque, decimal valor, bool ativo, DateTime dataCadastro)
        {
            Nome = nome;
            Estoque = estoque;
            Valor = valor;
            Ativo = ativo;
            DataCadastro = dataCadastro;
        }

        #endregion

        #region - Propriedades

        public int Codigo { get; private set; }
        public String Nome { get; private set; }
        public int Estoque { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public bool Ativo { get; private set; }

        #endregion

        #region - Comportamentos

        public void AdicionarEstoque(int qtdEstoque) => Estoque += qtdEstoque;
        public void BaixarEstoque(int qtdEstoque) => Estoque -= qtdEstoque;
        public void Ativar() => Ativo = true;
        public void Desativar() => Ativo = false;
        public void AlterarNome(string novoNome) => Nome = novoNome;

        public void AtribuirCodigo(int codigo) => Codigo = codigo;

        #endregion
    }
}
