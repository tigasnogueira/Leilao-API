
using Entity;
using System.Linq.Expressions;

namespace Leilao.Intefaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : EntityModel
    {
        Task Adicionar(TEntity entity);
        Task<TEntity> ObterPorId(Guid id);
        Task<List<TEntity>> ObterTodos();
        Task Atualizar(TEntity entity);
        Task Remover(Guid id);
        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);
        Task<int> SaveChanges();
    }
}
