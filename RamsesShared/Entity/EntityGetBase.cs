using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamsesShared.Entity
{
   public abstract class EntityGetBase
    {
        public int ID { get; set; }
        public string CreateByName { get; set; }
        public DateTime CreateDate { get; set; }
        public string ModifiedByName { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
