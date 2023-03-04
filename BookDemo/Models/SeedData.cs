using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BookDemo.Data;
using System;
using System.Linq;

namespace BookDemo.Models;

public static class SeedData
{
	public static void Initialize(IServiceProvider serviceProvider)
	{
		using (var context = new BookDemoContext(
				serviceProvider.GetRequiredService<
						DbContextOptions<BookDemoContext>>()))
		{
			// Look for any movies.
			if (context.Book.Any())
			{
				return;   // DB has been seeded
			}
			context.Book.AddRange(
					new Book
					{
						Title = "Sagan om ringen",
						ReleaseDate = DateTime.Parse("1989-2-12"),
						Genre = "Romantic Comedy",
						Rating = "R",
						Price = 7.99M
					},
					new Book
					{
						Title = "Nalle Puh och heffaklumpen",
						ReleaseDate = DateTime.Parse("1984-3-13"),
						Genre = "Comedy",
						Rating = "R",
						Price = 8.99M
					},
					new Book
					{
						Title = "Sagan om tornen del 2",
						ReleaseDate = DateTime.Parse("1986-2-23"),
						Genre = "Comedy",
						Rating = "R",
						Price = 9.99M
					},
					new Book
					{
						Title = "Sagan om tornen del 1",
						ReleaseDate = DateTime.Parse("1959-4-15"),
						Genre = "Western",
						Rating = "R",
						Price = 3.99M
					}
			);
			context.SaveChanges();
		}
	}
}
