using System;

namespace EqualityTests.Domain.After
{
	internal class Album : IEquatable<Album>
	{
		internal string Name { get; set; }
		internal string Artist { get; set; }
		internal short Year { get; set; }
		internal short Tracks { get; set; }

		public override bool Equals(object obj)
		{
			return Equals(obj as Album);
		}

		public bool Equals(Album other)
		{
			return other != null &&
				   Name == other.Name &&
				   Artist == other.Artist &&
				   Year == other.Year &&
				   Tracks == other.Tracks;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Name, Artist, Year, Tracks);
		}
	}
}
