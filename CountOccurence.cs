using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CountOccurence
    {
        static void Main(string[] args)
        {

            Dictionary<char,int> myDict = new Dictionary<char,int>();

            string name = Console.ReadLine();

            for (int i = 0; i<name.Length; i++)
            {
                if (myDict.ContainsKey(name[i]))
                {
                    myDict[name[i]] += 1;
                }
                else
                {
                    myDict.Add(name[i], 1);
                }
               
            }



            for (int i = 0; i < myDict.Count; i++)
            {
                Console.WriteLine("Letter: {0}, Value: {1}",
                                                        myDict.ElementAt(i).Key,
                                                        myDict.ElementAt(i).Value);
            }
            Console.ReadLine();
        }
    }
}
