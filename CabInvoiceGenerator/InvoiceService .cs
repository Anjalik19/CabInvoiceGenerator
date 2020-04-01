// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InvoiceService.cs" company="Bridgelabz">
// <Copyright © 2020 Company="BridgeLabz".>
// </copyright>
// <creator name="Anjali"/>
// --------------------------------------------------------------------------------------------------------------------

namespace CabInvoiceGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// InvoiceService class
    /// </summary>
    public class InvoiceService
    {
        int costPerMinute = 1;
        double costPerKilometer = 10;
        double minimumFare = 5;
        double totalFare = 0;
        int totalNumberOfRides = 0;
        double Total_Fare = 0;
        double averageFarePerRide = 0;
        
        /// <summary>
        /// CalculateFare method
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public double CalculateFare(double distance, double time)
        {
            totalFare = distance * costPerKilometer + time * costPerMinute;
            if(totalFare>minimumFare)
            {
                return totalFare;
            }
            return minimumFare;

        }

        /// <summary>
        /// CalculateFare method
        /// </summary>
        /// <param name="ride"></param>
        /// <returns></returns>
        public double CalculateFare(Ride[] ride)
        {
            foreach(var item in ride)
            {
                totalFare = totalFare + CalculateFare(item.Distance, item.Time);
            }
            totalNumberOfRides = ride.Length;
            return totalFare;
        }


    }
}
