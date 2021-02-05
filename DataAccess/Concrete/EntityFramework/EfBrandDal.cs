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
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (ProjectContext context = new ProjectContext())
            {
                var addedEntity = context.Entry(entity); // Referansı yakala , veritabaniyla iliskilendir.
                addedEntity.State = EntityState.Added; // Ekleme , set et
                context.SaveChanges(); // Değişikliği kaydet
            }
        }

        public void Delete(Brand entity)
        {
            using (ProjectContext context = new ProjectContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (ProjectContext context = new ProjectContext())
            {
                return filter == null ? context.Set<Brand>().ToList()
                    : context.Set<Brand>().Where(filter).ToList();
            }
        }

        public void Update(Brand entity)
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
