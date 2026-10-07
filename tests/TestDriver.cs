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
		Car car = new Car(
	"AR-01",
	68.0f,
	72.0f,
	65.0f,
	78.0f
);

team.SetCar(car);
Circuit circuit = new Circuit(
	"Circuit des Hautes-Rives",
	"France",
	100.0f,
	25.0f,
	45.0f
);
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
GD.Print("");
GD.Print("=== VOITURE ===");
GD.Print("Modèle : ", team.Car?.Name);
GD.Print("Aérodynamique : ", team.Car?.Aerodynamics);
GD.Print("Puissance : ", team.Car?.Power);
GD.Print("Grip mécanique : ", team.Car?.MechanicalGrip);
GD.Print("Fiabilité : ", team.Car?.Reliability);

GD.Print("");
GD.Print("=== CIRCUIT ===");
GD.Print("Circuit : ", circuit.Name);
GD.Print("Pays : ", circuit.Country);
Car rivalCar = new Car(
	"VX-01",
	62.0f, // Aéro moins bonne
	80.0f, // Moteur plus puissant
	72.0f, // Meilleur grip mécanique
	70.0f
);
Circuit powerCircuit = new Circuit(
	"Autodrome de Valdora",
	"Italie",
	45.0f, // Aéro
	95.0f, // Puissance
	40.0f  // Grip mécanique
);
float circuitPerformance = car.CalculateCircuitPerformance(circuit);

GD.Print(
	"Performance théorique de l'AR-01 : ",
	circuitPerformance.ToString("0.00")
);
GD.Print("");
GD.Print("=== COMPARAISON ===");

 
GD.Print(
	"VX-01 : ",
	rivalCar.CalculateCircuitPerformance(circuit).ToString("0.00")
);

GD.Print("");

GD.Print("Autodrome de Valdora :");
GD.Print(
	"AR-01 : ",
	car.CalculateCircuitPerformance(powerCircuit).ToString("0.00")
);
GD.Print(
	"VX-01 : ",
	rivalCar.CalculateCircuitPerformance(powerCircuit).ToString("0.00")
);

	}
}
