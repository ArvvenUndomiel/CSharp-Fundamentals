using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_23_Mentor_Group
{
    class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            string input = Console.ReadLine();

            while (input != "end of dates")
            {
                var userInfo = input.Split(' ', ',').ToArray();
                var name = userInfo[0];
                var dates = new List<DateTime>();

                for (int i = 1; i < userInfo.Length; i++)
                {
                    dates.Add(DateTime.ParseExact(userInfo[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }

                if (students.Any(x => x.Name.Equals(name)))
                {
                    Student existingUser = students.First(s => s.Name.Equals(name));
                    existingUser.Dates.AddRange(dates);
                }
                else
                {
                    Student user = new Student
                    {
                        Name = name,
                        Dates = dates,
                        Comments = new List<string>()
                    };

                    students.Add(user);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "end of comments")
            {
                var userInfo = input.Split('-').ToArray();
                var name = userInfo[0];
                var comment = userInfo[1];

                if (students.Any(s => s.Name.Equals(name)))
                {
                    Student existingUser = students.First(s => s.Name.Equals(name));
                    existingUser.Comments.Add(comment);
                }

                input = Console.ReadLine();
            }

            foreach (var student in students.OrderBy(s => s.Name))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");
                if (student.Comments != null)
                {
                    foreach (var comment in student.Comments)
                    {
                        Console.WriteLine($"- {comment}");
                    }
                }
                Console.WriteLine("Dates attended:");
                if (student.Dates != null)
                {
                    foreach (var date in student.Dates.OrderBy(x => x))
                    {
                        Console.WriteLine($"-- {date:dd/MM/yyyy}");
                    }
                }   
            }
        }
    }
}
