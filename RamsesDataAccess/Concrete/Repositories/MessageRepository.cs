using RamsesDataAccess.Abstract;
using RamsesDataAccess.SharedDal.Concrete;
using RamsesEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamsesDataAccess.Concrete.Repositories
{
    public class MessageRepository:EntityRepositoryBase<Message>,IMessageDal
    {
    }
}
