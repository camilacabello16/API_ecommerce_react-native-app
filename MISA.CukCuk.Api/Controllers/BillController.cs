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
    public class BillController : BaseController<Bill>
    {

        #region CONSTRUCTOR
        public BillController(IBaseService<Bill> baseService) : base(baseService)
        {

        }
        #endregion
    }
}
