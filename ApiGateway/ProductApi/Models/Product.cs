using System;
using System.Collections.Generic;

namespace ProductApi.Models
{
    public partial class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
