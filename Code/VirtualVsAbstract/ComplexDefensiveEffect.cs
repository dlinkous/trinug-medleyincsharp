using System;

namespace VirtualVsAbstract
{
	internal class ComplexDefensiveEffect : DefensiveEffect
	{
		internal ComplexDefensiveEffect(int pointsTotal) : base(pointsTotal) { }

		internal override string Name => "Complex";

		internal override int CalculatePointsReduction(int damage) =>
			damage * 2;
	}
}
