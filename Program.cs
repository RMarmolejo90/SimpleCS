using System;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

namespace SimpleCS
{
    class Program
    {

        static void Main(string[] args)
        {
            string message = "You know this is true...";
            Console.WriteLine(ConcatMessage(message));
            Console.ReadLine();
        }

        private static string ConcatMessage(string message)
        {
            return message += " and this is also FOR REALS";
                   
        }

    }


}