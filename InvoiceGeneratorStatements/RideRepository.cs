using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGeneratorStatements
{
    public class RideRepository
    {
        /// <summary>
        /// Declare the Dictionary
        /// </summary>
        Dictionary<string, List<Ride>> rideDict = null;
        /// <summary>
        /// Using Constructore to intialize the Dictionary
        /// </summary>
        public RideRepository()
        {
            this.rideDict = new Dictionary<string, List<Ride>>();
        }
        /// <summary>
        /// in the Dictionary adding the UserId and Number of rides
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="rides"></param>
        public void AddRides(string userId, Ride[] rides)
        {
            bool check = rideDict.ContainsKey(userId);
            try
            {
                if (!check)
                {
                    List<Ride> list = new List<Ride>();
                    list.AddRange(rides);
                    rideDict.Add(userId, list);
                }
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.NULL_RIDES, "Rides are Null");
            }
        }
        /// <summary>
        /// this method is to Get A ride  list as An Array to speciedfied UserId
        /// </summary>
        /// <returns userId="UserId"></returns>
        public Ride[] GetRide(string userId)
        {
            try
            {
                return this.rideDict[userId].ToArray();
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_USER_ID, "User iad is Invalid");
            }
        }
    }
}
