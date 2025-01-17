using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Module_2_review;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        bool exit = false;

        Student student1 = new Student()
        {
            Name = "Fudgie",
            ID = 1001
        };
        student1.AddGrade(94.3);

        Student student2 = new Student
        {
            Name = "Queso",
            ID = 1002,
        };
        student2.AddGrade(91.7);

        Student student3 = new Student
        {
            Name = "Gerardo",
            ID = 1003
        };
        student3.AddGrade(89.7);
        
        students.Add(student1);
        students.Add(student2);
        students.Add(student3);

        foreach (var student in students)
        {
            Console.WriteLine($"Student Name: {student.Name}, ID: {student.ID}, Average Grade: {student.CalculateAverageGrade()}");
        }

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
                        CalculateAverageGrade(students);
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

    static void CreateStudent(List<Student> students)
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();
        Console.Write("Enter student ID: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            Student newStudent = new Student()
            {
                Name = name,
                ID = id
            };
            students.Add(newStudent);
            Console.WriteLine("Student created succcessfully.");
        }
        else
        {
            Console.WriteLine("Invalid ID.Student creation failed.");
        }
    }

    static void AddGrade(List<Student> students)
    {
        Console.Write("Enter student ID: ");
        {
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Student student = students.Find(s => s.ID == id);
                if (student != null)
                {
                    Console.WriteLine("Enter grade(s): ");
                    string[] gradesInput = Console.ReadLine().Split(' ');
                    double[] grades = Array.ConvertAll(gradesInput, Double.Parse);
                    student.AddGrade(grades);
                    Console.WriteLine("Grade added successfully.");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    static void CalculateAverageGrade(List<Student> students)
    {
        Console.WriteLine("Enter student ID: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            Student student = students.Find(s => s.ID == id);
            if (student != null)
            {
                double average = student.CalculateAverageGrade();
                Console.WriteLine($"Student {student.Name}'s average grade is {average}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid ID. Please enter a number.");
        }
    }

    static void DisplayStudentInfo(List<Student> students)
    {
        static void DisplayStudentInfo(List<Student> students)
        {
            Console.WriteLine("Enter Student ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Student student = students.Find(s => s.ID == id);
                if (student != null)
                {
                    Console.WriteLine(
                        $"Student Name: {student.Name}, ID: {student.ID}, Grades: {student.Grades}(), Average Grade: {student.CalculateAverageGrade()}");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a number.");
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public List<double> Grades { get; set; }

        public Student()
        {
            Grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            Grades.Add(grade);
        }

        public void AddGrade(double[] grades)
        {
            Grades.AddRange(grades);
        }

        public double CalculateAverageGrade()
        {
            if (Grades.Count == 0)
                return 0;
            
            double total = 0;
            foreach (var grade in Grades)
            {
                total += grade;
            }
            return total / Grades.Count;
        }
    }
}