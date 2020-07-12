using FootballManagerApp3_1.Data;
using FootballManagerApp3_1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballManagerApp3_1.ConsolApp
{
    public class AddData
    {
        private static FootballManagerContext _context = new FootballManagerContext();

        public static void InsertClub()
        {
            var club = new Club { ClubName = "Arsenal", City = "London", Founded = new DateTime(1886, 1, 1)};
            _context.Clubs.Add(club);
            _context.SaveChanges();
        }

        public static void InsertMultipleClubs()
        {
            var club1 = new Club { ClubName = "Chelsea", City = "London", Founded = new DateTime(1905, 3, 10) };
            var club2 = new Club { ClubName = "Everton", City = "Liverpool", Founded = new DateTime(1878, 1, 1) };
            var club3 = new Club { ClubName = "United", City = "Manchester", Founded = new DateTime(1878, 1, 1) };
            var club4 = new Club { ClubName = "City", City = "Manchester", Founded = new DateTime(1880, 1, 1) };
            _context.Clubs.AddRange(club1, club2, club3, club4);
            _context.SaveChanges();
        }

        public static void InsertCoach()
        {
            var coach = new Coach { Name = "Mikel", Surname = "Arteta",  ClubId = 1};
            _context.Coaches.Add(coach);
            _context.SaveChanges();
        }

        public static void InsertClubWithFootballers()
        {
            var club = new Club
            {
                ClubName = "Leicester",
                City = "Leicester",
                Founded = new DateTime(1884, 1, 1),
                Footballers = new List<Footballer>
                {
                    new Footballer { Name = "Kasper", Surname = "Schmeichel", ClubId = 5},
                    new Footballer { Name = "Ricardo", Surname = "Pereira", ClubId = 5},
                    new Footballer { Name = "James", Surname = "Maddison", ClubId = 5},
                    new Footballer { Name = "Jamie", Surname = "Vardy", ClubId = 5}
                }
            };
            _context.Clubs.Add(club);
            _context.SaveChanges();
        }

        public static void InsertClubWithStadium()
        {
            var club = new Club { ClubName = "Liverpool", City = "Liverpool", Founded = new DateTime(1892, 6, 3)};
            var stadium = new Stadium { StadiumName = "Anfield", Capacity = 54074, ClubId = 7 };
            _context.AddRange(club, stadium);
            _context.SaveChanges();
        }

        public static void AddFootballerToExistingClubTracked()
        {
            var club = _context.Clubs.FirstOrDefault();
            club.Footballers.Add(new Footballer
            {
                Name = "Bernd", Surname = "Leno", ClubId = 1
            });
            _context.SaveChanges();
        }

        public static void AddFootballerToExistingClubNotTracked(int clubId)
        {
            var club = _context.Clubs.Find(clubId);
            club.Footballers.Add(new Footballer
            {
                Name = "Piere-Emerick", Surname = "Aubameyang", ClubId = 1
            });
            using (var newContext = new FootballManagerContext())
            {
                newContext.Clubs.Update(club);
                newContext.SaveChanges();
            }
        }

        public static void InsertMultipleTournament()
        {
            var tournament1 = new Tournament { TournamentName = "Champions League" };
            var tournament2 = new Tournament { TournamentName = "Europa League" };
            var tournament3 = new Tournament { TournamentName = "Premier League" };
            var tournament4 = new Tournament { TournamentName = "FA Cup" };
            _context.Tournaments.AddRange(tournament1, tournament1, tournament1, tournament1);
            _context.SaveChanges();
        }
    }
}