namespace ACM.BL
{
    public class OrderItem : BaseEntity
    {
        public OrderItem() { }

        public OrderItem(int orderItemId)
        {
            Id = orderItemId;
        }

        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (Id <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
