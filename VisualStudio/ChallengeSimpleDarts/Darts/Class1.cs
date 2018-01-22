using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        Random FivePercent = new Random();

        public int Throw(int DartThrow)
        {

            // Throw method must pass an instance of random. When this method is called it will simulate a throw.
            // Must have an equal chance to hit 0 - 20
            // 5% for double band, 5% for triple band
            // 5% for inner bullseye (0)



            if (DartThrow == 0)  //If bullseye, need to allow a 5% chance of getting inner ring
            {
                if (FivePercent.Next(1, 20) == 1)
                    Score = 50;

                else Score = 25;

                BullsEye += 1;
            }
            if (DartThrow != 0)
            {
                if (FivePercent.Next(1, 20) == 1)  // A 1/20 chance of getting double
                {
                    DoubleBand += 1;
                    Score = DartThrow * 2;
                }

                else if (FivePercent.Next(1, 20) == 2)  // A 1/20 chance of getting triple
                {
                    TripleBand += 1;
                    Score = DartThrow * 3;
                }
                    
                else this.Score = DartThrow;  // Otherwise, the score is the number you landed on.

            }
            return Score;
        }
        public int BullsEye { get; set; }
        public int DoubleBand { get; set; }
        public int TripleBand { get; set; }
        public int Score { get; set; }
    }
}
