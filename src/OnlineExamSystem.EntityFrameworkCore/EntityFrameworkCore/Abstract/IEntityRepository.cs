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
        public IEnumerable<T> GetAll(Expression<Func<T, bool>>filter = null);
        public void Add(T entity);
        Task<T> GetAllAsync(T entity);
        public void Update(T entity);
        Task<T> UpdateAsync(T entity);
        public void Delete(T entity);
        Task<T> DeleteAsync(T entity);
        public void DeleteByID(object id);

    }
}
