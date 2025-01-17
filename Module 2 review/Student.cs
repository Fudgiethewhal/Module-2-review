using System;
using System.Collections.Generic;
//added system.collections.generic due to having a list below
namespace Module_2_review;

public class Student
{
    
    //Properties
    public string Name { get; set; } // A string property to store the name of the student.
    public int ID { get; set; } // An integer property to store the student's ID.
    public List<double> Grades { get; set; } //A list of doubles, initialized in the constructor, to store the student's grades.

    public Student() //Constructor
    {
        Grades = new List<double>();
    }

    public void AddGrade(double grade) //Adds a single grade to the Grades list.
    {
        Grades.Add(grade);
    }

    public void AddGrade(params double[] grades) //Adds multiple grades
    {
        Grades.AddRange(grades);
    }

    public double CalculateAverageGrade()
    {
        if (Grades.Count == 0)
        {
            return 0;
        }

        double total = 0;
        foreach (var grade in Grades)
        {
            total += grade;
        }
        return total / Grades.Count;
    }
}
 