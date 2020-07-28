using FootballManager.Data;
using FootballManager.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FootballManager.ConsolApp
{
    public class GetData
    {
        private static FootballManagerContext _context = new FootballManagerContext();

        private static void GetClubs(string text)
        {
            var clubs = _context.Clubs.ToList();
            Console.WriteLine($"{text}: Club count is {clubs.Count}");
            foreach (var club in clubs)
            {
                Console.WriteLine(club.ClubName, club.City, club.Founded, club.Age);
            }
        }

        private static void GetClubWithStadium()
        {
            var club = _context.Clubs.Include(c => c.Stadium).ToList();
        }

        private static void GetStadiumWithClub()
        {
            var clubWithoutStadium = _context.Set<Stadium>().Find(3);

            var clubWithStadium = _context.Clubs.Include(c => c.Stadium)
                .FirstOrDefault(c => c.Stadium.Id == 3);

            var clubsWithStadiums = _context.Clubs
                .Where(c => c.Stadium != null)
                .Select(c => new { Stadium = c.Stadium, Club = c })
                .ToList();
        }

        private static void GetFootballerWithClub()
        {
            var footballer = _context.Footballers.Include(f => f.Club).FirstOrDefault();
        }

        private static void GetClubWithFootballers()
        {
            var club = _context.Clubs.Find(5);
            var footballersForClub = _context.Footballers.Where(f => f.ClubId == 5).ToList();
        }
    }
}