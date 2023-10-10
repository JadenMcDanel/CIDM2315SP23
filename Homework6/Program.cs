namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        professor professor1 = new professor{
                name = "Alice",
                ClassT = "Java",
                };
                professor1.SetSalary(9000);

                professor professor2 = new professor{
                    name = "Bob",
                    ClassT = "Math",
                };
                professor2.SetSalary(8000);

                student student1 = new student{
                    name = "Lisa",
                    ClassE = "Java",
                    Grade = 90};

                student student2 = new student{
                    name = "Tom",
                    ClassE = "Math",
                    Grade = 80};

                    double professorSalaryD = professor1.GetSalary() - professor2.GetSalary();
                    int totalGrade = student1.Grade + student2.Grade;
                
                Console.WriteLine($"Professor {professor1.name} teaches {professor1.ClassT}, and the salary is {professor1.GetSalary()}");
                Console.WriteLine($"Professor {professor2.name} teaches {professor2.ClassT}, and the salary is {professor2.GetSalary()}");
                Console.WriteLine($"Student {student1.name} enrolls {student1.ClassE}, and the grade is {student1.Grade}");
                Console.WriteLine($"Student {student2.name} enrolls {student2.ClassE}, and the grade is {student2.Grade}");
                Console.WriteLine($"Salary difference between Alice and Bob is: {professorSalaryD}");
                Console.WriteLine($"The total grade of Lisa and Tom is: {totalGrade}");
                }
}
