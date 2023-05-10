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

            Car jeep = new Car("Jeep");
            Car vehicle = new Car();
            Console.WriteLine(jeep.Make);
            Console.WriteLine(vehicle.Make);
            Console.ReadLine();

            Console.ReadLine();

        }
    }


}