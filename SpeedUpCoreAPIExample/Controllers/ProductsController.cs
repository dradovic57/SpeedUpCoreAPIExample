using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using SpeedUpCoreAPIExample.Interfaces;

namespace SpeedUpCoreAPIExample.Controllers
{
    //public class ProductsController
    //{
    //}
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        // GET /api/products
        [HttpGet]
        public async Task<IActionResult> GetAllProductsAsync()
        {
            return await _productsService.GetAllProductsAsync();
        }

        // GET /api/products/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductAsync(int id)
        {
            return await _productsService.GetProductAsync(id);
        }

        // GET /api/products/find
        [HttpGet("find/{sku}")]
        public async Task<IActionResult> FindProductsAsync(string sku)
        {
            return await _productsService.FindProductsAsync(sku);
        }

        // DELETE /api/products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductAsync(int id)
        {
            return await _productsService.DeleteProductAsync(id);
        }
    }
}
