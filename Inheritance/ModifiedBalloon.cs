using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    public class ModifiedBalloon : Balloon
    {
        public ModifiedBalloon(int initialX , int initialY , int radius) 
            :base(initialX , initialY , radius)
        {}
    }
}