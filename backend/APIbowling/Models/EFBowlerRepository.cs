
using Microsoft.EntityFrameworkCore;

namespace APIbowling.Models
{
    public class EFBowlerRepository : IBowlingRepository
    {
        private BowlingLeagueContext _bowlingContext;
        public EFBowlerRepository(BowlingLeagueContext temp) {
        
            _bowlingContext = temp;
        }
        public IEnumerable<Bowler> Bowlers => _bowlingContext.Bowlers;

        public IEnumerable<Team> Teams => _bowlingContext.Teams;
    }
}
