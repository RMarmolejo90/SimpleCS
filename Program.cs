using System;
using System.Security.Cryptography.X509Certificates;

namespace SimpleCS
{
    public class Main
    {
        static bool IsClockedIn { get; set; } = false;

        public setClockStatus()
        {
            IsClockedIn == true ? IsClockedIn = false : IsClockedIn = true;
            Console.WriteLine(IsClockedIn);
        }



        public class Shift
        {
            public string Date { get; set; };

            public bool Overtime { get; set; };

            public ClockIn
            {
                public string StartTime = DateTime.Now.ToString();
                IsClockedIn = true;
            }
            
            public ClockOut()
            {
                IsClockedIn = false
            }
    }
}