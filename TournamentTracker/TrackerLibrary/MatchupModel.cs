using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents the match in the tournament.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Represents a list of all the matches.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>;
        /// <summary>
        /// Represents the winning team of a match.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the number of the match.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
