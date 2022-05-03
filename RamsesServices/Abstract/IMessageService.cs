using RamsesEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RamsesServices.Abstract
{
   public  interface IMessageService:IGenericService<Message>
    {
        List<Message> GetInBoxListByWriter(string p);

        Message GetMessage(Message message);
    }
}
