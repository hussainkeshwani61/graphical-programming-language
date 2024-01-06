using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Assingment2
{
    /// <summary>
    /// Represents an abstract base class for shapes implementing ShapeInterface.
    /// </summary>
    public abstract class Shape : ShapeInterface
    {
        // Fields for the position of the shape
        protected int x, y;
       
        /// <summary>
        /// Initializes a new instance of the <see cref="Shape"/> class with specified coordinates.
        /// </summary>
        /// <param name="x">The x-coordinate of the shape.</param>
        /// <param name="y">The y-coordinate of the shape.</param>
        public Shape(int x, int y)
        {

            this.x = x;
            this.y = y;

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Shape"/> class with default coordinates.
        /// </summary>
        public Shape()
        {
        }

        /// <summary>
        /// Sets the position of the shape using a variable number of integer parameters.
        /// </summary>
        /// <param name="list">A list of integers representing the coordinates.</param>
        public virtual void set(params int[] list)
        {

            this.x  = list[0];
            this.y = list[1];

        }

        /// <summary>
        /// Sets the position of a triangle shape.
        /// </summary>
        /// <param name="x">The x-coordinate of the shape.</param>
        /// <param name="y">The y-coordinate of the shape.</param>
        /// <param name="points">An array of points representing the vertices of the triangle.</param>
        public virtual void setTriangle(int x, int y, Point[] points)
        {
            this.x = x;
            this.y = y;

        }

        /// <summary>
        /// Draws the shape on the specified graphics context using the provided pen and brush.
        /// </summary>
        /// <param name="g">The graphics context on which to draw the shape.</param>
        /// <param name="pen">The pen used for drawing the shape outline.</param>
        /// <param name="brush">The brush used for filling the shape.</param>
        public abstract void Draw(Graphics g, Pen pen, Brush brush);

        /// <summary>
        /// Returns a string representation of the shape's position.
        /// </summary>
        /// <returns>A string containing the coordinates of the shape.</returns>
        public override string ToString()
        {
            return base.ToString() + "    " + this.x + "," + this.y + " : ";
        }


    }
}
