namespace Homework99;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input 4 numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int LG = Two(a,b,c,d);
            Console.WriteLine($"a = {a}; b = {b}; c = {c}; d = {d}");
            Console.WriteLine($"The largest number is: {LG}");
    }
   static int Two(int a, int b, int c, int d){
    if(a>b&&a>c&&a>d){
        return a;
    }
    else if(b>c&&b>a&&b>d){
        return b;
    }
    else if(c>d&&c>a&&c>d){
        return c;
    }
    else{
        return d;
    }
    }
}
