using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string? FilePic { get; set; }
        public double Price { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Categories { get; set; }

        public int SizeId { get; set; }
        public virtual Size Sizes { get; set; }


        public int BrandId { get; set; }
        public virtual Brand Brands { get; set; }

        public int ColorId { get; set; }
        public virtual Color Colors { get; set; }

        public ICollection<Comment> Comments { get; set; }

    }
}
