using System.Collections.Generic;

namespace FootballManagerApp3_1.Domain
{
    public class Tournament
    {
        public int Id { get; set; }
        public string TournamentName { get; set; }
        public List<ClubTournament> ClubTournaments { get; set; }
    }
}
