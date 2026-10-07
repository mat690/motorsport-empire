public class Circuit
{
	public string Name { get; set; }
	public string Country { get; set; }

	public float AeroImportance { get; private set; }
	public float PowerImportance { get; private set; }
	public float MechanicalGripImportance { get; private set; }

	public Circuit(
		string name,
		string country,
		float aeroImportance,
		float powerImportance,
		float mechanicalGripImportance)
	{
		Name = name;
		Country = country;

		AeroImportance = aeroImportance;
		PowerImportance = powerImportance;
		MechanicalGripImportance = mechanicalGripImportance;
	}
}
