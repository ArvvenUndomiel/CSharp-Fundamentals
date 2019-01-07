using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
                    //1. Initially read the number of log lines to be read
            var n = int.Parse(Console.ReadLine());

                    //2. Create a list to store the input and a dictionary to keep the results
            List<string> inputs = new List<string>();
            var Logs = new SortedDictionary<string, SortedDictionary<string, int>>();

                    //3. Add each line from the console to the list
            for (int i = 0; i < n; i++)
            {
                var entry = Console.ReadLine();
                inputs.Add(entry);
            }
   
            foreach (var input in inputs)
            {
                        //4. Split each line from the list to its elements
                var elements = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string userName = elements[1];
                string IPnumber = elements[0];
                int duration = int.Parse(elements[2]);

                        //5.1 If user is new, add him to the dictionary as key
                if (!Logs.ContainsKey(userName))
                {
                    var dict = new SortedDictionary<string, int>();
                    dict.Add(IPnumber, duration);
                    Logs[userName] = dict;
                }
                else    //5.2 If user is not new, add the new IP to the values
                {
                        //5.3 currentLogs holds the nested Dictionary
                    var currentLogs = Logs[userName];

                        //5.4 If the nested dictionary does not have the same IP, add it as key + duration as value
                    if (!currentLogs.ContainsKey(IPnumber))
                    {
                        currentLogs.Add(IPnumber, duration);
                    }
                    else 
                    {
                        //5.5 If there is already the same IP, add only the new duration
                        var ping = currentLogs[IPnumber];
                        ping += duration;
                        currentLogs[IPnumber] = ping;
                    }

                    Logs[userName] = currentLogs;
                }
            }
                        
            foreach (var log in Logs)
            {
                        //6.1 Calculate sum of durations for each user
                int totalDuration = log.Value.Sum(x => x.Value);

                        //6.2 Print
                Console.WriteLine($"{log.Key}: {totalDuration} [{string.Join(", ", log.Value.Select(y => y.Key).ToArray())}]");

            }
        }
    }
}
