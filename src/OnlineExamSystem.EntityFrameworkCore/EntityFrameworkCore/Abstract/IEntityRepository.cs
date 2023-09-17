using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.EntityFrameworkCore.Abstract
{
    public interface IEntityRepository <T> where T : class, IEntity
    {
        T GetByID(object id);
        Task<T> GetByIdAsync(object id);
        IEnumerable<T> GetAll(
            Expression<Func<T>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "");
        public void Add(T entity);
        Task<T> AddAsync(T entity);
        public void Update(T entityToUpdate);
        Task<T> UpdateAsync(T entityToUpdate);
        public void Delete(T entityToDelete);
        Task<T> DeleteAsync(T entityToDelete);
        public void DeleteByID(object id);

    }
}
