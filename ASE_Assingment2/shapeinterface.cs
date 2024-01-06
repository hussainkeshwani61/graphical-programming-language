using System.Drawing;
// ShapeInterface.cs
namespace ASE_Assingment2
{
    /// <summary>
    /// Interface defining methods for shape properties and drawing
    /// </summary>
    interface ShapeInterface
    {
        /// <summary>
        /// Set basic shape properties
        /// </summary>
        /// <param name="list">List of integers representing shape properties</param>
        void set(params int[] list);

        /// <summary>
        /// Set properties for a triangle
        /// </summary>
        /// <param name="x">X-coordinate of the triangle</param>
        /// <param name="y">Y-coordinate of the triangle</param>
        /// <param name="points">Array of points defining the triangle</param>
        
        void setTriangle(int x, int y, Point[] points);

        /// <summary>
        /// Draw the shape
        /// </summary>
        /// <param name="g">Graphics object for drawing</param>
        /// <param name="pen">Pen object for drawing the outline</param>
        /// <param name="brush">Brush object for filling the shape</param>
        void Draw(Graphics g, Pen pen, Brush brush);

    }
}



