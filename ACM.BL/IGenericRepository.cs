using System.Collections.Generic;

namespace ACM.BL
{
    public interface IGenericRepository<T>
    {
        T GetById(int id);
        IList<T> GetAll();
        void Insert(T entity);
        void Delete(int id);
    }
}
