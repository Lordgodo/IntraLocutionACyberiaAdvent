using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Diagnostics;

// PARAMETERIZE THESE FUCTIONS
//public static void OneLineRedWhiteRain(string speakandspell)
//{
//	DanceParameter( speakandspell, foregroundColor, backGroundCOlor, sleepTime );
//}

public static class TextFx
{

    #region RainbowWriterBG
    public static void RainbowWriterBG(string speakandspell)
    {
        for (int x = 1; x <= 7; x++)
        {
            Type type = typeof(ConsoleColor);
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (var name in Enum.GetNames(type))
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, name);
                Console.Clear();
                // Thread.Sleep(60);

                Console.WriteLine(speakandspell);
                Thread.Sleep(60);
            }
        }
    }
    #endregion


    #region RainbowWriterFG
    public static void RainbowWriterFG(string speakandspell)
    {
        for (int x = 1; x <= 7; x++)
        {
            // Console.Clear();
            Type type = typeof(ConsoleColor);
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var name in Enum.GetNames(type))
            {
                Console.Clear();
                Console.BackgroundColor = (ConsoleColor)Enum.Parse(type, name);
                //Console.WriteLine(name);
                Console.WriteLine(speakandspell);
            }
            Thread.Sleep(60);
        }
    }
    #endregion

	
    #region testscan
    #endregion

	
    #region matrixwalk
    #endregion


    #region jamvibe
    #endregion


    #region numberrain
    public static void numberrain()
    {
        Random myrandom = new Random();
        string screensmash;
        for (int x = 0; x < 100; x++)
        {
            int myr = myrandom.Next(1, 100);
            screensmash = myr.ToString();
            Console.Write(screensmash.PadLeft(myr) + " \n");
            Thread.Sleep(100);
        }
    }
    #endregion

	
    #region rain
    // prints string in random locations on screen
    public static void rain(string speakandspell)
    {
        Random myrandom = new Random();
        //string screensmash;
        for (int x = 0; x < 100; x++)
        {
            int myr = myrandom.Next(1, 100);
            // screensmash = myr.ToString();
            Console.Write(speakandspell.PadLeft(myr) + " \n");
            Thread.Sleep(100);
        }
    }
    #endregion


    #region EndScreenWriter
    public static void EndScreenWriter(string speakandspell)
    {
        for (int x = 1; x <= 7; x++)
        {
            Type type = typeof(ConsoleColor);
            Console.BackgroundColor = ConsoleColor.Black;
            Random myrandom = new Random();
            foreach (var name in Enum.GetNames(type))
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, name);
                //Console.Clear();
                // Thread.Sleep(60);
                // Console.WriteLine(speakandspell);
                int myr = myrandom.Next(1, 100);
                // screensmash = myr.ToString();
                Console.Write(speakandspell.PadLeft(myr) + " \n");
                //nibble(speakandspell);
                Thread.Sleep(60);
            }
        }
    }
    #endregion

	
    #region grunblancheblack
    public static void grunblancheblack(string speakandspell)
    {
        Console.CursorVisible = false;
        for (int rotatethree = 0; rotatethree < 1; rotatethree++)
        {
            for (int x = 0; x <= 5; x++)
            {
                int timercontrol = 60;

                if (x == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else if (x == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else if (x == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else if (x == 3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else if (x == 4)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else if (x == 5)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else
                {
                    Console.Clear();

                }
            }
        }
    }
    #endregion

	
    #region grunblancheblackdance
    public static void grunblancheblackdance(string speakandspell)
    {
        Console.CursorVisible = false;
        for (int rotatethree = 0; rotatethree < 1; rotatethree++)
        {
            for (int x = 0; x <= 5; x++)
            {
                int timercontrol = 60;

                if (x == 0)
                {
                    //Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else if (x == 1)
                {
                    // Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else if (x == 2)
                {
                    // Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else if (x == 3)
                {
                    // Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else if (x == 4)
                {
                    //  Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else if (x == 5)
                {
                    // Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else
                {
                    // Console.Clear();
                }
            }
        }
    }
    #endregion


    #region RedWhiteDance
    public static void RedWhiteDance(string speakandspell)
    {
        Console.CursorVisible = false;
        for (int rotatethree = 0; rotatethree < 1; rotatethree++)
        {
            for (int x = 0; x <= 5; x++)
            {
                int timercontrol = 60;

                if (x == 0)
                {
                    //Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else if (x == 1)
                {
                    //Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else if (x == 2)
                {
                    //  Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else if (x == 3)
                {
                    // Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else if (x == 4)
                {
                    // Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else if (x == 5)
                {
                    // Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else
                {
                    // Console.Clear();
                }
            }
        }
    }
    #endregion

	
    #region Redwhiterain
    // prints string in random locations on screen
    public static void RedWhiteRain(string speakandspell)
    {
        Random myrandom = new Random();
        //string screensmash;
        for (int x = 0; x < 100; x++)
        {
            int myr = myrandom.Next(1, 100);
            // screensmash = myr.ToString();
            // Console.Write(speakandspell.PadLeft(myr) + " \n");
            // RainbowWriterBG(speakandspell.PadLeft(myr) + "\n");
            RedWhiteDance(speakandspell.PadLeft(myr) + "\n");
            Thread.Sleep(100);
        }
    }
    #endregion


    #region RedWhiteDance
    public static void OneLineRedWhiteRain(string speakandspell)
    {
        Console.CursorVisible = false;
        for (int rotatethree = 0; rotatethree < 1; rotatethree++)
        {
            for (int x = 0; x <= 5; x++)
            {
                int timercontrol = 60;

                if (x == 0)
                {
                    //Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else if (x == 1)
                {
                    //Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else if (x == 2)
                {
                    //  Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else if (x == 3)
                {
                    // Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else if (x == 4)
                {
                    // Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else if (x == 5)
                {
                    // Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(speakandspell);
                    Thread.Sleep(timercontrol);
                }
                else
                {
                    // Console.Clear();
                }
            }
        }
    }
    #endregion
}

