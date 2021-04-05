using System;
using System.Collections.Generic;
using System.Text;

namespace Evolent.Persistance
{
    public interface IRepository<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T Get(string id);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetAll();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public T InsertOrUpdate(T element);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        void Delete(string id);
    }
}
