using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TIMG_DAL;

namespace TIMG_API.Controller
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController:ControllerBase
    {
        public ITIMGDb ITIMGDb;

        public OrderController(ITIMGDb ITIMGDb)
        {
            this.ITIMGDb = ITIMGDb;
        }

        [AllowAnonymous]
        [HttpGet("Orders")]
        public async Task<IActionResult> GetAllOrders()
        {
            var prod = await ITIMGDb.GetAllOrders().ToListAsync();
            return Ok(prod);
        }

        [AllowAnonymous]
        [HttpGet("OrderItem/{orderId}")]
        public async Task<IActionResult> GetOrderItembyorderId(int orderId)
        {
            var prod = await ITIMGDb.GetOrderItembyOrderId(orderId).ToListAsync();
            return Ok(prod);
        }

    }
}
