string yildizlar = "";
int kacSatir = 7;

for (int i = 1; i < kacSatir; i++)
{
    yildizlar += "*\n";
    for (int j = 1; j < i+1; j++)
    {
        yildizlar += "*";
        if (i == 6 && j==6)
        {
            yildizlar += "*";
            break;
        }
    }
}
Console.WriteLine(yildizlar);

﻿string yildizlar1 = "";
for (int i = 0; i < kacSatir; i++)
{
    for (int j = 0; j < i; j++)
    {
        yildizlar1 += "*";
  
    }
    yildizlar1 += "*\n";
}
Console.WriteLine(yildizlar1);
