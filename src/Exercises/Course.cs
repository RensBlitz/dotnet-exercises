namespace Exercises;
using System.Collections.Generic;

public class Course
{
    private readonly string title;
    private readonly List<string> students = new();

    public Course(string title)
    {
        // TODO
        throw new NotImplementedException();
    }
    public bool Enrol(string student)
    {
        // TODO
        throw new NotImplementedException();
    }
    public bool Drop(string student)
    {
        // TODO
        throw new NotImplementedException();
    }
    public int GetEnrolmentCount() => students.Count;
} 