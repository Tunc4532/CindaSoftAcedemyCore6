using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterMesssageService : IGenericService<WriterMesssage>
    {
        List<WriterMesssage> GetListSenderMessage(string p);
        List<WriterMesssage> GetListReceiverMessage(string p);
        
    }
}
