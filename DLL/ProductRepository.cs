using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DLL
{
    /// <summary>
    /// An abstract layer for CRUD operatins
    /// </summary>
    public class ProductRepository : IProductRepository
    {
        #region Private Fields

        private readonly IList<Product> _storage;

        #endregion

        #region Constructors

        ProductRepository(IList<Product> list)
        {
            this._storage = list;
        }

        #endregion

        #region IProductRepository members

        public void Add(Product product)
        {
            if (_storage == null)
                throw new NullReferenceException();

            _storage.Add(product);
        }

        public void Delete(Product product)
        {
            if (_storage == null)
                throw new NullReferenceException();

            _storage.Remove(product);
        }

        public void Update(Product productForUpdate, Product updatedProduct)
        {
            if (_storage == null)
                throw new NullReferenceException();

            _storage.Where(s => s == productForUpdate).FirstOrDefault();
        }

        public List<Product> GetAllProducts()
        {
            if (_storage == null)
                throw new NullReferenceException();

            return (List<Product>)_storage;
        }

        #endregion
    }
}