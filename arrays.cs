using System.Collections;

// 1st way of defining arrays
int[] sayilar = new int[4];
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

// One disadv. of arrays is that you have to specify the amount of items it's going to contain while defining them.
// One adv. of arrays that it's type safe
// You can learn the amount of elements in an array using length property

// 2nd way of defining arrays
int[] sayilar1 = new int[] { 3, 4, 5, 1, 6, 12, 6, 4, 2, 13 };
int[] sayilar2;
sayilar2 = new int[] { 3, 4, 5, 1, 6, 12, 6, 4, 2, 13 };


// 3rd way of defining arrays
int[] sayilar3 = { 2, 3, 4, 1, 2, 3, 5, 6, 1, 6 }; // Anonymous type
// int[] sayilar4; 
// sayilar4 = { 2, 3, 4, 1, 2, 3, 5, 6, 1, 6 }; this doesn't work







// This is a non-generic list.
// In collections you learn the amount of elements with count property 
ArrayList list = new ArrayList();
list.Add(10);
list.Add("Efkan");
list.Add(500);

list.Remove(10);
