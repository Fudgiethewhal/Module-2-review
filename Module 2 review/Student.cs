namespace Module_2_review;

public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public List<double> Grades { get; set; }

    public Student(int id, string name)
    {
        ID = id;
        Name = name;
        Grades = new List<double>();
    }

    public void AddGrade(double grade)
    {
        Grades.Add(grade);
    }

    public void AddGrad(double grade)
    {
        Grades.Add(grade);
    }
}
 