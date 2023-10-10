using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfEducationDal : GenericRepository<Education>, IEducationDal
    {
        public List<Education> GetListWithSurname()
        {
            using(var c = new Context())
            {
                return c.Educations.Include(x => x.AppUser).ToList();
            }
        }
    }
}
