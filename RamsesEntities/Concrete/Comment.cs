using RamsesShared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamsesEntities.Concrete
{
    public class Comment:EntityGetBase
    {
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogPoint { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
