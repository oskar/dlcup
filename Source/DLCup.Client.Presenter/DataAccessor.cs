using System.Linq;
using DLCup.Common.Model;

namespace DLCup.Client.Presenter
{
    public class DataAccessor
    {
        public void GetCup(int id)
        {
            using (var db = new DLCupEntities())
            {
                var cup = db.Cups.Single(c => c.CupId == id);
                db.LoadProperty(cup, c => c.Matches);
                db.LoadProperty(cup, c => c.HomeTeam);
                db.LoadProperty(cup, c => c.GuestTeam);


            }
        }
    }
}
