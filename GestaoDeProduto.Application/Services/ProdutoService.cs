using GestaoDeProduto.Application.Interfaces;
using GestaoDeProduto.Application.ViewModels;
using GestaoDeProduto.Domain.Entities;
using GestaoDeProduto.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void Adicionar(NovoProdutoViewModel produto)
        {
            _produtoRepository.Adicionar(
              new Produto(produto.Nome, produto.Estoque,produto.Valor, produto.Ativo, produto.DataCadastro)
            );

        }

        public void Atualizar(EditaProdutoViewModel produto)
        {
            throw new NotImplementedException();
        }

        public void Desativar(int id)
        {
            throw new NotImplementedException();
        }

        public ProdutoViewModel ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<ProdutoViewModel> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Reativar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
