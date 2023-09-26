using Abp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using OnlineExamSystem.Data;
using OnlineExamSystem.EntityFrameworkCore.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.EntityFrameworkCore.Concrete
{
    public class EfEntityRepositoryBase<T> : IEntityRepository<T> where T : class, IDataEntity, new()
    {
        internal DbSet<T> dbset;
        private readonly OnlineExamSystemDbContext _context = null;

        public EfEntityRepositoryBase(OnlineExamSystemDbContext context)
        {
            _context = context;
            this.dbset = _context.Set<T>();
        }
        public void Add(T entity)
        {
            dbset.Add(entity);
        }

        public void Delete(T entityToDelete)
        {
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbset.Attach(entityToDelete);
            }
            dbset.Remove(entityToDelete);
        }

        public async Task<T> DeleteAsync(T entityToDelete)
        {
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbset.Attach(entityToDelete);
            }
            dbset.Remove(entityToDelete);
            return entityToDelete;
        }

        public void DeleteByID(object id)
        {
            T entityToDelete = dbset.Find(id);
            Delete(entityToDelete);
        }

        public T GetByID(object id)
        {
            return dbset.Find(id);
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await dbset.FindAsync(id);
        }

        public void Update(T entityToUpdate)
        {
            dbset.Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public async Task<T> UpdateAsync(T entityToUpdate)
        {
            dbset.Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State= EntityState.Modified;
            return entityToUpdate;
        }

        public async Task<T> AddAsync(T entity)
        {
            dbset.Add(entity);
            return entity;
        }

        public IEnumerable<T> GetAll(Expression<Func<T>> filter = null, 
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, 
            string includeProperties = "")
        {
            IQueryable<T> query = dbset;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }
            if (orderBy!=null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }
    }
}
