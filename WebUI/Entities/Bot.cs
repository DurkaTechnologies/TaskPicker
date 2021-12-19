namespace WebUI.Entities
{
	public class Bot
	{
		private int stupidity;

		public bool IsDead { get; set; }

		public static int MaxStupidity = 10;
		
		public int Stupidity 
		{ 
			get { return stupidity; } 
			set 
			{
				if(value >= 0 && value <= MaxStupidity)
					stupidity = value;
			} 
		}

		public Bot()
		{
			IsDead = false;
			Stupidity = 0;
		}

		public Bot(Random random) : base() 
		{
			Generate(random);
		}

		public void Generate(Random random) 
		{
			Stupidity = random.Next(MaxStupidity);
		}

		public int Vote(Random random, int quantity) 
		{
			if (IsDead || quantity <= 0)
				return 0;

			return random.Next(quantity);
		}
	}
}
