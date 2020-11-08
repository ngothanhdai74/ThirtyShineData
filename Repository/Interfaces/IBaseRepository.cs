using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Uitility.Common;

namespace Repository.Interfaces
{
    public interface IBaseRepository<TModel>
        where TModel : class
    {
        Task<bool> DeleteAsync(int t);
        Task<bool> UpdateAsync(TModel t);
        Task<bool> AddAsync(TModel t);
        Task<TModel> GetByIdAsync(int id);
        Task<TModel> FindAsync(Expression<Func<TModel, bool>> expression);
        Task<IList<TModel>> QueryAsync(Paging paging, params Expression<Func<TModel, bool>>[] expressions);
    }
}
