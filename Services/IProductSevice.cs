using BusinessObjects;
using System.Collections.Generic;

namespace Services
{
    public interface IProductSevice
    {
        void SaveProduct(Product p);
        void DeleteProduct(Product p);
        void UpdateProduct(Product p);
        List<Product> GetProducts();
        Product GetProductById(int id);
    }
}
