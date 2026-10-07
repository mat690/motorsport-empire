using Godot;

public partial class TestDriver : Node
{
	public override void _Ready()
	{
		Driver driver1 = new Driver(
			"Adrian",
			"Varek",
			19,
            "France"
		);

		Driver driver2 = new Driver(
			"Luca",
			"Moretti",
			24,
            "Italie"
		);

		Team team = new Team(
			"Asterion Racing",
			"France",
			25_000_000
		);

		team.SetDrivers(driver1, driver2);

		GD.Print("=== MOTORSPORT EMPIRE ===");
		GD.Print("Écurie : ", team.Name);
		GD.Print("Nationalité : ", team.Nationality);
		GD.Print("Budget : ", team.Budget, " €");

		GD.Print("");
		GD.Print("Pilote 1 : ", team.FirstDriver?.GetFullName());
		GD.Print("Pilote 2 : ", team.SecondDriver?.GetFullName());
		GD.Print("");
GD.Print(
	driver1.GetFullName(),
	" roule pour ",
	driver1.CurrentTeam?.Name
);

GD.Print(
	driver2.GetFullName(),
	" roule pour ",
	driver2.CurrentTeam?.Name
);
	}
}
