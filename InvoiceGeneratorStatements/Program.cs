using System;
using InvoiceGeneratorStatements;
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("             ###############>>$$$$$>>WELCOME TO THE CAB INVOICE GENERATOR PROBLEM STATEMENTS<<$$$$$<<############         ");
        bool check=true;
        while (check)
        { 
            Console.WriteLine(" Enter the Zero (0) To Stop the Execution\n 1.Display Fare Of Cab \n 2. Display Fare Of Multiple Rides\n 3. Display Invoice Summary \n 4. Invoice Summary Given the User id\n ");
            Console.WriteLine("Enter the Above Option to perform the Specific Operation");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            { 
                case 1:
                    CabInvoiceGenerator generator = new CabInvoiceGenerator(RideType.NORMAL);
                    double result = generator.CalculatingFair(15, 5);
                    Console.WriteLine("Result is:->"+result);
                    break;
                case 0:
                    check=false;
                    break;
                case 2:
                    CabInvoiceGenerator invoice = new CabInvoiceGenerator(RideType.PREMIER);
                    Ride[] rides = { new Ride(15, 5), new Ride(25, 10), new Ride(20, 20) };
                    double result1 = invoice.CalaulateMultipleRides(rides);
                    Console.WriteLine("Result is:->"+result1);
                    break;
                case 3:
                    CabInvoiceGenerator cabInvoice = new CabInvoiceGenerator(RideType.NORMAL);
                    Ride[] rides1 = { new Ride(15, 10), new Ride(35, 35), new Ride(25, 15), new Ride(15, 15), new Ride(50, 60) };
                    InvoiceSummary results = cabInvoice.CalaulateMultipleRidesSummary(rides1);
                    Console.WriteLine("total Number of Rides:->" + results.totalNumberOfRides+"\n"+"Total Fare of Cab:-> "+results.totalFair+"\n"+"Average Fare Of Cab :-> "+results.averageFair);
                    break;
                case 4:
                    CabInvoiceGenerator invoiceSummary = new CabInvoiceGenerator(RideType.NORMAL);
                    Ride[] ride = { new Ride(15, 10), new Ride(35, 35), new Ride(25, 15), new Ride(15, 15), new Ride(50, 60) };
                    string userId = "1005abc";
                    invoiceSummary.MapUserId(userId, ride);
                   
                    InvoiceSummary summary = invoiceSummary.GetRideInvoiceSummary("1005abc");
                    Console.WriteLine("Total Number of Rides:->" + summary.totalNumberOfRides + "\n" + "Total Fare:->" + summary.totalFair + "\n" + "Average Fare:->" + summary.averageFair);
                    break;
                default: Console.WriteLine(" $$$$$$$$ Please Enter the Correct option Among the Above To Perform the Specific Operaton $$$$$$$$ ");break;
            }
        }        
    }
}