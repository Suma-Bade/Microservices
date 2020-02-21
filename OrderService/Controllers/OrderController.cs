using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Models;
using OrderService.Repositories;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _repo;
        public OrderController(IOrderRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("GetOrders")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_repo.GetAllOrders());
            }
            catch(Exception e)
            {
                return NotFound(e.InnerException.Message);
            }
        }
        [HttpGet]
        [Route("GetOrderById/{id}")]
        public IActionResult Get(string id)
        {
            try
            {
                return Ok(_repo.GetOrderById(id));
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }
        }
        [HttpPost]
        [Route("AddOrder")]

        public IActionResult POST(Orders order)
        {
            try
            {
                _repo.AddOrder(order);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }
        }
        [HttpPut]
        [Route("UpdateOrder")]

        public IActionResult PUT(Orders order)
        {
            try
            {
                _repo.UpdateOrder(order);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }
        }
        [HttpDelete]
        [Route("Delete/{id}")]

        public IActionResult Delete(string id)
        {
            try
            {
                _repo.DeleteOrder(id);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }
        }
    }
}
    
