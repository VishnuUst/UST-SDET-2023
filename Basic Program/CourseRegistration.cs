using System;
using System.Threading;
using System.Collections.Generic;

class CourseRegistration
{
    private List<string> registeredStudents = new List<string>();

    public void RegisterStudent(string studentName)
    {
        Thread.Sleep(100); // Simulate the time it takes to register a student
        lock (registeredStudents)
        {
            registeredStudents.Add(studentName);
            Console.WriteLine($"{studentName} has registered for the course.");
        }
    }

    public int GetRegisteredStudentCount()
    {
        lock (registeredStudents)
        {
            return registeredStudents.Count;
        }
    }
}