using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class SayilarController : Controller
    {
        public IActionResult Index()
        {
            Random rnd = new Random();
            int[] sayilar = new int[1000];

            for (int i=0;i<sayilar.Length; i++)
            {
                int uretilenSayi = rnd.Next(1, 500);
                sayilar[i] = uretilenSayi;
            }

            
            string sayilarJson = Newtonsoft.Json.JsonConvert.SerializeObject(sayilar);
            HttpContext.Session.SetString("sayilar", sayilarJson);


            return View();
        }

        [HttpPost]
        public IActionResult Index(int Sayi)
        {
            string sayilarJson = HttpContext.Session.GetString("sayilar");
            int[] sayilar = Newtonsoft.Json.JsonConvert.DeserializeObject<int[]>(sayilarJson);
            int sayac = 0;
            string mesaj = "";

            for (int i = 0; i < sayilar.Length; i++)
            {
                mesaj += sayilar[i] + "<br>";
                if (Sayi == sayilar[i])
                {
                    sayac++;
                }
            }

            TempData["mesaj"] = mesaj + $"Dizi içerisinde {Sayi} ifadesi {sayac} kere geçmektedir.";
            return View();
        }
    }
}
