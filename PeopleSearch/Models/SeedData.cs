using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace PeopleSearch.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PeopleSearchContext(
                serviceProvider.GetRequiredService<DbContextOptions<PeopleSearchContext>>()))
            {
                // Look for any Peoples.
                if (context.People.Any())
                {
                    return;   // DB has been seeded
                }

                context.People.AddRange(
                     new People
                     {
                         Name = "Jayson Nguyen",
                         Address = "801S Jump Street, West Valley City UT 84120",
                         Age = 25,
                         Interest = "Video Games, Snowboarding, Cars, Fishing "
                     },

                     new People
                     {
                         Name = "John Doe",
                         Address = "102 Lincoln Ave., Sandy UT 80407",
                         Age = 25,
                         Interest = "Japanese, Reading, Hiking"
                     },

                     new People
                     {
                         Name = "Lisa Doe",
                         Address = "387s Circle Drive, SLC UT 84115",
                         Age = 27,
                         Interest = "Science, Astrology"
                     },

                   new People
                   {
                       Name = "Melissa Smith",
                       Address = "987s Hacking Way, SLC UT 84119",
                       Age = 26,
                       Interest = "Enghlish, Science, Technology"
                   }
                );
                context.SaveChanges();
            }
        }
    }
}
