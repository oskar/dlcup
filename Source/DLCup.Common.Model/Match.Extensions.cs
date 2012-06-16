using System.Linq;

namespace DLCup.Common.Model
{
    public partial class Match
    {
        private const string UnknownPlayerName = "Okänd";

        public PlayingTeam WinningTeam
        {
            get
            {
                var homeTeamGames = 0;
                var guestTeamGames = 0;

                foreach (var game in Games)
                {
                    // spara i variabel, onödigt att beräkna två gånger
                    var gameWinningTeam = game.WinningTeam;

                    if (gameWinningTeam == PlayingTeam.HomeTeam)
                        homeTeamGames++;

                    if (gameWinningTeam == PlayingTeam.GuestTeam)
                        guestTeamGames++;
                }

                var gamesRequiredToWin = (Games.Count / 2) + 1;

                if (homeTeamGames >= gamesRequiredToWin)
                    return PlayingTeam.HomeTeam;

                if (guestTeamGames >= gamesRequiredToWin)
                    return PlayingTeam.GuestTeam;

                return PlayingTeam.None;
            }
        }

        public string HomePlayersText
        {
            get
            {
                if (PrimaryHomePlayer == null)
                    return UnknownPlayerName;

                if (SecondaryHomePlayer == null)
                    return PrimaryHomePlayer.PlayerName;

                return PrimaryHomePlayer.PlayerName + " & " + SecondaryHomePlayer.PlayerName;
            }
        }

        public string GuestPlayersText
        {
            get
            {
                if (PrimaryGuestPlayer == null)
                    return UnknownPlayerName;

                if (SecondaryGuestPlayer == null)
                    return PrimaryGuestPlayer.PlayerName;

                return PrimaryGuestPlayer.PlayerName + " & " + SecondaryGuestPlayer.PlayerName;
            }
        }

        public bool IsCurrentlyPlaying
        {
            get
            {
                if (WinningTeam != PlayingTeam.None)
                    return false;

                return Games.Any(g => g.HomeScore.HasValue && g.GuestScore.HasValue);
            }
        }
    }
}
