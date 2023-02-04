namespace RawData
{
    public class Car
    {
		private string model;
		private Engine engine;
		private Cargo cargo;
		private Tire[] tires;

        public Car(
            string model,
            int engineSpeed,
            int enginePower,
            int cargoWeight,
            string cargoType,
            double tire1Pressure,
            int tire1Age,
            double tire2Pressure,
            int tire2Age,
            double tire3Pressure,
            int tire3Age,
            double tire4Pressure,
            int tire4Age
            )
        {
			this.model = model;
            this.engine = new Engine(engineSpeed, enginePower);
            this.cargo = new Cargo(cargoType, cargoWeight);
            this.tires = new Tire[4];
            this.tires[0] = new Tire(tire1Age, tire1Pressure);
            this.tires[1] = new Tire(tire2Age, tire2Pressure);
            this.tires[2] = new Tire(tire3Age, tire3Pressure);
            this.tires[3] = new Tire(tire4Age, tire4Pressure);
        }

        
		public Tire[] Tires
		{
			get { return tires; }
        }
		
        public Cargo Cargo
		{
			get { return cargo; }
		}

        public Engine Engine
		{
			get { return engine; }
		}
		
		public string Model
		{
			get { return model; }
		}
    }
}
