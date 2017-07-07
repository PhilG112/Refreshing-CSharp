using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.LINQ
{
    public static class DataSource
    {
        public static List<Customer> GetCustomers()
        {
            var customerList = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Pat", LastName = "Smith" },
                new Customer { Id = 2, FirstName = "Joe", LastName = "Pee" },
                new Customer { Id = 3, FirstName = "George", LastName = "Bottle" },
                new Customer { Id = 4, FirstName = "Frank", LastName = "Lime" },
                new Customer { Id = null, FirstName = "Oskar", LastName = "Dog" }
            };

            return customerList;
        }
    }
}
