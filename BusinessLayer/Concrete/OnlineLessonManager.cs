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
    public class OnlineLessonManager : IOnlineLessonService
    {
        IOnlineLessonDal _onlineLessonDal;

        public OnlineLessonManager(IOnlineLessonDal onlineLessonDal)
        {
            _onlineLessonDal = onlineLessonDal;
        }

        public void TAdd(OnlineLesson t)
        {
            _onlineLessonDal.Insert(t);
        }

        public void TDelete(OnlineLesson t)
        {
            _onlineLessonDal.Delete(t);
        }

        public OnlineLesson TGetById(int id)
        {
            return _onlineLessonDal.GetByID(id);
        }

        public List<OnlineLesson> TGetList()
        {
            return _onlineLessonDal.GetList();
        }

        public List<OnlineLesson> TGetListByFilter(string r)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(OnlineLesson t)
        {
            _onlineLessonDal.Update(t);
        }
    }
}
