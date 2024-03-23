using Blog.DATA.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DATA.Abstract
{
     public abstract class BaseBlog
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime DeletedDate { get; set; }

        public DateTime? UpdatedDate { get; set; } = null;

        public Status Status { get; set; } = Status.Added;


    }
}
