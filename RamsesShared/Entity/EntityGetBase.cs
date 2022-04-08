using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamsesShared.Entity
{
   public abstract class EntityGetBase
    {
        public virtual int ID { get; set; }
        public virtual string CreateByName { get; set; } = "Bülent";
        public virtual DateTime CreateDate { get; set; } = DateTime.Now;
        public virtual string ModifiedByName { get; set; } = "Bülent";
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = true;
    }
}
