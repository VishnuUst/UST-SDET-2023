using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class LinqExample
    {
        public void LinqExam()
        {
            List<string> courses = new List<string>();
            courses.Add("MCA");
            courses.Add("MTECH");
            courses.Add("Phd");
            courses.Add("MBA");
            /* var result = from course in courses 
                          where course.Equals("Phd") 
                          select course;*/
           // var result = courses.Where(course => course.Equals("MTECH"));
            var result = courses.Where(course => course.Contains("M"));

            Console.WriteLine("*--My Selected Course is--*");
            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
            

        }
        public void LinqExamTwo()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Vishnu", "MCA"));
            students.Add(new Student(2, "Gokul", "MBBS"));
            students.Add(new Student(3, "Shirin", "UKG"));
            students.Add(new Student(4, "Jachithra", "Mtech"));
            students.Add(new Student(5, "Vishnu", "Mtech"));
            Console.WriteLine("*--Student details BY ID--*");
            Console.WriteLine("StudentName\tDepartment");
            Student stud = (Student)students.Find(s => s.StudentId == 3);

            if (stud != null)
            {
                Console.WriteLine($"{stud.StudentName}\t\t{stud.Department}\n");

            }
            else
            {
                Console.WriteLine("The Student Id Is Not Found!!!");
            }
            Console.WriteLine("*--Student details By Name--*");
            Console.WriteLine("StudentName\tDepartment");
            List<Student> s = (List<Student>)students.FindAll(x => x.StudentName == "Vishnu" || x.StudentName=="Shirin");
            foreach(Student studs in s)
            {
                Console.WriteLine($"{studs.StudentName}\t\t{studs.Department}");
            }
        }

    }
}
