using System;
using System.Windows.Forms;

namespace BullRace
{
    public class PunterFactory
    {
        public Punter getPunter(String Name, Label MaximumBet, Label bet)
        {
            Punter p;
            switch (Name.ToLower())
            {
                case "pranshu":
                    p = new Pranshu(null, MaximumBet, 50, bet);
                    break;

                case "kumar":
                    p = new Kumar(null, MaximumBet, 50, bet);
                    break;

                case "sachin":
                    p = new Sachin(null, MaximumBet, 50, bet);
                    break;

                default:
                    p = null;
                    break;
            }
            p.setPunterName();
            return p;
        }
    }
}
