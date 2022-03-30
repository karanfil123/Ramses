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

        public void WriterAdd(Writer writer)
        {
            _writerDal.Add(writer);
        }
    }
}
