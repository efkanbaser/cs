string yildizlar = "";
int kacSatir = 7;

for (int i = 1; i < kacSatir; i++)
{
    yildizlar += "*\n";
    for (int j = 1; j < i + 1; j++)
    {
        yildizlar += "*";
        if (i == 6 && j == 6)
        {
            yildizlar += "*";
            break;
        }
    }
}
Console.WriteLine(yildizlar);
Console.WriteLine("\n");

//-------------------------------------------------------------------------------------------
string yildizlar1 = "";
for (int i = 0; i < kacSatir; i++)
{
    for (int j = 0; j < i; j++)
    {
        yildizlar1 += "*";

    }
    yildizlar1 += "*\n";
}
Console.WriteLine(yildizlar1);
Console.WriteLine("\n");

//-------------------------------------------------------------------------------------------
string yildizlar2 = "";

for (int i = 0; i < kacSatir; i++)
{
    for (int j = 0; j < kacSatir - i-1; j++)
    {
        yildizlar2 += "*";
        
    }
    yildizlar2 += "*\n";
}
Console.WriteLine(yildizlar2);
Console.WriteLine("\n");