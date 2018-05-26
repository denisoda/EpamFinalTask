using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.SearchAlrogorithms;
using DLL;

namespace BLL
{
    public class ShopService : IShopService
    {
        #region Private fields

        private readonly IProductRepository _repository;

        #endregion

        #region Public fieds

        public IFinderStrategy<Product> Finder { get; }

        #endregion

        #region Constructors

        public ShopService(IProductRepository repository, IFinderStrategy<Product> finderAlgorithm)
        {
            _repository = repository;
            Finder = finderAlgorithm;
        }

        #endregion

        #region IShopService Members

        void IShopService.Add(Product product)
        {
            _repository?.Add(product);
        }

        void IShopService.Remove(Product product)
        {
            _repository?.Delete(product);
        }

        public IList<Product> FindChipest(string name, int number)
        {
            return Finder.Find(_repository.GetAllProducts(),name, number);
        }

        #endregion
    }
}