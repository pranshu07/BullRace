using System.Windows.Forms;

namespace BullRace
{
    public class Pranshu : Punter
    {
        public Pranshu(Bet MyBet, Label MaximumBet, int Money, Label MyLabel) : base(MyBet, MaximumBet, Money, MyLabel)
        {
        }

        public override void setPunterName()
        {
            Title = "Pranshu";
        }
    }

    public class Sachin : Punter
    {
        public Sachin(Bet bet, Label MaximumBet, int Money, Label label) : base(bet, MaximumBet, Money, label)
        {
        }

        public override void setPunterName()
        {
            Title = "Sachin";
        }
    }

    public class Kumar : Punter
    {
        public Kumar(Bet bet, Label MaximumBet, int Money, Label label) : base(bet, MaximumBet, Money, label)
        {
        }

        public override void setPunterName()
        {
            Title = "Kumar";
        }
    }
}
