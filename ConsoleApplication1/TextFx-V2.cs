using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Diagnostics;


public static class TextFx
{

    #region RainbowWriterFG
    public static void RainbowWriterFG(string speakandspell)
    {
        for (int x = 1; x <= 7; x++)
        {
            Type type = typeof(ConsoleColor);
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (var name in Enum.GetNames(type))
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, name);
                Console.Clear();

                Console.WriteLine(speakandspell);
                Thread.Sleep(60);
            }
        }
    }
    #endregion


    #region RainbowWriterBG
    public static void RainbowWriterBG(string speakandspell)
    {
        for (int x = 1; x <= 7; x++)
        {
            Type type = typeof(ConsoleColor);
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var name in Enum.GetNames(type))
            {
                Console.Clear();
                Console.BackgroundColor = (ConsoleColor)Enum.Parse(type, name);
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
		int myr;
        for (int x = 0; x < 100; x++)
        {
            myr = myrandom.Next(1, 100);
            Console.Write(speakandspell.PadLeft(myr) + " \n");
            Thread.Sleep(100);
        }
    }
    #endregion
	
	
    #region Redwhiterain
    // prints string in random locations on screen
    public static void RedWhiteRain(string speakandspell)
    {
        Random myrandom = new Random();
        int myr;
        for (int x = 0; x < 100; x++)
        {
            myr = myrandom.Next(1, 100);
            RedWhiteDance(speakandspell.PadLeft(myr) + "\n");
            Thread.Sleep(100);
        }
    }
    #endregion

	
    #region EndScreenWriter
    public static void EndScreenWriter(string speakandspell)
    {
		Random myrandom = new Random();
		Type type = typeof(ConsoleColor);
		int myr;
		Console.BackgroundColor = ConsoleColor.Black;
        for (int x = 1; x <= 7; x++)
        {
            foreach (var name in Enum.GetNames(type))
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, name);
                myr = myrandom.Next(1, 100);
                Console.Write(speakandspell.PadLeft(myr) + " \n");
                Thread.Sleep(60);
            }
        }
    }
    #endregion

	
    #region grunblancheblack
    public static void grunblancheblack(string speakandspell)
    {
        var ColorCycles[] = {
                    ConsoleColor.Green,
					ConsoleColor.White,
					ConsoleColor.Gray,
					ConsoleColor.DarkGray,
					ConsoleColor.DarkBlue,
					ConsoleColor.Black
							};
							
		DanceParameter( speakandspell, ColorCycles );
    }
    #endregion

	
    #region grunblancheblackdance
    public static void grunblancheblackdance(string speakandspell)
    {
		var ColorCycles[] = {
                    ConsoleColor.Green,
                    ConsoleColor.White,
                    ConsoleColor.Gray,
                    ConsoleColor.DarkGray,
                    ConsoleColor.DarkBlue,
                    ConsoleColor.Black
							};
							
		DanceParameter( speakandspell, ColorCycles );
    }
    #endregion


    #region RedWhiteDance
    public static void RedWhiteDance(string speakandspell)
    {
		var ColorCycles[] = {	
                    ConsoleColor.DarkRed,
					ConsoleColor.Red,
                    ConsoleColor.DarkYellow,
                    ConsoleColor.Yellow,
                    ConsoleColor.Gray,
                    ConsoleColor.White
							};
							
		DanceParameter( speakandspell, ColorCycles );
    }
    #endregion

	#region OneLineRedWhiteRain
	public static void OneLineRedWhiteRain(string speakandspell)
	{
		// Colors used in this form
		var ColorCycles[] = {	
					ConsoleColor.White,
					ConsoleColor.Gray,
					ConsoleColor.Yellow,
					ConsoleColor.DarkYellow,
					ConsoleColor.Red,
					ConsoleColor.DarkRed 
							};
							
		DanceParameter( speakandspell, ColorCycles );
	}
	#endregion


    #region RedWhiteDance
    public static void DanceParameter( string Message, ConsoleColor Colors[], int SleepTime = 60, int Iterations = 1 )
    {
        Console.CursorVisible = false;
        for (int rotatethree = 0; rotatethree < Iterations; rotatethree++)
        {
            foreach( var curColor in Colors )
            {
                Console.ForegroundColor = curColor;
                Console.WriteLine(speakandspell);
                Thread.Sleep(SleepTime);
            }
		}
		Console.CursorVisible = true;
    }
    #endregion
}

