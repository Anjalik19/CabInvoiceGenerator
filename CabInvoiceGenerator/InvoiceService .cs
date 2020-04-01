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
        int normalCostPerMinute = 1;
        int normalCostPerKilometer = 10;
        int normalMinimumFare = 5;
        double totalFare = 0;
        int numberOfRides = 0;
        double total_Fare = 0;
        double averageFarePerRide = 0;
        int premiumRideCostPerMin =2;
        int premiumCostPerKilometer =15;
        int premiumMinimumFare =20;
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
        public double CalculateFare(string rideType,double distance, double time)
        {
            if (rideType == "Normal")
            {
                totalFare = distance * normalCostPerKilometer + time * normalCostPerMinute;
                if (totalFare > normalMinimumFare)
                {
                    return totalFare;
                }
                return normalMinimumFare;
            }
            totalFare = distance * premiumCostPerKilometer + time * premiumRideCostPerMin;
            if(totalFare>premiumMinimumFare)
            {
                return totalFare;
            }
            return premiumMinimumFare;
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
                total_Fare = total_Fare + CalculateFare(item.RideType,item.Distance, item.Time);
            }

            numberOfRides = ride.Length;
            averageFarePerRide = total_Fare / numberOfRides;
            return total_Fare;
        }
    }
}
