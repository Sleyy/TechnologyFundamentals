using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorGroup
{
    class Student
    {
        public List<DateTime> Date { get; set; }
        public List<string> Comment { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Student> students = new SortedDictionary<string, Student>();

            var dates = Console.ReadLine()
                .Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (dates[0] != "end")
            {
                Student currentStudent = new Student();
                currentStudent.Date = new List<DateTime>();
                currentStudent.Comment = new List<string>();
                var datesNumbers = dates.Skip(1).ToArray();

                if (!students.ContainsKey(dates[0]))
                {
                    students.Add(dates[0], currentStudent);

                    for (int i = 0; i < datesNumbers.Length; i++)
                    {
                        students[dates[0]].Date.Add(DateTime.ParseExact(datesNumbers[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }
                }
                else
                {
                    for (int i = 0; i < datesNumbers.Length; i++)
                    {
                        students[dates[0]].Date.Add(DateTime.ParseExact(datesNumbers[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }
                }
                dates = Console.ReadLine()
                    .Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            var comments = Console.ReadLine()
                .Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (comments[0] != "end of comments")
            {

                if (students.ContainsKey(comments[0]))
                {
                    students[comments[0]].Comment.Add(comments[1]);
                }

                comments = Console.ReadLine()
                    .Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key}");
                Console.WriteLine($"Comments:");
                foreach (var comment in student.Value.Comment)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine($"Dates attended:");
                foreach (var date in student.Value.Date.OrderBy(x=>x.Date))
                {
                    Console.WriteLine($"-- {date:dd/MM/yyyy}");
                }
            }

        }
    }
}
