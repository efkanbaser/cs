// break
// break completely stops the loop and gets you out of it's scope
// it only gets you out of one scope, the loop under will not work for i==7 and it excusively, it'll keep working for other iterations
string mesaj1 = "";
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 2; j++)
    {
        if (i == 7)
        {
            break;
        }
        mesaj1 += "Merhaba i=" + i +" j=" +j + "\n";
    }
}

mesaj1 += "Merhaba işlem tamam\n";
Console.WriteLine(mesaj1);

string mesaj3 = "";
for (int i = 0; i < 10; i++)
{
        if (i == 7)
        {
            break;
       }
        mesaj3 += "Merhaba i=" + i + "\n";
}


mesaj1 += "Merhaba işlem tamam\n";
Console.WriteLine(mesaj3);


// continue
// continue skips the current iteration of the loop
string mesaj2 = "";
for (int i = 0; i < 10; i++)
{
    if (i == 7)
    {
        continue;
    }
    mesaj2 += "Merhaba " + i + "\n";
}
mesaj2 += "Merhaba işlem tamam\n";
Console.WriteLine(mesaj2);

