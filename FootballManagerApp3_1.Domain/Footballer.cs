using System.Collections.Generic;

namespace FootballManagerApp3_1.Domain
{
    public class Footballer
    {
        public Footballer()
        {
            PitchPositions = new List<PitchPosition>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Club Club { get; set; }
        public int ClubId { get; set; }
        public List<PitchPosition> PitchPositions { get; set; }
    }
}
