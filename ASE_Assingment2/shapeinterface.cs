using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Assingment2
{
    interface ShapeInterface
    {
        void set(params int[] list);
        void setTriangle(int x, int y, Point[] points);
        void Draw(Graphics g, Pen pen, Brush brush);

    }
}
