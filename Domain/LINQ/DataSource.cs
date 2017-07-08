using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.LINQ
{
    public static class DataSource
    {
        public static List<Customer> GetCustomers()
        {
            var customerList = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Pat", LastName = "Smith", Invoices = GetInvoice(1), CustomerTypeId = GetCustomerType(1) },
                new Customer { Id = 2, FirstName = "Joe", LastName = "Pee", Invoices = GetInvoice(2) },
                new Customer { Id = 3, FirstName = "George", LastName = "Bottle", Invoices = GetInvoice(3) },
                new Customer { Id = 4, FirstName = "Frank", LastName = "Lime", Invoices = GetInvoice(1) },
                new Customer { Id = null, FirstName = "Oskar", LastName = "Dog" }
            };

            return customerList;
        }


        public static int GetCustomerType(int customerId)
        {
            var typesList = new List<CustomerType>
            {
                new CustomerType {Id = 1, Type = "Wrestler"}
            };

            var q = typesList.FirstOrDefault(t => t.Id == customerId);
            return q.Id;
        }

        public static List<Invoice> GetInvoices()
        {
            var invoices = new List<Invoice>
            {
                new Invoice { Id = 1, CustomerId = 1, DueDate = DateTime.Now.AddDays(21), InvoiceDate = DateTime.Now, IsPaid = null, Amount = 99.99M, NumberOfUnits = 2, DiscountPercent = 5M},
                new Invoice { Id = 2, CustomerId = 2, DueDate = DateTime.Now.AddDays(8), InvoiceDate = DateTime.Now, IsPaid = null, Amount = 499.99M, NumberOfUnits = 10, DiscountPercent = 3M},
                new Invoice { Id = 3, CustomerId = 3, DueDate = DateTime.Now.AddDays(11), InvoiceDate = DateTime.Now, IsPaid = null, Amount = 9.99M, NumberOfUnits = 15, DiscountPercent = 2M},
                new Invoice { Id = 4, CustomerId = 4, DueDate = DateTime.Now.AddDays(16), InvoiceDate = DateTime.Now, IsPaid = null, Amount = 699.99M, NumberOfUnits = 16, DiscountPercent = 1M},
                new Invoice { Id = 1, CustomerId = 1, DueDate = DateTime.Now.AddDays(5), InvoiceDate = DateTime.Now, IsPaid = null, Amount = 1199.99M, NumberOfUnits = 3, DiscountPercent = 4M},
                new Invoice { Id = 2, CustomerId = 2, DueDate = DateTime.Now.AddDays(5), InvoiceDate = DateTime.Now, IsPaid = null, Amount = 64.4M, NumberOfUnits = 123, DiscountPercent = 2M},
                new Invoice { Id = 3, CustomerId = 3, DueDate = DateTime.Now.AddDays(5), InvoiceDate = DateTime.Now, IsPaid = null, Amount = 89.50M, NumberOfUnits = 500, DiscountPercent = 0M}
            };
            return invoices;
        }

        public static List<Invoice> GetInvoice(int customerId)
        {
            return GetInvoices().Where(c => c.CustomerId == customerId).ToList();
        }
    }
}
