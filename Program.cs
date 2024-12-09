// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Declare some variables

PI();
void PI()
{
    try
    {   
        Console.Write("Input the first Real Number : ");
        float floatPI = float.Parse(Console.ReadLine()!);
        Console.Write("Input the second Real Number : ");
        double doublePI = double.Parse(Console.ReadLine()!);
        // Print the results on the console
        Console.WriteLine("Float PI is: " + floatPI, + doublePI);
        // Console.WriteLine("Double PI is: " + doublePI);
    }
    catch (Exception)
    {     
        Console.Write(" Invalid Real Number : ");
    }
}


