namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please insert a number: ");
       int n = Convert.ToInt16(Console.ReadLine());
       Console.WriteLine("Please insert left or right: ");
       string d = Console.ReadLine();
       if(d=="right"){
            Console.WriteLine($"N is {n}; Shape is {d}");
            for (int i=1; i<=n; i++)
        {
            for (int row=1; row<=n - i; row++)
            {
                Console.Write(" ");
            }
            for (int col=1; col<=i; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        }
        else if(d=="left"){   
            Console.WriteLine($"N is {n}; Shape is left");
      for(int row = 0; row<5; row++){
    for(int col = 0; col<5; col++)
    {
        if(row>=col)
            Console.Write('*');
    }
    Console.WriteLine("");
    }
        }
        }
}


