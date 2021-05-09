using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Common.Models;
using MISA.DataLayer.interfaces;
using MISA.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : BaseController<User>
    {
        IUserRepository _userRepository;
        #region CONSTRUCTOR
        public UserController(IBaseService<User> baseService, IUserRepository userRepository) : base(baseService)
        {
            _userRepository = userRepository;
        }
        #endregion
        
        [HttpGet("{userName}/{password}")]
        public IActionResult FindUser([FromRoute] string userName, [FromRoute] string password)
        {
            var res = _userRepository.FindUser(userName, password);
            var data = res as List<User>;
            if (data.Count == 0)
            {
                return StatusCode(204, data);
            }
            else
            {
                return StatusCode(200, data);
            }
        }
    }
}
