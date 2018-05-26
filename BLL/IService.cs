using DLL;

namespace BLL
{
    /// <summary>
    /// An Interface for the shop service
    /// </summary>
    public interface IShopService
    {
        void Add(Product product);
        void Remove(Product product);
        Product Find(Product product);
    }
}