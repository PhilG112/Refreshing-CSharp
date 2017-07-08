using System;
using System.Collections.Generic;

namespace Domain.LINQ
{
    public class Customer
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? CustomerTypeId { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }

    public class CustomerType
    {
        public int Id { get; set; }
        public string Type { get; set; }
    }

    public class Invoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool? IsPaid { get; set; }
        public decimal Amount { get; set; }
        public int NumberOfUnits { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal TotalAmount => Amount - (Amount * (DiscountPercent / 100));
    }
}
