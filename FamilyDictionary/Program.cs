using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister1", new Dictionary<string, string>() { { "name", "Beth" }, { "age", "58" } });
            myFamily.Add("brotherThatLivesWithMom", new Dictionary<string, string>() { { "name", "Nick" }, { "age", "60" } });
            myFamily.Add("brother2", new Dictionary<string, string>() { { "name", "Keith" }, { "age", "57" } });
            myFamily.Add("psychoSister", new Dictionary<string, string>() { { "name", "Susan" }, { "age", "44" } });

            foreach (var (relationship, properties) in myFamily)
            {
                
                Console.WriteLine($"{properties["name"]} is my {relationship} and they are {properties["age"]}");
            }
        }
    }
}
