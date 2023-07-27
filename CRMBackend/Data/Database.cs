using System.Collections.Generic;
using CRMBackend.Models;

namespace CRMBackend.Data
{
    public class Database
    {
        public List<Customer> Customers { get; set; }

        public Database()
        {
            // Seed the database with initial customer data
            Customers = new List<Customer>
            {
                new Customer { ID = new System.Guid("6ca9b92a-3d18-4d06-9b77-9c7b6a6b228d"), Name = "Abdirizk Abdullahi", Role = "Manager", Email = "abdirizak.Abdullahi@noemail.com", Phone = "+1234567890", Contacted = true },
                new Customer { ID = new System.Guid("34798f2c-2b47-43e2-99fb-5b5795ff6bb7"), Name = "Jane Smith", Role = "Employee", Email = "jane.smith@noemail.com", Phone = "+9876543210", Contacted = false },
                new Customer { ID = new System.Guid("d1b0ed91-826f-4d67-aa77-4c7ccf30361a"), Name = "Bob Johnson", Role = "Customer", Email = "bob.johnson@noemail.com", Phone = "+4567891230", Contacted = true }
            };
        }
    }
}