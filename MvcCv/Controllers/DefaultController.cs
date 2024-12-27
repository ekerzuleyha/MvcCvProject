using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;//modeli çağırdık(klasörü)

namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        // db nesnesi türettik . db nesnesi aracılığıyla db nesnesi içerisinde yer alan sınıflara erişim sağlayabiliyoruz.
        DbCVEntities db = new DbCVEntities();

        public ActionResult Index()
        {
            //hakkımda tablosunda yer alan verileri bana listelesin.
            var degerler = db.Tbl_Hakkimda.ToList();
            // geriye değerleri döndür.index kısmında bunu çağırmam gerekiyor.
            return View(degerler);
        }


        public PartialViewResult Deneyim()
        {
            var deneyimler = db.TblDeneyimlerim.ToList();
            return PartialView(deneyimler);
        }

        public PartialViewResult Eğitim()
        {
            var egitim = db.TblEğitimlerim.ToList();
            return PartialView(egitim);
        }

        public PartialViewResult Yetenek()
        {
            var yetenek = db.TblYeteneklerim.ToList();
            return PartialView(yetenek);
        }

        public PartialViewResult Hobi()
        {
            var hobi = db.TblHobilerim.ToList();
            return PartialView(hobi);
        }

        public PartialViewResult Sertifika()
        {
            var sertifika = db.TblSertifikalarım.ToList();
            return PartialView(sertifika);
        }

        [HttpGet]
        public PartialViewResult İletisim()
        {
            
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult İletisim(Tblİletisim i)
        {
            i.Tarih = DateTime.Now;
            db.Tblİletisim.Add(i);
            db.SaveChanges();
            return PartialView();

        }
    }
}