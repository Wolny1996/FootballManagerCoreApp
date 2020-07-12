using System.Linq;
using FootballManagerApp3_1.Data;
using Microsoft.EntityFrameworkCore;

namespace FootballManagerApp3_1.ConsolApp
{
    public class LoadData
    {
        private static FootballManagerContext _context = new FootballManagerContext();


        private static void EagerLoadClubsWithFootballers()
        {
            var clubsWithFootballers = _context.Clubs
                .Where(c => EF.Functions.Like(c.ClubName, "L%"))
                .Include(c => c.Footballers).ToList();
        }

        private static void ExplicitLoadFootballers()
        {
            var club = _context.Clubs.FirstOrDefault(c => c.ClubName.Contains("L"));
            _context.Entry(club).Collection(c => c.Footballers).Load();
            _context.Entry(club).Reference(c => c.Coach).Load();
        }

        private static void LazyLoadFootballers()
        {
            var footballer = _context.Footballers.FirstOrDefault(f => f.Surname.StartsWith("L"));
            var pitchPositionCount = footballer.PitchPositions.Count();
        }
    }
}