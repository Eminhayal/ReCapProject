using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Core.DataAccess.EntityFramework
{
    // Bütün Ef'lerde yapacaklarımızı tek tek yazmamak için Ef base oluşturduk.
    // Generic yapısını verdik < Hangi varlıkla çalışacağımız , Hangi veritabanını kullancağımız> 
    // Referans olarak EntityRepository verdik Methodları (işlemleri çağırabilmek (implement etmemiz için )
    // <TEntity> ise gelen methotlarda kullanmak istediğimiz varlığı belirttik.
    
    public class EfEntityRepositoryBase<TEntity, TContex> : IEntityRepository<TEntity>
        
        // Varlığımızın hangi özelliklerde olabileceğini belirtiyoruz.
        // Yani class olamalı , referansı IEntity olmalı , newlenebilir olmalı 
        
        where TEntity : class,IEntity , new () 
        where TContex : DbContext , new()
    {
        public void Add(TEntity entity) // interfaceden çağırdığımız methodda yukarıda olmasını istediğimiz varlığı yazıyoruz
        {
            //Yapılan işlem sistemi zorlıcağı için using kullanıyoruz.
            //Yani işlemi yaptıktan sonra bekleme yapmadan direk çöpe taşıyor diyebiliriz.
            // () yapılan işlem ise yeni bir DbContext oluşturmak 
            using (TContex context = new TContex())
            {
                var addedEntity = context.Entry(entity);    // Referansı yakala , veritabanı ile ilişkilendir.
                addedEntity.State = EntityState.Added;      // Ekleme , set etme
                context.SaveChanges();                      // Değişikliği kaydet
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContex context = new TContex())
            {
                var deletedEntity = context.Entry(entity);      // Referansı yakala , veritabanı ile ilişkilendir.
                deletedEntity.State = EntityState.Deleted;      // Silme işlemi
                context.SaveChanges();                          // Değişikliği kaydet
            }
        }

        // videodan bul 
        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContex context = new TContex())
            {
                return context.Set<TEntity>().FirstOrDefault(filter);
            }
        }

        //videodan bul 
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContex context = new TContex())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContex context = new TContex())
            {
                var updatedEntity = context.Entry(entity);       // Referansı yakala , veritabanı ile ilişkilendir.
                updatedEntity.State = EntityState.Modified;      // Güncelleme işlemi
                context.SaveChanges();                          // Değişikliği kaydet
            }
        }
    }
}
