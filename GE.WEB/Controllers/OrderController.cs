using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GE.Models;
using GE.SL.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GE.WEB.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<OrderVM>> Get()
        {
            return _orderService.GetAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult<OrderVM> Get(int id)
        {
            return _orderService.FindById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]OrderVM value)
        {
            _orderService.Create(value);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]OrderVM value)
        {
            _orderService.Update(id, value);
     }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _orderService.Delete(id);
        }
    }
}
