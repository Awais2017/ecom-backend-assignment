using ecom_backend.Data;
using ecom_backend.Generic;
using ecom_backend.Models;
using ecom_backend.Resources;
using System.Security.Cryptography.X509Certificates;

namespace ecom_backend.Repository.Categories
{
    public class CategoryService : ICategoryService
    {
        public mApiResponse Add(CategoryResource categoryResource)
        {
            var cat=CategoriesStore.categories.OrderByDescending(c => c.Id).FirstOrDefault();
            Category category = new Category();
            category.Id = cat.Id+1;
            category.Name = categoryResource.Name;
            category.Description = categoryResource.Description;
            category.CreatedOn = new DateTime();
            CategoriesStore.categories.Add(category);
            mApiResponse response = new mApiResponse{ Status = 1, Message = "Record Added Successfully" };
            return response;
        }

        public mApiResponse Delete(int id)
        {
            mApiResponse response = new mApiResponse();
            var category = CategoriesStore.categories.FirstOrDefault(c => c.Id == id);
            if (category != null) { 
                CategoriesStore.categories.Remove(category);
                response = new mApiResponse { Status = 1, Message = "Record Deleted Successfully" };
                return response;
            }
            else
            {
                response = new mApiResponse { Status = 0, Message = "Record Not Found!" };
                return response;
            }
        }

        public mApiResponse getAll()
        {
            var result = CategoriesStore.categories.Select(x => new GetCategoriesResource {Id=x.Id, Name = x.Name, Description = x.Description }).ToList();
            mApiResponse response = new mApiResponse { Status = 1, Message = "Record Fetch Successfully", Data = result };
            return response;
        }

        public mApiResponse Update(CategoryResource categoryResource)
        {
            mApiResponse response = new mApiResponse();
            if (categoryResource.Id == 0)
            {
                 response = new mApiResponse { Status = 0, Message = "No Record Found!" };
                return response;
            }
            var cat = CategoriesStore.categories.Find(c => c.Id==categoryResource.Id);
            cat.Name=categoryResource.Name;
            cat.Description=categoryResource.Description;
            cat.UpdatedOn = new DateTime();
            response = new mApiResponse { Status = 1, Message = "Record Updated Successfully" };
            return response;
        }
    }
}
