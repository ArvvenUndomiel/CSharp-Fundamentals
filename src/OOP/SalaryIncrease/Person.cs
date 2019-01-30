using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public string FirstName => firstName;
        public string LastName => lastName;
        public int Age => age;
        public decimal Salary => salary;

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {salary:f2} leva.";
        }

        public void IncreaseSalary (decimal bonus)
        {
            if (this.Age > 30)
            {
                this.salary += this.salary * bonus / 100;
            }
            else
            {
                this.salary += this.salary * bonus / 200;
            }
        }
    }
}
