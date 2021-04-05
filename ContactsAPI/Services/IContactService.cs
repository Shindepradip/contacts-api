using ContactsAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsAPI.Services
{
    public interface IContactService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<ContactsModel> GetItems();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ContactsModel GetItem(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        ContactsModel AddItem(ContactsModel contact);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contact"></param>
        /// <param name="id"></param>
        void Update(ContactsModel contact, int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);
    }
}
