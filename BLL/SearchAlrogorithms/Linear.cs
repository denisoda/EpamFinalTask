using System.Collections.Generic;
using System.Linq;
using DLL;

namespace BLL.SearchAlrogorithms
{
    public class Linear : IFinderStrategy<Product>
    {
        public IList<Product> Find(IList<Product> productStorage, string item)
        {
            foreach (var product in productStorage.ToList())
            {
                if (product.Description != item)
                    productStorage.Remove(product);
            }

            productStorage.OrderBy(s => s.Price).Reverse().Take(10).Reverse();

            return productStorage;
        }
    }
}