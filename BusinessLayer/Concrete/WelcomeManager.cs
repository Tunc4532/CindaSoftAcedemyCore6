using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WelcomeManager : IWelcomeService
    {
        IWelcomeDal _welcomeDal;

        public WelcomeManager(IWelcomeDal welcomeDal)
        {
            _welcomeDal = welcomeDal;
        }

        public void TAdd(Welcome t)
        {
            _welcomeDal.Insert(t);
        }

        public void TDelete(Welcome t)
        {
            _welcomeDal.Delete(t);
        }

        public Welcome TGetById(int id)
        {
            return _welcomeDal.GetByID(id);
        }

        public List<Welcome> TGetList()
        {
            return _welcomeDal.GetList();
        }

        public List<Welcome> TGetListByFilter(string r)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Welcome t)
        {
           _welcomeDal.Update(t);
        }
    }
}
