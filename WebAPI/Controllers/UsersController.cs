using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase,IControllerRepository<User>
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            throw new NotImplementedException();
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            throw new NotImplementedException();
        }
        [HttpPost("Add")]
        public IActionResult Add(User entity)
        {
            throw new NotImplementedException();
        }
        [HttpPost("Update")]
        public IActionResult Update(User entity)
        {
            throw new NotImplementedException();
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
