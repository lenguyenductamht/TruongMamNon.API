using AutoMapper;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Drawing.Printing;
using System.Linq.Expressions;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Interfaces;
using TruongMamNon.BackendApi.ViewModels.MamNon;

namespace TruongMamNon.BackendApi.Repositories
{
    public class GenericRepository<T, TVm> : IGenericRepository<T, TVm> where T : class
        where TVm : class
    {
        private readonly TruongMamNonDbContext _context;
        private readonly IMapper _mapper;
        private DbSet<T> dbSet = null;

        public GenericRepository(TruongMamNonDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            dbSet = _context.Set<T>();
        }

        public async Task<bool> Delete(object id)
        {
            var entity = await dbSet.FindAsync(id);
            if (entity == null)
            {
                return false;
            }
            return await Delete(entity);
        }

        public async Task<bool> Delete(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteMulti(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> entities = dbSet.Where<T>(where).AsEnumerable();
            foreach (T entity in entities)
            {
                dbSet.Remove(entity);
            }
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<TVm>> GetAll()
        {
            var entities = await dbSet.ToListAsync();
            return _mapper.Map<IEnumerable<TVm>>(entities);
        }

        public async Task<TVm> GetById(object id)
        {
            var entity = await dbSet.FindAsync(id);
            return _mapper.Map<TVm>(entity);
        }

        public async Task<bool> Post(TVm model)
        {
            var entity = _mapper.Map<T>(model);
            dbSet.Add(entity);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> Put(object id, TVm model)
        {
            var entity = _mapper.Map<T>(model);
            dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        //public IEnumerable<T> Get(
        //    Expression<Func<T, bool>> filter = null,
        //    Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        //    string includeProperties = "")
        //{
        //    IQueryable<T> query = dbSet;

        //    if (filter != null)
        //    {
        //        query = query.Where(filter);
        //    }

        //    foreach (var includeProperty in includeProperties.Split
        //        (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        //    {
        //        query = query.Include(includeProperty);
        //    }

        //    if (orderBy != null)
        //    {
        //        return orderBy(query).ToList();
        //    }
        //    else
        //    {
        //        return query.ToList();
        //    }
        //}
    }
}