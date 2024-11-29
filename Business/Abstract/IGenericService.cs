using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Concrete.DataLayer;
using Entities;

namespace Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        ObjectListClass<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity); 
    }
}
