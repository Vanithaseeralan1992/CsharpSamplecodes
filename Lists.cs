﻿using System;

using System.Linq;

namespace Lists
{

    static void Main(string[] args)

    {
        var names = new List<string> { "vanitha", "Ana", "Felipe", "applie", "banna", "theju" };

        foreach (var name in names)
        {
            Console.WriteLine($"Hello {name.ToUpper()}!");
            Console.WriteLine($"lowercase is:{name.ToLower()} and {'\n'} {name.Length}");
        }


    }
}