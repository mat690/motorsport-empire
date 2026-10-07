 
using System.Collections.Generic;
public class RaceWeekend
{
	public int RoundNumber { get; private set; }
	public Circuit Circuit { get; private set; }
	public List<RaceResult> Results { get; } = new();

	public RaceWeekend(int roundNumber, Circuit circuit)
	{
		RoundNumber = roundNumber;
		Circuit = circuit;
	}
}
