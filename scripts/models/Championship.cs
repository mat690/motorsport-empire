using System.Collections.Generic;

public class Championship
{
	public string Name { get; set; }

	public List<Team> Teams { get; private set; }
	public List<RaceWeekend> Calendar { get; private set; }

	public Championship(string name)
	{
		Name = name;
		Teams = new List<Team>();
		Calendar = new List<RaceWeekend>();
	}

	public void AddTeam(Team team)
	{
		Teams.Add(team);
	}

	public void AddRaceWeekend(RaceWeekend raceWeekend)
	{
		Calendar.Add(raceWeekend);
	}
}
