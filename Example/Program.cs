using System.Diagnostics;

namespace ExampleProj
{
   
    class Program
    {

        public static void Main(string[] args)
        {
            Debug.WriteLine(DateTime.Now.ToUniversalTime().ToString("MM/dd/yyyy hh:mm tt"));
        }
    }
}




