using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Assingment2
{
    /// <summary>
    /// Represents a class for drawing squares, derived from the DrawRectangle class.
    /// </summary>
    public class DrawSquare : DrawRectangle
    {
        // Size of the square (both width and height)
        readonly int size;
       
        /// <summary>
        /// Initializes a new instance of the <see cref="DrawSquare"/> class with specified coordinates and size.
        /// </summary>
        /// <param name="x">The x-coordinate of the square.</param>
        /// <param name="y">The y-coordinate of the square.</param>
        /// <param name="size">The size of the square (both width and height).</param>
        public DrawSquare(int x, int y, int size) : base(x, y, size, size)
        {

            this.size = size;
        }

        /// <summary>
        /// Draws the square on the specified graphics context using the provided pen and brush.
        /// </summary>
        /// <param name="g">The graphics context on which to draw the square.</param>
        /// <param name="pen">The pen used for drawing the square outline.</param>
        /// <param name="brush">The brush used for filling the square.</param>
        public override void Draw(Graphics g, Pen pen, Brush brush)
        {
            base.Draw(g, pen, brush);
        }
    }
}
