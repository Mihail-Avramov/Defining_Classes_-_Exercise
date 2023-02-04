using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carArguments = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carArguments[0];
                int engineSpeed = int.Parse(carArguments[1]);
                int enginePower = int.Parse(carArguments[2]);
                int cargoWeight = int.Parse(carArguments[3]);
                string cargoType = carArguments[4];
                double tire1Pressure = double.Parse(carArguments[5]);
                int tire1Age = int.Parse(carArguments[6]);
                double tire2Pressure = double.Parse(carArguments[7]);
                int tire2Age = int.Parse(carArguments[8]);
                double tire3Pressure = double.Parse(carArguments[9]);
                int tire3Age = int.Parse(carArguments[10]);
                double tire4Pressure = double.Parse(carArguments[11]);
                int tire4Age = int.Parse(carArguments[12]);

                Car newCar = new Car(
                    model,
                    engineSpeed,
                    enginePower,
                    cargoWeight,
                    cargoType,
                    tire1Pressure,
                    tire1Age,
                    tire2Pressure,
                    tire2Age,
                    tire3Pressure,
                    tire3Age,
                    tire4Pressure,
                    tire4Age
                    );

                cars.Add( newCar );
            }

            string type = Console.ReadLine();

            if (type == "fragile")
            {
                foreach (var car in cars.Where(c => c.Cargo.Type == type && c.Tires.Any(t => t.Pressure < 1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                foreach (var car in cars.Where(c => c.Cargo.Type == type && c.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}