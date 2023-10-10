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
    public class TeacherManager : ITeacherService
    {
        ITeacherDal _teacherDal;

        public TeacherManager(ITeacherDal teacherDal)
        {
            _teacherDal = teacherDal;
        }

        public void TAdd(Teacher t)
        {
            _teacherDal.Insert(t);
        }

        public void TDelete(Teacher t)
        {
           _teacherDal.Delete(t);
        }

        public Teacher TGetById(int id)
        {
            return _teacherDal.GetByID(id);
        }

        public List<Teacher> TGetList()
        {
            return _teacherDal.GetList();
        }

        public List<Teacher> TGetListByFilter(string r)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Teacher t)
        {
            _teacherDal.Update(t);
        }
    }
}
