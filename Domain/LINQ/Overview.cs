using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.LINQ
{
    public class Overview
    {
        public Overview()
        {
            var dataSource = DataSource.GetCustomers();

            // Query syntax
            var query = from c in dataSource
                        where c.Id == 4
                        select c;

            // Method syntax
            var query2 = dataSource.Where(c => c.Id == 4).Skip(1).FirstOrDefault();
        }
    }
}
