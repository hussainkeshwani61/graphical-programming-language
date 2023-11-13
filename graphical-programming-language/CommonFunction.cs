using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphical_programming_language
{
    public class CommonFunction
    {
        public Boolean checkNumber(string no, ref int val)
        {
            //inital boolean for isNumber is false
            Boolean isNumber = false;
            if (int.TryParse(no.Trim(), out val))
                isNumber = true;
            return isNumber;
        }

        public bool CheckArrayLength(string[] arr)
        {
            return arr.Count() == 3 ? true : false;
        }

    }
}
