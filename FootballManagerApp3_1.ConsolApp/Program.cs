using FootballManagerApp3_1.Data;
using FootballManagerApp3_1.Domain;
using System;
using System.Collections.Generic;

namespace FootballManagerApp3_1.ConsolApp
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