using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IEducationService : IGenericService<Education>
    {
        List<Education> TGetEducationListName(string r);
        List<Education> TGetEducationWithSurname();
    }
}
