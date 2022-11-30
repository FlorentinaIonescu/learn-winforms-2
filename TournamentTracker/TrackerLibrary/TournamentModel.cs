using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// The name of the tournament.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents the amount of money asked for as entry fee.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents a list of the teams entered in the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represents a list of the prizes.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Represents a list of lists which are
        /// the matches organized within rounds.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
