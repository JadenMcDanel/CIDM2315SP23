namespace HomeWork4Part1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input an integer: ");
        string num = Console.ReadLine();
        int n = Convert.ToInt16(num);
        if(n==3){
            Console.WriteLine("N is prime");
        }
        else if (n==2){
            Console.WriteLine("N is prime");
       }
        else if (n==3){
            Console.WriteLine("N is prime");
        }
        else if (n==5){
            Console.WriteLine("N is prime");
        }
        else if(n==7){
            Console.WriteLine("N is prime");
        }
        else if(n==11){
            Console.WriteLine("N is prime");
        }
        else if(n%3==0){
            Console.WriteLine("N is non-prime");
        }
        else if(n%5==0){
            Console.WriteLine("N is non-prime");
        }
        else if(n%7==0){
            Console.Write("N is non-prime");
        }
        else if(n%11==0){
            Console.WriteLine("N is non-prime");
        }
        else if(n%2==0){
            Console.WriteLine("N is non-prime");
        }
        else{
            Console.WriteLine("N is prime");
        }
             
    }
}
