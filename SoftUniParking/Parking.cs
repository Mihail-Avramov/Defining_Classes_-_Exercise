using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    internal class Parking
    {
        private List<Car> cars;
        private int capacity;

        public Parking(int capacity)
        {
            cars = new List<Car>();
            this.capacity = capacity;
        }

        public int Count
        {
            get { return cars.Count; }
        }

        public string AddCar(Car car)
        {
            if (cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }

            if (cars.Count >= capacity)
            {
                return "Parking is full!";
            }

            cars.Add(car);

            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string regNumber)
        {
            if (cars.Any(c => c.RegistrationNumber == regNumber))
            {
                cars.RemoveAll(c => c.RegistrationNumber == regNumber);
                return $"Successfully removed {regNumber}";
            }

            return "Car with that registration number, doesn't exist!";
        }

        public Car GetCar(string regNumber)
        {
            return cars.Single(c => c.RegistrationNumber == regNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> regNumbers)
        {
            foreach (var regNumber in regNumbers)
            {
                cars.RemoveAll(c => c.RegistrationNumber == regNumber);
            }
        }
    }
}
