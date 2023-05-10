using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SimpleCS
{
    public class Car
    {
        public string Make { get; set; }    
        public string Model { get; set; }  
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal GetCarValue()
        {
            decimal Value;

            if (Year > 1990)
            {
                return Value = 22454.55m;
            }
            else
            {
                return Value = 10345.09m;
            }
            
        }

        public Car()
        {
            Make = String.Empty;
        }
        public Car(string make)
        {
            Make = make;
        }
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;

        }
    }
}
