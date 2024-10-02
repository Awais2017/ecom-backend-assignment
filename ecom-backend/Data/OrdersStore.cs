using ecom_backend.Models;

namespace ecom_backend.Data
{
    public static class OrdersStore
    {
        public static List<Orders> ordersList = new List<Orders>
        {
            new Orders{Id=1,OrderId="#123131",Amount=12313,Quanitity=2},
            new Orders{Id=2,OrderId="#11212",Amount=12313,Quanitity=2},
            new Orders{Id=3,OrderId="#121212",Amount=12313,Quanitity=2}
        };
    }
}
