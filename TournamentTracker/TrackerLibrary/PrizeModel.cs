using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents place number achieved by a team within the tournament.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the name of the place, for eg. "Winner", "First Place", etc.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the given amount of money handed out to the team that achieved this place.
        /// Either use this or PrizePercentage.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the percentage of money from a total sum that as prize will be given to the team.
        /// Either use this or PrizeAmount.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
