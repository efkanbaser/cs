int a = Math.Abs(-10);
double b = Math.Acos(0.48);
b = Math.BigMul(50000, 50000); // Returns a long value just in case int*int returns bigger than sizeofint
b = Math.Ceiling(15.1); // Her zaman yukarı yuvarlar
b = Math.Floor(15.9); // Her zaman aşağı yuvarlar
b = Math.Round(15.96, 1); // Virgülden sonra kaç karakter istediğini seçersin, sonra da son karaktere göre yuvarlama yapar.

b = Math.Min(500, 100); // Verilen sayıdan en küçük olanı verir
b = Math.Max(500, 100); // Verilen sayıdan en büyük olanı verir
b = Math.Pow(2, 3); // 2nin 3. kuvvetini alır

Math.DivRem(150, 7, out a);
b = Math.PI;
b = Math.E;

b = Math.Sqrt(16);
b = Math.Exp(2);
b = Math.Log(10); // ln10, not actually log10
b = Math.Log10(10);

b = Math.Sign(-5000); // İçerdeki sayının işaretini döner, yani -1, 0, 1 döner
b = Math.Truncate(500015120.132512351235125135312); // Virgülden sonrasını tamamen siler
double c = System.Numerics.Complex.Sqrt(-16).Phase;
Console.WriteLine(c);
                                                  


