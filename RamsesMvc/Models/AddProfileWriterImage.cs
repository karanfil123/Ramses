using Microsoft.AspNetCore.Http;
using RamsesEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamsesMvc.Models
{
    public class AddProfileWriterImage
    {
        public Writer Writer { get; set; }
        public IFormFile ImageUrl { get; set; }
    }
}
