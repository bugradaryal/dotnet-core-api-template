using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected AppDbContext DbContext = new AppDbContext();
        public List<T> GetAll()
        {
            return DbContext.Set<T>().ToList();            
        }
        public void Delete(T entity)
        {
            DbContext.Remove(entity);
        }
        public void Update(T entity)
        {
            DbContext.Update(entity);
            DbContext.SaveChanges();
        }
        public void Add(T entity) 
        {
            DbContext.Add(entity);
            DbContext.SaveChanges();
        }
    }
}
