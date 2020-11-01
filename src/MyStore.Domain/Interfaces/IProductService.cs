using MyStore.Domain.Models;
using System;
using System.Threading.Tasks;

namespace MyStore.Domain.Interfaces
{
    public interface IProductService
    {
        Task Create(Product product);
        Task Update(Product product);
        Task Delete(Guid id);
    }
}
