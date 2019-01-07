using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12_Time_and_15_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 15;
            
            if (minutes > 59)
            {
                hour = hour + 1;
                if (hour == 24) hour = 0; 
                minutes = minutes - 60;
                if (minutes < 10) Console.WriteLine($"{hour}:0{minutes}");
                else Console.WriteLine($"{hour}:{minutes}");
            }
            else Console.WriteLine($"{hour}:{minutes}");

            //Console.WriteLine($"{hour}:{minutes:D2}");
            //Console.WriteLine($"{hour}:{minutes:00}");

            //2nd option
            //var totalTime = hours*60 + minutes + 15;
            //var resultHours = totalTime /60;
            //var resultMinutes = totalTime %60;
            
            //TimeSpan option
            //var inTime = new TimeSpan(hours, mins, 0);
            //var timeToAdd = new TimeSpan (0, 15, 0);
            //var resultTime = inTime+timeToAdd;
            //Console...
        }
    }
}
