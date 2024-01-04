using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Assingment2
{
    public class DrawSquare : DrawRectangle
    {
        readonly int size;
        public DrawSquare(int x, int y, int size) : base(x, y, size, size)
        {

            this.size = size;
        }


        public override void Draw(Graphics g, Pen pen, Brush brush)
        {
            base.Draw(g, pen, brush);
        }
    }
}
