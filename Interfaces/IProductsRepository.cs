using web_api_store.Domains;

namespace web_api_store.Interfaces
{
    public interface IProductsRepository
    {
        public List<Products> GetAllProducts();

        public Products GetProductById(Guid id);

        public void PostProduct(Products product);

        public void PutProduct(Products product);

        public void DeleteProduct(Guid id);
    }
}
