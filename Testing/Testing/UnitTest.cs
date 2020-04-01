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
        /// TestCase1
        /// Given time and distance return total fair
        /// </summary>
        [Test]
        public void Given_DistanceAndTime_ShouldReturn_TotalFare()
        {
            InvoiceService invoiceService = new InvoiceService();
            double actual = invoiceService.CalculateFare("Normal",5, 10);
            double expected = 60;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase2
        /// Multiple rides return total fare
        /// </summary>
        [Test]
        public void Given_MultipleRides_ShouldReturn_TotalFare()
        {
            InvoiceService invoiceService = new InvoiceService();
            Ride[] ride =
            {
                new Ride("Normal",5,10),
                new Ride("Normal",10, 20)
            };
            double actual = invoiceService.CalculateFare(ride);
            double expected = 180;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase3
        /// Invoice generator should return total rides,Total fare and Average Fare
        /// </summary>
        [Test]
        public void GivenInvoiceGenerator_ShouldReturn_TotalRides_TotalFare_AverageFare()
        {
            InvoiceService invoiceService = new InvoiceService();
            Ride[] ride =
            {
                new Ride("Normal",20,10),
                new Ride("Normal",15,5),
                new Ride("Normal",10,3)
            };
            double Total_Fare = invoiceService.CalculateFare(ride);
            double AverageFarePerRide = Math.Round(invoiceService.AverageFarePerRide);
            int totalNumberOfRides = invoiceService.NumberOfRides;
            Assert.AreEqual(156, AverageFarePerRide);
            Assert.AreEqual(468, Total_Fare);
            Assert.AreEqual(3, totalNumberOfRides);
        }

        /// <summary>
        /// TestCase4
        /// Invoice service gets list of records from rideRepository
        /// </summary>
        [Test]
        public void GivenInvoiceService_GetsListOfRecords_FromRideRepository()
        {
            string userId = "Anjali@gmail.com";
            InvoiceService invoiceService = new InvoiceService();
            Ride[] ride =
                {
                new Ride("Normal",20,10),
                new Ride("Normal",15,5),
                new Ride("Normal",10,3)
            };
            RideRepository rideRepository = new RideRepository();
            rideRepository.AddRide(userId, ride);
            double totalFare = invoiceService.CalculateFare(rideRepository.GetRides(userId));
            Assert.AreEqual(468, totalFare);
        }

        /// <summary>
        /// TestCase5
        /// Invoic service return premium and normal rides
        /// </summary>
        [Test]
        public void GivenInvoiceService_ReturnPremiumAndNormalRides()
        {
            string userId = "Anjali@gmail.com";
            InvoiceService invoiceService = new InvoiceService();
            Ride[] ride =
                {
                new Ride("Normal",15,5),
                new Ride("Normal",10,3),
                new Ride("Premium",20,10),
                new Ride("Premium",15,20)
            };
            RideRepository rideRepository = new RideRepository();
            rideRepository.AddRide(userId, ride);
            double totalFare = invoiceService.CalculateFare(rideRepository.GetRides(userId));
            Assert.AreEqual(843, totalFare);
        }
    }
}