using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using CRMBackend.Models;
using CRMBackend.Services;

namespace CRMBackend.Controllers
{
    public class CustomersController : ApiController
    {
        private readonly CustomerService _customerService = new CustomerService();

        [HttpGet]
        public IHttpActionResult GetCustomers()
        {
            List<Customer> customers = _customerService.GetCustomers();
            return Ok(customers);
        }

        [HttpGet]
        public IHttpActionResult GetCustomer(Guid id)
        {
            Customer customer = _customerService.GetCustomer(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpPost]
        public IHttpActionResult AddCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _customerService.AddCustomer(customer);
            return Created(new Uri(Request.RequestUri + "/" + customer.ID), customer);
        }

        [HttpPut]
        public IHttpActionResult UpdateCustomer(Guid id, Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (!_customerService.CustomerExists(id))
            {
                return NotFound();
            }
            customer.ID = id;
            _customerService.UpdateCustomer(customer);
            return Ok(customer);
        }

        [HttpDelete]
        public IHttpActionResult DeleteCustomer(Guid id)
        {
            if (!_customerService.CustomerExists(id))
            {
                return NotFound();
            }
            _customerService.DeleteCustomer(id);
            return Ok();
        }
    }
}
