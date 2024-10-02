using ecom_backend.Resources;

namespace ecom_backend.Repository.Auth
{
    public interface IAuthService
    {
        LoginResponse GenerateToken(AuthResource authResource);
    }
}
