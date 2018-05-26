using System;
using System.Collections.Generic;
using System.Linq;
using DLL;

namespace BLL.SearchAlrogorithms
{
    public class Linear : IFinderStrategy<Product>
    {
        public IList<Product> Find(IList<Product> productStorage, string item, int num)
        {
            IList<Product> items = new List<Product>();

            foreach (var product in productStorage)
            {
                if(product.Description == item)
                    items.Add(product);
            }

            return items.OrderBy(s => s.Price).Reverse().Take(num).Reverse().ToList();
        }
    }
}