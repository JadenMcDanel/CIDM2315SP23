namespace Homework4Part3;

class Program
{
    static void Main(string[] args)
    {  
        Console.WriteLine("Please insert number: ");
        int n  = Convert.ToInt16(Console.ReadLine());
   for(int row = 0; row<n; row++){
    for(int col = 0; col<n; col++)
    {
        if(row>=col)
            Console.Write('*');
    }
    Console.WriteLine("");
   }

   }
}
