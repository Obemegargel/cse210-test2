using System;
using System.Collections.Generic;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Bob");
            names.Add("Steve");
            names.Add("Joe");

            names.ForEach(name => Console.Write(name + " "));//for each loop

            string aString = "a";
            List<string> stuff = new List<string> {aString, "b", "c", "d"};

            char aSingleCharacterExample = 'a';//just for example
            Console.WriteLine($"This is a single character: {aSingleCharacterExample}");

            int x = 5;
            int y = 7;
            int result = Adder(x,y);//12

            int result2 = Adder(10, 46);//56

            Console.WriteLine($"Function result: {result} and result2: {result2}");
        }

        static int Adder(int a, int b)
        {
            return a + b;
        }
    }
}
