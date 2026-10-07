public class Car
{
	public string Name { get; set; }

	public float Aerodynamics { get; private set; }
	public float Power { get; private set; }
	public float MechanicalGrip { get; private set; }
	public float Reliability { get; private set; }

	public Car(
		string name,
		float aerodynamics,
		float power,
		float mechanicalGrip,
		float reliability)
	{
		Name = name;

		Aerodynamics = aerodynamics;
		Power = power;
		MechanicalGrip = mechanicalGrip;
		Reliability = reliability;
	}
	public float CalculateCircuitPerformance(Circuit circuit)
{
	float totalImportance =
		circuit.AeroImportance +
		circuit.PowerImportance +
		circuit.MechanicalGripImportance;

	float performance =
		(Aerodynamics * circuit.AeroImportance) +
		(Power * circuit.PowerImportance) +
		(MechanicalGrip * circuit.MechanicalGripImportance);

	return performance / totalImportance;
}
}
