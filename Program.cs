namespace Part1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please input a letter grade: ");
        string letterGrade = Console.ReadLine(); 
        int gpa;
        switch (letterGrade)
        {
            case "A":
                gpa = 4;
                break;
            case "B":
                gpa = 3;
                break;
            case "C":
                gpa = 2;
                break;
            case "D":
                gpa = 1;
                break;
            case "F":
                gpa = 0;
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                return; 
        }
        Console.WriteLine($"GPA point: {gpa}");
    }
}