using System;

namespace VirtualVsAbstract
{
	internal class SimpleDefensiveEffect : DefensiveEffect
	{
		internal SimpleDefensiveEffect(int pointsTotal) : base(pointsTotal) { }

		internal override string Name => "Simple";
	}
}
