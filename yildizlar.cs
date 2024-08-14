string yildizlar = "";
for (int i = 1; i < 7; i++)
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