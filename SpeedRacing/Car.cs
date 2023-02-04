using System;

namespace SpeedRacing
{
    public class Car
    {
		private string model;
		private double fuelAmount;
		private double fuelConsumptionPerKilometer;
		private double travelledDistance;

        public Car()
        {
			this.travelledDistance = 0;
        }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer):this()
        {
			this.Model = model;
			this.FuelAmount = fuelAmount;
			this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }

		public double TravelledDistance
        {
			get { return travelledDistance; }
		}
		

		public double FuelConsumptionPerKilometer
        {
			get { return fuelConsumptionPerKilometer; }
			set { fuelConsumptionPerKilometer = value; }
		}


		public double FuelAmount
		{
			get { return fuelAmount; }
			set { fuelAmount = value; }
		}


		public string Model
		{
			get { return model; }
			set { model = value; }
		}

        public void Drive(double amountOfKm)
        {
            double fuelNeeded = amountOfKm * this.fuelConsumptionPerKilometer;

            if (fuelNeeded <= this.fuelAmount)
            {
                this.fuelAmount -= fuelNeeded;
				this.travelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

	}
}
