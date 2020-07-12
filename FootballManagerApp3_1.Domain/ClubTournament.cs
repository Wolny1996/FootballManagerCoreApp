namespace FootballManagerApp3_1.Domain
{
    public class ClubTournament
    {
        public int ClubId { get; set; }
        public int TournamentId { get; set; }
        public Club Club { get; set; }
        public Tournament Tournament { get; set; }
    }
}
