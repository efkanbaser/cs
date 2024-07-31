
// you can't write code in namespace scope

public class DegiskenlerinYasamAlani
{
    // In class scope you can write variables and give them a value but cannot use them
    int a = 15;
    // int b = a + 10; doesn't work because you can't use int a in class scope

    int b;
    // if a variable is defined between class scope, it'll take an automatic value. 
    // int = 0
    // str = ""
    // char = '' 
    // etc...

    // int k = b + 1; gives an error in this scope
    
    public void Main()
    {
        int k = b + 1; // doesn't give an error in this scope because b == 0
        Console.WriteLine(k);
    }

}
