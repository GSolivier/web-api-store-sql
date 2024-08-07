using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using web_api_store.Domains;
using web_api_store.Interfaces;
using web_api_store.Repositories;

namespace web_api_store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ProductController : ControllerBase
    {

        private readonly IProductsRepository _productsRepository;
        public ProductController()
        {
            _productsRepository = new ProductRepository();
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            try
            {
               var products = _productsRepository.GetAllProducts();

               return Ok(products);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("id")]
        public IActionResult GetProduct(Guid id) 
        {
            try
            {
                var product = _productsRepository.GetProductById(id);

                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult PostProduct(Products product) 
        {
            try
            {
                _productsRepository.PostProduct(product);

                return Ok(product);
            }catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult PutProduct(Products product)
        {
            try
            {
                _productsRepository.PutProduct(product);

                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeleteProduct(Guid id)
        {
            try
            {
                _productsRepository.DeleteProduct(id);

                return Ok("Produto deletado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
