using System.Collections.Generic;
using System.Linq;

namespace Domain.LINQ
{
    public class Sorting
    {
        public Sorting()
        {
            var dataSource = DataSource.GetCustomers();
            SortByName(dataSource);
            SortByNameInReverse(dataSource);
        }

        public IEnumerable<Customer> SortByName(List<Customer> customers)
        {   
            return customers.OrderBy(c => c.FirstName).ThenBy(c => c.LastName);
        }

        public IEnumerable<Customer> SortByNameInReverse(List<Customer> customers)
        {
            //return customers.OrderByDescending(c => c.LastName)
            //    .ThenByDescending(c => c.FirstName);
            // OR
            return SortByName(customers).Reverse();
        }

        public IEnumerable<Customer> SortByType(List<Customer> customers)
        {
            // As someone has null for an Id, values with null will go to the top of the list.
            // return customers.OrderBy(c => c.Id);
            // If you want the null values to be at the bottom of the list, do this:
            return customers.OrderByDescending(c => c.Id.HasValue).ThenBy(c => c.Id);
        }
    }
}
