public class DriverKnowledge
{
	public Driver Driver { get; }

	public float EstimatedPotentialMin { get; private set; }
	public float EstimatedPotentialMax { get; private set; }

	// 0 = presque aucune information
	// 100 = connaissance très précise du pilote
	public float KnowledgeLevel { get; private set; }

	public DriverKnowledge(Driver driver)
	{
		Driver = driver;

		EstimatedPotentialMin = 50.0f;
		EstimatedPotentialMax = 90.0f;
		KnowledgeLevel = 20.0f;
	}

	public string GetPotentialEstimation()
	{
		return $"{EstimatedPotentialMin:0} - {EstimatedPotentialMax:0}";
	}
}
