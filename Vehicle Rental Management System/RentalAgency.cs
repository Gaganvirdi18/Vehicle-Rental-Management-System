// RentalAgency.cs
using System;

public class RentalAgency
{
    private Vehicle[] Fleet { get; set; }
    public double TotalRevenue { get; private set; }

    // Constructor
    public RentalAgency(int fleetSize)
    {
        Fleet = new Vehicle[fleetSize];
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

    // Method to rent a vehicle
    public void RentVehicle(int index)
    {
        if (Fleet[index] != null)
        {
            TotalRevenue += Fleet[index].RentalPrice;
            Fleet[index] = null;
            Console.WriteLine("Vehicle rented successfully.");
             
        }
        else
        {
            Console.WriteLine("No vehicle available at this index.");
        }
         Console.WriteLine("\n");
    }
}
