namespace WebUI.Entities
{
	public class Mission
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public int Weight { get; set; }
		public double Value { get; set; }

		public Mission()
		{
			Name = "";
			Description = "";
			Weight = 0;
		}

		public Mission(string name, string description = "", double value = 0) : base()
		{
			Name = name;
			Description = description;
			Value = value;
		}
	}
}
