namespace Homework5P1;

class Program
{
    static void Main(string[] args)
   {
        Console.WriteLine("Please input 2 numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int LG = Two(a,b);
            Console.WriteLine($"a = {a}; b = {b}");
            Console.WriteLine($"The largest number is: {LG}");
    }
   static int Two(int a, int b){
    if(a>b){
        return a;
    }
    else{
        return b;
    }
    }
}