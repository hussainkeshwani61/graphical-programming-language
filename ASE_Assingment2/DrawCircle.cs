using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Assingment2
{
    /// <summary>
    /// Represents a class for drawing circles, derived from the base Shape class.
    /// </summary>
    public class DrawCircle : Shape
    {
        // Radius of the circle
        int radius;

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawCircle"/> class with specified coordinates and radius.
        /// </summary>
        /// <param name="x">The x-coordinate of the circle.</param>
        /// <param name="y">The y-coordinate of the circle.</param>
        /// <param name="radius">The radius of the circle.</param>
        public DrawCircle(int x, int y, int radius) : base(x, y)
        {

            this.radius = radius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawCircle"/> class with specified radius.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        public DrawCircle(int radius)
        {
            this.radius = radius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawCircle"/> class with default values.
        /// </summary>
        public DrawCircle() : base()
        {
        }

        /// <summary>
        /// Draws the circle on the specified graphics context using the provided pen and brush.
        /// </summary>
        /// <param name="g">The graphics context on which to draw the circle.</param>
        /// <param name="pen">The pen used for drawing the circle outline.</param>
        /// <param name="brush">The brush used for filling the circle.</param>
        public override void Draw(Graphics g, Pen pen, Brush brush)
        {

            // Fill the circle with the specified brush
            g.FillEllipse(brush, x, y, radius * 2, radius * 2);

            // Draw the circle outline with the specified pen
            g.DrawEllipse(pen, x, y, radius * 2, radius * 2);

        }

        /// <summary>
        /// Sets the position and radius of the circle.
        /// </summary>
        /// <param name="list">A list of integers representing the coordinates and radius.</param>
        public override void set(params int[] list)
        {
            //list[0] is x, list[1] is y, list[2] is radius
            base.set(list[0], list[1]);
            this.radius = list[2];

        }

        /// <summary>
        /// Returns a string representation of the circle's position and radius.
        /// </summary>
        /// <returns>A string containing the coordinates and radius of the circle.</returns>
        public override string ToString()
        {
            return base.ToString() + "  " + this.radius;
        }
    }
}
