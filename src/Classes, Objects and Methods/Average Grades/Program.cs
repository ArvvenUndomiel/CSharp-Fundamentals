using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_19_Average_Grades
{
    class Student
    {
        public Student(string name, List<double> grades)
        {
            Name = name;
            Grades = grades;
        }

        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double AverageGrade
        {
            get
            {
               return Grades.Average();
            }
        }

        public static Student Parse (string input)
        {
            var args = input.Split(' ');
            var name = args[0];
            var grades = args.Skip(1).Select(double.Parse).ToList();

            Student result = new Student(name, grades);
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                students.Add(Student.Parse(input));
            }

            List<Student> filteredStudents = FilterStudents(students);
            var orderedStudents = filteredStudents.OrderBy(s => s.Name).ThenByDescending(s => s.AverageGrade).ToList();

            foreach (var student in orderedStudents)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }

        public static List<Student> FilterStudents(List<Student> students)
        {
            var result = new List<Student>();

            foreach (var student in students)
            {
                if (student.AverageGrade >= 5)
                {
                    result.Add(student);
                }
            }

            return result;
        }
    }
}
