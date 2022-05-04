using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamsesEntities.Concrete
{
    public class Admin
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string NameSurname { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Role { get; set; }
    }
}
