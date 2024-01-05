using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASE_Assingment2
{
    public partial class Form1 : Form
    {

        private int x = 0, y = 0;

        //for partition
        private string[] splitw;
        private string[] parm = new string[50];
        private int[] strSplit = new int[50];
        private int[] strError = new int[50];

        //looping 
        private int loopmax;
        private int loopstart;
        private int loopfinish;
        private int loopcount;
        private int errorno = 0;


        //flag bits
        private bool lbit = false;
        private bool ifrslt = false;
        private bool strif = false;
        private bool condn = false;

        //universal colour
        private Color pencolor = Color.Black;
        private Color brushcolor = Color.Cyan;
        private Random rndm = new Random();

        //Shape Factory
        private Shape shape1;
        private ShapeFactory factory = new ShapeFactory();




        public Form1()
        {
            InitializeComponent();
            display.Image = new Bitmap(Size.Width, Size.Height);
        }
    }
}
