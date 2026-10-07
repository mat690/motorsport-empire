public class RaceWeekend
{
	public int RoundNumber { get; private set; }
	public Circuit Circuit { get; private set; }

	public RaceWeekend(int roundNumber, Circuit circuit)
	{
		RoundNumber = roundNumber;
		Circuit = circuit;
	}
}
