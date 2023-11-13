using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphical_programming_language
{
    public class CommonFunction
    {
        /// <summary>
        /// this function is to check enter value is number or not
        /// </summary>
        /// <param name="no">this is string </param>
        /// <param name="val">this is its value</param>
        /// <returns></returns>
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
