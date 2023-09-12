using GestaoDeProduto.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Application.Interfaces
{
    public interface IProdutoService
    {
        public void Adicionar(NovoProdutoViewModel produto);
        public void Atualizar(EditaProdutoViewModel produto);
        public IList<ProdutoViewModel> ObterTodos();
        public ProdutoViewModel ObterPorId(int id);
        public void Desativar(int id);
        public void Reativar(int id);

    }
}
