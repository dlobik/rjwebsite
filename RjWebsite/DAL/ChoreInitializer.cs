using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using RjWebsite.Models;

namespace RjWebsite.DAL
{
    public class ChoreInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ChoreContext>
    {
        protected override void Seed(ChoreContext context)
        {
            var roommates = new List<Roommate>
            {
            new Roommate{FirstName="Jake",LastName="Jaworksi"},
            new Roommate{FirstName="RJ",LastName="Dlobik"},
            new Roommate{FirstName="Miguel",LastName="Zarazua"},


            };

            roommates.ForEach(s => context.Roommates.Add(s));
            context.SaveChanges();
            var courses = new List<Chore>
            {
            new Chore{CName="Dishes",CDifficulty=6,},
            new Chore{CName="Floors",CDifficulty=4,},
            new Chore{CName="Bathrooms",CDifficulty=4,},
            new Chore{CName="Garbage",CDifficulty=1,},
            new Chore{CName="Cooking",CDifficulty=8,},
            new Chore{CName="Living Room",CDifficulty=5,},
            new Chore{CName="Shopping",CDifficulty=4,}
            };
            courses.ForEach(s => context.Chores.Add(s));
            context.SaveChanges();
        }
    }
}