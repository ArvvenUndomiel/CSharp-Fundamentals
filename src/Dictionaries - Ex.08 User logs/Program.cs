using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_08_User_logs
{
    class Program
    {
        static void Main(string[] args)
        {
                    //Input format: IP=(IP.Address) message=(A&sample&message) user=(username)
                    //For every user, you have to display every IP from which the corresponding user has sent a message
                    //...and the count of the messages sent with the corresponding IP.

                    //1. Create a dictionary to keep the logs 

            SortedDictionary<string, List<string>> userLogs = new SortedDictionary<string, List<string>>();

                    //2.1 Add every line into the list
                    //2.2 until you reach "end"
            List<string> inputs = new List<string>();

            for (int i = 0; ; i++)
            {
                string entry = Console.ReadLine();

                if (entry == "end")
                {
                    break;
                }
                else
                {
                    inputs.Add(entry);
                }
            }

            
            foreach (var input in inputs)
            {   
                        //3. Split each element from the list and get the IP and userName

                var elements = input.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                var IPaddress = elements[0].Split(new string[] {"="}, StringSplitOptions.RemoveEmptyEntries);
                var IP = IPaddress[1];

                var user = elements[2].Split(new string[] {"="}, StringSplitOptions.RemoveEmptyEntries);
                var userName = user[1];

                        //4.1 If key not found => Add userNames and all IPs into dictionary
                        //4.2 If key already exists => add the new IPs to the rest of the values

                if (!userLogs.ContainsKey(userName))
                {
                    userLogs.Add(userName, new List<string>() { IP });
                }
                else
                {
                    List<string> currentUserIPs = userLogs[userName];
                    currentUserIPs.Add(IP);
                    userLogs[userName] = currentUserIPs;
                }
            }

                        //5.1 How to: Calculate number of messages from each IP
                        //5.2 Transfer the IPs for each user into a separate list
                        //5.3 Create a dictionary to keep the number of occurrences(value) for each IP (key)
                        //5.4 If key does not exist, start counting from 1
                        //5.5 If key already exists, add to count

            foreach (var kvp in userLogs)
            {
                List<string> userIPs = kvp.Value;
                
                Dictionary<string, int> IPcount = new Dictionary<string, int>();

                for (int i = 0; i < userIPs.Count; i++)
                {
                    if (!IPcount.ContainsKey(userIPs[i]))
                    {
                        IPcount[userIPs[i]] = 1;
                    }
                    else
                    {
                        var currentOccurences = IPcount[userIPs[i]];
                        IPcount[userIPs[i]] = currentOccurences + 1;
                    }
                }

                        //6.1 How to: Print the number of occurrences for each IP for each user
                        //6.2 Print the first line "{userName}:"
                        //6.3 Go through the dictionary of IPs and count
                        //..check if element is not last, add to string with ", "
                        //..check if element is last, add end with "."
                        //6.4 Finally print the whole output

                string output = null;
                int count = 1;

                Console.WriteLine(kvp.Key + ":");

                foreach (var kvp2 in IPcount)
                {
                    if (count == IPcount.Keys.Count)
                    {
                        output += $"{kvp2.Key} => {kvp2.Value}.";
                    }
                    else
                    {
                        output += $"{kvp2.Key} => {kvp2.Value}, ";
                    }

                    count += 1;
                }

                Console.WriteLine(output);
            }
            
        }
    }
}
