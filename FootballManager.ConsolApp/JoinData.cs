﻿using FootballManager.Data;
using FootballManager.Domain;

namespace FootballManager.ConsolApp
{
    public class JoinData
    {
        private static FootballManagerContext _context = new FootballManagerContext();

        private static void JoinClubAndTournament()
        {
            var ctJoin = new ClubTournament { ClubId = 1, TournamentId = 2 };
            _context.AddRange(ctJoin);
            _context.SaveChanges();
        }

        private static void EnlistClubIntoTournament()
        {
            var tournament = _context.Tournaments.Find(1);
            tournament.ClubTournaments
                .Add(new ClubTournament { ClubId = 2 });
            _context.SaveChanges();
        }
    }
}