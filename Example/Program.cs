using System;
using System.Text;

namespace ExampleProj
{
   
    class Program
    {

        public static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hello World");

            for (int i = 0; i < 4; i++)
            {
                stringBuilder.Append(" nice to see you!");
            }
            string s = stringBuilder.ToString();
            System.Diagnostics.Debug.WriteLine(s);
        }
    }
}




