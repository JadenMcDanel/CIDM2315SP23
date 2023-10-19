namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer(110, "Alice", 28);
        Customer customer2 = new Customer(111, "Bob", 30);
        customer1.PrintCusInfo();
        customer2.PrintCusInfo();
        customer1.ChangeID(220);
        customer2.ChangeID(221);
        customer1.PrintCusInfo(); 
        customer2.PrintCusInfo();
        customer1.CompareAge(customer2);
    }
}
