using System.Collections;
using System.Collections.Generic;

namespace DLL
{
    /// <summary>
    /// A singleton product storage
    /// </summary>
    public sealed class ProductStorage
    {
        #region Singleton instance

        static readonly List<Product> _list = new List<Product>();

        #endregion

        #region Getter for the singleton

        public static List<Product> Instance => _list;

        #endregion
    }
}