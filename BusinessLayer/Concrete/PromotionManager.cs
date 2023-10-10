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
    public class PromotionManager : IPromotionService
    {
        IPromotionDal _promotionDal;

        public PromotionManager(IPromotionDal promotionDal)
        {
            _promotionDal = promotionDal;
        }

        public void TAdd(Promotion t)
        {
           _promotionDal.Insert(t);
        }

        public void TDelete(Promotion t)
        {
            _promotionDal.Delete(t);
        }

        public Promotion TGetById(int id)
        {
           return _promotionDal.GetByID(id);
        }

        public List<Promotion> TGetList()
        {
            return _promotionDal.GetList();
        }

        public List<Promotion> TGetListByFilter(string r)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Promotion t)
        {
            _promotionDal.Update(t);
        }
    }
}
