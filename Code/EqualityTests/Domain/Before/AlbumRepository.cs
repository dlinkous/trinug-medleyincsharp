using System;

namespace EqualityTests.Domain.Before
{
	internal class AlbumRepository
	{
		internal Album GetFavoriteAlbum() => new Album()
		{
			Name = "Lateralus",
			Artist = "Tool",
			Year = 2001,
			Tracks = 13
		};
	}
}
