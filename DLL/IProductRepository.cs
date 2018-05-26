using System.Collections;
using System.Collections.Generic;

namespace DLL
{
    /// <summary>
    /// An abstact layer for data manipulation
    /// </summary>
    public interface IProductRepository
    {
        void Add(Product product);
        void Delete(Product product);
        void Update(Product productForUpdate, Product updatedProduct);
        List<Product> GetAllProducts();
    }
}