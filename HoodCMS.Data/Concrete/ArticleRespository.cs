using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HoodCMS.Data.Interfaces;

namespace HoodCMS.Data.Concrete
{
    public class ArticlesRepository : IArticleRepository
    {
        private HoodDataContext db = new HoodDataContext();

        #region IRepository<Article> Members

        public IQueryable<Article> GetAll()
        {
            return db.Articles.AsQueryable();
        }

        public void Delete(int id)
        {
            Article news = db.Articles.First(x => x.ArticleId == id);
            if (news != null)
                db.Articles.DeleteOnSubmit(news);
        }

        public Article Get(int id)
        {
            return db.Articles.First(x => x.ArticleId == id);
        }

        public void Update(Article entity)
        {
            db.Articles.Attach(entity);
        }

        public void Add(Article entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Article> GetNextThree()
        {
            var s = from t in db.Articles
                    orderby t.ArticleDate descending
                    select t;
            
            int take = s.Count() > 3 ? 3 : s.Count();

            return s.Take(take).AsQueryable();
        }

        public IQueryable<Article> GetPage(int? page)
        {
            var s = from t in db.Articles
                    orderby t.ArticleDate descending
                    select t;

            int skip = ((page.GetValueOrDefault(1) - 1) * 10) < s.Count() ? ((page.GetValueOrDefault(1) - 1) * 10) : s.Count();
            int take = (s.Count() - skip) > 10 ? 10 : s.Count() - skip;

            return s.Skip(skip).Take(take).AsQueryable();
        }

        public void Save()
        {
            db.SubmitChanges();
        }

        #endregion
    }
}
