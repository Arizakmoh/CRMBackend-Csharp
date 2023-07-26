using System;
using System.Collections.Generic;
using CRMBackend.Data;
using CRMBackend.Models;

namespace CRMBackend.Services
{
    public class CustomerService
    {
        private readonly Database _database = new Database();

        public List<Customer> GetCustomers()
        {
            return _database.Customers;
        }

        public Customer GetCustomer(Guid id)
        {
            return _database.Customers.Find(c => c.ID == id);
        }

        public void AddCustomer(Customer customer)
        {
            customer.ID = Guid.NewGuid();
            _database.Customers.Add(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            int index = _database.Customers.FindIndex(c => c.ID == customer.ID);
            _database.Customers[index] = customer;
        }

        public void DeleteCustomer(Guid id)
        {
            _database.Customers.RemoveAll(c => c.ID == id);
        }

        public bool CustomerExists(Guid id)
        {
            return _database.Customers.Exists(c => c.ID == id);
        }
    }
}