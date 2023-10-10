using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ILessonService : IGenericService<Lesson> 
    {
        List<Lesson> GetLessonListById(int p);
        List<Lesson> TGetLessonListById(string r);
    }
}
