﻿using System;
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
            int cmdX = 0, cmdY = 0;
            string errorMessage = string.Empty;
            Boolean runFlag = true;
            //storing all inputCommand in array and converting string into lowerCase using for loop (we can use different loop as per our requirment.)
            //in other words, string is converted into commands.
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

                        //moveto command 
                        if (firstArrCommand[j].ToString().Trim().Equals("moveto"))
                        {
                            //check if the three value enter where, firstvalue = "moveto" 2nd and 3rd value are numbers
                            if (firstArrCommand.Count() != 3)
                            {
                                //error message for invalid and break the loop.
                                errorMessage = errorMessage + "Command no. " + (i + 1).ToString() + " is invalid!\n";
                                runFlag = false;
                                break;
                            }
                            else
                            {
                                //check condition for x parameter is number or not
                                if (checkNumber(firstArrCommand[j + 1].Trim(), ref cmdX))
                                {
                                    //check condition for y parameter is number or not
                                    if (checkNumber(firstArrCommand[j + 2].Trim(), ref cmdY))
                                    {
                                        //if both x and y is number than pass to moveto function
                                        if (runFlag)
                                        {
                                            //all condition pass than go to perform task
                                            MovePoint(cmdX, cmdY);
                                        }
                                    }
                                    else
                                    {
                                        //Y parameter is not number than this error message will display
                                        errorMessage = errorMessage + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                        //program run flag will be false
                                        runFlag = false;
                                    }
                                }
                                else
                                {
                                    // parameter is not number than this error message will display
                                    errorMessage = errorMessage + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                    //program run flag will be false
                                    runFlag = false;
                                }
                                j = j + 2;
                            }
                        }

                        //rect command
                        else if (firstArrCommand[j].ToString().Trim().Equals("rect"))
                        {
                            //check if the three value enter where, firstvalue = "rect", 2nd and 3rd value are numbers.
                            if (firstArrCommand.Count() != 3)
                            {
                                //error messgae and break the loop
                                errorMessage= errorMessage+ "Invalid no of argument at command " + (i + 1).ToString() + "!\n";
                                runFlag = false;
                                break;
                            }
                            else
                            {
                                //check condition for x parameter is number or not
                                if (checkNumber(firstArrCommand[j + 1].Trim(), ref cmdX))
                                {
                                    //check condition for y parameter is number or not
                                    if (checkNumber(firstArrCommand[j + 2].Trim(), ref cmdY))
                                    {
                                        //if both x and y is number than pass to DrawRect function
                                        if (runFlag)
                                        {
                                            //all condition pass than go to perform task
                                            DrawRect(cmdX, cmdY);
                                        }
                                    }
                                    else
                                    {
                                        //height parameter is not number than this error message will display
                                        errorMessage = errorMessage + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                        //program run flag will be false
                                        runFlag = false;
                                    }
                                }
                                else
                                {
                                    //height parameter is not number than this error message will display
                                    errorMessage = errorMessage + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                    //program run flag will be false
                                    runFlag = false;
                                }
                                j = j + 2;
                            }
                        }
                        else
                        {
                            //error message display not enter a valid command
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


        //check pass parameter is number of not?
        private Boolean checkNumber(string no, ref int val)
        {
            //inital boolean for isNumber is false
            Boolean isNumber = false;
            if (int.TryParse(no.Trim(), out val))
                isNumber = true;
            return isNumber;
        }

    }
}
