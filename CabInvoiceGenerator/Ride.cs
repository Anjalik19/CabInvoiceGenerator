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
        double time;
        double distance;
        public Ride(double distance,double time)
        {
            this.distance = distance;
            this.time = time;
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