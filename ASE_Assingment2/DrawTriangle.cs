using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Assingment2
{
    /// <summary>
    /// Represents a class for drawing triangles, derived from the base Shape class.
    /// </summary>
    public class DrawTriangle : Shape
    {
        // Array to store the vertices of the triangle
        private Point[] pnt;

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawTriangle"/> class with specified vertices.
        /// </summary>
        /// <param name="pnt">An array of points representing the vertices of the triangle.</param>
        public DrawTriangle(Point[] pnt)
        {

            this.pnt = pnt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawTriangle"/> class with default values.
        /// </summary>
        public DrawTriangle() { }

        /// <summary>
        /// Sets the position and vertices of the triangle.
        /// </summary>
        /// <param name="x">The x-coordinate of the triangle.</param>
        /// <param name="y">The y-coordinate of the triangle.</param>
        /// <param name="points">An array of points representing the vertices of the triangle.</param>
        public override void setTriangle(int x, int y, Point[] points)
        {
            base.set(x, y);
            this.pnt = points;
        }

        /// <summary>
        /// Draws the triangle on the specified graphics context using the provided pen and brush.
        /// </summary>
        /// <param name="g">The graphics context on which to draw the triangle.</param>
        /// <param name="pen">The pen used for drawing the triangle outline.</param>
        /// <param name="brush">The brush used for filling the triangle.</param>
        public override void Draw(Graphics g, Pen pen, Brush brush)
        {
            // Draw the triangle outline
            g.DrawPolygon(pen, pnt);

            // Fill the triangle with the specified brush
            g.FillPolygon(brush, pnt);
        }
    }
}
