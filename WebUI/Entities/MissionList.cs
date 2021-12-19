namespace WebUI.Entities
{
	public class MissionList
	{
		public List<Mission> Missions { get; set; }

		public string Description { get; set; }

		public MissionList()
		{
			Missions = new List<Mission>();
			Description = "";
		}

		public MissionList(List<Mission> missions, string description) : base()
		{
			Missions = missions;
			Description = description;
		}
	}
}
