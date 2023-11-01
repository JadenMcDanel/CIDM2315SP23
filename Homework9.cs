namespace Homework9
{
    class Student
    {
        public int StudentID { get; private set; }
        public string StudentName { get; private set; }
        public Student(int id, string name)
        {
            StudentID = id;
            StudentName = name;
            studentList.Add(this);
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Student ID: {StudentID}, Student Name: {StudentName}");
        }
        public static List<Student> studentList = new List<Student>();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(111, "Alice");
            Student student2 = new Student(222, "Bob");
            Student student3 = new Student(333, "Cathy");
            Student student4 = new Student(444, "David");
            Dictionary<string, double> gradebook = new Dictionary<string, double>
            {
                { "Alice", 4.0 },
                { "Bob", 3.6 },
                { "Cathy", 2.5 },
                { "David", 1.8 }
            };
            if (!gradebook.ContainsKey("Tom"))
            {
                gradebook["Tom"] = 3.3;
            }
            double totalGPA = gradebook.Values.Sum();
            double averageGPA = totalGPA / gradebook.Count;
            Console.WriteLine($"Average GPA: {averageGPA}");
            foreach (var student in gradebook)
            {
                Console.WriteLine($"Student ID: {GetStudentID(student.Key)}, Student Name: {student.Key}");
            }
        }
    static int GetStudentID(string studentName)
    {
        foreach (var student in Student.studentList)
        {
                if (student.StudentName == studentName)
            {
                    return student.StudentID;
                }
            }
            return 555; 
        }
    }
}
