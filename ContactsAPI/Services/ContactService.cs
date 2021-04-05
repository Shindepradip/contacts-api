using AutoMapper;
using ContactsAPI.Model;
using Evolent.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsAPI.Services
{
    public class ContactService : IContactService
    {
        private readonly IRepository<Contact> _repo;
        private readonly IMapper _mapper;

        public ContactService(IRepository<Contact> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        /// <inheritdoc/>
        public IEnumerable<ContactsModel> GetItems()
        {
            return _mapper.Map<IEnumerable<ContactsModel>>(_repo.GetAll().ToList());
        }

        /// <inheritdoc/>
        public ContactsModel GetItem(int id)
        {
            return _mapper.Map<ContactsModel>(_repo.Get(id.ToString()));
        }

        /// <inheritdoc/>
        public ContactsModel AddItem(ContactsModel contact)
        {

            var items = _repo.GetAll();
            int Id = 0;

            if (items.Any())
            {
                Id = Convert.ToInt32(items.OrderByDescending(item => item.Id).FirstOrDefault().Id);
            }

            var dataItem = _mapper.Map<Contact>(contact);
            dataItem.Id = Convert.ToString(Id + 1);

            return _mapper.Map<ContactsModel>(_repo.InsertOrUpdate(dataItem));
        }

        /// <inheritdoc/>
        public void Update(ContactsModel contact, int id)
        {
            contact.Id = id;
            _repo.InsertOrUpdate(_mapper.Map<Contact>(contact));
        }

        /// <inheritdoc/>
        public void Delete(int id)
        {
            _repo.Delete(id.ToString());
        }
    }
}
