﻿using RamsesShared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamsesEntities.Concrete
{
    public class About :EntityGetBase
    {
        public string Detail1 { get; set; }
        public string Detail2 { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string MapLocation { get; set; }
    }
}
