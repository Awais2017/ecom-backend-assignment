using ecom_backend.Models;

namespace ecom_backend.Data
{
    public static class RolesStore
    {
        public static List<Roles> RolesList = new List<Roles>
            {
                new Roles{Id=1,Name="Admin",Description="Have access to all the admin roles like adding a product and category etc"},
                new Roles{Id=2,Name="User",Description="Just a simple user that can login and buy something form the store" }
        };
    }
}
