using System;
using System.Windows.Forms;

namespace BullRace
{
    public partial class Form1 : Form
    {
        Bull[] Bulls = new Bull[4];

        PunterFactory pFactory = new PunterFactory();
        Punter[] punters = new Punter[3];

        public Form1()
        {
            InitializeComponent();
            SetupRaceTrack();
        }

        private void SetupRaceTrack()
        {

            Bull.StartingPosition1 = Bull1.Right - racetrack.Left;
            Bull.RacetrackLength1 = racetrack.Size.Width - 70; //fixing length of race - till finish line

            Bulls[0] = new Bull() { BullPictureBox = Bull1 };
            Bulls[1] = new Bull() { BullPictureBox = Bull2 };
            Bulls[2] = new Bull() { BullPictureBox = Bull3 };
            Bulls[3] = new Bull() { BullPictureBox = Bull4 };

            punters[0] = pFactory.getPunter("Pranshu", MaximumBet, PranshuBet); //getting Pranshu object from factory class
            punters[1] = pFactory.getPunter("Kumar", MaximumBet, KumarBet); //getting Kumar object from factory class
            punters[2] = pFactory.getPunter("Sachin", MaximumBet, SachinBet); //getting Sachin object from factory class


            foreach (Punter punter in punters)
            {
                punter.UpdateLabels();
            }
        }

        private void PranshuButton_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(punters[0].money);
        }

        private void KumarButton_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(punters[1].money);
        }

        private void SachineButton_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(punters[2].money);
        }

        private void setMaximumBetTextLabel(int Cash)
        {
            MaximumBet.Text = string.Format("Maximum Bet: ${0}", Cash);
        }

        // setting the bet for each Punter and updating labels respectively
        private void Bets_Click(object sender, EventArgs e)
        {
            int PunterNum = 0;

            if (PranshuButton.Checked)
            {
                PunterNum = 0;
            }
            if (KumarButton.Checked)
            {
                PunterNum = 1;
            }
            if (SachinButton.Checked)
            {
                PunterNum = 2;
            }

            punters[PunterNum].PlaceBet((int)BettingAmount.Value, (int)BullNumber.Value);
            punters[PunterNum].UpdateLabels();
        }

        private void race_Click(object sender, EventArgs e)
        {
            bool NoWinner = true;
            int winningBull;
            race.Enabled = false; //disable start race button

            while (NoWinner)
            { // loop until we have a winner
                Application.DoEvents();
                for (int i = 0; i < Bulls.Length; i++)
                {
                    if (Bull.Run(Bulls[i]))
                    {
                        winningBull = i + 1;
                        NoWinner = false;
                        MessageBox.Show("We have a winner - Bull #" + winningBull);
                        foreach (Punter punter in punters)
                        {
                            if (punter.gamble != null)
                            {
                                punter.Collect(winningBull); //give double amount to all who've won or deduce betted amount
                                punter.gamble = null;
                                punter.UpdateLabels();
                            }
                        }
                        foreach (Bull Bull in Bulls)
                        {
                            Bull.StartPosition();
                        }
                        break;
                    }
                }
            }
            if (punters[0].busted && punters[1].busted && punters[2].busted)
            {  //stop punters from betting if they run out of cash
                string message = "Do you want to Play Again?";
                string title = "GAME OVER!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    SetupRaceTrack(); //restart game
                }
                else
                {
                    Close();
                }

            }
            race.Enabled = true; //enable race button 
        }

    }
}
