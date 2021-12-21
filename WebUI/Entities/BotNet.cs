namespace WebUI.Entities
{
	public class BotNet
	{
		private int botsQantity;

		public BotNet()
		{
			Bots = new List<Bot>();
		}

		public BotNet(Random random, int quantity)
		{
			Bots = new List<Bot>();
			BotsQuantity = quantity;

			for (int i = 0; i < BotsQuantity; i++)
				Bots.Add(new Bot(random));
		}

		public void Vote(Random random, MissionList missions) 
		{
			if (missions.Missions.Count > 1)
				foreach (var bot in Bots)
					missions.Missions[bot.Vote(random, missions.Missions.Count)].Weight++;
		}


		public int BotsQuantity
		{
			get => botsQantity;
			set
			{
				if (!VoteStarted)
				{
					if (value > 0)
						botsQantity = value;
				}
			}
		}

		public List<Bot> Bots { get; set; }

		private bool VoteStarted { get; set; }
	}
}
