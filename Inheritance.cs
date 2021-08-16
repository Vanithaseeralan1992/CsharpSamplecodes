using System;
using System.Collections.Generic;
using System.Text;

namespace Codepracticewithcsharp
{    //inheritance concept
    public class ParentclassforGames
    {
        public void Start()
        {
            Console.WriteLine("Game started.....");
        }
        public void End()
        {
            Console.WriteLine("Game ended....");
        }
    }
    public class Childclassforgame1:ParentclassforGames
    {
    public void gameplay()
        {
            Console.WriteLine("Game1 started.....");
        }
    }
    public class Childclassforgame2:ParentclassforGames
    {
        public void gameplay()
        {
            Console.WriteLine("Game2 started....");
        }
    }
}
