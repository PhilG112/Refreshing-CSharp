using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Delegates.PluralSight.BuiltInDelegates
{
    public class FuncDelegate
    {
        public FuncDelegate()
        {
            var customers = new List<Customer>
            {
                new Customer {Id = 1, FirstName = "Pat", LastName = "Smith", City = "Sydney"},
                new Customer {Id = 2, FirstName = "Dog", LastName = "Oskar", City = "Sydney"},
                new Customer {Id = 3, FirstName = "Mat", LastName = "Cree", City = "Dorado"},
                new Customer {Id = 4, FirstName = "Lena", LastName = "Oxten", City = "London"},
            };
            // Pass in your own methods into LINQ query
            var syd = customers.Where(filterByCity)
                .OrderBy(FilterByFirstName);
            // Or use lambdas to do your queries with.
            var otherSyd = customers.Where(c => c.City == "Sydney")
                .OrderBy(c => c.FirstName);
        }

        public bool filterByCity(Customer c)
        {
            return c.City == "Sydney";
        }

        public string FilterByFirstName(Customer c)
        {
            return c.FirstName;
        }

    }

    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
