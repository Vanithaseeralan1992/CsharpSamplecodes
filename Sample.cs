using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Codepracticewithcsharp
{
    class Arrays
    {
        //Arraylist
        public void arrays()
        {
            ArrayList myclass = new ArrayList();
            myclass.Add("Vanitha");
            myclass.Add("Thejasri");
            myclass.Add("1224567");
            myclass.Add(null);
            myclass.Add("Seeralan");
            myclass.Add(9874673);
            myclass.Add(null);
            myclass.Add(987434);
            myclass.RemoveAt(3);
            //myclass.RemoveRange(0, 2);
            for( int i=0;i<myclass.Count;i++)
            {
                Console.Write(myclass[i] + "\n");

            }
        }
        
    }
    class Hashtable
    {

    }
}
