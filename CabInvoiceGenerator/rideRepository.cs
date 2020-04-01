// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RideRepository.cs" company="Bridgelabz">
// <Copyright © 2020 Company="BridgeLabz".>
// </copyright>
// <creator name="Anjali"/>
// --------------------------------------------------------------------------------------------------------------------

namespace CabInvoiceGenerator
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    public class RideRepository
    {
        Dictionary<string, List<Ride>> userRide=null;

        public RideRepository()
        {
            this.userRide = new Dictionary<string, List<Ride>>();
        }
        public void AddRide(string userId, Ride[] rides)
        {
            bool rideList = this.userRide.ContainsKey(userId);
            if(rideList==false)
            {
                List<Ride> list = new List<Ride>();
                list.AddRange(rides);
                this.userRide.Add(userId, list);
            }
        }
        public Ride[] GetRides(string userId)
        {
            return this.userRide[userId].ToArray();
        }
    }
}
