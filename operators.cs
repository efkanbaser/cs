// Mathematical operators
// +, -, *, /, %


// Comparison operators
// <, >, <=, >=, ==, !=
int num1 = 2;
int num2 = 3;
bool b1 = num1 > num2;

string str1 = "a";
string str2 = "b";
// bool b = str1 > str2; gives an error because you can't compare if strings are bigger than eachother or not

char c1 = 'a';
char c2 = 'b';
bool b2 = c1 > c2;
// this works because all char values have their respective ASCII values

int code = Convert.ToInt32(c1); // To learn ASCII value of 'a'


// Logical operators
// &&, ||, !, &, |

// && single false results in false
// || single true results in true

// & and | are used for comparisons between bits (0s and 1s) because it keeps looking even after a false value,
// in practical coding this makes it work slower but when comparing bits it gives you the desired result wheras
// double operands would give unwanted results

bool bb = false;
bool cc = !bb;


// Increment, decrement
// ++, --

int sayi = 10;
// sayi++; ++sayi; sayi--; --sayi;
int sonuc = sayi++; // 10
sonuc = ++sayi; // 11

