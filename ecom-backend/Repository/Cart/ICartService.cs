using ecom_backend.Generic;
using ecom_backend.Resources;

namespace ecom_backend.Repository.Cart
{
    public interface ICartService
    {
        mApiResponse addOrders(List<AddOrderResouces> orders);
    }
}
