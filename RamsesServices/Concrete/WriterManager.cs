using RamsesDataAccess.Abstract;
using RamsesEntities.Concrete;
using RamsesServices.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamsesServices.Concrete
{
    public class WriterManager : IWriterService
    {
        private readonly IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public Writer Get(int Id)
        {
           return _writerDal.GetById(Id);
        }

        public List<Writer> GetAll()
        {
            return _writerDal.GetAll();
        }

        public void TAdd(Writer t)
        {
            _writerDal.Add(t);
        }

        public void TDelete(Writer t)
        {
           
        }

        public void TUpdate(Writer t)
        {
            _writerDal.Update(t);
        }

        public void WriterAdd(Writer writer)
        {
            _writerDal.Add(writer);
        }
    }
}
