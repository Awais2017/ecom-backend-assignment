using ecom_backend.Models;

namespace ecom_backend.Data
{
    public static class ProductStore
    {
        public static List<Product> ProductsList = new List<Product>
        {
            new Product{Id=1,CategoryId=1,Name="T shirt",Description="Made with very good quality of fleecc",ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQPFH5Hko2XsQuffRMgQYBaAQIESdX_uWVPqA&s",Quantity=33,Amount=2000},
            new Product{Id=2,CategoryId=2,Name="Face wash",Description="face wash for acne and also for skin",ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQSAFkCyyakuWovB_gy4q9hpt2f99RNH6NL2Q&s",Quantity=21,Amount=4300}
        };
    }
}
