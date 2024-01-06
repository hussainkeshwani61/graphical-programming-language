using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Assingment2
{
    /// <summary>
    /// Represents a class for drawing rectangles, derived from the base Shape class.
    /// </summary>
    public class DrawRectangle : Shape
    {
        // Width and height of the rectangle
        private int width;
        private int height;

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawRectangle"/> class with specified coordinates, width, and height.
        /// </summary>
        /// <param name="x">The x-coordinate of the rectangle.</param>
        /// <param name="y">The y-coordinate of the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        public DrawRectangle(int x, int y, int width, int height) : base(x, y)
        {

            this.width = width;
            this.height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawRectangle"/> class with default values.
        /// </summary>
        public DrawRectangle() { }

        /// <summary>
        /// Sets the position of the rectangle and its dimensions using a variable number of integer parameters.
        /// </summary>
        /// <param name="list">A list of integers representing the coordinates, width, and height.</param>
        public override void set(params int[] list)
        {
            base.set(list[0], list[1]);
            this.width = width;
            this.height = height;
        }

        /// <summary>
        /// Draws the rectangle on the specified graphics context using the provided pen and brush.
        /// </summary>
        /// <param name="g">The graphics context on which to draw the rectangle.</param>
        /// <param name="pen">The pen used for drawing the rectangle outline.</param>
        /// <param name="brush">The brush used for filling the rectangle.</param>
        public override void Draw(Graphics g, Pen pen, Brush brush)
        {
            // Fill the rectangle with the specified brush
            g.FillRectangle(brush, x, y, width, height);

            // Draw the rectangle outline with the specified pen
            g.DrawRectangle(pen, x, y, width, height);
        }
    }
}
