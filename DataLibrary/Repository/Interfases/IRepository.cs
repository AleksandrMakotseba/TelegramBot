using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Repository.Interfases
{
    public interface IRepository<T> where T : class
    {
        void Add(T obj, int id);
        T Get(int id);
        IList<T> GetAll();
        void Remove(int id);
        void Update(T newObj, int id);
        void Clear();
    }
}
