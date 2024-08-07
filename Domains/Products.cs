using System.ComponentModel.DataAnnotations;

namespace web_api_store.Domains
{
    public class Products
    {
        [Key]
        public Guid ProdcutId { get; set; } = Guid.NewGuid();

        public string? Name { get; set; }

        public decimal? Price { get; set; }
    }
}
