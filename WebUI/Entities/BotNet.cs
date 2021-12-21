namespace WebUI.Entities
{
	public class BotNet
	{
		private int botsQantity;

		public BotNet()
		{
			Bots = new List<Bot>();
      VoteStart = true;
		}

		public BotNet(Random random, int quantity)
		{
			Bots = new List<Bot>();
			BotsQuantity = quantity;
      VoteStart = true;
      
			for (int i = 0; i < BotsQuantity; i++)
				Bots.Add(new Bot(random));
		}

		public void Vote(Random random, List<Mission> missions) 
		{
			foreach (var mission in missions)
				mission.Weight = 0;

			if (missions.Count > 1)
				foreach (var bot in Bots)
					missions[bot.Vote(random, missions.Count)].Weight++;

			//int maxCount = missions.Max(x => x.Weight);

			foreach (var mission in missions)
				mission.Value = ((double)mission.Weight / (double)Bots.Count) * 100;
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
