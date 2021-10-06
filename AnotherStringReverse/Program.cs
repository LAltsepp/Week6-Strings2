using System;

namespace AnotherStringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello World!" tagurpidi

            string helloW = "Hello, world!";
            for (int i = helloW.Length - 1; i >= 0; i--)
            {
                Console.Write(helloW[i]);
            }

            

        }
    }
}
