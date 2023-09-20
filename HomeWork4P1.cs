namespace Homework4P1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please insert first number: ");
        int a = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please insert second number: ");
        int b = Convert.ToInt16(Console.ReadLine());
    
    if(a>b){
        Console.WriteLine($"a = {a}; b = {b}");
    Console.WriteLine($"The largest number is {a}");}
    else if(b>a){
        Console.WriteLine($"a = {a}; b = {b}");
        Console.WriteLine($"The largest number is {b}");
    }
    else if(a==b){
    Console.WriteLine($"a = {a}; b = {b}");
    Console.WriteLine($"The numbers are equal.");
}
    }
}
