using System.Text;

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

        public string Model
        {
            get { return this.model; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"  {this.model}:");
            sb.AppendLine($"    Power: {this.power}");
            if (this.displacement == default)
            {
                sb.AppendLine($"    Displacement: n/a");
            }
            else
            {
                sb.AppendLine($"    Displacement: {this.displacement}");
            }

            if (this.efficiency == default)
            {
                sb.Append("    Efficiency: n/a");
            }
            else
            {
                sb.Append($"    Efficiency: {this.efficiency}");
            }

            return sb.ToString();
        }
    }
}
