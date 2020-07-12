using System;
using System.Collections.Generic;

namespace FootballManagerApp3_1.Domain
{
    public class Club
    {
        public Club()
        {
            Footballers = new List<Footballer>();
        }

        private int age;

        public int Id { get; set; }
        public string ClubName { get; set; }
        public string City { get; set; }
        public DateTime Founded { get; set; }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - Founded.Year;
            }
            set
            {
                age = value;
            }
        }
        public Coach Coach { get; set; }
        public Stadium Stadium { get; set; }
        public List<Footballer> Footballers { get; set; }
        public List<ClubTournament> ClubTournaments { get; set; }
    }
}
