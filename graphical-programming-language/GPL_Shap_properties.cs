using System;
using System.Collections.Generic;
using System.Drawing;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace graphical_programming_language
{
 /// <summary>
 /// this class contain all properties is either used or will be used in future
 /// </summary>
    public class GPL_Shap_properties
    {
        /// <summary>
        /// variable declared for the function
        /// </summary>
        private static int _x, _y;
        static private Bitmap _NewPicture = new Bitmap(640, 480);
        static SolidBrush _FillColor;
        static Boolean _isFill;
        static Boolean _isUnitTestValid;
        static Color _penColor;


        /// <summary>
        /// setup x-axis value of the cursor
        /// </summary>
        public static int x
        {
            get
            { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// setup y-axis value of the drawing cursor
        /// </summary>
        public static int y
        {
            get
            { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// setup the bitmap of the picture
        /// </summary>
        public static Bitmap NewPicture
        {
            get
            {
                return _NewPicture;
            }
            set { _NewPicture = value; }
        }

       
        public static SolidBrush FillColor
        {
            get
            {
                return _FillColor;
            }
            set { _FillColor = value; }
        }
        /// <summary>
        /// to check the page is filled or not
        /// </summary>

        public static Boolean isFill
        {
            get
            {
                return _isFill;
            }
            set { _isFill = value; }
        }

        /// <summary>
        /// to check if the unit test is vallid or not 
        /// </summary>
        public static Boolean isUnitTestValid
        {
            get { return _isUnitTestValid; }
            set { _isUnitTestValid = value; }
        }

        /// <summary>
        /// set the pen color to draw
        /// </summary>
        public static Color penColor
        {
            get { return _penColor; }
            set { _penColor = value; }
        }

    }
}
