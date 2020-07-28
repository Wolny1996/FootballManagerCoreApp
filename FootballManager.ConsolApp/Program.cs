namespace FootballManager.ConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AddData.InsertClub();
            AddData.InsertMultipleClubs();
            AddData.InsertCoach();
            AddData.InsertClubWithFootballers();
            AddData.InsertClubWithStadium();
            AddData.AddFootballerToExistingClubTracked();
            AddData.AddFootballerToExistingClubNotTracked(4);
            AddData.InsertMultipleTournament();
        }
    }
}