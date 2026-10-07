public class RaceResult
{
	public Driver Driver { get; }
	public int Position { get; }
	public int Points { get; }

	public RaceResult(Driver driver, int position, int points)
	{
		Driver = driver;
		Position = position;
		Points = points;
	}
}
