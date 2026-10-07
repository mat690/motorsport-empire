using System.Collections.Generic;

public class PointsSystem
{
	private readonly Dictionary<int, int> _pointsByPosition;

	public PointsSystem(Dictionary<int, int> pointsByPosition)
	{
		_pointsByPosition = pointsByPosition;
	}

	public int GetPointsForPosition(int position)
	{
		if (_pointsByPosition.TryGetValue(position, out int points))
		{
			return points;
		}

		return 0;
	}
}
