using Godot;

public partial class TestDriver : Node
{
	public override void _Ready()
	{
		Driver driver = new Driver(
			"Adrian",
			"Varek",
			19,
			"France"
		);

		GD.Print("=== MOTORSPORT EMPIRE C# ===");
		GD.Print("Pilote : ", driver.GetFullName());
		GD.Print("Âge : ", driver.Age);
		GD.Print("Nationalité : ", driver.Nationality);
		GD.Print("Rythme : ", driver.Pace);
		GD.Print("Qualifications : ", driver.Qualifying);
		GD.Print("Feedback technique : ", driver.TechnicalFeedback);
	}
}
