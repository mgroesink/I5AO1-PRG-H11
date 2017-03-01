using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Inheritance
{
    public class Bubble : Sphere
    {
        #region Fields and Properties
        protected int radius = 60;

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        public int Size
        {
            set
            {
                radius = value;
                UpdateEllipse(); // Calls the UpdateEllipse method from the parent
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Bubble"/> class.
        /// </summary>
        /// <param name="drawingCanvas">The drawing canvas.</param>
        public Bubble(Canvas drawingCanvas)
        {
            base.CreateEllipse(drawingCanvas);
            ellipse.MouseUp += Ellipse_MouseUp;
        }
        #endregion

        #region Eventhandlers

        private void Ellipse_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MoveVertical(10);

        }
        #endregion

        #region Methods
        /// <summary>
        /// Updates the ellipse.
        /// </summary>
        public override void UpdateEllipse()
        {
            if (ellipse != null)
            {
                ellipse.Margin = new Thickness(xCoord, yCoord, 0, 0);
                ellipse.Width = 2 * radius;
                ellipse.Height = 2 * radius;
            }

        }
       
        /// <summary>
        /// Moves the ellipse in vertical direction.
        /// </summary>
        /// <param name="amount">The amount of pixels to move.</param>
        public void MoveVertical(int amount)
        {
            yCoord += amount;
            UpdateEllipse();
        } 
        #endregion

    }
}