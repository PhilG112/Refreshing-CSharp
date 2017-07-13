using System.Collections.Generic;

namespace ACM.BL
{
    public class Product : BaseEntity
    {
        public Product() { }

        public Product(int productId)
        {
            Id = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(Name)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
