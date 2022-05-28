using InvoiceGeneratorStatements;
using NUnit.Framework;

namespace GeneratedInvoiceTesting
{
    public class Tests
    {
        [Test]
        public void InputInInteger_ShouldReturn_TotalFair()
        {
            CabInvoiceGenerator invoice = new CabInvoiceGenerator(RideType.NORMAL);
            double result = invoice.CalculatingFair(15, 5);
            Assert.AreEqual(result, 250);
        }
        [Test]
        public void InputInInteger_ShouldReturn_MultipleRides_TotalFair()
        {
            CabInvoiceGenerator invoice = new CabInvoiceGenerator(RideType.PREMIER);
            Ride[] rides = { new Ride(2, 3), new Ride(4, 5), new Ride(5, 6) };
            double result = invoice.CalaulateMultipleRides(rides);
            Assert.AreEqual(result, 46);
        }
        [Test]
        public void InputInInteger_ShouldReturn_MultipleRides_TotalFair_InvoiceSummary()
        {
            CabInvoiceGenerator invoice = new CabInvoiceGenerator(RideType.NORMAL);
            Ride[] rides1 = { new Ride(15, 10), new Ride(35, 35), new Ride(25, 15) };
            InvoiceSummary result = invoice.CalaulateMultipleRidesSummary(rides1);
            Assert.AreEqual(result.totalNumberOfRides, 3);
        }
    }
}