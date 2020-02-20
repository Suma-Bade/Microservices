using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIAssignment.Models;

namespace APIAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        CustomerDBContext db = new CustomerDBContext();
        [HttpGet]
        public List<Customer> GetAll()
        {
            return db.Customer.ToList();
        }
        [HttpGet("{id}")]
        [Route("GetCustomerById/{id}")]
        public Customer GetCustomerById(int id)
        {
            return db.Customer.Find(id);
        }
        [HttpGet("{city}")]
        [Route("GetCustomerByCity/{city}")]
        public List<Customer> GetCustomerByCity(string city)
        {
            return db.Customer.Where<Customer>(p => p.City == city).ToList();
        }
        [HttpPost]
        [Route("AddCustomer")]
        public void Add(Customer c)
        {
            db.Customer.Add(c);
            db.SaveChanges();
        }
        [HttpPut]
        [Route("Update/{id}")]
        public void Update(string id)
        {
            Customer c = db.Customer.Find(id);
            c.Address = "Bangalore";
            db.Customer.Update(c);
            db.SaveChanges();
        }

    }
}