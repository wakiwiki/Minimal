using System.Linq.Expressions;

namespace Minimal.Core.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class
    {
        Task CreateAsync(T entity);
        Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> predicate);
    }
}
