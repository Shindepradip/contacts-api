using AutoMapper;
using ContactsAPI.Model;
using Evolent.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsAPI.Services
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Contact, ContactsModel>().ReverseMap();
        }
    }
}
