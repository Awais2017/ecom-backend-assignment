using ecom_backend.Models;

namespace ecom_backend.Data
{
    public static class CategoriesStore
    {
        public static List<Category> categories = new List<Category>
        {
            new Category{Id=1,Name="Clothing",Description="This category incluedes all the product related to clothing"},
            new Category{Id=2,Name="Accessories",Description="This category incluedes all the product related to watches,belts and "}
        };
    }
}
