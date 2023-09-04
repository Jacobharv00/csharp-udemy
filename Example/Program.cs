using System;

namespace ExampleProj
{
   
    class Program
    {
        public static void Main(string[] args)
        {
            Type sType = typeof(string);
            System.Diagnostics.Debug.WriteLine(sType.FullName);
        }
    }
}

