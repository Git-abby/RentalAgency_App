using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_STP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of vehicles
            Vehicle car = new Car("Accord", "Honda", 2022, 60, 5, "Gasoline", "CVT", true);
            Vehicle truck = new Truck("Silverado", "Chevrolet", 2021, 120, 6, "Pickup", false);
            Vehicle motorcycle = new Motorcycle("CBR600RR", "Honda", 2023, 70, 600, "Gasoline", false);



            // Display details of vehicles
            Console.WriteLine("***** Vehicle Details *****\n");
            Console.WriteLine("---Car---");
            car.DisplayDetails();

            Console.WriteLine("\n---Truck---");
            truck.DisplayDetails();

            Console.WriteLine("\n---Motorcycle---");
            motorcycle.DisplayDetails();

            // Create an instance of RentalAgency
            RentalAgency agency = new RentalAgency(3);

            // Add vehicles to the fleet
            agency.AddVehicle(car, 0);
            agency.AddVehicle(truck, 1);
            agency.AddVehicle(motorcycle, 2);

            // Rent a vehicle
            agency.RentVehicle(car);

            // Display total revenue
            Console.WriteLine($"\nTotal Revenue: {agency.TotalRevenue:C}");


        }
    }
}
