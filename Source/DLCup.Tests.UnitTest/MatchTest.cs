using System;
using DLCup.Common.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DLCup.Tests.UnitTest
{
    [TestClass]
    public class MatchTest
    {
        [TestMethod]
        public void WinningTeamTest()
        {
            WinningTeamTestHelper(0, 0, 0, PlayingTeam.None);
            WinningTeamTestHelper(0, 0, 1, PlayingTeam.None);
            WinningTeamTestHelper(0, 1, 2, PlayingTeam.None);
            WinningTeamTestHelper(1, 0, 2, PlayingTeam.None);
            WinningTeamTestHelper(1, 1, 2, PlayingTeam.None);
            WinningTeamTestHelper(0, 0, 3, PlayingTeam.None);
            WinningTeamTestHelper(1, 0, 3, PlayingTeam.None);
            WinningTeamTestHelper(0, 1, 3, PlayingTeam.None);
            WinningTeamTestHelper(1, 1, 3, PlayingTeam.None);
            WinningTeamTestHelper(0, 0, 4, PlayingTeam.None);
            WinningTeamTestHelper(1, 0, 4, PlayingTeam.None);
            WinningTeamTestHelper(0, 1, 4, PlayingTeam.None);
            WinningTeamTestHelper(1, 1, 4, PlayingTeam.None);
            WinningTeamTestHelper(2, 0, 4, PlayingTeam.None);
            WinningTeamTestHelper(2, 1, 4, PlayingTeam.None);
            WinningTeamTestHelper(0, 2, 4, PlayingTeam.None);
            WinningTeamTestHelper(1, 2, 4, PlayingTeam.None);
            WinningTeamTestHelper(2, 2, 4, PlayingTeam.None);

            WinningTeamTestHelper(1, 0, 1, PlayingTeam.HomeTeam);
            WinningTeamTestHelper(2, 0, 2, PlayingTeam.HomeTeam);
            WinningTeamTestHelper(3, 0, 3, PlayingTeam.HomeTeam);
            WinningTeamTestHelper(2, 0, 3, PlayingTeam.HomeTeam);
            WinningTeamTestHelper(2, 1, 3, PlayingTeam.HomeTeam);
            WinningTeamTestHelper(3, 0, 4, PlayingTeam.HomeTeam);
            WinningTeamTestHelper(3, 1, 4, PlayingTeam.HomeTeam);
            WinningTeamTestHelper(3, 0, 5, PlayingTeam.HomeTeam);
            WinningTeamTestHelper(3, 1, 5, PlayingTeam.HomeTeam);
            WinningTeamTestHelper(3, 2, 5, PlayingTeam.HomeTeam);

            WinningTeamTestHelper(0, 1, 1, PlayingTeam.GuestTeam);
            WinningTeamTestHelper(0, 2, 2, PlayingTeam.GuestTeam);
            WinningTeamTestHelper(0, 2, 3, PlayingTeam.GuestTeam);
            WinningTeamTestHelper(1, 2, 3, PlayingTeam.GuestTeam);
            WinningTeamTestHelper(0, 3, 4, PlayingTeam.GuestTeam);
            WinningTeamTestHelper(1, 3, 4, PlayingTeam.GuestTeam);
            WinningTeamTestHelper(0, 3, 5, PlayingTeam.GuestTeam);
            WinningTeamTestHelper(1, 3, 5, PlayingTeam.GuestTeam);
            WinningTeamTestHelper(2, 3, 5, PlayingTeam.GuestTeam);
        }

        private void WinningTeamTestHelper(int homeGames, int guestGames, int totalGames, PlayingTeam expectedWinningTeam)
        {
            var noneGames = totalGames - homeGames - guestGames;
            if (noneGames < 0)
                throw new ArgumentException("Totalt antal set är mindre än hemmaset + bortaset");

            var m = new Match();

            for (int i = 0; i < homeGames; i++)
            {
                var homeGame = new Game() { HomeScore = 11, GuestScore = 0 };
                Assert.AreEqual(PlayingTeam.HomeTeam, homeGame.WinningTeam);

                m.Games.Add(homeGame);
            }

            for (int i = 0; i < guestGames; i++)
            {
                var guestGame = new Game() { HomeScore = 0, GuestScore = 11 };
                Assert.AreEqual(PlayingTeam.GuestTeam, guestGame.WinningTeam);

                m.Games.Add(guestGame);
            }

            for (int i = 0; i < noneGames; i++)
            {
                var noneGame = new Game();
                Assert.AreEqual(PlayingTeam.None, noneGame.WinningTeam);

                m.Games.Add(noneGame);
            }

            Assert.AreEqual(expectedWinningTeam, m.WinningTeam);
        }
    }
}
