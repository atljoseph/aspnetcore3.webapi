using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapi.Business;
using webapi.AuthDAL;
using webapi.Dto;
using webapi.Models;
using AutoMapper;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IMapper mapper;

        public UsersController(IMapper autoMapper)
        {
            mapper = autoMapper;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<webapi.Dto.User>> Get()
        {
            var authBusiness = new AuthBusiness();
            var modelUsers = authBusiness.GetUsers();
            var dtoUsers = mapper.Map<List<webapi.Models.User>, List<webapi.Dto.User>>(modelUsers);
            return dtoUsers;
        }

    }
}
