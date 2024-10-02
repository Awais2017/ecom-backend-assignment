using ecom_backend.Models;

namespace ecom_backend.Data
{
    public static class OrderDetailsStore
    {
        public static List<OrderDetails> orderDetailsList = new List<OrderDetails>
        {
            new OrderDetails { Id = 1, OrderId = 1, ProductId = 1, Quanitity = 1, Amount = 2221 },
            new OrderDetails { Id = 2, OrderId = 1, ProductId = 1, Quanitity = 1, Amount = 2221 }
        };
    }
}
