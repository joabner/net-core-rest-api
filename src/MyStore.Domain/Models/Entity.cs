using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Domain.Models
{
    public abstract class Entity
    {
        public Entity()
        {
            Id = new Guid();
        }

        public Guid Id { get; set; }
    }
}
