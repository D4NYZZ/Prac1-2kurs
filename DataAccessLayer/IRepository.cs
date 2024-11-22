using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace DataAccessLayer
{
    public interface IRepository<T> where T : IDomainObject, new()
    {
        void Create(T obj);
        IEnumerable<T> GetAll();
        T ReadById(int id);
        void Update(T obj);
        void Delete(T obj);
    }
}
