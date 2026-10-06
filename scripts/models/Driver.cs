using Godot;

public partial class Driver : RefCounted
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public int Age { get; set; }
	public string Nationality { get; set; }

	public float Pace { get; set; }
	public float Qualifying { get; set; }
	public float Consistency { get; set; }
	public float TireManagement { get; set; }
	public float WetSkill { get; set; }
	public float TechnicalFeedback { get; set; }

	// Vérité interne de la simulation.
	// Cette valeur ne sera pas directement montrée au joueur.
	internal float Potential { get; set; }


	public Driver(
		string firstName,
		string lastName,
		int age,
		string nationality)
	{
		FirstName = firstName;
		LastName = lastName;
		Age = age;
		Nationality = nationality;

		Pace = 50.0f;
		Qualifying = 50.0f;
		Consistency = 50.0f;
		TireManagement = 50.0f;
		WetSkill = 50.0f;
		TechnicalFeedback = 50.0f;

		Potential = 75.0f;
	}


	public string GetFullName()
	{
		return $"{FirstName} {LastName}";
	}
}
