// See https://aka.ms/new-console-template for more information

#region Int
    Console.WriteLine("Int");
    int a = int.MinValue;
    int b = int.MaxValue;
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine("Byte size is "+sizeof(int)); //Byte cinsinden
    Console.WriteLine("Bit size is " + sizeof(int)*8); //Bit cinsinden
#endregion

Console.WriteLine("-----------------------------------------------------------");

#region Long
    Console.WriteLine("Long");
    long c = long.MinValue;
    long d = long.MaxValue;
    Console.WriteLine(c);
    Console.WriteLine(d);
    Console.WriteLine("Byte size is "+sizeof(long)); //Byte cinsinden
    Console.WriteLine("Bit size is " + sizeof(long) * 8); //Bit cinsinden
#endregion


#region sbyte
// 0-255                // unsigned => signed   = sbyte     -128, 127
// -32768~32768         // signed   => unsigned = ushort    0, 65535
// -214...~214...       // signed   => unsigned = uint      0, 429...  
// -922...~922...       // signed   => unsigned = ulong     0, 1824...

#endregion

Console.WriteLine("-----------------------------------------------------------");

#region Ondalıklı Sayı Değişken Tipleri
// float, double, decimal

    #region float
        float f1 = 15.2f; // floata değer verirken sonuna "f" koyulur   
        Console.WriteLine("Float");
        Console.WriteLine(f1);
        float e = float.MinValue;
        float f = float.MaxValue;
        Console.WriteLine(e);
        Console.WriteLine(f);
        Console.WriteLine("Byte size is "+sizeof(float)); //Byte cinsinden
        Console.WriteLine("Bit size is " + sizeof(float) * 8); //Bit cinsinden
    #endregion

    Console.WriteLine("-----------------------------------------------------------");

    #region double
        double d1 = 15.22d; // doublea değer verirken sonuna "f" koyulur   
        Console.WriteLine("double");
        Console.WriteLine(d1);
        double g = double.MinValue;
        double h = double.MaxValue;
        Console.WriteLine(g);
        Console.WriteLine(h);
        Console.WriteLine("Byte size is "+sizeof(double)); //Byte cinsinden
        Console.WriteLine("Bit size is " +sizeof(double) * 8); //Bit cinsinden
    #endregion

    Console.WriteLine("-----------------------------------------------------------");

    #region double
        decimal de1 = 15.2222M; // decimala değer verirken sonuna "f" koyulur   
        Console.WriteLine("decimal");
        Console.WriteLine(de1);
        decimal i = decimal.MinValue;
        decimal j = decimal.MaxValue;
        Console.WriteLine(i);
        Console.WriteLine(j);
        Console.WriteLine("Byte size is "+sizeof(decimal)); //Byte cinsinden
        Console.WriteLine("Bit size is " +sizeof(decimal) * 8); //Bit cinsinden
#endregion

#endregion

Console.WriteLine("-----------------------------------------------------------");

#region Metinsel tip
    Console.WriteLine("String");
    string isim = "Efkan";
    string sayi = "5";
    string bosluk = " ";
    string soyisim = "Başer";

    string metin = isim + bosluk + soyisim;
    string metin2 = $"Merhaba Dolarlanmış: {isim} {soyisim}";
    string metin3 = string.Format("Merhaba Formatlanmış: {0} {1}", isim, soyisim);
    Console.WriteLine(metin);
    Console.WriteLine(metin2);
    Console.WriteLine(metin3);

    if(string.IsNullOrEmpty(str))
    {
        // Condition
    }

    // or you can put an exclamation mark to check if it's not null or empty

    if(!string.IsNullOrEmpty(str))
    {
        // Condition
    }

    TempData["foo"] = "lorem ipsum \"dolor\" sit amet"; // This shows the user double quote

    // String aslında bi char arrayidir (BENCE ÖNEMLİ)
#endregion

Console.WriteLine("-----------------------------------------------------------");

#region Karakter Tipi
    char karakter = 'a';
    karakter = '?';
    karakter = '3';
    karakter = 'b';
    Console.WriteLine(karakter);

#endregion
