using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreatePrize(PrizeModel model); //this is a contract, it has only public terms
        void CreatePerson(PersonModel model);
        void CreateTeam(TeamModel model);
        void CreateTournament(TournamentModel model);
        void UpdateMatchup(MatchupModel model);
        List<TeamModel> GetTeam_All();
        List<PersonModel> GetPerson_All();
        List<TournamentModel> GetTournament_All();
    }
}
