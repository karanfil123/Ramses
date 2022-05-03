using RamsesDataAccess.Abstract;
using RamsesEntities.Concrete;
using RamsesServices.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RamsesServices.Concrete
{
    public class MessageManager : IMessageService
    {
        private readonly IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public Message Get(int Id)
        {
            return _messageDal.GetById(Id);
        }

        public List<Message> GetAll()
        {
            return _messageDal.GetAll();
        }

        public List<Message> GetInBoxListByWriter(string p)
        {
            return _messageDal.GetList(x => x.Receiver == p);
        }

        public Message GetMessage(Message message)
        {
            return _messageDal.Get(x => x.ID==message.ID);
        }

        public void TAdd(Message t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Message t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
