// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of vehicles
        Vehicle car = new Car("Model S", "Tesla", 2022, 100.00, 4, "Electric", "Automatic", true);
        Vehicle truck = new Truck("F-150", "Ford", 2020, 150.00, 1000, "Pickup", true);
        Vehicle motorcycle = new Motorcycle("Ninja 300", "Kawasaki", 2021, 50.00, 300, "Gasoline", true);

        // Displaying vehicle details
        car.DisplayDetails();
        truck.DisplayDetails();
        motorcycle.DisplayDetails();

        // Demonstrating RentalAgency functionality
        RentalAgency agency = new RentalAgency(3);
        agency.AddVehicle(car, 0);
        agency.AddVehicle(truck, 1);
        agency.AddVehicle(motorcycle, 2);

        agency.RentVehicle(0); // Renting the car
        Console.WriteLine($"Total revenue: {agency.TotalRevenue}");

        // Trying to rent the car again
        agency.RentVehicle(0); // Should display "No vehicle available at this index."

        // Removing truck from fleet
        agency.RemoveVehicle(1);
    }
}

