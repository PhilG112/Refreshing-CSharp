using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.LINQ
{
    public class TransformingAndProjections
    {

        public TransformingAndProjections()
        {
            var dataSource = DataSource.GetCustomers();
            GetNames(dataSource);
            GetNamesAndId(dataSource);
        }

        public IEnumerable<string> GetNames(List<Customer> customers)
        {
            return customers.Select(c => $"{c.LastName}, {c.FirstName}");
        }

        public IEnumerable<dynamic> GetNamesAndId(List<Customer> customers)
        {
            // You should not do it like this. This is just for readability.
            // Example of creating anonymous types on the fly.
            return customers.Select(c => new
            {
                Name = $"{c.LastName}, {c.FirstName}",
                c.Id
            });
        }
    }
}
