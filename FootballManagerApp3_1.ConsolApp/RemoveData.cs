using FootballManagerApp3_1.Data;
using FootballManagerApp3_1.Domain;

namespace FootballManagerApp3_1.ConsolApp
{
    public class RemoveData
    {
        private static FootballManagerContext _context = new FootballManagerContext();

        private static void RemoveJoinBetweenClubAndTournament()
        {
            var join = new ClubTournament { ClubId = 1, TournamentId = 2 };
            _context.Remove(join);
            _context.SaveChanges();
        }
    }
}