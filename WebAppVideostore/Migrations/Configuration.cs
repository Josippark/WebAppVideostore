namespace WebAppVideostore.Migrations
{
    using MvcMovie.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MvcMovie.Models.MovieDBContext";
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "Ljubavna prièa",
                    ReleaseDate = DateTime.Parse("1970-1-11"),
                    Genre = "Romantièni",
                    Rating = 7,
                    Price = 10
                },

                new Movie
                {
                    Title = "Petak 13",
                    ReleaseDate = DateTime.Parse("1980-3-13"),
                    Genre = "Horor",
                    Rating = 5,
                    Price = 30
                },

                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Komedija",
                    Rating = 3,
                    Price = 25
                },

                new Movie
                {
                    Title = "Iron man",
                    ReleaseDate = DateTime.Parse("2008-4-15"),
                    Genre = "Superheroji",
                    Rating = 10,
                    Price = 15
                }
            );

        }
    }
}
