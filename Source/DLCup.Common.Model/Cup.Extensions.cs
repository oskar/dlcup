using System.Linq;

namespace DLCup.Common.Model
{
    public partial class Cup
    {
        public int HomeTeamScore
        {
            get { return Matches.Where(m => m.WinningTeam == PlayingTeam.HomeTeam).Sum(m => m.Points); }
        }

        public int GuestTeamScore
        {
            get { return Matches.Where(m => m.WinningTeam == PlayingTeam.GuestTeam).Sum(m => m.Points); }
        }

        public PlayingTeam WinningTeam
        {
            get
            {
                var totalScore = Matches.Sum(m => m.Points);
                var scoreRequiredToWin = (totalScore / 2) + 1;

                if (HomeTeamScore >= scoreRequiredToWin)
                    return PlayingTeam.HomeTeam;

                if (GuestTeamScore >= scoreRequiredToWin)
                    return PlayingTeam.GuestTeam;

                return PlayingTeam.None;
            }
        }
    }
}
