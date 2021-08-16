using System;
using System.Linq;

namespace samples
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);
            //Replace, Toupper and tolower case methods
            string myname = "vanithaseeralan";
            Console.WriteLine(myname.Replace("seeralan", ""));
            Console.WriteLine($"{myname.LongCount()} and {myname.Length}");

            Console.WriteLine(myname.ToUpper());
            Console.WriteLine(myname.ToLower());
            //Contains method
            string check, songLyrics = "Check this lyrics contains letters that want to check in boolean format";
            check = "want to check this text has any word for testing";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));
            Console.WriteLine(check.Contains("testing"));
            Console.WriteLine(check.Contains("wanted"));
            Console.WriteLine(check.StartsWith("want"));
            Console.WriteLine(check.EndsWith("testing"));
            //Numbers and its calculations
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
            int what = max + 3;
            int what1 = min + 3;
            Console.WriteLine($"An example of overflow: {what} and {what1}");
            double max1 = double.MaxValue;
            double min1 = double.MinValue;
            Console.WriteLine($"The range of double is {min1} to {max1}");

            decimal min2 = decimal.MinValue;
            decimal max2 = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min2} to {max2}");
            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);


        }
    }
}
