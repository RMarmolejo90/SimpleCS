using System;
using System.Security.Cryptography.X509Certificates;

namespace SimpleCS
{
    public class Shift
    {
        public Shift shift = new Shift();

        public bool Overtime { get; set; }

        public static bool IsClockedIn { get; set; } = false;


        public void SetClockStatus()
        {
            IsClockedIn = !IsClockedIn;
            
        }
        public void ClockIn()
        {
            DateTime StartTime;
            SetClockStatus();
        }

        public void ClockOut()
        {
            SetClockStatus();
        }

        Console.WriteLine(IsClockedIn);
        Console.WriteLine(StartTime);
    }

}