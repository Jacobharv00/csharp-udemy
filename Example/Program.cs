using System;

namespace ExampleProj
{
   
    class Program
    {
        public static void Main(string[] args)
        {
            string s1 = "HEY";
            string s2 = "There";
            string s3 = s1 + " " + s2;
            s3 = "!";
            System.Diagnostics.Debug.WriteLine(s3);
        }
    }
}

