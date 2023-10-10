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
    public class CommentTeacherManager : ICommentTeacherService
    {
        ICommentTeacherDal _commentTeacherDal;

        public CommentTeacherManager(ICommentTeacherDal commentTeacherDal)
        {
            _commentTeacherDal = commentTeacherDal;
        }

        public void TAdd(CommentTeacher t)
        {
           _commentTeacherDal.Insert(t);
        }

        public void TDelete(CommentTeacher t)
        {
            _commentTeacherDal.Delete(t);
        }

        public CommentTeacher TGetById(int id)
        {
          return _commentTeacherDal.GetByID(id);
        }

        public List<CommentTeacher> TGetList()
        {
            return _commentTeacherDal.GetList();
        }

        public List<CommentTeacher> TGetListByFilter(string r)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(CommentTeacher t)
        {
            _commentTeacherDal.Update(t);
        }
    }
}
