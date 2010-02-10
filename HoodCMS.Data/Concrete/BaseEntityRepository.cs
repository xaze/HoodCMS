using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HoodCMS.Data.Interfaces;

namespace HoodCMS.Data.Concrete
{
    public class BaseEntityRepository<T> : IRepository<T>
    {
        #region IRepository<T> Members

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetNextThree()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetPage(int? page)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
