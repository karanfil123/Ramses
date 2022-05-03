using RamsesShared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamsesEntities.Concrete
{
    public class Writer:EntityGetBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string Image  { get; set; }
        public bool Policy  { get; set; }
        public List<Blog> Blogs { get; set; }
        public virtual ICollection<Message2> MessageSender { get; set; }
        public virtual ICollection<Message2> MessageReceiver { get; set; }
    }
}
