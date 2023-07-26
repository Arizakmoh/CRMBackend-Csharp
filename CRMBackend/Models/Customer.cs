using System;
using System.ComponentModel.DataAnnotations;

namespace CRMBackend.Models
{
    public class Customer
    {
        public Guid ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Role { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        public bool Contacted { get; set; }
    }
}