using C_OOP02.Classes;
using C_OOP02.Struct;

namespace C_OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Theoretical Questions

            #region (Q1) Class vs Struct

            // (a)
            /* 
             * Struct :
             * 1) Value Type 
             * 2) stored in stack 
             * 3) new => Constructor selection  
             * 4) Copies value.
             * 5) Suitable for small and simple data.
             * 
             * Class :
             * 1) Reference type 
             * 2) stored in heap 
             * 3) new => Create object in heap  
             * 4) Copies reference.
             * 5) Suitable for larger and more complex objects.
             */

            // (b)
            /*
             * Classes are more suitable for large applications because they are
             * reference types,They also support important OOP features such as inheritance and
             * polymorphism, which make large applications easier to organize
             * and maintain.
             */

            #endregion

            #region (Q2) Inheritance

            // (a) Shipment is the parent class.

            // (b) ExpressShipment is the child class.

            // (c) TrackingCode is inherited by ExpressShipment.

            // (d) Inheritance avoids code duplication and allows us to reuse
            //     common code from the parent class.

            #endregion

            #endregion

            #region Practical Questions

            Console.WriteLine("Enter Delivery center name : ");
            string? CenterName=Console.ReadLine();
            DeliveryCenter Center= new DeliveryCenter(CenterName);

            ReadShipmentData(
                out string? trackingCode,
                out string? description,
                out decimal weight,
                out decimal deliveryFee,
                out DeliveryAddress destination
);

            StandardShipment standard = new StandardShipment(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination
            );


            
           

            Console.WriteLine("==========================================================");

            ReadShipmentData(
                 out trackingCode,
                 out description,
                 out weight,
                 out deliveryFee,
                 out destination
);

            Console.WriteLine("Enter Extra Fee:");
            decimal extraFee = decimal.Parse(Console.ReadLine());

            ExpressShipment express = new ExpressShipment(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination,
                extraFee
                
            );

            


            Console.WriteLine("==========================================================");

            ReadShipmentData(
              out trackingCode,
              out description,
              out weight,
              out deliveryFee,
              out destination
            );

            Console.WriteLine("Enter Destination Country:");
            string? destinationCountry = Console.ReadLine();

            Console.WriteLine("Enter Customs Fee:");
            decimal customsFee = decimal.Parse(Console.ReadLine());

            InternationalShipment international = new InternationalShipment(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination,
                destinationCountry,
                customsFee
            );

            Center.AddShipment(standard);
            Center.AddShipment(express);
            Center.AddShipment(international);

            Console.WriteLine("==========================================================");
            Console.WriteLine($"Delivery Center : {CenterName}");
            Console.WriteLine("==========================================================");

            Center.PrintAllShipments();

            Console.WriteLine("Enter tracking code to search:");
            string? searchCode = Console.ReadLine();

            Shipment? shipment = Center[searchCode];

            if (shipment != null)
            {
                shipment.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }

            Console.WriteLine("Enter Tracking Code to Remove:");
            string? removeCode = Console.ReadLine();

            if (Center.RemoveShipment(removeCode))
            {
                Console.WriteLine("Shipment removed successfully.");
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }

            Console.WriteLine("==========================================================");
            Console.WriteLine("Remaining Shipments");
            Console.WriteLine("==========================================================");

            Center.PrintAllShipments();
            #endregion

        }
        /// <summary>
        /// Reads the common shipment data from the user.
        /// </summary>
        /// <param name="trackingCode">The tracking code of the shipment.</param>
        /// <param name="description">The description of the shipment.</param>
        /// <param name="weight">The weight of the shipment.</param>
        /// <param name="deliveryFee">The delivery fee of the shipment.</param>
        /// <param name="destination">The delivery address of the shipment.</param>
        public static void ReadShipmentData(
           out string? trackingCode,
           out string? description,
           out decimal weight,
           out decimal deliveryFee,
           out DeliveryAddress destination)
        {
            Console.WriteLine("Enter tracking code:");
            trackingCode = Console.ReadLine();

            Console.WriteLine("Enter description:");
            description = Console.ReadLine();

            Console.WriteLine("Enter weight:");
            weight = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter delivery fee:");
            deliveryFee = decimal.Parse(Console.ReadLine());

            

            Console.WriteLine("Enter City:");
            string? city = Console.ReadLine();

            Console.WriteLine("Enter street:");
            string? street = Console.ReadLine();

            bool flag = false;
            int buildingNumber;

            do
            {
                Console.WriteLine("Enter building number:");
                flag = int.TryParse(Console.ReadLine(), out buildingNumber);

            } while (!flag);

            destination = new DeliveryAddress(city, street, buildingNumber);
        }

    }
}

