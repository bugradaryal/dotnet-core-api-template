using Business.Abstract;
using Business.Concrete.DataLayer;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IGenericService<User>
    { 
        private IGenericRepository<User> _genericRepository;
        public UserManager()
        {
            _genericRepository = new GenericRepository<User>();
        }

        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }

        public ObjectListClass<User> GetAll()
        {
            var obj = new ObjectListClass<User>();
            try
            {
                obj.Data = _genericRepository.GetAll();
                if (obj.Data.IsNullOrEmpty())
                {
                    obj.Status = (int)HttpStatusCode.NotFound;
                    return obj;
                }
                else
                {
                    obj.Status = (int)HttpStatusCode.OK;
                    return obj;
                }
            }
            catch(Exception)
            {
                obj.Status = (int)HttpStatusCode.BadRequest;
                return obj;
            }
        }
    }
}
