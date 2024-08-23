using Microsoft.AspNetCore.Mvc;

namespace CSharpTemelleri.MVCCoreUI.Controllers
{
    public class IfadeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string ifade)
        {
            // Ali
            // A l i -> char array
            // Dizinin her elemanının ascii kodunu elde et 65 108 105

            // 0065 0108 0105
            // 006501080105
            // Bir tane baştan bir tane sondan eleman alarak şifrelenmiş ifadeyi oluştur
            // 050061500810

            string[] asciikodlar = new string[ifade.Length];
            string asciikodlarYanYana = "";
            string sifre = "";

            for (int i = 0; i < ifade.Length; i++)
            {
                asciikodlar[i] = Convert.ToInt32(ifade[i]).ToString();
            }

            for (int i = 0; i < asciikodlar.Length; i++)
            {
                asciikodlar[i] = asciikodlar[i].PadLeft(4, '0');
            }

            for (int i = 0; i < asciikodlar.Length; i++)
            {
                asciikodlarYanYana += asciikodlar[i];
            }

            for (int i = 0; i < asciikodlarYanYana.Length/2; i++)
            {
                sifre += asciikodlarYanYana.Substring(i,1);
                sifre += asciikodlarYanYana.Substring(asciikodlarYanYana.Length-1-i,1);
            }

            TempData["mesaj"] = sifre;



            return View();
        }
    }
}
