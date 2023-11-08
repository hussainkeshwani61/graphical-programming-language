using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphical_programming_language
{
    internal class GPL_Shapes : GPL_Shapes_Draw
    {
        //get input from user when run button clicked!.
        public void runCommand(string inputCommand)
        {
            //seting up all axis at zero and strings at empty at initial face..
            //int cmdX = 0, cmdY = 0, cmdz = 0;
            string errorMessage = string.Empty;

            //storing all inputCommand in array and converting into single line commands using for loop (we can use different loop as per our requirment..)
            string[] arrCommand = inputCommand.ToLower().Split(new string[] { ";" }, StringSplitOptions.None);
            string[] arg1;

            for(int i = 0; i < arrCommand.Count(); i++)
            {
                /*
                 * /hear the whole main runCommand for single line and multiple line goes
                 *  and error message change as per condition and pass to PrintMessage function to pring messge
                 */

                //remove empty space from string.
                arg1 = arrCommand[i].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (arg1.Count() == 1)
                {
                    //program for single line start hear
                } 
                else
                {
                    //program for multiple line start hear
                }
            }

            //errorMessage was empty at first, but after passing from forLoop it has its message..
            if (errorMessage.Trim() != string.Empty)
            {
                //PrintMessage(inputCommand);
            }

        }

        
    }
}
