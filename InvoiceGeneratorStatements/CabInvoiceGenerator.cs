using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGeneratorStatements
{
    public class CabInvoiceGenerator
    {
        RideType rideType;
        private readonly int MIN_FAIR;
        private readonly int FAIR_PR_KM;
        private readonly int FAIR_PR_MINUTE;
        public CabInvoiceGenerator(RideType rideType)
        {
            this.rideType = rideType;
            try
            {
                if (rideType.Equals(RideType.NORMAL))
                {
                    this.MIN_FAIR = 10;
                    this.FAIR_PR_KM = 15;
                    this.FAIR_PR_MINUTE = 5;
                }
                else if (rideType.Equals(RideType.PREMIER))
                {
                    this.MIN_FAIR = 5;
                    this.FAIR_PR_KM = 10;
                    this.FAIR_PR_MINUTE = 2;
                }
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_RIDE_TYPE, "Invalid Ride");
            }
        }
        public double CalculatingFair(int distance, int time)
        {
            double calculateFair = 0.0d;
            try
            {
                calculateFair = FAIR_PR_KM * distance + time * FAIR_PR_MINUTE;
            }
            catch (CabInvoiceException)
            {
                if (rideType.Equals(null))
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_RIDE_TYPE, "Invalid Ride");
                }
                if (distance == 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_DISTANCE, "Please Tell me Valid Distance");
                }
                if (time < 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_TIME, "Time is invalid");
                }
            }
            return Math.Max(calculateFair, MIN_FAIR);
        }
    }
}
