using ecom_backend.Generic;
using ecom_backend.Resources;
using ecom_backend.Models;
using ecom_backend.Data;

namespace ecom_backend.Repository.Products
{
    public class ProductService : IProductService
    {
        public mApiResponse AddProduct(AddUpdateProductResource addUpdateProduct)
        {
            int id=ProductStore.ProductsList.OrderByDescending(x => x.Id).FirstOrDefault().Id;
            Product prod = new Product();
            prod.Id = id+1;
            prod.Name=addUpdateProduct.Name;
            prod.Description=addUpdateProduct.Description;
            prod.ImageUrl = addUpdateProduct.ImageUrl;
            prod.CreatedOn = new DateTime();
            prod.CategoryId= addUpdateProduct.CategoryId;
            prod.Amount= addUpdateProduct.Amount;
            prod.Quantity=addUpdateProduct.Quantity;
            ProductStore.ProductsList.Add(prod);
            mApiResponse response = new mApiResponse{Status=1,Message="Record Added Successfully" };
            return response;
        }

        public mApiResponse Delete(int id)
        {
            throw new NotImplementedException();
        }

        public mApiResponse GetAll()
        {
            var result = ProductStore.ProductsList.Select(p=>new GetAllProducts
            {
                Id=p.Id,
                Name=p.Name,  
                Description=p.Description,
                ImageUrl=p.ImageUrl,
                Quantity=p.Quantity,
                Amount=p.Amount,
                Category=CategoriesStore.categories.Find(c=>c.Id==p.CategoryId).Name
            }).ToList();
            mApiResponse response = new mApiResponse{Status=1,Message="Record Fetch Successfully",Data=result};
            return response;
        }

        public mApiResponse Update(AddUpdateProductResource addUpdateProduct)
        {
            throw new NotImplementedException();
        }

        public mApiResponse uploadFile(IFormFile file, string fileName)
        {
            try
            {
                var path = Path.Combine(
                 "C:", "securefiles",
                 fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                mApiResponse response=new mApiResponse {Status=1,Message="File Uploaded Sucessfully",Data= path };
                return response;
            }
            catch (Exception ex) { Console.WriteLine(ex); return null; }
        }
    }
}
