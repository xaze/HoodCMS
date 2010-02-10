using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoodCMS.Data.Interfaces
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        void Delete(int id);
        T Get(int id);
        void Update(T entity);
        void Add(T entity);
        void Save();
        IQueryable<T> GetNextThree();
        IQueryable<T> GetPage(int? page);
    }
}
