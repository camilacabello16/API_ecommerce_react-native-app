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
    [Route("api/[controller]")]
    [ApiController]
    public class ProductInfoController : BaseController<ProductInfo>
    {
        public ProductInfoController(IBaseService<ProductInfo> baseService) : base(baseService)
        {

        }
    }
}