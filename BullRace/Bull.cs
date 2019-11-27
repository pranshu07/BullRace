using System;
using System.Drawing;
using System.Windows.Forms;

namespace BullRace
{
    public class Bull
    {
        private static int StartingPosition;
        private static int RacetrackLength;
        public PictureBox BullPictureBox = null;
        public int Location = 0;
        public static Random MyRandom = new Random(); //declared random object as static to avoid same random number

        public static int StartingPosition1 { get => StartingPosition; set => StartingPosition = value; }
        public static int RacetrackLength1 { get => RacetrackLength; set => RacetrackLength = value; }

        // generation across all Bull objects

        public static bool Run(Bull obj)
        {
            int distance = MyRandom.Next(1, 10);
            if (obj.BullPictureBox != null)
                obj.MoveBullPictureBox(distance);

            obj.Location += distance;
            if (obj.Location >= (RacetrackLength1 - StartingPosition1))
            {
                return true;
            }
            return false;
        }

        public void StartPosition()
        {
            MoveBullPictureBox(-Location); //reset location to -ve distance ie. to starting point
            Location = 0;

        }

        public void MoveBullPictureBox(int distance)
        {
            Point p = BullPictureBox.Location;
            p.X += distance;
            BullPictureBox.Location = p; //move Bull in x-axis
        }
    }
}
