namespace ecom_backend.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string OrderNo { get; set; }
        public int ProductId { get; set; }
        public int Quanitity { get; set; }
        public DateTime CreatedOn { get; set; }
        public int Amount { get; set; }
    }
}
