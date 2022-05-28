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
            Console.WriteLine(" Enter the Zero (0) To Stop the Execution\n 1.Display Fare Of Cab \n");
            Console.WriteLine("Enter the Above Option to perform the Specific Operation");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            { 
                case 1:
                    CabInvoiceGenerator generator = new CabInvoiceGenerator(RideType.NORMAL);
                    double result = generator.CalculatingFair(15, 5);
                    Console.WriteLine(result);
                    break;
                case 0:
                    check=false;
                    break;
                default: Console.WriteLine(" $$$$$$$$ Please Enter the Correct option Among the Above To Perform the Specific Operaton $$$$$$$$ ");break;
            }
        }        
    }
}