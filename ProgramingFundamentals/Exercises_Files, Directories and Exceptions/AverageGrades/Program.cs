using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(File.ReadLines("input2.txt").First());
            List<Student> students = new List<Student>();
            File.Delete("result2.txt");
            string[] input = File.ReadAllText("input2.txt")
                .Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for (int i = 1; i <= numberOfStudents; i++)
            {
                Student student = new Student();
                student.Grades = new List<double>();
                string[] currentInput =
                    input[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                student.Name = currentInput.First();
                for (int j = 1; j < currentInput.Length; j++)
                {
                    student.Grades.Add(double.Parse(currentInput[j]));
                }

                students.Add(student);
            }
            students.Where(x => x.AverageGrade >= 5)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.AverageGrade)
                .ToList()
                .ForEach(x => File.AppendAllText("result2.txt",$"{x.Name} -> {x.AverageGrade:f2} {Environment.NewLine}"));


        }
    }

    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade => Grades.Average();
    }
}

