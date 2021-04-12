using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Common.Models;
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

        #region CONSTRUCTOR
        public UserController(IBaseService<User> baseService) : base(baseService)
        {

        }
        #endregion
    }
}
