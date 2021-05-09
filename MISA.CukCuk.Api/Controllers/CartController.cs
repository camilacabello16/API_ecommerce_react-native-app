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
    public class CartController : BaseController<Cart>
    {
        ICartRepository _cartRepository;
        #region CONSTRUCTOR
        public CartController(IBaseService<Cart> baseService, ICartRepository cartRepository) : base(baseService)
        {
            _cartRepository = cartRepository;
        }

        [HttpGet("{userId}")]
        public IActionResult GetCartByUserID([FromRoute] Guid userId)
        {
            var res = _cartRepository.GetByUserID(userId);
            var data = res as List<Cart>;
            if (data.Count == 0)
            {
                return StatusCode(204, res);
            }
            else
            {
                return StatusCode(200, res);
            }
        }

        [HttpPost("insert-cart")]
        public IActionResult InsertToCart([FromHeader] Guid userId, [FromHeader] Guid productId)
        {
            var res = _cartRepository.InsertToCart(userId, productId);
            if (res > 0)
            {
                return StatusCode(201, res);
            }
            else
            {
                return StatusCode(400, res);
            }
        }
        #endregion
    }
}
