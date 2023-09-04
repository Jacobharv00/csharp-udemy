using System;
using System.Text;

namespace ExampleProj
{
   
    class Program
    {

        public static void Main(string[] args)
        {
            StringBuilder sB = new StringBuilder("This is a new string");
          
            sB.Replace(" ", "_");

            System.Diagnostics.Debug.WriteLine(sB);
        }
    }
}




