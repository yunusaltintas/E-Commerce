using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Entities
{
    public class AppUserComment : BaseEntity    
    {
        public int CommentId { get; set; }
        public virtual Comment Comment { get; set; }
        public int UserId { get; set; }
        public virtual AppUser User { get; set; }
    }
}
