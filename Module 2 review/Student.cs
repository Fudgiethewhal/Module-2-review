using System;
using System.Collections.Generic;
//added system.collections.generic due to having a list below
namespace Module_2_review;

public class Student
{
    //Properties
    public string Name { get; set; } 
    public int ID { get; set; }
    public List<double> Grades { get; set; }

    public Student() //Constructor
    {
        Grades = new List<double>();
    }

    public void AddGrad(double grade)
    {
        Grades.Add(grade);
    }

    public void AddGrade(params double[] grades)
    {
        Grades.AddRange(grades);
    }
}
 