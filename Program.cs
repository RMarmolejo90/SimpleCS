using System;
using System.Collections;
using System.Collections.Specialized;

namespace SimpleCS
{
    class Program
    {

        static void Main(string[] args)
        {
            Car car1 = new Car("Geo", "Prism");

            Car car2 = new Car("Dodge", "Challenger");

            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);   

            foreach (Car car in myList ) { Console.WriteLine(car.Model); }

            Console.ReadLine();

        }

    }


}