using System.Linq;
using DLCup.Common.Model;

namespace DLCup.Client.Presenter.Services
{
    public class DataService : IDataService
    {
        public Cup GetCup(int id)
        {
            using (var db = new DLCupEntities())
            {
                var cup = db.Cups.Single(c => c.CupId == id);
                db.LoadProperty(cup, c => c.Matches);
                db.LoadProperty(cup, c => c.HomeTeam);
                db.LoadProperty(cup, c => c.GuestTeam);

                foreach (var match in cup.Matches)
                {
                    db.LoadProperty(match, m => m.Games);

                    db.LoadProperty(match, m => m.PrimaryHomePlayer);
                    db.LoadProperty(match, m => m.PrimaryGuestPlayer);
                    db.LoadProperty(match, m => m.SecondaryHomePlayer);
                    db.LoadProperty(match, m => m.SecondaryGuestPlayer);
                }

                return cup;
            }
        }
    }
}
