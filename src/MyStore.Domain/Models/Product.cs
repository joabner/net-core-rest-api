using System;

namespace MyStore.Domain.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string  Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
