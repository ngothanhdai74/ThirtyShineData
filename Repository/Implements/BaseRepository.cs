using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Uitility.Common;

namespace Repository.Implements
{
    public abstract class BaseRepository<TDbContext, TModel> : IBaseRepository<TModel>
        where TDbContext : DbContext
        where TModel : class
    {
        protected readonly TDbContext _dbContext;
        public BaseRepository(TDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #region Read
        public virtual async Task<IList<TModel>> QueryAsync(Paging paging, params Expression<Func<TModel, bool>>[] expressions)
        {
            var data = _dbContext.Set<TModel>().AsQueryable();
            foreach (Expression<Func<TModel, bool>> expression in expressions) data = data.Where(expression);
            if (paging != null)
            {
                paging.TotalRow = await data.CountAsync();
                data = data.Skip(paging.PageIndex * paging.PageSize).Take(paging.PageSize);
            }
            return await data.ToArrayAsync();
        }
        public virtual async Task<TModel> FindAsync(Expression<Func<TModel, bool>> expression) => await _dbContext.Set<TModel>().FirstOrDefaultAsync(expression);
        public virtual async Task<TModel> GetByIdAsync(int id) => await _dbContext.Set<TModel>().FindAsync(id);
        #endregion
        #region Write
        public virtual async Task<bool> AddAsync(TModel t)
        {
            try
            {
                await _dbContext.Set<TModel>().AddAsync(t);
                return (await _dbContext.SaveChangesAsync()) > 0;
            }
            catch
            {
                throw new Exception("");
            }
        }
        public virtual async Task<bool> UpdateAsync(TModel t)
        {
            try
            {
                _dbContext.Set<TModel>().Update(t);
                return (await _dbContext.SaveChangesAsync()) > 0;
            }
            catch
            {
                throw new Exception("");
            }
        }
        public virtual async Task<bool> DeleteAsync(int t)
        {
            try
            {
                var result = await _dbContext.Set<TModel>().FindAsync(t);
                if (result != null)
                {
                    _dbContext.Set<TModel>().Remove(result);
                    return (await _dbContext.SaveChangesAsync()) > 0;
                }
                return false;
            }
            catch
            {
                throw new Exception("");
            }
        }
        #endregion
    }
}
