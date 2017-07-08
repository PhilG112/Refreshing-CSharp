using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.LINQ
{
    public class AnalyzingData
    {
        // Sum the total amount of all invoices
        public decimal CalculateTotalAmountInvoiced(List<Invoice> invoices)
        {
            
            return invoices.Sum(i => i.TotalAmount);
        }

        // Sum the total number of units sold
        public int CalcuateTotalUnitsSold(List<Invoice> invoices)
        {
            return invoices.Sum(i => i.NumberOfUnits);
        }

        // Total amount invoiced grouped by IsPaid
        public dynamic GetInvoiceTotalByIsPaid(List<Invoice> invoices)
        {
            var query = invoices.GroupBy(i => i.IsPaid ?? false,
                        i => i.TotalAmount,
                        (key, invTotal) => new
                        {
                            Key = key,
                            InvoicedAmount = invTotal.Sum()
                        });

            foreach (var item in query)
            {
                Console.WriteLine($"{item.Key}: {item.InvoicedAmount}");
            }

            return query;
        }

        // Total amount invoiced grouped by IsPaid and Month
        public dynamic GetInvoiceTotalByIsPaidAndMonth(List<Invoice> invoices)
        {
            var query = invoices.GroupBy(i => new
                {
                    IsPaid = i.IsPaid ?? false,
                    InvoiceMonth = i.InvoiceDate.ToString("MMMM")
                },
                        i => i.TotalAmount,
                        (key, invTotal) => new
                        {
                            Key = key,
                            InvoicedAmount = invTotal.Sum()
                        });

            foreach (var item in query)
            {
                Console.WriteLine($"{item.Key.IsPaid}/{item.Key.InvoiceMonth}: {item.InvoicedAmount}");
            }

            return query;
        }

        
        // Total amount invoiced by types of customers
        public IEnumerable<KeyValuePair<string, decimal>> GetInvoiceTotalByCustomerType(List<Customer> customers, List<CustomerType> customerTypes)
        {
            var custTypeQuery = customers.Join(customerTypes, 
                                c => c.CustomerTypeId,
                                ct => ct.Id,
                                (c, ct) => new
                                {
                                    CustomerInstance = c,
                                    CustomerTypeName = ct.Type
                                });

            var query = custTypeQuery.GroupBy(c => c.CustomerTypeName,
                c => c.CustomerInstance.Invoices.Sum(i => i.TotalAmount),
                (groupKey, invTotal) => new KeyValuePair<string, decimal>(groupKey, invTotal.Sum()));

            foreach (var item in query)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            return query;
        }

        // Get mean of invoice discounts
        public decimal CalculateMean(List<Invoice> invoices)
        {
            return invoices.Average(i => i.DiscountPercent);
        }

        // Get median of invoice discounts
        public decimal CalculateMedian(List<Invoice> invocies)
        {
            var sorted = invocies.OrderBy(i => i.DiscountPercent);
            var position = sorted.Count() / 2;

            if (position % 2 == 0)
            {
                return (sorted.ElementAt(position).DiscountPercent + 
                            sorted.ElementAt(position - 1).DiscountPercent) / 2;
            } 
            
            return sorted.ElementAt(position).DiscountPercent;
            
        }

        // Get mode of invoice discounts
        public decimal CalculateMode(List<Invoice> invoices)
        {
            var query = invoices.GroupBy(i => i.DiscountPercent)
                        .OrderByDescending(group => group.Count())
                        .Select(group => group.Key)
                        .FirstOrDefault();
            return query;
        }
    }

}
