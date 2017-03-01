using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    public class DifferentBalloon : Balloon
    {
        public DifferentBalloon(int initialX, int initialY):base()
        {
            xCoord = initialX;
            yCoord = initialY;
            radius = 20;
        }
    }
}