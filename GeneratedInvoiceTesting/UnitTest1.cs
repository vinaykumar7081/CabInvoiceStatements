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
    }
}