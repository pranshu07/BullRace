using BullRace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BullRaceTest
{
    [TestClass]
    public class UnitTest1
    {
        PunterFactory objFactory = new PunterFactory();
        Punter Pranshu;
        Bull[] Bulls = new Bull[2];

        [TestMethod]
        public void TestWinnerOutcome()
        {
            Bull.StartingPosition1 = 0;
            Bull.RacetrackLength1 = 50;
            int BettingAmount = 50;
            int BullNumber = 1;
            int expectedWin = 100;
            int expectedLose = 0;
            Bulls[0] = new Bull() { BullPictureBox = null };
            Bulls[1] = new Bull() { BullPictureBox = null };
            Pranshu = objFactory.getPunter("Pranshu", null, null);
            Pranshu.money = BettingAmount;
            Pranshu.PlaceBet((int)BettingAmount, BullNumber);

            bool nowin = true;
            int win = -1;
            while (nowin)
            {
                for (int i = 0; i < Bulls.Length; i++)
                {
                    if (Bull.Run(Bulls[i]))
                    {
                        win = i + 1;
                        Pranshu.Collect(win);
                        nowin = false;

                    }
                }
            }
            if (Pranshu.gamble.BullNum == win)
            {
                Assert.AreEqual(expectedWin, Pranshu.money, "Account not credited correctly");
            }
            if (Pranshu.gamble.BullNum != win)
            {
                Assert.AreEqual(expectedLose, Pranshu.money, "Account not debited correctly");

            }
        }
    }

}
