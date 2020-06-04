using System;
using System.Collections.Generic;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Data.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
