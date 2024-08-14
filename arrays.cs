int[] sayilar = new int[4];
// sayilar[0];
// sayilar[1];
// sayilar[2];
// sayilar[3];

sayilar[0] = 5;
sayilar[1] = 14;
sayilar[2] = 19;
sayilar[3] = 9;

// sayilar[4] = 10;
// index out of bounds gives runtime error

foreach (int num in sayilar)
{
    Console.WriteLine(num);
}
