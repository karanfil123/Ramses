using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamsesEntities.Concrete
{  
        public class Message2
        {
            public int ID { get; set; }
            public int? SenderID { get; set; }
            public int? ReceiverID { get; set; }
            public string Subject { get; set; }
            public string Content { get; set; }
            public DateTime Date { get; set; }
            public bool IsActive { get; set; }
            public Writer SenderUser { get; set; }
            public Writer ReceiverUser { get; set; }
            
        }
 
}
