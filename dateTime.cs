DateTime dt1 = new DateTime(2024, 8, 26);
DateTime dt2 = new DateTime();
DateTime dt3 = DateTime.Now;

string metin = "";

Console.WriteLine("Year: " + dt3.Year);
Console.WriteLine("Month: " + dt3.Month);
Console.WriteLine("Day: " + dt3.Day);
Console.WriteLine("Hour: " + dt3.Hour);
Console.WriteLine("Minute: " + dt3.Minute);
Console.WriteLine("Second: " + dt3.Second);

metin = dt2.ToString();
metin = dt2.ToShortDateString();
metin = dt2.ToShortTimeString();
metin = dt2.ToLongDateString();
metin = dt2.ToLongTimeString();

metin = dt2.TimeOfDay + "";
metin = dt2.DayOfWeek + "";

metin = dt2.AddYears(3).ToLongDateString();
metin = dt2.AddDays(45).ToLongDateString();
metin = dt2.AddMinutes(2400).ToString();
metin = dt2.AddHours(-150).ToString();

bool b = DateTime.IsLeapYear(2024); // Şubat ayının 29 çektiği yılları gösterir

int a = DateTime.DaysInMonth(2025, 9);

DateTime dt4 = Convert.ToDateTime("26.10.2024 19:00");

TimeSpan ts = dt2.Subtract(dt4);
metin = ts.Hours + "";
metin = ts.Days + "";
metin = ts.TotalDays + "";
metin = ts.Hours + "";

// dd : sayısal olarak gün bilgisi verir
// dddd : metinsel olarak gün bilgisi verir 
// MM : sayısal olarak ay bilgisi verir
// MMMM : metinsel olarak ay bilgisi verir
// yy : kısa yıl bilgisi verir (24)
// yyyy : uzun yıl bilgisi verir 

// hh : 12 saat üzerinde saati verir
// HH : 24 saat üzerinde saati verir
// mm : dakika bilgisi verir
// ss : saniyeyi verir

metin = dt2.ToString("dddd, dd MMMM yyyy, HH:mm:ss");

