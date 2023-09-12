using GestaoDeProduto.Domain.Entities;
using GestaoDeProduto.Domain.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        #region - Construtor

        private readonly string _produtoCaminhoArquivo;
        public ProdutoRepository()
        {
            _produtoCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "FileJsonData", "produto.json");
        }

        #endregion

        #region - Funções do Repositório

        public void Adicionar(Produto produto)
        {
            List<Produto> produtos = new List<Produto>();
            int proximoCodigo = ObterProximoCodigoDisponivel();
            produto.AtribuirCodigo(proximoCodigo);
            produtos.Add(produto);
            EscreverProdutosNoArquivo(produtos);
        }

        public void Atualizar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public void Desativar(int id)
        {
            throw new NotImplementedException();
        }

        public Produto ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Produto> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Reativar(int id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region - Funções do Arquivo

        private List<Produto> LerProdutosDoArquivo()
        {
            if (!System.IO.File.Exists(_produtoCaminhoArquivo))
            {
                return new List<Produto>();
            }

            string json = System.IO.File.ReadAllText(_produtoCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<Produto>>(json);
        }

        private int ObterProximoCodigoDisponivel()
        {
            List<Produto> produtos = LerProdutosDoArquivo();
            if (produtos.Any())
            {
                return produtos.Max(p => p.Codigo) + 1;
            }
            else
            {
                return 1;
            }
        }

        private void EscreverProdutosNoArquivo(List<Produto> produtos)
        {
            string json = JsonConvert.SerializeObject(produtos);
            System.IO.File.WriteAllText(_produtoCaminhoArquivo, json);
        }

        #endregion
    }
}
