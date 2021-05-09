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
    public class ProductController : BaseController<Product>
    {
        IBaseService<Product> _baseService;
        IProductRepository _productRepository;

        #region CONSTRUCTOR
        public ProductController(IBaseService<Product> baseService, IProductRepository productRepository) : base(baseService)
        {
            _baseService = baseService;
            _productRepository = productRepository;
        }
        #endregion

        #region
        [HttpGet("category/{categoryId}")]
        public IActionResult GetProductByCategoryID([FromRoute] int categoryId)
        {
            var res = _productRepository.GetProductByCategoryID(categoryId);
            var data = res as List<Product>;
            if (data.Count == 0)
            {
                return StatusCode(204, res);
            }
            else
            {
                return StatusCode(200, res);
            }
        }

        [HttpGet("user/{userId}")]
        public IActionResult GetProductByUserID([FromRoute] Guid userId)
        {
            var res = _productRepository.GetProductByUserID(userId);
            var data = res as List<Product>;
            if (data.Count == 0)
            {
                return StatusCode(204, res);
            }
            else
            {
                return StatusCode(200, res);
            }
        }
        #endregion
    }
}
