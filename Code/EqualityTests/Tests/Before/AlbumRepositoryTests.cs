using System;
using Xunit;
using EqualityTests.Domain.Before;

namespace EqualityTests.Tests.Before
{
	public class AlbumRepositoryTests
	{
		[Fact]
		public void GetsFavoriteAlbumCorrectly()
		{
			var repository = new AlbumRepository();
			var expected = new Album()
			{
				Name = "Lateralus",
				Artist = "Tool",
				Year = 2001,
				Tracks = 13
			};
			var actual = repository.GetFavoriteAlbum();
			Assert.Equal(expected.Name, actual.Name);
			Assert.Equal(expected.Artist, actual.Artist);
			Assert.Equal(expected.Year, actual.Year);
			Assert.Equal(expected.Tracks, actual.Tracks);
		}
	}
}
