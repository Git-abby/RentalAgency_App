using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_STP
{
    internal class RentalAgency
    {
        // Array to store instances of vehicles
        private Vehicle[] Fleet { get; set; }
        // Property to track the total revenue earned by the rental agency
        public double TotalRevenue { get; private set; }

        // Constructor
        public RentalAgency(int capacity)
        {
            Fleet = new Vehicle[capacity];
            TotalRevenue = 0;
        }

        // Method to add vehicles to the fleet
        public void AddVehicle(Vehicle vehicle, int index)
        {
            Fleet[index] = vehicle;
        }
        // Method to remove vehicles from the fleet
        public void RemoveVehicle(int index)
        {
            Fleet[index] = null;
        }
        // Method to rent vehicles
        public void RentVehicle(Vehicle vehicle)
        {
            for (int i = 0; i < Fleet.Length; i++)
            {
                if (Fleet[i] != null && Fleet[i].GetType() == vehicle.GetType() && Fleet[i].Model == vehicle.Model)
                {
                    Fleet[i] = null;
                    TotalRevenue += Convert.ToDouble(vehicle.RentalPrice);
                    break;
                }
            }
        }


    }
}
