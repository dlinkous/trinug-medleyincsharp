using System;

namespace VirtualVsAbstract
{
	internal abstract class DefensiveEffect
	{
		internal abstract string Name { get; }
		internal int PointsRemaining { get; private set; }
		internal bool Exhausted { get; private set; }

		internal DefensiveEffect(int pointsTotal) => PointsRemaining = pointsTotal;

		internal void ProcessHit(int damage)
		{
			PointsRemaining -= CalculatePointsReduction(damage);
			if (PointsRemaining <= 0)
			{
				PointsRemaining = 0;
				Exhausted = true;
			}
		}

		internal virtual int CalculatePointsReduction(int damage) => damage;
	}
}
