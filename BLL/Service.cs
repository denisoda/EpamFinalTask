﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace BLL
{
    public class ShopService : IShopService
    {
        #region IShopService Members

        void IShopService.Add(Product product)
        {
            throw new NotImplementedException();
        }

        void IShopService.Remove(Product product)
        {
            throw new NotImplementedException();
        }

        IFinderStrategy<Product> IShopService.SortingStrategy(List<Product> products)
        {
            throw new NotImplementedException();
        }
        
        #endregion
    }
}