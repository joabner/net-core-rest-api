using MyStore.Data.Context;
using MyStore.Domain.Interfaces;
using MyStore.Domain.Models;

namespace MyStore.Data.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(MyStoreDbContext context) : base(context) { }
    }
}
