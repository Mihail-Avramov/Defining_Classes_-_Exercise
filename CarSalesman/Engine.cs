namespace CarSalesman
{
    public class Engine
    {
		private readonly string model;
		private readonly int power;
		private readonly int displacement;
		private readonly string efficiency;

        public Engine(string model, int power)
        {
			this.model = model;
			this.power = power;
            this.displacement = default;
            this.efficiency = default;
        }

        public Engine(string model, int power, int displacement) : this(model, power)
        {
            this.displacement = displacement;
        }

        public Engine(string model, int power, string efficiency) : this(model, power)
        {
            this.efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement, string efficiency) : this(model, power)
        {
            this.displacement = displacement;
            this.efficiency = efficiency;
        }


        public string Efficiency
		{
			get { return this.efficiency; }
		}

        public int Displacement
		{
			get { return this.displacement; }
		}
		
		public int Power
		{
			get { return this.power; }
		}

		public string Model
		{
			get { return this.model; }
		}
    }
}
