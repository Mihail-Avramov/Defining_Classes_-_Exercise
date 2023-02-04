using System;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
		private readonly string model;
		private readonly Engine engine;
		private readonly int weight;
		private readonly string color;

        public Car(string model, Engine engine)
        {
			this.model = model;
			this.engine = engine;
            this.weight = default;
			this.color = default;
        }

        public Car(string model, Engine engine, int weight):this(model, engine)
        {
            this.weight = weight;
        }

        public Car(string model, Engine engine,string color):this(model, engine)
        {
            this.color = color;
        }
		public Car(string model, Engine engine, int weight, string color) : this(model, engine)
        {
            this.weight = weight;
            this.color = color;
        }

        public string Color
		{
			get { return color; }
		}

		public int Weight
		{
			get { return weight; }
		}

		public Engine Engine
		{
			get { return engine; }
		}

        public string Model
		{
			get { return model; }
		}


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.model}:");
            sb.AppendLine($"  {this.engine.Model}:");
            sb.AppendLine($"    Power: {this.engine.Power}");
            if (this.engine.Displacement == default)
            {
                sb.AppendLine($"    Displacement: n/a");
            }
            else
            {
                sb.AppendLine($"    Displacement: {this.engine.Displacement}");
            }

            if (this.engine.Efficiency == default)
            {
                sb.AppendLine("    Efficiency: n/a");
            }
            else
            {
                sb.AppendLine($"    Efficiency: {this.engine.Efficiency}");
            }

            if (this.weight == default)
            {
                sb.AppendLine("  Weight: n/a");
            }
            else
            {
                sb.AppendLine($"  Weight: {this.weight}");
            }

            if (this.color == default)
            {
                sb.Append("  Color: n/a");
            }
            else
            {
                sb.Append($"  Color: {this.color}");
            }

            return sb.ToString();
        }
    }
}
