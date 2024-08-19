Random rnd = new Random();
int[] sayilar = new int[100];
int uretilenSayi;
int sayac = 0;
int toplam = 0;
string mesaj = "";

for (int i = 1; i < sayilar.Length+1; i++)
{
    uretilenSayi = rnd.Next(1, 20);
    if(uretilenSayi == 8)
    {
        toplam++;
    }
    sayilar[i-1] = uretilenSayi;
    mesaj += "i : " + i + " - " + uretilenSayi + "\n";
}

for (int i = 0; i<sayilar.Length; i++)
{
    sayac++;
    if (sayilar[i] == 8)
    {
        break;
    }
}

mesaj += "8 sayısı ilk defa " + sayac + ". sırada üretilmiştir ve toplamda " + toplam + " defa üretilmiştir.";
Console.WriteLine(mesaj);

