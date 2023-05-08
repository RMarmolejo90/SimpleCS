using System;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

namespace SimpleCS
{
    class Program
    {

        static void Main(string[] args)
        {
            Guid id = new Guid();
            Person person = new Person("Phil", id);

            Console.WriteLine(person);
            Console.ReadLine();
        }
    }


}