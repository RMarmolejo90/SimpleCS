using System;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

namespace SimpleCS
{
    class Program
    {

        static void Main(string[] args)
        {
            Person person = new Person("Bobert", 9889391);

            Console.WriteLine(person.Date);
            Console.ReadLine();
        }
    }


}