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
    public class ArticleManager : IArticleService
    {
        IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public void TAdd(Article t)
        {
            _articleDal.Insert(t);
        }

        public void TDelete(Article t)
        {
            _articleDal.Delete(t);
        }

        public Article TGetById(int id)
        {
           return _articleDal.GetByID(id);
        }

        public List<Article> TGetList()
        {
           return _articleDal.GetList();
        }

        public List<Article> TGetListByFilter(string r)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Article t)
        {
            _articleDal.Update(t);
        }
    }
}
