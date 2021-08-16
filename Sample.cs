using System;
using System.Linq;

namespace samples
{
    
        static void Main(string[] args)

	{
        int a1 = 5;
        int b1 = 6, k1 = 10;
        if (a1 + b1 > k1)
            Console.WriteLine($"The answer {a1 + b1} is greater than {k1}.");
        var x1 = Console.ReadLine();
        Console.WriteLine($"The value of x is:{x1}");
        var y1 = Console.ReadLine();
        Console.WriteLine($"The value of y is:{y1}");
        int a = 5;
        int b = 3;
        int c = 4;int x = 5;
        int y = 3;
        if (x + y > 10)
        {
            Console.WriteLine("The answer is greater than 10");
        }
        else
        {
            Console.WriteLine("The answer is not greater than 10");
        }
        if ((a + b + c > 10) && (a == b))
        {
            Console.WriteLine("The answer is greater than 10");
            Console.WriteLine("And the first number is equal to the second");
        }
        else
        {
            Console.WriteLine("The answer is not greater than 10");
            Console.WriteLine("Or the first number is not equal to the second");
        }
        int k = 5;
        int l = 3;
        int m = 4;
        if ((k + l + m > 10) || (a == b))
        {
            Console.WriteLine("The answer is greater than 10");
            Console.WriteLine("Or the first number is equal to the second");
        }
        else
        {
            Console.WriteLine("The answer is not greater than 10");
            Console.WriteLine("And the first number is not equal to the second");
        }
        int counter = 0;
        while (counter < 10)
        {
            Console.WriteLine($"Hello World! The counter is {counter}");
            counter++;
        }

        int counter1 = 0;
        do
        {
            Console.WriteLine($"Hello World! The counter is {counter1}");
            counter1++;
        } while (counter1 < 10);

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Hello World! The counter is {i}");
        }
        //For looops 
        for (int row = 1; row < 11; row++)
        {
            Console.WriteLine($"The row is {row}");
        }
        for (char column = 'a'; column < 'k'; column++)
        {
            Console.WriteLine($"The column is {column}");
        }

        for (int row = 1; row < 11; row++)
        {
            for (char column = 'a'; column < 'k'; column++)
            {
                Console.WriteLine($"The cell is ({row}, {column})");
            }
        }
        int sum = 0;
        for (int number = 1; number < 21; number++)
        {
            if (number % 3 == 0)
            {
                sum = sum + number;
            }
        }
        Console.WriteLine($"The sum is {sum}");

    }
}
