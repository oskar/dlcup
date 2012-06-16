using DLCup.Common.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DLCup.Tests.UnitTest
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void WinningTeamTest()
        {
            WinningTeamTestHelper(null, null, PlayingTeam.None);
            WinningTeamTestHelper(0, null, PlayingTeam.None);
            WinningTeamTestHelper(null, 0, PlayingTeam.None);
            WinningTeamTestHelper(0, 0, PlayingTeam.None);
            WinningTeamTestHelper(11, null, PlayingTeam.None);
            WinningTeamTestHelper(null, 11, PlayingTeam.None);

            WinningTeamTestHelper(1, 1, PlayingTeam.None);
            WinningTeamTestHelper(9, 9, PlayingTeam.None);
            WinningTeamTestHelper(10, 10, PlayingTeam.None);
            WinningTeamTestHelper(11, 11, PlayingTeam.None);
            WinningTeamTestHelper(11, 10, PlayingTeam.None);
            WinningTeamTestHelper(10, 11, PlayingTeam.None);
            WinningTeamTestHelper(12, 12, PlayingTeam.None);

            WinningTeamTestHelper(11, 9, PlayingTeam.HomeTeam);
            WinningTeamTestHelper(11, 0, PlayingTeam.HomeTeam);
            WinningTeamTestHelper(12, 10, PlayingTeam.HomeTeam);
            WinningTeamTestHelper(13, 11, PlayingTeam.HomeTeam);
            WinningTeamTestHelper(14, 12, PlayingTeam.HomeTeam);

            WinningTeamTestHelper(9, 11, PlayingTeam.GuestTeam);
            WinningTeamTestHelper(0, 11, PlayingTeam.GuestTeam);
            WinningTeamTestHelper(10, 12, PlayingTeam.GuestTeam);
            WinningTeamTestHelper(11, 13, PlayingTeam.GuestTeam);
            WinningTeamTestHelper(12, 14, PlayingTeam.GuestTeam);
        }

        private void WinningTeamTestHelper(int? homeScore, int? guestScore, PlayingTeam expectedWinningTeam)
        {
            var g = new Game() { HomeScore = homeScore, GuestScore = guestScore };
            Assert.AreEqual(expectedWinningTeam, g.WinningTeam);
        }
    }
}
