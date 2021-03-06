using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Diagnostics;
using CoolApp.Core.Models;
using CoolApp.Infrastructure.Data;

namespace CoolApp.Infrastructure.Seeders
{

    public static partial class AppDataSeeder
    {
        public static void SeedFriendship(DataContext context)
        {
            try
            {
                new List<Friendship>
                {
                    new Friendship
                        {
                            UserId = 1,
                            FriendId = 2,
                            Created = DateTime.UtcNow,
                            Updated = null
                        },
                         new Friendship
                         {
                            UserId = 3,
                            FriendId = 1,
                            Created = DateTime.UtcNow,
                            Updated = null
                        }
                }.ForEach(u => context.Friendships.AddOrUpdate(u));

            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        Console.Write("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
           
        }
    }
}
