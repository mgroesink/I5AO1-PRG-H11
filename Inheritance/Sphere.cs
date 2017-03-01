using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Inheritance
{
    /// <summary>
    /// Base class for different kinds of sphere objects
    /// </summary>
    public class Sphere
    {
        #region Fields and Properties
        protected int xCoord = 100;
        protected int yCoord = 100;
        protected Ellipse ellipse;

        /// <summary>
        /// Sets the x coordinate.
        /// </summary>
        /// <value>
        /// The x coordinate.
        /// </value>
        protected int X
        {
            set
            {
                this.xCoord = value;
            }
        }

        /// <summary>
        /// Sets the y coordinate.
        /// </summary>
        /// <value>
        /// The y coordinate.
        /// </value>
        protected int Y
        {
            set
            {
                this.yCoord = value;
            }
        }


        #endregion

        #region Methods
        /// <summary>
        /// Creates the ellipse and draws it on the given canvas.
        /// </summary>
        /// <param name="drawingCanvas">The drawing canvas.</param>
        public virtual void CreateEllipse(Canvas drawingCanvas)
        {
            ellipse = new Ellipse();
            ellipse.Fill = new SolidColorBrush(Colors.Beige);
            ellipse.Stroke = new SolidColorBrush(Colors.Black);
            ellipse.StrokeThickness = 2;
            ellipse.Width = 40;
            ellipse.Height = 40;
            ellipse.Margin = new System.Windows.Thickness(xCoord, yCoord, 0, 0);
            drawingCanvas.Children.Add(ellipse);
        }

        /// <summary>
        /// Updates the ellipse.
        /// </summary>
        public virtual void UpdateEllipse()
        {
            if (ellipse != null)
            {
                ellipse.Margin = new System.Windows.Thickness(xCoord, yCoord, 0, 0);
            }
        }
        #endregion

    }
}
