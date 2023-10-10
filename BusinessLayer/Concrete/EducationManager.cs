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
    public class EducationManager : IEducationService
    {
        IEducationDal _educationDal;

        public EducationManager(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        public void TAdd(Education t)
        {
            _educationDal.Insert(t);
        }

        public void TDelete(Education t)
        {
            _educationDal.Delete(t);
        }

        public Education TGetById(int id)
        {
            return _educationDal.GetByID(id);
        }

        public List<Education> TGetEducationListName(string r)
        {
            return _educationDal.GetByFilter(x => x.Name == r);
        }

        public List<Education> TGetEducationWithSurname()
        {
           return _educationDal.GetListWithSurname();
        }

        public List<Education> TGetList()
        {
          return _educationDal.GetList();
        }

        public List<Education> TGetListByFilter(string r)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Education t)
        {
            _educationDal.Update(t);
        }
    }
}
