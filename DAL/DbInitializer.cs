using System;
using System.Collections.Generic;
using System.Data.Entity;
using DAL.Entities;

namespace DAL
{
    public class DbInitializer : CreateDatabaseIfNotExists<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            var quizes = new List<Quiz>
            {
                new Quiz
                {
                    Name = "First",
                    Description = "Description",
                    CreatedOn = DateTime.Now
                },
                new Quiz
                {
                    Name = "Second",
                    Description = "Description 2",
                    CreatedOn = DateTime.Now.AddDays(-1)
                }
            };
            quizes.ForEach(q => context.Quizes.Add(q));
            context.SaveChanges();
        }
    }
}
