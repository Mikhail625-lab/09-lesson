﻿
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
            ver: 0.1a date: 2021.04.30
            autor: Mikhail625@protonmail.com

                Tip: for formatting Ctrl + K, а затем Ctrl + D.
        */
        
        const int WINDOW_MAX_HEIGHT = 30; // Y base frame 
        const int WINDOW_MAX_WEIGHT = 150; // X base frame 
        
        const int WINDOW_1_HEIGHT = WINDOW_MAX_HEIGHT/2 - 1; // Y       
        const int WINDOW_1_WEIGHT = WINDOW_MAX_WEIGHT/2 - 1; // X

        const int WINDOW_2_HEIGHT = WINDOW_MAX_HEIGHT/2 - 1; // Y
        const int WINDOW_2_WEIGHT = WINDOW_MAX_WEIGHT/2 - 1; // X


      

        static void Main(string[] args)
        {
            ConfigureConsole("herramienta");
            Task001();
        }

        static void Task001()
        {
            // block declare init vars
            int dimY = WINDOW_MAX_HEIGHT - 1;
            int dimX = WINDOW_MAX_WEIGHT - 1;

            char[,] cWind1 = new char [dimY, dimX];
            ArrayFill_2(cWind1 , dimY, dimX);

            ArrayWin2(cWind1, dimY, dimX, 1, 1, WINDOW_1_HEIGHT - 1 , WINDOW_1_WEIGHT - 1);
            ArrayWin2(cWind1, dimY, dimX,  WINDOW_1_HEIGHT + 1, WINDOW_1_WEIGHT + 1 , WINDOW_2_HEIGHT - 2, WINDOW_2_WEIGHT - 2);

            Console.WriteLine("Drawing now ....");
            Console.ReadKey();            Console.Clear();
            ArrayDisplay2D(cWind1);

            //char[,] cWind2 = new char[WINDOW_1_HEIGHT, WINDOW_1_WEIGHT];
            // char[,] cWind3 = new char[WINDOW_1_HEIGHT, WINDOW_2_WEIGHT];


            //ArrayDisplay2D(cWind1);

            ArrayWin2 (cWind1  , dimY , dimX, 1,  1 , 9 , 15);
             ArrayDisplay2D(cWind1);

             
            int Ans = 1; // for answear 1 - yes , 0- no
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
            Console.ReadKey();
        }

        // under
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
            Console.SetWindowSize(20, 30);
            Console.BufferWidth = WINDOW_MAX_WEIGHT;
            Console.BufferHeight = WINDOW_MAX_HEIGHT; ;

            Console.SetWindowSize(WINDOW_MAX_WEIGHT +1 , WINDOW_MAX_HEIGHT);
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


        static Array ArrayFill(char[,] arrEmpty, int dimY, int dimX)

        {
            // StringBuilder sbLine1 = new StringBuilder();

            char cSpace = '\u0020';          // https://unicode.bootstrap-4.ru/alt-codes/
            char cornLeftTop2l = '\u2554';          // ╔    Граница двойная вниз и направо
            char cornRightTop2l = '\u2557';          // ╗    Граница двойная вниз и налево
            char cornLeftBottom2l = '\u255A';          // ╚    Граница двойная вверх и направо
            char cornRightBottom2l = '\u255D';          // ╝    Граница двойная вверх и налево

            char cBordrHorDouble = '\u2550'; // ═ 	Alt 205     Граница двойная горизонтальная Double horizontal border
            char cBordrVerDouble = '\u2551'; // ║ 	Alt 186 	Граница двойная вертикальная
            char cBordrTmp12 = '\u0020';
            char cBordrTmp13 = '\u0020';
            char cBordrTmp14 = '\u2554'; // ╟ 	Alt 199 	Граница вертикальная двойная и одинарная направо
            char cBordrTmp15 = '\u2557'; // ╢ 	Alt 182 	Граница вертикальная двойная и одинарная налево
            char cBordrTmp16 = '\u0020';
            char cBordrTmp17 = '\u2564'; // ╤ 	Alt 209 	Граница одинарная вниз и двойная горизонтально
            char cBordrTmp18 = '\u2567'; // ╧ 	Alt 207 	Граница одинарная вверх и двойная горизонтально
            char cBordrTmp19 = '\u0020';
            char cBordrCrossL = '\u253c'; // ┼ 	Alt 197 	Граница легкая вертикальная и горизонтальная

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
                arrEmpty[0, 0] = cornLeftTop2l;
                arrEmpty[0, dimX - 1] = cornRightTop2l;
                // line last 
                arrEmpty[dimY - 1, 0] = cornLeftBottom2l;
                arrEmpty[dimY - 1, dimX - 1] = cornRightBottom2l;
            }

            //return
            return arrEmpty;
            Console.ReadKey();
        }


        static Array ArrayFill_1(char[,] arrEmpty, int dimY, int dimX)

        {
            // StringBuilder sbLine1 = new StringBuilder();

            char cSpace = '\u0020';          // https://unicode.bootstrap-4.ru/alt-codes/
            char cornLeftTop2l = '\u2554';          // ╔    Граница двойная вниз и направо
            char cornRightTop2l = '\u2557';          // ╗    Граница двойная вниз и налево
            char cornLeftBottom2l = '\u255A';          // ╚    Граница двойная вверх и направо
            char cornRightBottom2l = '\u255D';          // ╝    Граница двойная вверх и налево

            char cBordrHorDouble = '\u2550'; // ═ 	Alt 205     Граница двойная горизонтальная Double horizontal border
            char cBordrVerDouble = '\u2551'; // ║ 	Alt 186 	Граница двойная вертикальная
            char cBordrTmp12 = '\u0020';
            char cBordrTmp13 = '\u0020';
            char cBordrTmp14 = '\u2554'; // ╟ 	Alt 199 	Граница вертикальная двойная и одинарная направо
            char cBordrTmp15 = '\u2557'; // ╢ 	Alt 182 	Граница вертикальная двойная и одинарная налево
            char cBordrTmp16 = '\u0020';
            char cBordrTmp17 = '\u2564'; // ╤ 	Alt 209 	Граница одинарная вниз и двойная горизонтально
            char cBordrTmp18 = '\u2567'; // ╧ 	Alt 207 	Граница одинарная вверх и двойная горизонтально
            char cBordrTmp19 = '\u0020';
            char cBordrCrossL = '\u253c'; // ┼ 	Alt 197 	Граница легкая вертикальная и горизонтальная

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
                arrEmpty[0, 0] = cornLeftTop2l;
                arrEmpty[0, dimX - 1] = cornRightTop2l;
                // line last 
                arrEmpty[dimY - 1, 0] = cornLeftBottom2l;
                arrEmpty[dimY - 1, dimX - 1] = cornRightBottom2l;

            }

            //return
            return arrEmpty;
            Console.ReadKey();
        }






      static Array ArrayWin2(char[,] arrEmpty 
                            , int dimY1, int dimX1  // dimension base frame
                            , int dimY2, int dimX2  // begin coordinatos window
                            , int dimY3, int dimX3) // end coordinatos window
        /*

        */
        {
            // StringBuilder sbLine1 = new StringBuilder();

            char cSpace = '\u0020';          // https://unicode.bootstrap-4.ru/alt-codes/
            char cornLeftTop2l = '\u2554';          // ╔    Граница двойная вниз и направо
            char cornRightTop2l = '\u2557';          // ╗    Граница двойная вниз и налево
            char cornLeftBottom2l = '\u255A';          // ╚    Граница двойная вверх и направо
            char cornRightBottom2l = '\u255D';          // ╝    Граница двойная вверх и налево

            char cBordrHorDouble = '\u2550'; // ═ 	Alt 205     Граница двойная горизонтальная Double horizontal border
            char cBordrVerDouble = '\u2551'; // ║ 	Alt 186 	Граница двойная вертикальная
            char cBordrTmp12 = '\u0020';
            char cBordrTmp13 = '\u0020';
            char cBordrTmp14 = '\u2554'; // ╟ 	Alt 199 	Граница вертикальная двойная и одинарная направо
            char cBordrTmp15 = '\u2557'; // ╢ 	Alt 182 	Граница вертикальная двойная и одинарная налево
            char cBordrTmp16 = '\u0020';
            char cBordrTmp17 = '\u2564'; // ╤ 	Alt 209 	Граница одинарная вниз и двойная горизонтально
            char cBordrTmp18 = '\u2567'; // ╧ 	Alt 207 	Граница одинарная вверх и двойная горизонтально

            char cBordrVerLight = '\u2502'; //  Граница легкая вертикальная 
            char cBordrHorLight = '\u2500'; //  Граница легкая горизонт
            char cBordrCrossL = '\u253c'; // ┼ 	Alt 197 	Граница легкая вертикальная и горизонтальная
            

            // fill all elements space symbols
            Console.WriteLine("  f");
            Console.ReadKey();

            
            // Console.WriteLine(Convert.ToString('\u2550'));
            // set check max dimantions
            // border Win1 in frame 
            {

                for (int currY = dimY2 ;   currY <dimY3 ;  currY ++)
                {
                    //1 line: Set duble horizot line
                    if (  currY  == dimY2)
                    {
                        for (int  currX  = dimX2;  currX  < dimX3;  currX ++)
                        {
                                arrEmpty[ currY , currX ] = cBordrHorLight;  // '\u2574'  '\u2576'
                        }
                    }
                    // last line: Set duble horizot line
                    else if (  currY == (dimY3 - 1))
                    {
                        for (int  currX = dimX2;  currX < dimX3;  currX++)
                        {
                            if (currX % 2 == 0)
                            {
                                arrEmpty[ currY, currX ] = '\u2574';   // ─ 	Alt 196  '\u2567'; // ╧
                            }
                            else
                            {
                                arrEmpty[ currY, currX ] = '\u2576';// ─ 	Alt 196  //cBordrHorDouble;
                            }

                        }
                    }
					

                    // Left and right border
                    arrEmpty[ currY , dimX2 ] = cBordrVerLight;
                    arrEmpty[ currY , dimX3 ] = cBordrVerLight;

                }

            }
            // corners 
            { // line 1
                arrEmpty[ dimY2, dimX2 ] = '\u250c';
                arrEmpty[ dimY2, dimX3 ] = '\u2510';
                // line last 
                arrEmpty[dimY3 , dimX2] = '\u2514';
                arrEmpty[dimY3 , dimX3] = '\u2574';

            }

            //return
            return arrEmpty;
            Console.ReadKey();
        }








        static Array ArrayFill_2 (char[,] arrEmpty, int dimY, int dimX)

        {
            // StringBuilder sbLine1 = new StringBuilder();

            char cSpace = '\u0020';          // https://unicode.bootstrap-4.ru/alt-codes/
            char cornLeftTop2l = '\u2554';          // ╔    Граница двойная вниз и направо
            char cornRightTop2l = '\u2557';          // ╗    Граница двойная вниз и налево
            char cornLeftBottom2l = '\u255A';          // ╚    Граница двойная вверх и направо
            char cornRightBottom2l = '\u255D';          // ╝    Граница двойная вверх и налево

            char cBordrHorDouble = '\u2550'; // ═ 	Alt 205     Граница двойная горизонтальная Double horizontal border
            char cBordrVerDouble = '\u2551'; // ║ 	Alt 186 	Граница двойная вертикальная
            char cBordrTmp12 = '\u0020';
            char cBordrTmp13 = '\u0020';
            char cBordrTmp14 = '\u2554'; // ╟ 	Alt 199 	Граница вертикальная двойная и одинарная направо
            char cBordrTmp15 = '\u2557'; // ╢ 	Alt 182 	Граница вертикальная двойная и одинарная налево
            char cBordrTmp16 = '\u0020';
            char cBordrTmp17 = '\u2564'; // ╤ 	Alt 209 	Граница одинарная вниз и двойная горизонтально
            char cBordrTmp18 = '\u2567'; // ╧ 	Alt 207 	Граница одинарная вверх и двойная горизонтально
            char cBordrTmp19 = '\u0020';
            char cBordrCrossL = '\u253c'; // ┼ 	Alt 197 	Граница легкая вертикальная и горизонтальная

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

                    //1 line: Set duble horizot line // last line: Set duble horizot line
                    if (dimY1 == 0 | (dimY1 == (dimY - 1)))
                    {
                        for (int i = 0; i < dimX; i++)
                        { arrEmpty[dimY1, i] = cBordrHorDouble;                     

                        }
                    }

                    // Left and right border
                    arrEmpty[dimY1, 0] = cBordrVerDouble;
                    arrEmpty[dimY1, dimX - 1] = cBordrVerDouble;

                }

            }
            // corners 
            { // line 1
                arrEmpty[0, 0] = cornLeftTop2l;
                arrEmpty[0, dimX - 1] = cornRightTop2l;
                // line last 
                arrEmpty[dimY - 1, 0] = cornLeftBottom2l;
                arrEmpty[dimY - 1, dimX - 1] = cornRightBottom2l;

            }

            //return
            return arrEmpty;
            Console.ReadKey();
        }



        static void ArrayDisplay2D(char[,] arr)
        {
            StringBuilder sbLine = new StringBuilder();

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
                Console.WriteLine(Convert.ToString(i%2) );
            
            }

            Console.WriteLine(Convert.ToString(blSw));

        } // end temp Test 

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


        static void ApplyArray2Array2D (char[,] arrBackground, char[,] arrFrame)
        {
            char cSpace = '\u0020';
            int dimY = Math.Min(arrFrame.GetLength(0), arrBackground.GetLength(0) );
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






    } // 






} // 








