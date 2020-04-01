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
        int costPerKilometer = 10;
        int minimumFare = 5;
        double totalFare = 0;
        int numberOfRides = 0;
        double total_Fare = 0;
        double averageFarePerRide = 0;

        public int NumberOfRides
        {
            get
            {
               return this.numberOfRides;
            }
        }

        public double AverageFarePerRide
        {
            get
            {
                return this.averageFarePerRide;
            }
        }
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
            foreach (var item in ride)
            {
                total_Fare = total_Fare + CalculateFare(item.Distance, item.Time);
            }

            numberOfRides = ride.Length;
            averageFarePerRide = total_Fare / numberOfRides;
            return total_Fare;
        }
    }
}
