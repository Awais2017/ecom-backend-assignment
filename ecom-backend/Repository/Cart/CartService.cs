using ecom_backend.Data;
using ecom_backend.Generic;
using ecom_backend.Models;
using ecom_backend.Resources;

namespace ecom_backend.Repository.Cart
{
    public class CartService : ICartService
    {
        public mApiResponse addOrders(List<AddOrderResouces> orders)
        {
            Orders ord = new Orders();
            ord.Id = OrdersStore.ordersList.OrderByDescending(x => x.Id).FirstOrDefault().Id + 1;
            ord.OrderDate = DateTime.Now;
            ord.OrderId = Guid.NewGuid().ToString("N");
            ord.Quanitity = orders.Sum(x=>x.NoOfItems);
            ord.Amount = orders.Sum(x=>x.Amount);
            OrdersStore.ordersList.Add(ord);
            foreach (var item in orders)
            {
                OrderDetails details = new OrderDetails();
                details.OrderId = ord.Id;
                details.OrderNo = ord.OrderId;
                details.ProductId = item.Id;
                details.CreatedOn = DateTime.Now;
                details.Quanitity = item.NoOfItems;
                details.Amount = item.Amount;
                OrderDetailsStore.orderDetailsList.Add(details);
                ProductStore.ProductsList.Find(x => x.Id == item.Id).Quantity = ProductStore.ProductsList.Find(x => x.Id == item.Id).Quantity - item.NoOfItems;
            }

            return new mApiResponse { Status = 1, Message = "Order Successfull" };
        }
    }
}
