using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Entities
{
    public class Size : BaseEntity
    {
        public string BodySize { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
