using NUnit.Framework;
using CabInvoiceGenerator;
namespace Testing
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Given_distanceAndTime_shouldReturn_Fare()
        {
            InvoiceService invoiceService = new InvoiceService();
            double actual = invoiceService.CalculateFare(5, 10);
            double expected = 60;
            Assert.AreEqual(expected, actual);
        }
    }
}