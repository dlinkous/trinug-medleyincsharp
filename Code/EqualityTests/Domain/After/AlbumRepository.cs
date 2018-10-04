using System;

namespace EqualityTests.Domain.After
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
