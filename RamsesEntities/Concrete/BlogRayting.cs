using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamsesEntities.Concrete
{
    public class BlogRayting
    {
        public int B_RaytingID { get; set; }
        public int BlogID { get; set; }
        public int TotalPoint { get; set; }
        public int RaytingCount { get; set; }
    }
}
