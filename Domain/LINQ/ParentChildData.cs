using System.Collections.Generic;
using System.Linq;

namespace Domain.LINQ
{
    public class ParentChildData
    {
        public IEnumerable<Customer> GetOverdueCustomers(List<Customer> customers)
        {
            // Use .SelectMany() when working with parent child data
            var query = customers.SelectMany(c => c.Invoices
                                  // See if their invoices are paid
                                  .Where(i => (i.IsPaid ?? false) == false),
                                  // return the customers with overdue invoices with no duplications
                                  (customer, invoice) => customer).Distinct();
            return query;
        }
    }
}
