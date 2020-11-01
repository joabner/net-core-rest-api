using MyStore.Domain.Interfaces;
using MyStore.Domain.Models;
using MyStore.Domain.Validations;
using System;
using System.Threading.Tasks;

namespace MyStore.Domain.Services
{
    public class ProductService : BaseService, IProductService
    {
        private IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository,
                              INotificationContext notificationContext) : base(notificationContext)
        {
            _productRepository = productRepository;
        }

        public async Task Create(Product product)
        {
            if (!Validate(new ProductValidation(), product)) return;

            await _productRepository.Add(product);
        }

        public async Task Delete(Guid id)
        {
            await _productRepository.Delete(id);
        }

        public async Task Update(Product product)
        {
            await _productRepository.Update(product);
        }
    }
}
