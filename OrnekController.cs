using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class OrnekController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string Metin, string Kelime)
        {
            // SORU: Metin ifadesinde Kelime ifadesi kaç defa geçiyor bulunuz
            int sayac = 0;
            int IndexNo = 0;

            // IndexOf verilen string içerisinde metodun parameetresine verilen değeri arar, bulduğunda ilk harfin index numarasını döner.(Index numarası tüm stringlerde ilk karakterden başlayarak 0dan itibaren arkaplanda verilen bir numaradır.

            // Bulamazsa -1 değerini döner

            // string isim = "Efkan";
            // char c = isim[0];

            IndexNo = Metin.IndexOf(Kelime);
            while (IndexNo != -1)
            {
                sayac++;
                IndexNo=Metin.IndexOf(Kelime,IndexNo + Kelime.Length);
            }

            TempData["Mesaj"] = $"Metin ifadesi içerisinde kelime ifadesi {sayac} adet geçmektedir";



            return View();
        }
    }
}
