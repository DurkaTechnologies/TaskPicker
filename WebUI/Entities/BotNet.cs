namespace WebUI.Entities
{
	public class BotNet
	{
		public List<Bot> Bots { get; set; }

		public BotNet()
		{
			this.Bots = new List<Bot>();
		}

		public BotNet(Random random, int quantity)
		{
			Bots = new List<Bot>();

			if (quantity > 0)
				for (int i = 0; i < quantity; i++)
					Bots.Add(new Bot(random));
		}

		public void Vote(Random random, MissionList missions) 
		{
			if (missions.Missions.Count != 0)
				foreach (var bot in Bots)
					missions.Missions[bot.Vote(random, missions.Missions.Count)].Weight++;
		}
	}
}
