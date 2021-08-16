using System;
using System.Collections.Generic;
using System.Text;

namespace Codepracticewithcsharp
{
    public class Nameofclass
    {
        string Firstname;
        string Lastname;
        public Nameofclass(string Firstname1, string Lastname1)
        {
            this.Firstname = Firstname1;
            this.Lastname = Lastname1;
            Console.WriteLine($"My full name is '{Firstname1}'  '{Lastname1}'");
        }
        public void getfullname()
        {
            Console.WriteLine($"My full name is {Firstname}  {Lastname}");
        }
    }

}
