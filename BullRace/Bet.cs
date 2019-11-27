namespace BullRace
{
    public class Bet
    {
        public int Amount;
        public int BullNum;
        public Punter Bettor;

        public Bet(int Amount, int BullNum, Punter Bettor)
        {
            this.Amount = Amount;
            this.BullNum = BullNum;
            this.Bettor = Bettor;
        }

        public string GetDescription()
        {
            string description = "";

            if (Amount > 0)
            {
                description = string.Format("{0} bets {1} on Bull #{2}",
                    Bettor.Title, Amount, BullNum);
            }
            else
            {
                description = string.Format("{0} hasn't placed any bets",
                    Bettor.Title);
            }
            return description;
        }

        public int Pay(int Winner)
        {
            if (BullNum == Winner)
            {
                return Amount;
            }
            return -Amount;
        }
    }
}
