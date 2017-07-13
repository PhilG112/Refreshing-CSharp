using System;
using System.Collections.Generic;
using System.Linq;

namespace ACM.BL
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private List<T> _source;

        public GenericRepository(List<T> source)
        {
            _source = source;
        }

        public T GetById(int id)
        {
            var entity = _source.FirstOrDefault(x => x.Id == id);
            return entity;
        }

        public IList<T> GetAll()
        {
            return _source;
        }

        public void Insert(T entity)
        {
            _source.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = _source.FirstOrDefault(x => x.Id == id);
            _source.Remove(entity);
        }
    }
}
