using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TournamentTracker
{
    public interface IPrizeRequester
    {
        void PrizeComplete(PrizeModel model);
    }
}
