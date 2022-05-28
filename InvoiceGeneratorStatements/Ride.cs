using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGeneratorStatements
{
    public class Ride
    {
        /// <summary>
        /// Declaring the intance Variable
        /// </summary>
        public double distance;
        public int time;
        /// <summary>
        /// Parameter Constructure for for initializing the intance Variable
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="time"></param>
        public Ride(double distance, int time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}
