using FootballManagerApp3_1.Data;
using FootballManagerApp3_1.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballManagerApp3_1.ConsolApp
{
    public class BuisnessDataLogic
    {
        private FootballManagerContext _context;

        public BuisnessDataLogic(FootballManagerContext context)
        {
            _context = context;
        }

        public BuisnessDataLogic()
        {
            _context = new FootballManagerContext();
        }

        public int AddMultipleClubs(string[] nameList)
        {
            var clubList = new List<Club>();
            foreach (var name in nameList)
            {
                clubList.Add(new Club { ClubName = name });
            }
            _context.Clubs.AddRange(clubList);

            var dbResult = _context.SaveChanges();
            return dbResult;
        }

        public int InsertNewClub(Club club)
        {
            _context.Clubs.Add(club);
            var dbResult = _context.SaveChanges();
            return dbResult;
        }

        public Club GetClubWithFootballers(int clubId)
        {
            var samuraiWithQuotes = _context.Clubs.Where(c => c.Id == clubId)
                                            .Include(c => c.Footballers)
                                            .FirstOrDefault();


            return samuraiWithQuotes;
        }
    }
}