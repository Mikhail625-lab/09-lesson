
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace herramienta
{
    class Program
    {
        /*
            ver: 0.7b date: 2021.05.10
            autor: Mikhail625@protonmail.com

            Tip: for formatting Ctrl + K, а затем Ctrl + D.
        */

        // https://unicode.org/charts/nameslist/n_2500.html
        // https://unicode.bootstrap-4.ru/alt-codes/
        static char cSpace = '\u0020';
        static char cBordrHorDouble = '\u2550'; // ═ 	Alt 205     Граница двойная горизонтальная Double horizontal border       
        static char cBordrVerDouble = '\u2551'; //  ║ 	Alt 186 	Граница двойная вертикальная               

        static char cornUpRight2l = '\u255A';   //  ╚    угол Граница двойная вверх и направо
        static char cornUpLeft2l = '\u255D';   //  ╝    угол Граница двойная вверх и налево

        static char cornDownRight2l = '\u2554'; // ╔    угол Граница двойная вниз и направо
        static char cornDownLeft2l = '\u2557'; // ╗    угол Граница двойная вниз и налево

        static char cBordrTmp14 = '\u2554'; // ╟ 	Alt 199 	Граница вертикальная двойная и одинарная направо
        static char cBordrTmp15 = '\u2557'; // ╢ 	Alt 182 	Граница вертикальная двойная и одинарная налево

        static char cBordrTmp17 = '\u2564'; // ╤ 	Alt 209 	Граница одинарная вниз и двойная горизонтально
        static char cBordrTmp18 = '\u2567'; // ╧ 	Alt 207 	Граница одинарная вверх и двойная горизонтально


        static char cBordrVerLight = '\u2502'; //   │   Граница легкая вертикальная Граница легкая вертикальная 
        static char cBordrHorLight = '\u2500'; //   ─   Граница легкая горизональная 
        static char cBordrCrossL = '\u253c'; //   ┼ 	Alt 197 	Граница легкая вертикальная и горизонтальная

        static char cornUpRight1l = '\u2514';  //  └     Alt 192 	Граница легкая вверх и легкая направо
        static char cornUpLeft1l = '\u2518';  //  ┘   '\u2518' Alt 217 Граница легкая вверх и легкая налево      
        static char cornDownRight1l = '\u250C';  //  ┌   '\u250E' Alt 218 Граница легкая вниз в легкая направо
        static char cornDownLeft1l = '\u2510';  //  ┐ 	   Alt 191 	Граница легкая вниз и легкая налево

        static char cBordrTmp16 = '\u2502'; // 
        static char cBordrTmp12 = '\u0020';
        static char cBordrTmp13 = '\u0020';

        const int WINDOW_MAX_HEIGHT = 40;     // Y base frame 
        const int WINDOW_MAX_WIDTH = 151;    // X base frame 

        const int WINDOW_1_HEIGHT = WINDOW_MAX_HEIGHT / 2 - 1; // Y       
        const int WINDOW_1_WIDTH = WINDOW_MAX_WIDTH / 2 - 1; // X

        const int WINDOW_2_HEIGHT = WINDOW_MAX_HEIGHT / 2 - 1; // Y
        const int WINDOW_2_WIDTH = WINDOW_MAX_WIDTH / 2 - 1; // X

        static void Main(string[] args)
        {
            ConfigureConsole("herramienta");
            Task001();
        }

        static void Task001()
        {
            // block declare init vars
            int dimY = WINDOW_MAX_HEIGHT - 1; // высота
            int dimX = WINDOW_MAX_WIDTH - 1;  // ширина

            // Start coordinates
            int startX1;
            int startY1;



            char[,] cWind1 = new char[dimY, dimX];
            startY1 = 1;
            startX1 = 1;
            ArrayBaseFrame(cWind1, dimY, dimX, " Herramienta file manager ");

            ArrayWin2(cWind1, dimY, dimX, startY1, startX1, startY1 + dimY / 2, startX1 + dimX / 2);
            startY1 = startY1 + dimY / 2 + 1;
            startX1 = startX1 + dimX / 2 + 1;
            ArrayWin2(cWind1, dimY, dimX, startY1, startX1, startY1 + dimY / 2, startX1 + dimX / 2);

            //ArrayWin2(cWind1, dimY, dimX,  WINDOW_1_HEIGHT + 1, WINDOW_1_WIDTH + 1 , WINDOW_2_HEIGHT - 2, WINDOW_2_WIDTH - 2);
            ArrayDisplay2D(cWind1);

            //ArrayDisplay2D(cWind1);

            //char[,] cWind2 = new char[WINDOW_1_HEIGHT, WINDOW_1_WIDTH];
            // char[,] cWind3 = new char[WINDOW_1_HEIGHT, WINDOW_2_WIDTH];



            // int Ans = 1; // for answear 1 - yes , 0- no
            // block executive
            // Get begin data and calculet size dimention 
            {


            }

            /*
            {
                // create array field and aray for drawing
                char [,] arrWindow1 = new
                char[,] arrChar = new char[dimYf, dimXf];
                char[,] arrDraw = new char[dimYd, dimXd];
                // Shape array for Draw. Render. Display.
                ArrayFill(arrDraw, dimYd, dimXd);
                ArrayDisplay2D(arrDraw);
            }

            */
            Console.WriteLine("That all");
            Console.ReadKey();
        }

        // under


        static Array ArrayBaseFrame(char[,] arrEmpty, int dimY, int dimX, string nameWindow)

        {
            // Формирование массива основной внешней рамки (родительского окна)
            // Двойный границы 


            // Console.WriteLine("  Now generate base frame with double line-board and space ");
            // Console.ReadKey();

            // detect rank array // ранг (число измерений) 
            int iArrRank = arrEmpty.Rank;
            int[] arrRank = new int[iArrRank];
            // check verify 
            // ArrayDisplay2D(arrEmpty);

            // fill all elements space symbols            
            for (int currY = 0; currY < dimY; currY++)
            {
                for (int currX = 0; currX < dimX; currX++)
                {
                    arrEmpty[currY, currX] = cSpace;
                }
            }

            // border
            {
                for (int currY = 0; currY < dimY; currY++)
                {

                    //1 line: Set duble horizot line
                    if (currY == 0 | currY == (dimY - 1))
                    {
                        for (int currX = 0; currX < dimX; currX++)
                        {
                            arrEmpty[currY, currX] = cBordrHorDouble;

                        }
                    }
                    // last line: Set duble horizot line


                    else
                    {
                        for (int currX = 0; currX < dimX; currX++)
                        {
                            if (currX % 2 == 0)
                            {
                                arrEmpty[currY, currX] = cSpace; // = ' '
                            }
                            else
                            {
                                arrEmpty[currY, currX] = cSpace; //  
                            }
                        }
                    }

                    // Left and right border
                    arrEmpty[currY, 0] = cBordrVerDouble;
                    arrEmpty[currY, dimX - 1] = cBordrVerDouble;

                }
            }

            // corners 
            { // line 1
                arrEmpty[0, 0] = cornDownRight2l;
                arrEmpty[0, dimX - 1] = cornDownLeft2l;
                // line last '\u255A', '\u2550'
                arrEmpty[dimY - 1, 0] = cornUpRight1l;
                arrEmpty[dimY - 1, dimX - 1] = cornUpLeft1l; ;
            }

            // type headet banner window
            /// заголовок окна
            int positionBanner;
            int pos2 = 0;

            positionBanner = (dimX / 2) - (nameWindow.Length / 2);

            char[] cText = new char[nameWindow.Length];
            cText = nameWindow.ToCharArray();

            for (int pos1 = 0; pos1 < nameWindow.Length; pos1++)
            {
                arrEmpty[0, positionBanner] = cText[pos1];
                positionBanner++;
            }

            //return
            return arrEmpty;
            Console.ReadKey();
        }



        static Array ArrayFill(char[,] arrEmpty, int dimY, int dimX)

        {
            // StringBuilder sbLine1 = new StringBuilder();


            // ранг (число измерений) 
            //Console.WriteLine(arrEmpty.Rank);

            // fill all elements space symbols
            Console.WriteLine("  Go fill space symbols all elements");
            Console.ReadKey();

            {
                for (int j = 0; j < dimY; j++)
                {
                    for (int i = 0; i < dimX; i++)
                    {
                        arrEmpty[j, i] = cSpace;
                    }
                }
                // check verify 
                // ArrayDisplay2D(arrEmpty);
            }
            // Console.WriteLine(Convert.ToString('\u2550'));

            // border
            {

                for (int dimY1 = 0; dimY1 < dimY; dimY1++)
                {

                    //1 line: Set duble horizot line
                    if (dimY1 == 0)
                    {
                        for (int i = 0; i < dimX; i++)
                        {
                            if (i % 2 == 0)
                            {
                                arrEmpty[dimY1, i] = '\u2564';  // ╤
                            }
                            else
                            {
                                arrEmpty[dimY1, i] = cBordrHorDouble;
                            }

                        }
                    }
                    // last line: Set duble horizot line
                    else if (dimY1 == (dimY - 1))
                    {
                        for (int i = 0; i < dimX; i++)
                        {
                            if (i % 2 == 0)
                            {
                                arrEmpty[dimY1, i] = '\u2567'; // ╧
                            }
                            else
                            {
                                arrEmpty[dimY1, i] = cBordrHorDouble;
                            }

                        }
                    }

                    else
                    {
                        for (int i = 0; i < dimX; i++)
                        {
                            if (i % 2 == 0)
                            {
                                arrEmpty[dimY1, i] = cBordrCrossL; // = '\u253c'; // ┼ 
                            }
                            else
                            {
                                arrEmpty[dimY1, i] = '\u2500';// ─ 	Alt 196 	Граница легкая горизонтальная    
                            }
                        }
                    }

                    // Left and right border
                    arrEmpty[dimY1, 0] = cBordrVerDouble;
                    arrEmpty[dimY1, dimX - 1] = cBordrVerDouble;

                }

            }



            // corners 
            { // line 1
                arrEmpty[0, 0] = cornDownRight2l;
                arrEmpty[0, dimX - 1] = cornDownLeft2l;
                // line last '\u255A', '\u2550'
                arrEmpty[dimY - 1, 0] = cornUpRight1l;
                arrEmpty[dimY - 1, dimX - 1] = cornUpLeft1l; ;
            }




            //return
            return arrEmpty;
            Console.ReadKey();
        }

        static Array ArrayWin2(char[,] arrEmpty
                            , int dimY1, int dimX1  // dimension base frame
                            , int windY1, int windX3  // initial coordinate value | begin coordinatos window
                            , int windY2, int windX2) // end coordinatos window
        /*

        */
        {
            // StringBuilder sbLine1 = new StringBuilder();

            // fill all elements space symbols

            // Console.WriteLine(Convert.ToString('\u2550'));
            // set check max dimantions
            if (dimY1 -2 <= windY1) { windY1 = dimY1 - 3; }
            if (dimX1 -2 <= windX3) { windX3 = windX3 - 3; }

            if (dimY1 <= windY2) { windY2 = windY2 - 1; }
            if (dimX1 <= windX2) { windX2 = windX2 - 1; }



            // border Win1 in frame 
            {

                for (int currY = dimY2; currY < windY2; currY++)
                {
                    //1 line: Set duble horizot line
                    
                    if (currY == dimY2)
                    {
                        for (int currX = windX3; currX < windX2; currX++)
                        {
                            arrEmpty[currY, currX] = cBordrHorDouble;//cBordrHorLight;
                        }
                    }
                    // last line: Set duble horizot line
                    else if (currY == (windY2 - 1))
                    {
                        for (int currX = windX3; currX < windX2; currX++)
                        {
                            arrEmpty[currY, currX] = cBordrHorDouble;// cBordrHorLight;
                        }
                    }

                    // Left and right border
                    arrEmpty[currY, windX3] = cBordrVerLight;
                    arrEmpty[currY, windX2] = cBordrVerLight;

                }

            }
            // corners 
            { // line 1
                arrEmpty[dimY2, windX3] = '\u2554';
                arrEmpty[dimY2, windX2] = '\u2557';
                // line last 
                arrEmpty[windY2, windX3] = '\u255A';
                arrEmpty[windY2, windX2] = '\u255D';

            }

            //return
            return arrEmpty;

        }

        static void ArrayDisplay2D(char[,] arr)
        {
            StringBuilder sbLine = new StringBuilder();
            Console.WriteLine("Drawing now ....");
            Console.ReadKey(); Console.Clear();
            // Display the array elements.
            for (int i = 0; i < arr.GetLength(0); i++)
            {

                /*
                if (i < 10) { sbLine.Append(0 + Convert.ToString(i) + "."); }
                else { sbLine.Append(Convert.ToString(i) + "."); }
                */

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sbLine.Append(arr[i, j]);
                    //System.Console.WriteLine("Element({0},{1})={2}", i, j, arr[i, j]);
                }
                System.Console.WriteLine(sbLine);
                sbLine.Clear();
            }



        }


        static void ApplyArray2Array2D(char[,] arrBackground, char[,] arrFrame)
        {
            int dimY = Math.Min(arrFrame.GetLength(0), arrBackground.GetLength(0));
            int dimX = Math.Min(arrFrame.GetLength(1), arrBackground.GetLength(1));

            for (int i = 0; i < dimY; i++)
            {
                for (int j = 0; j < dimX; j++)
                {
                    if (arrFrame[i, j] != cSpace)
                    { arrBackground[i, j] = arrFrame[i, j]; }

                }

            }


        }


        // Methods for display 

        static void ClearScr(int countDown, int warningTimer)
        {
            bool bWarning = false;

            for (int i = (countDown + 1); i > 0; i--)
            {
                System.Threading.Thread.Sleep(1000);
                if (i == warningTimer) { bWarning = true; }
                if (bWarning == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\r         ");
                Console.Write("\r     [{0}]", i);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();

        }

        static void ConfigureConsole(string headerConsWindow)
        {
            // Configure console.
            Console.Title = headerConsWindow;
            //Если значение TreatControlCAsInput свойства равно false и нажата клавиша CTRL +C, нажатые клавиши не сохраняются во входном буфере, а операционная система завершает выполняющийся процесс. Это значение по умолчанию.
            Console.TreatControlCAsInput = true;
            Console.SetWindowSize(2, 4);
            Console.BufferWidth = WINDOW_MAX_WIDTH + 3; // ширина
            Console.BufferHeight = WINDOW_MAX_HEIGHT + 5; // высота

            Console.SetWindowSize(WINDOW_MAX_WIDTH + 3, WINDOW_MAX_HEIGHT + 5);
            //Console.WriteLine("now output 150 *");
            //Console.ReadKey();

            /*
            for (int i = 0; i < 150; i++)
                Console.Write("*");
            Console.WriteLine("|");
            Console.ReadKey();

            */

            Console.ForegroundColor = ConsoleColor.Gray;

        }

        // utils 

        static string GetStrFromCons(string strQuestion, string strByDef)
        {
            string strResult;
            if (TestForNullOrEmpty(strQuestion) == true)
            { strQuestion = "   Enter value:"; }

            Console.WriteLine("   " + strQuestion);
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            strResult = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;

            // check/verife isNull Empty
            if (TestForNullOrEmpty(strResult) == true)
            {
                strResult = strByDef;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("       " + "Not value, set by default: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(strResult);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("");

            }
            return strResult;
        }

        static bool TestForNullOrEmpty(string s)
        {
            bool result;
            result = (s == null || s == string.Empty);
            return result;
        }
        static bool SwitchBool(bool bSw)
        {
            if (bSw == true) bSw = false;
            else bSw = true;
            return bSw;
        }



        // for cross-zero / reversi 
        static bool CheckVictory(char[,] arrField, int dimY, int dimX, int numSec)
        {

            // numSec - количество последовательности 

            bool bResult = false;
            return bResult;


        }
        static bool CheckDanger(char[,] arrField, int dimY, int dimX)

        {
            bool bResult = false;
            return bResult;


        }
        static bool CheckMoveCorrect(char[,] arrField, int dimY, int dimX)

        {
            bool bResult = false;
            return bResult;


        }

        static void Move(char[,] arrField, int dimY, int dimX, int numPlayer)
        { }

        // for navy battle 

        // for temp / tests  and expirience 

        static void tempTest()
        {
            int count1 = 0;
            bool blSw = false;



            int[,] arrNum1 = new int[3, 5];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arrNum1[i, j] = count1;
                    count1++;
                }
            }

            for (int i = 0; i < 60; i++)
            {
                Console.WriteLine(Convert.ToString(i % 2));

            }

            Console.WriteLine(Convert.ToString(blSw));

        } // end temp Test 



    }








} // 








