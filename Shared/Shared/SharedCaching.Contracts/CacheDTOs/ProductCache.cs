using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCaching.Contracts.CacheDTOs
{
    public class ProductCache
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
    }
}
