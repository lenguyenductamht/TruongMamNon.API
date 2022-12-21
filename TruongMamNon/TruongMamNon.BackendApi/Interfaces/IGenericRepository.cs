using System.Linq.Expressions;

namespace TruongMamNon.BackendApi.Interfaces
{
    public interface IGenericRepository<T, TVm> where T : class
        where TVm : class
    {
        Task<IEnumerable<TVm>> GetAll();

        Task<TVm> GetById(object id);

        Task<bool> Post(TVm model);

        Task<bool> Put(object id, TVm model);

        Task<bool> Delete(object id);

        Task<bool> Delete(T entity);

        Task<bool> DeleteMulti(Expression<Func<T, bool>> where);

        //IEnumerable<T> Get(

        //    Expression<Func<T, bool>> filter = null,
        //    Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        //    string includeProperties = "");
    }
}