namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command=Console.ReadLine();
            List<Student> students = new List<Student>();
            while(command != "end")
            {
                string [] information=command.Split(' ').ToArray();
                string firstName = information[0];
                string secondName = information[1];
                int age =int.Parse(information[2]);
                string Hometown = information[3];

                Student student = new Student()
                {
                    FirstName= firstName,
                    LastName= secondName,
                    Age= age,
                    HomeTown= Hometown,
                };
                students.Add(student);
                command = Console.ReadLine();
            }
            string city=Console.ReadLine();

            List<Student> filteredStudents= students.Where(x=>x.HomeTown==city).ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown {get; set; }


    }
}