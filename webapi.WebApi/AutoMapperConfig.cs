using System;
using AutoMapper;
using webapi.Models;
using webapi.Dto;

namespace webapi.WebApi
{
    public class AutoMapperWebApiProfile : Profile
    {
        public AutoMapperWebApiProfile()
        {
            CreateMap<webapi.Models.User, webapi.Dto.User>();
        }
    }
}


