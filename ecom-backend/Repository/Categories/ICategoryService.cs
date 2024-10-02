using ecom_backend.Generic;
using ecom_backend.Resources;

namespace ecom_backend.Repository.Categories
{
    public interface ICategoryService
    {
        mApiResponse Add(CategoryResource categoryResource);
        mApiResponse Update(CategoryResource categoryResource);
        mApiResponse Delete(int id);
        mApiResponse getAll();
    }
}
