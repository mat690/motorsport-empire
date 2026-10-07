public class Team
{
	public string Name { get; set; }
	public string Nationality { get; set; }

	public double Budget { get; private set; }

	public Driver? FirstDriver { get; private set; }
	public Driver? SecondDriver { get; private set; }
	public Car? Car { get; private set; }

	public Team(
		string name,
		string nationality,
		double startingBudget)
	{
		Name = name;
		Nationality = nationality;
		Budget = startingBudget;
	}

	public void SetDrivers(Driver firstDriver, Driver secondDriver)
{
	FirstDriver = firstDriver;
	SecondDriver = secondDriver;

	firstDriver.CurrentTeam = this;
	secondDriver.CurrentTeam = this;
}
public void SetCar(Car car)
{
	Car = car;
}
}
