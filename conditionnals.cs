// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int deger = 4;
switch (deger)
{
    case 0:
        // Çalışacak kod
    break;

    case 1:
        // Çalışacak kod
    break;

    case 2:
        // Çalışacak kod
    break;

    case 3:
    case 4:
        // Çalışacak kod
        // case 3 veya case 4 için çalışır
    break;
}

int num1 = 10;
int num2 = 20;
int res = 0;

if(num1 > num2)
{
    res = num1 * num2 + 5;
}
else
{
    res = num2 + 20;
}

res = num1 > num2 ? num1 * num2 + 5 : num2 + 20;

// Ternary operator
// res = num1 > num2 ? num1 * num2 + 5 : num2 + 20;
// result  = condition ? is right : is wrong
