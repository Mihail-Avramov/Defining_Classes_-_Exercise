namespace RawData
{
    public class Cargo
    {
		private string type;
		private int weight;

        public Cargo(string type, int weight)
        {
			this.type = type;
			this.weight = weight;
        }

        public int Weight
        {
			get { return weight; }
		}

		public string Type
		{
			get { return type; }
		}
    }
}
