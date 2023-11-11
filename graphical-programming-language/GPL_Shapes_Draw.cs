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
        //declare variables 
        Graphics g;
        int x, y;
        Pen p;
        Rectangle CuurPos;
        Rectangle CurrShape;

        //construct functions
        public GPL_Shapes_Draw()
        {
            this.g = Graphics.FromImage(GPL_Shap_properties.NewPicture);
            //create pen object
            p = new Pen(Color.Black, 1);
            //get properties value of x and y parameter
            x = GPL_Shap_properties.x;
            y = GPL_Shap_properties.y;
        }

        //function to DrawSquare same as rectangle
        public void DrawSquare(int width)
        {
            try
            {
                int xpos = x - (width / 2);
                int ypos = y - (width / 2);
                CurrShape = new Rectangle(xpos, ypos, width, width);
                if (GPL_Shap_properties.isFill)
                    this.g.FillRectangle(GPL_Shap_properties.FillColor, CurrShape);
                this.g.DrawRectangle(p, CurrShape);
                GPL_Shap_properties.isUnitTestValid = true;
            }
            catch (Exception ex)
            {
                PrintMessage(ex.Message);
                GPL_Shap_properties.isUnitTestValid = false;
            }
        }


        //function to MovePoint from point A to Point B based on two parameters
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

        //function to draw shap of rectangle with two parameter widht and height
        public void DrawRect(int width, int height)
        {
            try
            {
                int xpos = x - (width / 2);
                int ypos = y - (height / 2);
                CurrShape = new Rectangle(xpos, ypos, width, height);
                if (GPL_Shap_properties.isFill)
                    this.g.FillRectangle(GPL_Shap_properties.FillColor, CurrShape);
                this.g.DrawRectangle(p, CurrShape);
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
       
        //bring cursor to origin position on left
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
