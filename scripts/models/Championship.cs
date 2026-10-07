using System.Collections.Generic;

public class Championship
{
	public string Name { get; set; }

	public List<Team> Teams { get; private set; }

	public Championship(string name)
	{
		Name = name;
		Teams = new List<Team>();
	}

	public void AddTeam(Team team)
	{
		Teams.Add(team);
	}
}
