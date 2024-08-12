Random rnd = new Random();
// First, create space in memory for random and name it 'rnd'
// Then, from the existing class of Random create a
// Copy
// Instance
// Object
// And append it to rnd

int res1 = rnd.Next();
int res2 = rnd.Next(500);
int res3 = rnd.Next(500, 700);
double res4 = rnd.NextDouble(); // 0-1 arasında 1 hariç bir sayı üretir
