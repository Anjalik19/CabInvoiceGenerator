// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitTest.cs" company="Bridgelabz">
// <Copyright © 2020 Company="BridgeLabz".>
// </copyright>
// <creator name="Anjali"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Testing
{
    using NUnit.Framework;
    using CabInvoiceGenerator;
    using System;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Given time and distance return total fair
        /// TestCase1
        /// </summary>
        [Test]
        public void Given_DistanceAndTime_ShouldReturn_TotalFare()
        {
            InvoiceService invoiceService = new InvoiceService();
            double actual = invoiceService.CalculateFare(5, 10);
            double expected = 60;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Multiple rides return total fare
        /// TestCase2
        /// </summary>
        [Test]
        public void Given_MultipleRides_ShouldReturn_TotalFare()
        {
            InvoiceService invoiceService = new InvoiceService();
            Ride[] ride =
            {
                new Ride(5,10),
                new Ride(10, 20)
            };
            double actual = invoiceService.CalculateFare(ride);
            double expected = 180;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenInvoiceGenerator_ShouldReturn_TotalRides_TotalFare_AverageFare()
        {
            InvoiceService invoiceService = new InvoiceService();
            Ride[] ride =
            {
                new Ride(20,10),
                new Ride(15,5),
                new Ride(10,3)
            };
            double Total_Fare = invoiceService.CalculateFare(ride);
            double AverageFarePerRide =Math.Round(invoiceService.AverageFarePerRide);
            int totalNumberOfRides = invoiceService.NumberOfRides; 
            Assert.AreEqual(156, AverageFarePerRide);
            Assert.AreEqual(468, Total_Fare);
            Assert.AreEqual(3, totalNumberOfRides);
        }
    }

}