
namespace DLCup.Common.Model
{
    public partial class Game
    {
        private const int WinningScore = 11;

        public PlayingTeam WinningTeam
        {
            get
            {
                // Båda lagen måste ha poäng (0 räknas som en poäng)
                if (!HomeScore.HasValue || !GuestScore.HasValue)
                    return PlayingTeam.None;

                if (HomeScore.Value >= WinningScore && GuestScore.Value <= WinningScore - 2)
                    return PlayingTeam.HomeTeam;

                if (GuestScore.Value >= WinningScore && HomeScore.Value <= WinningScore - 2)
                    return PlayingTeam.GuestTeam;

                if (HomeScore.Value >= WinningScore - 1 && GuestScore.Value >= WinningScore - 1)
                {
                    if (HomeScore.Value >= GuestScore.Value + 2)
                        return PlayingTeam.HomeTeam;

                    if (GuestScore.Value >= HomeScore.Value + 2)
                        return PlayingTeam.GuestTeam;
                }

                return PlayingTeam.None;
            }
        }
    }
}
