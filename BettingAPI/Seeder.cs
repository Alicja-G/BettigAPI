using BettingAPI.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BettingAPI
{
    public class Seeder
    {
        private BettingDbContext _dbContext { get; set; }
        public Seeder(BettingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Events.Any())
                {
                    var events = GetEvents();
                    _dbContext.Events.AddRange(events);
                    _dbContext.SaveChanges();
                }
            }
        }

        private List<Event> GetEvents()
            => new List<Event>
            {
                new Event
                {
                    Name = "firstEvent",
                    Description = "descriptionFirstEvent",
                    DateAdded = System.DateTime.Now,
                    DateFrom = System.DateTime.Now,
                    DateTo = System.DateTime.Now.AddDays(5),
                    IsActive = true,
                    EventAdress = new EventAdress
                    {
                        City = "wro",
                        Country = "pl",
                        Street = "streetFirstEvent"
                    },
                    Confrontations = new List<Confrontation>
                    {
                        new Confrontation
                        {
                            FirstTeam = "firstTeamForFirstEvent",
                            SecondTeam = "secondTeamForFirstEvent",
                            DateAdded = System.DateTime.Now,
                            StartDate = System.DateTime.Now,
                            IsActive = true
                        },
                        new Confrontation
                        {
                            FirstTeam = "thirdTeamForFirstEvent",
                            SecondTeam = "forthTeamForFirstEvent",
                            DateAdded = System.DateTime.Now,
                            StartDate = System.DateTime.Now,
                            EndDate = System.DateTime.Now.AddDays(1),
                            IsActive = true
                        },

                    }
                },
                new Event
                {
                    Name = "secondEvent",
                    Description = "descriptionSecondEvent",
                    DateAdded = System.DateTime.Now.AddDays(5),
                    DateFrom = System.DateTime.Now.AddDays(5),
                    DateTo = System.DateTime.Now.AddDays(15),
                    IsActive = true,
                    EventAdress = new EventAdress
                    {
                        City = "london",
                        Country = "gb",
                        Street = "streetSecondEvent"
                    },
                    Confrontations = new List<Confrontation>
                    {
                        new Confrontation
                        {
                            FirstTeam = "firstTeamForSecondEvent",
                            SecondTeam = "secondTeamForSecondEvent",
                            DateAdded = System.DateTime.Now.AddDays(5),
                            StartDate = System.DateTime.Now.AddDays(5),
                            IsActive = true
                        },
                        new Confrontation
                        {
                            FirstTeam = "thirdTeamForSecondEvent",
                            SecondTeam = "forthTeamForSecondEvent",
                            DateAdded = System.DateTime.Now.AddDays(5),
                            StartDate = System.DateTime.Now.AddDays(5),
                            EndDate = System.DateTime.Now.AddDays(6),
                            IsActive = true
                        },

                    }
                }
            };
    }
}
