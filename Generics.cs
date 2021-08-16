using System;
using System.Collections.Generic;
using System.Text;

namespace Codepracticewithcsharp
{
    //<T> is generic here and helps to use code reusablity and you can user any name<gneneric_name>
    public class Generics<T>
    {
        public bool compare(T a, T b)
        {
            if(a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
   
}
