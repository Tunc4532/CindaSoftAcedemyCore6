using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterMesssageManager : IWriterMesssageService
    {
        IWriterMesssageDal _writerMesssageDal;

        public WriterMesssageManager(IWriterMesssageDal writerMesssageDal)
        {
            _writerMesssageDal = writerMesssageDal;
        }

        public List<WriterMesssage> GetListReceiverMessage(string p)
        {
            return _writerMesssageDal.GetByFilter(x => x.Receiver == p);
        }

        public List<WriterMesssage> GetListSenderMessage(string p)
        {
            return _writerMesssageDal.GetByFilter(x => x.Sender == p);
        }

        public void TAdd(WriterMesssage t)
        {
           _writerMesssageDal.Insert(t);
        }

        public void TDelete(WriterMesssage t)
        {
           _writerMesssageDal.Delete(t);
        }

        public WriterMesssage TGetById(int id)
        {
           return _writerMesssageDal.GetByID(id);
        }

        public List<WriterMesssage> TGetList()
        {
           return _writerMesssageDal.GetList();
        }

        public List<WriterMesssage> TGetListByFilter(string r)
        {
           return _writerMesssageDal.GetByFilter(x => x.Receiver == r);
        }

        public void TUpdate(WriterMesssage t)
        {
            _writerMesssageDal.Update(t);
        }
    }
}
