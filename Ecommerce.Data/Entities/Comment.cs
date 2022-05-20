using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Entities
{
    public class Comment : BaseEntity
    {
        public string Comments { get; set; }
        public ICollection<AppUserComment> Users { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
