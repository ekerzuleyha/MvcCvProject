using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcCv.Models.Entity;

namespace MvcCv.Repositories
{
    public class GenericRepository<T> where T :class, new()
    {
        DbCVEntities db = new DbCVEntities();

        //bana t den gelen değeri liste olarak döndüreceksin diyoruz.

        public List<T> List()
        {
            return db.Set<T>().ToList();
        }

        public void TAdd(T p)
        {
            db.Set<T>().Add(p);
            db.SaveChanges();
        }

        public void TDelete(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }

        //id ye göre getirme, int ve T türünde olduğu için return kullanıldı.
        public T TGet(int id)
        {
            return db.Set<T>().Find(id);
        }

        //güncelleme de yapılan değişiklikleri kaydedecek. T den gelen bir p parametresi
        public void TUpdate(T p)
        {
            db.SaveChanges();
        }
    }
}