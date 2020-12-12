using SHoppingCart.Model;
using SHoppingCart.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHoppingCart.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _iRepository;
        public ProductService(IProductRepository iRepository)
        {
            _iRepository = iRepository;
        }

        /// <summary>
        /// Get All List of Products from Product Table
        /// </summary>
        /// <returns>return list of products</returns>
        public async Task<List<Product>> GetProductsAsync()
        {
            var products = await _iRepository.GetAllAsync();
            return products.ToList();
        }

        /// <summary>
        /// Get Product from product by productId
        /// </summary>
        /// <param name="productId"></param>
        /// <returns>return single product</returns>
        public async Task<Product> GetProductAsync(int productId)
        {
            var product = await _iRepository.GetOneAsync(productId);
            return product;
        }
    }
}
