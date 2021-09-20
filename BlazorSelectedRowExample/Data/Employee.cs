using System;

namespace BlazorSelectedRowExample.Data
{
    public class Employee
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }
        
        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }
    }
}
