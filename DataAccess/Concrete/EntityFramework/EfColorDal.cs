using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (ProjectContext context = new ProjectContext())
            {
                var addedEntity = context.Entry(entity); // Referansı yakala , veritabaniyla iliskilendir.
                addedEntity.State = EntityState.Added; // Ekleme , set et
                context.SaveChanges(); // Değişikliği kaydet
            }
        }

        public void Delete(Color entity)
        {
            using (ProjectContext context = new ProjectContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (ProjectContext context = new ProjectContext())
            {
                return filter == null ? context.Set<Color>().ToList()
                    : context.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color entity)
        {
            using (ProjectContext context = new ProjectContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
