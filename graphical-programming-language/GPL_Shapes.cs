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

            //storing all inputCommand in array and converting string into lowerCase using for loop (we can use different loop as per our requirment.)
            //in other words, string is converted into commands.
           .
            string[] arrCommand = inputCommand.ToLower().Split(new string[] { ";" }, StringSplitOptions.None);
            string[] firstArrCommand;

            for(int i = 0; i < arrCommand.Count(); i++)
            {

                if (arrCommand[i].Trim().ToString() != string.Empty)
                {
                    //remove extra space from the code
                    firstArrCommand = arrCommand[i].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int j = 0; j < firstArrCommand.Count(); j++)
                    {
                        // every run commands goes hear
                        if (firstArrCommand[j].Trim().ToString() != string.Empty)
                        {

                        } else
                        {
                            errorMessage = errorMessage + "Please, Enter a Valid Command!" + (i + 1).ToString();
                            
                        }
                    }
                }
            }

            /**
             * errorMessage value gets from above for loop 
             */
            if (errorMessage.Trim() != string.Empty)
            {
                // *** this function is not done yet 
                PrintMessage(errorMessage);
            }

        }

        
    }
}
