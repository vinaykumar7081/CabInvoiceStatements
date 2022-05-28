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
            Console.WriteLine(" Enter the Zero (0) To Stop the Execution\n 1.Display Fare Of Cab \n 2. Display Fare Of Multiple Rides");
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
                default: Console.WriteLine(" $$$$$$$$ Please Enter the Correct option Among the Above To Perform the Specific Operaton $$$$$$$$ ");break;
            }
        }        
    }
}