using System;
using System.Collections;

namespace LookupTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable g = new Hashtable();
            g.Add("1", "first");
            g.Add("2", "second");
            g.Add("3", "third");
            g.Add("4", "fuorth");
            g.Add("5", "fifth");
            g.Add("6", "sixth");
            g.Add("7", "seventh");
            g.Add("8", "eighth");
            g.Add("9", "ninth");
            g.Add("0", "zero");

            string number = "888-555-2121";

            foreach(char c in number)
            {

                string digit = c.ToString();
                if (g.ContainsKey(digit))
                {
                    Console.WriteLine(g[digit]);
                }
            }
        }
    }
}
