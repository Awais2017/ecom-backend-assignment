using ecom_backend.Models;

namespace ecom_backend.Data
{
    public static class UsersStore
    {
        public static List<Users> UsersList = new List<Users>
            {
                new Users{Id=1,Name="Awais Kahn",Email="mowaiskhan669@gmail.com",RoleId=1,Password="$2a$12$Ys33UNBWPaVId1v79uZ/ae8Pph.jt5zqmSIlskZAogYIj97LK90vW"},
                new Users{Id=2,Name="Israr",Email="israr@gmail.com",RoleId=2,Password="$2a$12$EA3O129TokA81y4YY9Bv9.Bt1Ume6MPDICz.AA/1VEu1iVZTiOjJS"}
            };
    }
}
