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

		public void Vote(Random random, List<Mission> missions) 
		{
			foreach (var mission in missions)
				mission.Weight = 0;

			if (missions.Count != 0)
				foreach (var bot in Bots)
					missions[bot.Vote(random, missions.Count)].Weight++;

			//int maxCount = missions.Max(x => x.Weight);

			foreach (var mission in missions)
				mission.Value = ((double)mission.Weight / (double)Bots.Count) * 100;
		}
	}
}
