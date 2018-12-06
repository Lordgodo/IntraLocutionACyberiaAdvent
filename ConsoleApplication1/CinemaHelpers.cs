using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Speech.Synthesis;


public static class CinemaHelpers
{

    #region Refresh Console
    public static void RefreshConsole()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
    }
    #endregion


    #region Deja Vu
    public static void DejaVu()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;
    }
    #endregion

	
    #region  Jamais vu
    public static void JamaisVu()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Green;
    }
    #endregion

	
    #region The Corp
    public static void TheCorp()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.White;
    }
    #endregion

	
    #region AmberVision
    public static void AmberVision()
    {
        Console.Clear();
        C.blackbg();
        C.yellow();
    }

    #endregion

	
    #region Space and Clean
    public static void SpaceandClean()
    {
        Console.Clear();
        Console.WriteLine("\n \n");
    }
    #endregion

	
    #region TextSpace
    public static void TextSpace()
    {
        Console.WriteLine("\n \n");
    }
    #endregion


    #region Time Control Spell
    public static void Timer(int time)
    {
        Thread.Sleep(time);
    }
    #endregion

	
    #region OpeningScene
    public static void OpeningScene(string Title) { 

		//Chapter Two 11:42 pm - Another Flip Switched
		SpeechSynthesizer synth = new SpeechSynthesizer();

		CinemaHelpers.SpaceandClean();
		//Console.WriteLine(Title);
        synth.Speak(Title);
        CinemaHelpers.Timer(3600);
        CinemaHelpers.SpaceandClean();
	}
    #endregion

	
    #region commandconsole
    public static void commandconsole(string speakandspell)
    {
        Soundz.OpenCmdSnd();
        CinemaHelpers.DejaVu();
        Console.CursorVisible = true;
        C.yellow();
        Console.Write(":: ");
        C.lightgreen();
        Console.Write(" Command Console ");
        C.yellow();
        Console.Write(" :: \n");
        C.white();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
        CinemaHelpers.TextSpace();
        C.lightgreen();
        CinemaHelpers.TextSpace();
        CinemaHelpers.Timer(5000);
        CinemaHelpers.CmdConType(speakandspell);
        Personality.ConsoleVoice(speakandspell);
      //  Console.WriteLine(" \t" + speakandspell + " ");
        CinemaHelpers.TextSpace();
        CinemaHelpers.Timer(5000);
        Console.CursorVisible = false;
        CinemaHelpers.RefreshConsole();
    }
    #endregion

	
    #region qproc
    public static void qproc(string speakandspell)
    {
        //CinemaHelpers.DejaVu();
        CinemaHelpers.AmberVision();
        Console.CursorVisible = true;
        Console.WriteLine(@"

                    Execute Fairlight...
   (Make Fairlight)



");
        C.blue();
        Console.Write(" :: ");
        C.yellow();
        Console.Write(" Quantum Direct Drive ");
             C.blue();
        Console.Write(" :: ");

        CinemaHelpers.TextSpace();
        C.lightgreen();
        CinemaHelpers.TextSpace();
        Console.WriteLine(" \t" + speakandspell + " ");
        CinemaHelpers.TextSpace();
        CinemaHelpers.Timer(5000);
        Console.CursorVisible = false;
        CinemaHelpers.RefreshConsole();
    }
    #endregion


    #region Asimbot
    public static void Asimbot(string speakandspell)
    {
        //CinemaHelpers.DejaVu();
        C.bluebg();
        C.white();
        Console.CursorVisible = true;
        Console.WriteLine(@"


    ::
                   [Photonic Brain]
|
|   (Energon Cubes Init)
|
    ::

");

        
        C.bluebg();
        C.white();
        // C.lightgreen();
     
        // SpecialFx.modstringtonum(speakandspell);
        Console.WriteLine("                                                                                                                  ");
        Console.WriteLine("                                                                                                                  ");
        Personality.AsimNibble(speakandspell);
        C.bluebg();
        C.white();

        CinemaHelpers.Timer(5000);
        C.bluebg();
        C.white();
        Console.WriteLine("                                                                                                                  ");
        Console.WriteLine("                                                                                                                  ");
       
        CinemaHelpers.Timer(5000);
        Console.CursorVisible = false;
        CinemaHelpers.RefreshConsole();
    }
    #endregion


    #region CmdConsoleType
    //public static void narr(object speakandspell)
    //{
    //    SpeechSynthesizer synth = new SpeechSynthesizer();
    //    synth.Rate = 0;
    //    synth.SelectVoice("Microsoft David Desktop");
    //    synth.Speak((string)speakandspell);
    //}
    //public static void mynarr(object speakandspell)
    //{
    //    Console.WriteLine(speakandspell);
    //}
    public static void CmdConType(string speakandspell)
    {
        string sentance = " ";

        //Process myProcess;
        //myProcess = Process.Start(FunNarrator);
        //myProcess.Close();

        //Personality.narr(speakandspell);

        Thread NVoice = new Thread(new ParameterizedThreadStart(Personality.narr));

       // NVoice.Start(speakandspell);

		for (int i = 0; i < speakandspell.Length; i++)
		{
			sentance += speakandspell[i];
			// Console.Write(" " + " *** " + " Narrator: " + sentance + " *** " + " ");
			C.lightgreen();
			Console.Write(" " + " *");
			C.yellow();
			Console.Write("*");
			C.lightgreen();
			Console.Write("* ");
			C.lightgreen();
			Console.Write(sentance);
			// 2nd half
			C.lightgreen();
			Console.Write(" " + " *");
			C.yellow();
			Console.Write("*");
			C.lightgreen();
			Console.Write("* \n");
			CinemaHelpers.Timer(10);
			Console.Clear();
		}

		C.white();
		Console.Write(" " + " *");
		C.lightgreen();
		Console.Write("*");
		C.white();
		Console.Write("* ");
		C.lightgreen();
		Console.Write(sentance);
		// 2nd half
		C.white();
		Console.Write(" " + " *");
		C.lightgreen();
		Console.Write("*");
		C.white();
		Console.Write("* \n");
		//Console.Write(" " + " *** " + sentance + " *** " + " ");

        // Console.Write(" " + " *** " + " Narrator: " + sentance + " *** " + " ");
        // Console.WriteLine(" " + " Narrator: " + speakandspell + " \n\n");
    }
    #endregion

	
    #region CmdConWithTyping
    public static void CmdConWithTyping(string speakandspell)
    {
        string sentance = " ";

        //Process myProcess;
        //myProcess = Process.Start(FunNarrator);
        //myProcess.Close();

        //Personality.narr(speakandspell);

        Thread NVoice = new Thread(new ParameterizedThreadStart(Personality.narr));

        // NVoice.Start(speakandspell);

		for (int i = 0; i < speakandspell.Length; i++)
		{
			sentance += speakandspell[i];

			// Console.Write(" " + " *** " + " Narrator: " + sentance + " *** " + " ");
			Soundz.OpenCmdSnd();
			CinemaHelpers.DejaVu();
			Console.CursorVisible = true;

			Console.WriteLine(":: Command Console ::");
			C.white();
			Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
			CinemaHelpers.TextSpace();
			C.lightgreen();
			CinemaHelpers.TextSpace();
			Thread.Sleep(2);
			Console.Write(" " + " *** " + sentance + " *** " + " ");
			Thread.Sleep(2);
			CinemaHelpers.TextSpace();
			Thread.Sleep(10);
			//Console.CursorVisible = false;
			CinemaHelpers.RefreshConsole();
			Console.Clear();
		}
		// Console.Write(" " + " *** " + sentance + " *** " + " ");

		CinemaHelpers.DejaVu();
		Console.CursorVisible = true;

		Console.WriteLine(":: Command Console ::");
		C.white();
		Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
		CinemaHelpers.TextSpace();
		C.lightgreen();
		CinemaHelpers.TextSpace();
		Thread.Sleep(5000);
		Console.Write(" " + " *** " + sentance + " *** " + " ");
		Thread.Sleep(10);
		CinemaHelpers.TextSpace();
		Thread.Sleep(5000);
		Console.CursorVisible = false;
		CinemaHelpers.RefreshConsole();
		Console.Clear();
		// Console.Write(" " + " *** " + " Narrator: " + sentance + " *** " + " ");
        // Console.WriteLine(" " + " Narrator: " + speakandspell + " \n\n");
    }
    #endregion
}

