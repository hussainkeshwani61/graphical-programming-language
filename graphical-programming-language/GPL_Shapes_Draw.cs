using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphical_programming_language
{
    internal class GPL_Shapes_Draw
    {
        Graphics g;
        int x, y;
        Pen p;
        Rectangle CuurPos;
        Rectangle CurrShape;


        public GPL_Shapes_Draw()
        {
            this.g = Graphics.FromImage(GPL_Shap_properties.NewPicture);
            p = new Pen(Color.Black, 1);
            x = GPL_Shap_properties.x;
            y = GPL_Shap_properties.y;
        }

        public void MovePoint(int xpos, int ypos)
        {
            try
            {
                p = new Pen(SystemColors.ActiveBorder, 2);
                this.g.DrawRectangle(p, CuurPos);
                p = new Pen(Color.Red, 2);
                CuurPos = GetRectangle(xpos, ypos, 2, 2);
                this.g.DrawRectangle(p, CuurPos);
                x = GPL_Shap_properties.x = xpos;
                y = GPL_Shap_properties.y = ypos;
                p = new Pen(Color.Black, 1);
                GPL_Shap_properties.isUnitTestValid = true;
            }
            catch (Exception ex)
            {
                PrintMessage(ex.Message);
                GPL_Shap_properties.isUnitTestValid = false;
            }
        }


        //this function will print every error message or the Graphical programming language application..
        public void PrintMessage(string message)
        {
            using (Font myFont = new Font("Arial", 8))
            {
                g.DrawString(message, myFont, Brushes.Black, new Point(5, 5));
            }
        }

        public void CurrPoint(Boolean flg)
        {
            p = new Pen(Color.Red, 2);
            if (flg)
            {
                CuurPos = GetRectangle(GPL_Shap_properties.x, GPL_Shap_properties.y, 2, 2);
                this.g.DrawRectangle(p, CuurPos);
            }
            else
            {
                x = y = 0;
                GPL_Shap_properties.x = GPL_Shap_properties.y = 0;
                CuurPos = GetRectangle(x, y, 2, 2);
                this.g.DrawRectangle(p, CuurPos);
            }
            p = new Pen(Color.Black, 1);
        }
        private Rectangle GetRectangle(int rx, int ry, int rwidth, int rheight)
        {
            return new Rectangle(rx, ry, rwidth, rheight);
        }
    }
}
