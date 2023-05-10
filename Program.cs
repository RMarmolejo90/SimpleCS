using System;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

namespace SimpleCS
{
    class Program
    {

        static void Main(string[] args)
        {
            Car myCar = new Car("GMC", "Canyon", 1993, "Silver");

            Console.WriteLine("{0} {1} {2} {3} {4}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color,
                myCar.GetCarValue());

            Console.ReadLine();

        }
    }


}