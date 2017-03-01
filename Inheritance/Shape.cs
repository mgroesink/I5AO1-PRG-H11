using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Shape
    {
        #region Fields and properties
        protected int xCoord, yCoord;
        protected int size;
        #endregion

        #region Abstract methods
        public abstract void CreatePhysicalShape();
        public abstract void UpdatePhysicalShape();
        #endregion
        #region Methods
        public void MoveRight()
        {
            xCoord += 10; // Move 10 Device Independant Units (diu) to the right
            UpdatePhysicalShape();
        } 
        #endregion

    }

}
