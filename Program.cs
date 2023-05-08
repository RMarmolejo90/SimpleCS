using System;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

namespace SimpleCS
{
    class Program
    {

        static void Main(string[] args)
        {
            ConcatMessage("Hello I am very serious right now");
        }

        private static void ConcatMessage(string message)
        {
            Console.WriteLine(message + " ..and this is for reals");
            Console.ReadLine();
        }

    }


}