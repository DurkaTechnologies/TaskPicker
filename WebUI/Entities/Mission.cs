namespace WebUI.Entities
{
	public class Mission
	{
		public string Name { get; set; }
		public string Description { get; set; }

		public int Weight { get; set; }

		public Mission()
		{
			Name = "";
			Description = "";
			Weight = 0;
		}

		public Mission(string name, string description = "") : base()
		{
			Name = name;
			Description = description;
		}
	}
}
