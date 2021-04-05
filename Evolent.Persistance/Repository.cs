using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Evolent.Persistance
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<T> : IRepository<T>
    {
        private readonly IDBContext _context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public Repository(IDBContext context)
        {
            _context = context;
        }

        /// <inheritdoc/>
        public T Get(string ID)
        {
            using var session = _context.store.OpenSession();
            var element = session.Load<T>(ID);
            return element;

        }

        /// <inheritdoc/>
        public IEnumerable<T> GetAll()
        {
          
            using var session = _context.store.OpenSession();
            var elements = session.Query<T>().ToList();

            return elements;
        }

        /// <inheritdoc/>
        public T InsertOrUpdate(T element)
        {
            using var session = _context.store.OpenSession();

            session.Store(element);
            session.SaveChanges();

            return element;
        }

        /// <inheritdoc/>
        public void Delete(string id)
        {
            using var session = _context.store.OpenSession();

            session.Delete(id);
            session.SaveChanges();
        }
    }
}
