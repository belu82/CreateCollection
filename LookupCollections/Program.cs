using System;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;


namespace LookupCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ListDictionary lista = new ListDictionary(new CaseInsensitiveComparer(CultureInfo.InvariantCulture));
            lista.Add("Estados Unidos", "United States");
            lista.Add("Canadá", "Canada");
            lista.Add("España", "Spain");
            Console.WriteLine(lista["españa"]);
            Console.WriteLine(lista["CANADÁ"]);
            Console.Read();
        }
    }
}
