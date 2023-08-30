using GestaoDeProduto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        public void Adicionar(Produto produto);
        public void Atualizar(Produto produto);
        public IList<Produto> ObterTodos();
        public Produto ObterPorId(int id);
        public void Desativar(int id);
        public void Reativar(int id);
    }
}
