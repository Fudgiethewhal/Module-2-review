using System.ComponentModel.Design;

namespace Module_2_review;

class Program
{
    static void Main(string[] args)
    {
        var students = new Dictionary<int, Student>();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nStudent Grades Manager");
            Console.WriteLine("1. Create Student");
            Console.WriteLine("2. Add Grade");
            Console.WriteLine("3. Calculate Average Grade");
            Console.WriteLine("4. Display Student Information");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        CreateStudent(students);
                        break;
                    case 2:
                        AddGrade(students);
                        break;
                    case 3:
                        CalculateAverage(students);
                        break;
                    case 4:
                        DisplayStudentInfo(students);
                        break;
                    case 5:
                        exit = true;
                        Console.WriteLine("Exiting application.");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

        }
    }
}