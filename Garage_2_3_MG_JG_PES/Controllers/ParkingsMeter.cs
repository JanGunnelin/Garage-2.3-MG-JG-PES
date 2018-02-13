using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Garage_2_3_MG_JG_PES.Controllers
{
    public class ParkingsMeter
    {
        public DateTime EndTime { get; set; }
        public int MinutesRemaining
        {
            get
            {
                if (DateTime.Now >= EndTime)
                return 0;
                else
                return (EndTime - DateTime.Now).Minutes;
            }
        }
            public int ParkingIntervalMins
            {
                get
                {
                    return 1;
                }
            }
            public void Pay(int quarters)

            {
            Stopwatch s = Stopwatch.StartNew();
            s.Stop();

            EndTime = DateTime.Now.AddMinutes(quarters * ParkingIntervalMins);
            }
        }
}