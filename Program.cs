namespace Homework5P3;

class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("Enter Your Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Your Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Enter Your Password again: ");
            string P2 = Console.ReadLine();
            Console.WriteLine("Enter Birthyear");
            string B = Console.ReadLine();
            if (int.TryParse(B, out int Birth))
        if (password == P2 && Birth <= 2004){
            Console.WriteLine("Account is created successfully");
        }
        else if(password == P2 && Birth>2004){
            Console.WriteLine("Could not create account.");
        }
        else{       
            Console.WriteLine("Wrong Password");
        }
            
    }
}
