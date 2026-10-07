public class DriverKnowledge
{
	public Driver Driver { get; }

	public float EstimatedPotentialMin { get; private set; }
	public float EstimatedPotentialMax { get; private set; }

	public float KnowledgeLevel { get; private set; }
	public float EvaluationBias { get; private set; }

	public DriverKnowledge(Driver driver)
	{
		Driver = driver;

		EstimatedPotentialMin = 50.0f;
		EstimatedPotentialMax = 90.0f;
		KnowledgeLevel = 20.0f;
		EvaluationBias = 5.0f;
	}

	public void ImproveKnowledge(float amount)
	{
		KnowledgeLevel += amount;

		if (KnowledgeLevel > 100.0f)
		{
			KnowledgeLevel = 100.0f;
		}

		float precision = KnowledgeLevel / 100.0f;

float uncertainty = 25.0f * (1.0f - precision);

float remainingBias = EvaluationBias * (1.0f - precision);
float estimatedCenter = Driver.Potential + remainingBias;

EstimatedPotentialMin = estimatedCenter - uncertainty;
EstimatedPotentialMax = estimatedCenter + uncertainty;

		if (EstimatedPotentialMin < 0.0f)
		{
			EstimatedPotentialMin = 0.0f;
		}

		if (EstimatedPotentialMax > 100.0f)
		{
			EstimatedPotentialMax = 100.0f;
		}
	}

	public string GetPotentialEstimation()
	{
		return $"{EstimatedPotentialMin:0} - {EstimatedPotentialMax:0}";
	}
}
