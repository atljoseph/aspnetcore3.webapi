using System;
using webapi.AuthDAL;
using webapi.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using AutoMapper;

namespace webapi.Business
{
    public class AuthBusiness : AutoMapperService
    {
        public List<webapi.Models.User> GetUsers() {
            var dalUsers = new List<webapi.AuthDAL.Entities.User>();
            dalUsers.Add(new webapi.AuthDAL.Entities.User() { Id = 123, FirstName = "Hey", LastName = "You", UserName = "HeyYou123", PasswordHash = "hash", PasswordSalt = "salt" });
            var modelUsers = Mapper.Map<List<webapi.AuthDAL.Entities.User>, List<webapi.Models.User>>(dalUsers);
            return modelUsers;
        }
    }
}
