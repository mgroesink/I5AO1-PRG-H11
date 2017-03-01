using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Inheritance
{
    public class Ball : Sphere
    {

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Ball"/> class.
        /// </summary>
        /// <param name="drawingCanvas">The drawing canvas.</param>
        public Ball(Canvas drawingCanvas)
        {
            base.CreateEllipse(drawingCanvas);
            ellipse.MouseLeftButtonUp += Ellipse_MouseLeftButtonUp;
            ellipse.MouseRightButtonUp += Ellipse_MouseRightButtonUp;
        } 
        #endregion

        #region Eventhandlers
        /// <summary>
        /// Handles the MouseLeftButtonUp event of the Ellipse control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Input.MouseButtonEventArgs"/> instance containing the event data.</param>
        private void Ellipse_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MoveRight(10);
        }

        /// <summary>
        /// Handles the MouseRightButtonUp event of the Ellipse control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Input.MouseButtonEventArgs"/> instance containing the event data.</param>
        private void Ellipse_MouseRightButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MoveLeft(10);
        } 
        #endregion
        
        #region Methods
        /// <summary>
        /// Moves the ball to the left.
        /// </summary>
        /// <param name="amount">The amount of pixels to move.</param>
        public void MoveLeft(int amount)
        {
            xCoord -= amount;
            UpdateEllipse();
        }

        /// <summary>
        /// Moves the ball to the right.
        /// </summary>
        /// <param name="amount">The amount of pixels to move.</param>
        public void MoveRight(int amount)
        {
            xCoord += amount;
            UpdateEllipse();
        } 
        #endregion


    }
}