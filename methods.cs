using System.Text;

int Topla(int s1, int s2)
{
    int sonuc = s1 + s2;
    return sonuc;
}


// Access modifiers --> public
//                  --> private (default)
 
// What it returns  --> return type (int, string etc...)
//                  --> void      

/// <summary>
/// Bu metot taban değeri ve üs değerini alarak alınan tabanın üssünü döner
/// </summary>
/// <param name="taban">Buraya taban değerini giriniz</param>
/// <param name="us">Buraya us değerini giriniz</param>
/// <returns>sonuc</returns>
int usAl(int taban, int us)
{
    int sonuc = 1;
    for (int i = 0; i < us; i++)
    {
        sonuc *= taban; 
    }
    return sonuc;
}
usAl(3, 4);

string[] HaftanınGunleriniVer()
{
    string[] dizi = new string[] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

    return dizi;
}

StringBuilder MesajVer(string isim)
{
    string[] dizi = HaftanınGunleriniVer();
    StringBuilder sb = new StringBuilder();
    sb.Append("Merhaba");
    sb.Append(isim);

    return sb;
}

int SesliHarfSayisiniBul(string ifade)
{
    int sesliHarfSayisi = 0;

    char[] sesliHarfler = { 'a', 'e', 'i', 'ı', 'u', 'ü', 'o', 'ö'};
    string yeniIfade = ifade.ToLower();

    for (int i = 0; i < ifade.Length; i++)
    {
        if(Array.IndexOf(sesliHarfler, yeniIfade[i]) != -1)
        {
            sesliHarfSayisi++;
        }
    }


    return sesliHarfSayisi;
}

Console.WriteLine(SesliHarfSayisiniBul("efkan"));

Random rnd = new Random();
rnd.Next(); // Normal bir metot
Math.Abs(4); // Statik bir metot
