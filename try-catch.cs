//try
//{
//    string Sayi = "Ahmet";
//    int sayi = Convert.ToInt32(Sayi);
//}
//catch (Exception e)
//{
//    Console.WriteLine("Hata oluştu\n" + e.Message + "\n" + e.HelpLink + "\n" + e.StackTrace);
//}


try
{
    string Sayi = "Ahmet";
    int sayi = Convert.ToInt32(Sayi);
    int sonuc = 150 / sayi;
}
catch (FormatException e)
{
    Console.WriteLine("Lüften bir sayı giriniz");
    // Kendine mail atabilirisn
    // Loglama yapabilirsin
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Lütfen sıfırdan başka bir sayı giriniz");
}
catch (OverflowException e)
{
    Console.WriteLine("Daha küçük bir sayı giriniz");
}
catch (Exception e)
{
    Console.WriteLine("Hata oluştu. Sistem yöneticisine başvurunuz. Hata kodu 50105");
    throw;
}
finally
{
    // This works no matter what you do
}


















