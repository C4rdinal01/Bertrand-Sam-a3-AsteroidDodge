using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class ScoreCounter
    {

        int scoreNumber = 0;

        public void Setup()
        {
            Text.Color = Color.White;
            Text.Size = 3;
            Text.Draw("Score:" + scoreNumber, 5, 5);
        }

        public void Update()
        {

        }

        public void Scoring()
        {
            // if an asteroid passes through the bottom of the screen, scoreNumber++

            // alternatively it could increase every second the player lives so;
            // scoreNumber = Time.SecondsElapsed <- or something like this
        }
    }
}
