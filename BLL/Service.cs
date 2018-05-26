using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace BLL
{
    public class ShopService : IShopService
    {
        private readonly IProductRepository _repository;
        public IFinderStrategy<Product> Finder { get; }

        public ShopService(IProductRepository repository, IFinderStrategy<Product> finderAlgorithm)
        {
            _repository = repository;
            Finder = finderAlgorithm;
        }

        #region IShopService Members

        void IShopService.Add(Product product)
        {
            _repository?.Add(product);
        }

        void IShopService.Remove(Product product)
        {
            _repository?.Delete(product);
        }

        IFinderStrategy<Product> IShopService.LowestPriceFinderStrategy(List<Product> products)
        {
            return 
        }
        
        #endregion
    }
}