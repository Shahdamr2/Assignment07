using Assignment07.Entities;
using Assignment07.Inheritance;

namespace Assignment07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            // a) A class is a reference type while a struct is a value type
            // When a struct is copied a separate copy is created
            // When a class object is copied both variables refer to the same object

            // b) Classes are more suitable for large applications because they are
            // suitable for complex objects and relationships between objects

            #endregion
            #region Question 2

            // a) Shipment is the parent class

            // b) ExpressShipment is the child class

            // c) ExpressShipment inherits the TrackingCode property from Shipment
            // ExtraFee is a new property in ExpressShipment

            // d) Inheritance allows us to reuse the same properties and methods
            // without duplicating the code in multiple classes

            #endregion
            #region Question 3

            //DeliveryAddress address =
            //    new DeliveryAddress("Cairo", "Tahrir Street", 15);

            //Shipment shipment =
            //    new Shipment("SH-101", "Laptop", 3, 100, address);

            //shipment.PrintShipment();

            //Console.WriteLine();

            //shipment.UpdateDeliveryFee(120);

            //Console.WriteLine("After updating delivery fee:");

            //shipment.PrintShipment();

            #endregion
            #region Question 4

            // StandardShipment
            // ExpressShipment
            // InternationalShipment

            #endregion
            #region Question 5

            Console.Write("Enter Delivery Center Name: ");
            string centerName = Console.ReadLine() ?? "Unknown";

            DeliveryCenter center = new DeliveryCenter(centerName);


            Console.WriteLine();

            Console.Write("Enter Standard Tracking Code: ");
            string standardTrackingCode = Console.ReadLine() ?? "Unknown";

            Console.Write("Enter Standard Description: ");
            string standardDescription = Console.ReadLine() ?? "Unknown";

            Console.Write("Enter Standard Weight: ");
            decimal standardWeight = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Standard Delivery Fee: ");
            decimal standardDeliveryFee = decimal.Parse(Console.ReadLine() ?? "0");

            DeliveryAddress standardAddress =
                new DeliveryAddress("Unknown", "Unknown", 0);

            StandardShipment standardShipment =
                new StandardShipment(
                    standardTrackingCode,
                    standardDescription,
                    standardWeight,
                    standardDeliveryFee,
                    standardAddress);


            Console.WriteLine();

            Console.Write("Enter Express Tracking Code: ");
            string expressTrackingCode = Console.ReadLine() ?? "Unknown";

            Console.Write("Enter Express Description: ");
            string expressDescription = Console.ReadLine() ?? "Unknown";

            Console.Write("Enter Express Weight: ");
            decimal expressWeight = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Express Delivery Fee: ");
            decimal expressDeliveryFee = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Extra Fee: ");
            decimal extraFee = decimal.Parse(Console.ReadLine() ?? "0");

            DeliveryAddress expressAddress =
                new DeliveryAddress("Unknown", "Unknown", 0);

            ExpressShipment expressShipment =
                new ExpressShipment(
                    expressTrackingCode,
                    expressDescription,
                    expressWeight,
                    expressDeliveryFee,
                    expressAddress,
                    extraFee);


            Console.WriteLine();

            Console.Write("Enter International Tracking Code: ");
            string internationalTrackingCode = Console.ReadLine() ?? "Unknown";

            Console.Write("Enter International Description: ");
            string internationalDescription = Console.ReadLine() ?? "Unknown";

            Console.Write("Enter International Weight: ");
            decimal internationalWeight = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter International Delivery Fee: ");
            decimal internationalDeliveryFee = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Destination Country: ");
            string destinationCountry = Console.ReadLine() ?? "Unknown";

            Console.Write("Enter Customs Fee: ");
            decimal customsFee = decimal.Parse(Console.ReadLine() ?? "0");

            DeliveryAddress internationalAddress =
                new DeliveryAddress("Unknown", "Unknown", 0);

            InternationalShipment internationalShipment =
                new InternationalShipment(
                    internationalTrackingCode,
                    internationalDescription,
                    internationalWeight,
                    internationalDeliveryFee,
                    internationalAddress,
                    destinationCountry,
                    customsFee);


            if (center.AddShipment(standardShipment))
            {
                Console.WriteLine("Shipment Added Successfully.");
            }

            if (center.AddShipment(expressShipment))
            {
                Console.WriteLine("Shipment Added Successfully.");
            }

            if (center.AddShipment(internationalShipment))
            {
                Console.WriteLine("Shipment Added Successfully.");
            }


            Console.WriteLine();

            center.PrintAllShipments();


            Console.WriteLine();

            Console.WriteLine("Enter Tracking Code to Remove:");
            string removeCode = Console.ReadLine() ?? "";

            if (center.RemoveShipment(removeCode))
            {
                Console.WriteLine();
                Console.WriteLine("Shipment Removed Successfully.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Shipment not found.");
            }

            Console.WriteLine();

            Console.WriteLine("==========================================");
            Console.WriteLine("Remaining Shipments");
            Console.WriteLine("==========================================");

            for (int i = 0; i < 20; i++)
            {
                if (center[i] != null)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Tracking Code : {center[i].TrackingCode}");
                    Console.WriteLine("...");
                }
            }

            #endregion
        }
    }
}
