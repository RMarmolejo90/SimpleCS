using System;
using System.Security.Cryptography.X509Certificates;

namespace SimpleCS
{
    
   

    public class Shift
    {
        public bool Overtime { get; set; }

        public static bool IsClockedIn { get; set; } = false;


        public static void SetClockStatus()
        {
                IsClockedIn = !IsClockedIn;
                Console.WriteLine(IsClockedIn);            
        }
        public static void ClockIn()
        {
            string startTime = DateTime.Now.ToString();
            SetClockStatus();
        }
            
        public static void ClockOut()
        {
            SetClockStatus();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shift shift = new Shift();
            Shift.ClockIn();
        }
    }
}