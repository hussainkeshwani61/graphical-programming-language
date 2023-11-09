using System;
using System.Collections.Generic;
using System.Drawing;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphical_programming_language
{
    internal class GPL_Shap_properties
    {
        private static int _x, _y;
        static private Bitmap _NewPicture = new Bitmap(640, 480);
        static SolidBrush _FillColor;
        static Boolean _isFill;
        static Boolean _isUnitTestValid;
        static Color _penColor;


        public static int x
        {
            get
            { return _x; }
            set { _x = value; }
        }

        public static int y
        {
            get
            { return _y; }
            set { _y = value; }
        }

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

        public static Boolean isFill
        {
            get
            {
                return _isFill;
            }
            set { _isFill = value; }
        }

        public static Boolean isUnitTestValid
        {
            get { return _isUnitTestValid; }
            set { _isUnitTestValid = value; }
        }


        public static Color penColor
        {
            get { return _penColor; }
            set { _penColor = value; }
        }

    }
}
