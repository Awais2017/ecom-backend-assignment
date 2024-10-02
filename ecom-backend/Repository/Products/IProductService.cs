using ecom_backend.Generic;
using ecom_backend.Resources;

namespace ecom_backend.Repository.Products
{
    public interface IProductService
    {
        mApiResponse AddProduct(AddUpdateProductResource addUpdateProduct);
        mApiResponse Update(AddUpdateProductResource addUpdateProduct);
        mApiResponse Delete(int id);
        mApiResponse GetAll();
        mApiResponse uploadFile(IFormFile file, string fileName);
    }
}
