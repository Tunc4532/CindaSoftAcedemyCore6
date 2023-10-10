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
    public class LessonManager : ILessonService
    {
        ILessonDal _lessonDal;

        public LessonManager(ILessonDal lessonDal)
        {
            _lessonDal = lessonDal;
        }

        public List<Lesson> GetLessonListById(int p)
        {
           return _lessonDal.GetByFilter(x => x.AppUserId == p);
        }

        public void TAdd(Lesson t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Lesson t)
        {
            throw new NotImplementedException();
        }

        public Lesson TGetById(int id)
        {
            return _lessonDal.GetByID(id);
        }

        public List<Lesson> TGetLessonListById(string r)
        {
            return _lessonDal.GetByFilter(x => x.Name == r); 
        }

        public List<Lesson> TGetList()
        {
            return _lessonDal.GetList();
        }

        public List<Lesson> TGetListByFilter(string r)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Lesson t)
        {
            throw new NotImplementedException();
        }
    }
}
