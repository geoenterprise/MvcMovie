using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "PG-13",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "PG-13",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "R",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "The Lion King",
                    ReleaseDate = DateTime.Parse("1994-6-24"),
                    Genre = "Animation",
                    Rating = "G",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "Gladiator",
                    ReleaseDate = DateTime.Parse("2000-5-5"),
                    Genre = "Action",
                    Rating = "R",
                    Price = 5.99M
                },
                new Movie
                {
                    Title = "Braveheart",
                    ReleaseDate = DateTime.Parse("1995-5-24"),
                    Genre = "Historical Drama",
                    Rating = "R",
                    Price = 5.99M
                },
                new Movie
                {
                    Title = "Ready Player One",
                    ReleaseDate = DateTime.Parse("2018-3-29"),
                    Genre = "Sci-Fi",
                    Rating = "PG-13",
                    Price = 6.99M
                },
                new Movie
                {
                    Title = "Bad Boys II",
                    ReleaseDate = DateTime.Parse("2003-7-18"),
                    Genre = "Action",
                    Rating = "R",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "I, Robot",
                    ReleaseDate = DateTime.Parse("2004-7-16"),
                    Genre = "Sci-Fi",
                    Rating = "PG-13",
                    Price = 4.99M
                }
            );
            context.SaveChanges();
        }
    }
}