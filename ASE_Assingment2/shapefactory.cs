using ASE_Assingment2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a factory for creating different shapes.
/// </summary>
class ShapeFactory
{
    /// <summary>
    /// Gets the specific shape based on the provided shape type.
    /// </summary>
    /// <param name="shapeType">The type of the shape to be created.</param>
    /// <returns>An instance of the specified shape.</returns>
    public Shape getShape(String shapeType)
    {
        // Convert shapeType to lowercase and remove leading/trailing spaces
        shapeType = shapeType.ToLower().Trim();
       
        // Check the shapeType and return the corresponding shape
        if (shapeType.Equals("circle"))
        {
            return new DrawCircle();

        }
        else if (shapeType.Equals("rect"))
        {
            return new DrawRectangle();

        }
        else if (shapeType.Equals("triangle"))
        {
            return new DrawTriangle();
        }
        else
        {
            // If the shapeType is not recognized, throw an ArgumentException
            System.ArgumentException argEx = new System.ArgumentException("Factory Exception occur : " + shapeType + " is not available");
            throw argEx;
        }


    }
}