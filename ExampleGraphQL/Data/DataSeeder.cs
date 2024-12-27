using Bogus;
using ExampleGraphQL.Models;
using Faker;
using Microsoft.EntityFrameworkCore;

namespace ExampleGraphQL.Data
{
        public static class DataSeeder
        {
            public static async Task SeedDataAsync(BlogDbContext db)
            {
                if (!await db.Clients.AnyAsync())
                {
                    for (int i = 0; i < 10; i++)
                    {
                        var client = new Client
                        {
                            Name = Name.FullName(),
                            ContactInformation = Internet.Email(),
                            Address = Address.StreetAddress(),
                            PhoneNumber = Phone.Number()
                        };

                        db.Clients.Add(client);
                    }
                    await db.SaveChangesAsync();
                }

                if (!await db.Teams.AnyAsync())
                {
                    for (int i = 0; i < 5; i++)
                    {
                        var team = new Team
                        {
                            Name = Company.Name(),
                            Description = Lorem.Sentence(),
                            FullName = Name.FullName(),
                            PhoneNumber = Phone.Number()
                        };

                        db.Teams.Add(team);
                    }
                    await db.SaveChangesAsync();
                }

                if (!await db.Members.AnyAsync())
                {
                    for (int i = 0; i < 20; i++)
                    {
                        var member = new Member
                        {
                            Name = Name.FullName(),
                            Role = Lorem.Sentence(),
                            DatePerformed = DateTime.Now,
                            WorkCompleted = RandomBoolean(),
                            FullName = Name.FullName(),
                            PhoneNumber = Phone.Number(),
                            TeamId = Faker.RandomNumber.Next(1, 5)
                        };

                        db.Members.Add(member);
                    }
                    await db.SaveChangesAsync();
                }

                if (!await db.Orders.AnyAsync())
                {
                    for (int i = 0; i < 10; i++)
                    {
                        var clientId = Faker.RandomNumber.Next(1, 10);

                        var order = new Order
                        {
                            ClientId = clientId,
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddMonths(1),
                            TotalCost = Faker.RandomNumber.Next(100, 5000),
                            IsPaid = RandomBoolean(),
                            Description = Lorem.Sentence(),
                            DatePerformed = DateTime.Now,
                            WorkCompleted = RandomBoolean(),
                            IsOverdue = DateTime.Now > DateTime.Now.AddMonths(1),
                        };

                        db.Orders.Add(order);
                    }
                    await db.SaveChangesAsync();
                }

                if (!await db.Works.AnyAsync())
                {
                    for (int i = 0; i < 20; i++)
                    {
                        var teamId = Faker.RandomNumber.Next(1, 5);
                        var orderId = Faker.RandomNumber.Next(1, 10);

                        var work = new Work
                        {
                            Description = Lorem.Sentence(),
                            Cost = Faker.RandomNumber.Next(50, 500),
                            Date = DateTime.Now,
                            TeamId = teamId,
                            WorkCompleted = RandomBoolean(),
                            OrderId = orderId,
                            DatePerformed = DateTime.Now
                        };

                        db.Works.Add(work);
                    }
                    await db.SaveChangesAsync();
                }
            }
            private static bool RandomBoolean()
            {
                return Faker.RandomNumber.Next(0, 2) == 1;
            }
        }
    }



