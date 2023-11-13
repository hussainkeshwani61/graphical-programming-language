using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphical_programming_language
{
    public class GPL_Shapes : GPL_Shapes_Draw
    {

        private readonly CommonFunction commonFunction;

        public GPL_Shapes()
        {
            commonFunction = new CommonFunction();
        }

        //get input from user when run button clicked!.
        public void runCommand(string inputCommand)
        {
            //seting up all axis at zero and strings at empty at initial face..
            int cmdX = 0, cmdY = 0;
            int cmdz = 0;
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

                        //moveto start 
                        if (firstArrCommand[j].ToString().Trim().Equals("moveto"))
                        {
                            //check if the three value enter where, firstvalue = "moveto" 2nd and 3rd value are numbers
                            if (!commonFunction.CheckArrayLength(firstArrCommand))
                                {
                                //error message for invalid and break the loop.
                                errorMessage = errorMessage + "Command no. " + (i + 1).ToString() + " is invalid!\n";
                                runFlag = false;
                                break;
                            }
                            else
                            {
                                //check condition for x parameter is number or not
                                if (commonFunction.checkNumber(firstArrCommand[j + 1].Trim(), ref cmdX))
                                {
                                    //check condition for y parameter is number or not
                                    if (commonFunction.checkNumber(firstArrCommand[j + 2].Trim(), ref cmdY))
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
                        //moveto end

                        //rect start
                        else if (firstArrCommand[j].ToString().Trim().Equals("rect"))
                        {
                            //check if the three value enter where, firstvalue = "rect", 2nd and 3rd value are numbers.
                            if (firstArrCommand.Count() != 3)
                            {
                                //error messgae if condition fail and will break the loop and change boolean value of runflage
                                errorMessage= errorMessage+ "Invalid no of argument at command " + (i + 1).ToString() + "!\n";
                                runFlag = false;
                                break;
                            }
                            else
                            {
                                //check condition for x parameter is number or not
                                if (commonFunction.checkNumber(firstArrCommand[j + 1].Trim(), ref cmdX))
                                {
                                    //check condition for y parameter is number or not
                                    if (commonFunction.checkNumber(firstArrCommand[j + 2].Trim(), ref cmdY))
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
                        //rect end

                        //square start
                        else if (firstArrCommand[j].ToString().Trim().Equals("square"))
                        {
                            //check if the both value enter where, firstvalue = "square", 2nd is numbers.
                            if (firstArrCommand.Count() != 2)
                            {
                                //error messgae if condition fail and will break the loop and change boolean value of runflage
                                errorMessage = errorMessage + "Command no " + (i + 1).ToString() + " is invalid!\n";
                                runFlag = false;
                                break;
                            }
                            else
                            {
                                //check the parameter value is number or not.
                                if (commonFunction.checkNumber(firstArrCommand[j + 1].Trim(), ref cmdX))
                                {
                                    //if it pass the condition than parameter value pass to square function
                                    if (runFlag)
                                    {
                                        DrawSquare(cmdX);
                                    }
                                }
                                else
                                {
                                    //height parameter is not number than this error message will display
                                    errorMessage = errorMessage + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                    runFlag = false;
                                }
                                j = j + 1;
                            }
                        }
                        //square end

                        //tringle start
                        else if (firstArrCommand[j].ToString().Trim().Equals("triangle"))
                        {
                            //check if the both value enter where, firstvalue = "square", other three are numbers.
                            if (firstArrCommand.Count() != 4)
                            {
                                errorMessage = errorMessage + "Command no " + (i + 1).ToString() + " is invalid!\n";
                                runFlag = false;
                                break;
                            }
                            else
                            {   //condition to check first parameter is number or not.
                                if (commonFunction.checkNumber(firstArrCommand[j + 1].Trim(), ref cmdX))
                                {
                                    //condtion to check second parameter is number or not
                                    if (commonFunction.checkNumber(firstArrCommand[j + 2].Trim(), ref cmdY))
                                    {
                                        //condition to check thrid number is parameter or not
                                        if (commonFunction.checkNumber(firstArrCommand[j + 3].Trim(), ref cmdz))
                                        {
                                            if (runFlag)
                                            {
                                                //pass all three parameter to draw tringle
                                                DrawTriangle(cmdX, cmdY, cmdz);
                                            }
                                        }
                                        else
                                        {
                                            //error message, if third parameter is invalid
                                            errorMessage = errorMessage + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                            runFlag = false;
                                        }
                                    }
                                    else
                                    {
                                        //error message, if second parameter is 
                                        errorMessage = errorMessage + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                        runFlag = false;
                                    }
                                }
                                else
                                {
                                    //error message if first parameter is invalid
                                    errorMessage = errorMessage + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                    runFlag = false;
                                }
                                j = j + 3;
                            }
                        }
                        //tringle end

                        //drawto start
                        else if (firstArrCommand[j].ToString().Trim().Equals("drawto"))
                        {
                            //check if the both value enter where, firstvalue = "drawto", other two are numbers.
                            if (firstArrCommand.Count() != 3)
                            {
                                errorMessage = errorMessage + "Command no " + i.ToString() + " is invalid!\n";
                                runFlag = false;
                                break;
                            }
                            else
                            {
                                //condition to check first parameter is number or not.
                                if (commonFunction.checkNumber(firstArrCommand[j + 1].Trim(), ref cmdX))
                                {
                                    //condition to check second parameter is number or not.
                                    if (commonFunction.checkNumber(firstArrCommand[j + 2].Trim(), ref cmdY))
                                    {
                                        if (runFlag)
                                        {
                                            //pass all three parameter to drawLine
                                            DrawLine(cmdX, cmdY);
                                        }
                                    }
                                    else
                                    {
                                        //error message, if second parameter is invalid
                                        errorMessage = errorMessage + " Invalid number at command no " + i.ToString() + "!\n";
                                        runFlag = false;
                                    }
                                }
                                else
                                {
                                    //error message, if first parameter is invalid
                                    errorMessage = errorMessage + " Invalid number at command no " + i.ToString() + "!\n";
                                    runFlag = false;
                                }
                                j = j + 2;
                            }
                        }
                        //drawto end

                        //circle start
                        else if (firstArrCommand[j].ToString().Trim().Equals("circle"))
                        {
                            if (firstArrCommand.Count() != 2)
                            {
                                errorMessage = errorMessage + "invalid number of parameters for circle " + (i + 1).ToString() + "\n";
                                runFlag = false;
                                break;
                            }
                            else
                            {
                                if (commonFunction.checkNumber(firstArrCommand[j + 1].Trim(), ref cmdX))
                                {
                                    if (runFlag)
                                    {
                                        DrawCircle(cmdX);
                                    }
                                }
                                else
                                {
                                    errorMessage = errorMessage + " Non numeric parameter " + (i + 1).ToString() + "\n";
                                    runFlag = false;
                                }
                                j = j + 1;
                            }
                        }

                        //circle end

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



    }
}
