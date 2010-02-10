using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HoodCMS.Data.Interfaces;
using System.Data.Linq;

namespace HoodCMS.Data.Concrete
{
    public class OccasionRepository : IOccasionRepository
    {
        private HoodDataContext db = new HoodDataContext();

        #region IRepository<Occasion> Members

        public IQueryable<Occasion> GetAll()
        {
            return db.Occasions.AsQueryable().Where(x => x.OccasionStartDate > DateTime.Now).OrderBy(x => x.OccasionStartDate);
        }

        public void Delete(int id)
        {
            HoodCMS.Data.Occasion e = db.Occasions.First(x => x.OccasionId == id);
            db.Occasions.DeleteOnSubmit(e);
        }

        public Occasion Get(int id)
        {
            return db.Occasions.First(x => x.OccasionId == id);
        }

        public void Update(Occasion entity)
        {
            db.Occasions.Attach(entity);
        }

        public void Add(Occasion entity)
        {
            db.Occasions.InsertOnSubmit(entity);
        }

        public IQueryable<Occasion> GetNextThree()
        {
            var s = from t in db.Occasions
                    where t.OccasionStartDate > DateTime.Now
                    orderby t.OccasionStartDate
                    select t;

            int take = s.Count() > 3 ? 3 : s.Count();

            return s.Take(take).AsQueryable();
        }

        public IQueryable<Occasion> GetPage(int? page)
        {
            var s = from t in db.Occasions
                    orderby t.OccasionStartDate descending
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
