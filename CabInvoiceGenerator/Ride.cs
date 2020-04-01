// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Ride.cs" company="Bridgelabz">
// <Copyright © 2020 Company="BridgeLabz".>
// </copyright>
// <creator name="Anjali"/>
// --------------------------------------------------------------------------------------------------------------------

namespace CabInvoiceGenerator
{
    public class Ride
    {
        string rideType;
        double time;
        double distance;
        public Ride(string rideType,double distance,double time)
        {
            this.distance = distance;
            this.time = time;
            this.rideType = rideType;
        }

        public string RideType
        {
            get
            {
                return this.rideType;
            }
        }
        public double Time
        {
            get 
            {
                return this.time;
            }

        }
        public double Distance
        {
            get
            {
                return this.distance;
            }
        }
    }
}