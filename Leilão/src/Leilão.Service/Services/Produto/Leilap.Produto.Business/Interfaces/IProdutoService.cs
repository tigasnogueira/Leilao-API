using Leilao.Produto.Business.Models;

namespace Leilao.Produto.Business.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(ProdutoModel produto);
        Task Atualizar(ProdutoModel produto);
        Task Remover(Guid id);
    }
}
