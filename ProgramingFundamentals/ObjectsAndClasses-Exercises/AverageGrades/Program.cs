using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < numberOfStudents; i++)
            {
                Student student = new Student();
                string[] input = Console.ReadLine()
                    .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                student.Name = input[0];
                student.Grades = input.Skip(1).Select(double.Parse).ToList();
                students.Add(student);
            }
            students.Where(x => x.AverageGrade >= 5)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.AverageGrade)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Name} -> {x.AverageGrade:f2}"));


        }
    }

    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade => Grades.Average();
    }
}
