using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           List<Engine> engines = new List<Engine>();
           List<Car> cars = new List<Car>();

           int counter = int.Parse(Console.ReadLine());

           for (int i = 0; i < counter; i++)
           {
                string[] engineArguments = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = engineArguments[0];
                int power = int.Parse(engineArguments[1]);
                if (engineArguments.Length == 4)
                {
                    int displacement = int.Parse(engineArguments[2]);
                    string efficiency = engineArguments[3];

                    Engine newEngine = new Engine(model, power, displacement, efficiency);
                    engines.Add(newEngine);
                }
                else if (engineArguments.Length == 3)
                {
                    if (int.TryParse(engineArguments[2],out int displacement))
                    {
                        Engine newEngine = new Engine(model, power, displacement);
                        engines.Add(newEngine);
                    }
                    else
                    {
                        string efficiency = engineArguments[2];
                        Engine newEngine = new Engine(model, power, efficiency);
                        engines.Add(newEngine);
                    }
                }
                else
                {
                    Engine newEngine = new Engine(model, power);
                    engines.Add(newEngine);
                }
           }

           counter = int.Parse(Console.ReadLine());

           for (int i = 0; i < counter; i++)
           {
               string[] carArguments = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

               string model = carArguments[0];
               string engineModel = carArguments[1];
               Engine engine = engines.First(e => e.Model == engineModel);

               if (carArguments.Length == 4)
               {
                   int weight = int.Parse(carArguments[2]);
                   string color = carArguments[3];

                   Car newCar = new Car(model, engine, weight, color);
                   cars.Add(newCar);
               }
               else if (carArguments.Length == 3)
               {
                   if (int.TryParse(carArguments[2], out int weight))
                   {
                       Car newCar = new Car(model, engine, weight);
                       cars.Add(newCar);
                   }
                   else
                   {
                       string color = carArguments[2];

                       Car newCar = new Car(model, engine, color);
                       cars.Add(newCar);
                   }
               }
               else
               {
                   Car newCar = new Car(model, engine);
                   cars.Add(newCar);
               }
           }

           foreach (var car in cars)
           {
               Console.WriteLine(car);
           }

        }
    }
}