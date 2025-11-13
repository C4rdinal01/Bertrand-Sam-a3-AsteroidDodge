using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Stars
    {

        float[] starPositions;

        bool areStarsDrawn = false;
        int StarsCount = 0;

        public void Setup()
        {

        }

        public void Update()
        {
            DrawStar();
        }

        public void DrawStar()
        {
            if (StarsCount <= 60)
            {
                Draw.FillColor = new Color("#FCFC12EE");
                Draw.Ellipse(Random.Float(0, 400), Random.Float(0, 400), 5, 5);

                StarsCount += 1;

                areStarsDrawn = false;
                return;

                // I want to add the random floats made here to the 'starPositions' array to keep their place
            }
            else if (StarsCount >= 60)
            {
                areStarsDrawn = true;
            }
        }
    }
}
