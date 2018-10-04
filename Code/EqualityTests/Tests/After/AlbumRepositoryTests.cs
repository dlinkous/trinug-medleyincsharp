using System;
using Xunit;
using EqualityTests.Domain.After;

namespace EqualityTests.Tests.After
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
			Assert.Equal(expected, actual);
		}
	}
}
