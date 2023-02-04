using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing;

public class StartUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            string[] inputArguments = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string model = inputArguments[0];
            double fuelAmount = double.Parse(inputArguments[1]);
            double fuelConsumptionFor1Km = double.Parse(inputArguments[2]);

            Car newCar = new Car(model, fuelAmount,fuelConsumptionFor1Km);

            cars.Add(newCar);
        }

        string input = string.Empty;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] inputArguments = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string model = inputArguments[1];
            double amountOfKm = double.Parse(inputArguments[2]);

            Car currentCar = cars.First(c => c.Model == model);

            currentCar.Drive(amountOfKm);
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
        }
    }
}

