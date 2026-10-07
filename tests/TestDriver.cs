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

		DriverKnowledge knowledge = new DriverKnowledge(driver);

		GD.Print("=== MOTORSPORT EMPIRE C# ===");
		GD.Print("Pilote : ", driver.GetFullName());
		GD.Print("Âge : ", driver.Age);
		GD.Print("Nationalité : ", driver.Nationality);

		GD.Print("");
		GD.Print("=== INFORMATIONS CONNUES ===");
		GD.Print("Rythme : ", driver.Pace);
		GD.Print("Qualifications : ", driver.Qualifying);
		GD.Print("Feedback technique : ", driver.TechnicalFeedback);

		GD.Print("");
		GD.Print("Potentiel estimé : ", knowledge.GetPotentialEstimation());
		GD.Print("Niveau de connaissance : ", knowledge.KnowledgeLevel, "%");
	}
}
