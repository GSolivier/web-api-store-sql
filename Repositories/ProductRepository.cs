using web_api_store.Context;
using web_api_store.Domains;
using web_api_store.Interfaces;

namespace web_api_store.Repositories
{
    public class ProductRepository : IProductsRepository
    {
        public ApiDbContext db = new ApiDbContext();
        public List<Products> GetAllProducts()
        {
            return db.Products.Select(p => new Products
            {
                ProdcutId = p.ProdcutId,
                Name = p.Name,
                Price = p.Price,
            }
            ).ToList();
        }

        public Products GetProductById(Guid id)
        {
            return db.Products.Select(p => new Products
            {
                ProdcutId = p.ProdcutId,
                Name = p.Name,
                Price = p.Price,
            }
            ).FirstOrDefault(p => p.ProdcutId == id)!;
        }

        public void PostProduct(Products product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void PutProduct(Products product)
        {
            var productFound = GetProductById(product.ProdcutId);

            if (productFound != null) 
            {


                productFound.Name = product.Name;
                productFound.Price = product.Price;
                db.Products.Update(productFound);
                db.SaveChanges();
            } else
            {
                throw new Exception("Produto não encontrado");
            }
            
        }

        public void DeleteProduct(Guid id)
        {
            var productFound = GetProductById(id);

            if (productFound != null)
            {
                db.Products.Remove(productFound);
                db.SaveChanges();
            }
            else
            {
                throw new Exception("Produto não encontrado");
            }
        }
    }
}
