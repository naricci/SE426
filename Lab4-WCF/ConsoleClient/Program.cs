using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService.OrderServiceClient client = new OrderService.OrderServiceClient();
            OrderService.Item[] items = client.GetItemListForOrder(1);
            OrderService.BillingInformation[] billinginfo = client.GetBillingAddressForAnOrder(1);

            Console.WriteLine(client.GetNumberOfOrders());
            Console.WriteLine("\n");

            Console.WriteLine(client.HowManyOrderedForAPartNum());
            Console.WriteLine("\n");

            Console.WriteLine("Billing Information for Order 1");

            Console.WriteLine("Name: " + billinginfo[0].Name);
            Console.WriteLine("Address: " + billinginfo[0].Address);
            Console.WriteLine("City: " + billinginfo[0].City);
            Console.WriteLine("State: " + billinginfo[0].State);
            Console.WriteLine("ZipCode: " + billinginfo[0].ZipCode);
            Console.WriteLine("\n");

            Console.WriteLine("Item: " + items[0].PartNo);
            Console.WriteLine("Description: " + items[0].Description);
            Console.WriteLine("Price: " + items[0].UnitPrice);
            Console.WriteLine("Qty: " + items[0].Quantity);
            Console.WriteLine("Total Price: " + items[0].TotalCost);
            Console.WriteLine("\n");

            

            Console.WriteLine(client.GetTotalCostForAnOrder());
            Console.WriteLine("\n");


            Console.WriteLine("Enter CR To Exit");
            Console.ReadLine();
        }
    }
}
