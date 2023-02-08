using AutoMapper;
using PracticomService.Common.DTOs;
using PracticomService.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticomService.Services
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<UserDTO,User>().ReverseMap();
            CreateMap<ChildDTO, Child>().ReverseMap();

        }
    }
}
