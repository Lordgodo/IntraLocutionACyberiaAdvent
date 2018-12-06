using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Diagnostics;


public static class Personality
{

    #region nibble
    public static void nibble(string speakandspell)
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        synth.SelectVoice("Microsoft Zira Desktop");
        synth.Rate = 3;
        SpecialFx.stringtonum(speakandspell);
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.Black;
		Console.ForegroundColor = ConsoleColor.Green;

        synth.Speak(speakandspell);
        //Console.WriteLine(" /* " + " Nibble: " + speakandspell + " */ \n\n");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" /* ");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(" Nibble");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(": ");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(speakandspell);
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" */  \n\n");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;
    }
    #endregion

	
    #region byte
    public static void mybyte(string speakandspell)
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        synth.Rate = 2;
        synth.SelectVoice("Microsoft David Desktop");
        SpecialFx.stringtonum(speakandspell);
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;
        synth.Speak(speakandspell);
        
       // Console.WriteLine(" /* " + " Byte: " + speakandspell + " */  \n\n");

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" /* ");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(" Byte");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(": ");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(speakandspell);
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" */  \n\n");
		
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;
    }
    #endregion

	
    #region Narrator
    public static void Narrator(string speakandspell)
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        synth.Rate = 0;
        synth.Speak(speakandspell);
        synth.SelectVoice("Microsoft David Desktop");
        Console.WriteLine(" " + " Narrator: " + speakandspell + " \n\n");
    }
    #endregion

	
    #region RedQueenNarrator
    public static void RedQueenNarrator(string speakandspell, int rate = 0, int timer = 2600)
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        synth.SelectVoice("Microsoft Hazel Desktop");

        synth.Rate = rate;
     
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;
       // SpecialFx.stringtonum(speakandspell);
        synth.Speak(speakandspell);
       // SpecialFx.stringtonum(speakandspell);
        //Console.WriteLine(" /* " + " Nibble: " + speakandspell + " */ \n\n");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" /* ");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write('\u2665'); // heart
        Console.Write(" Red_Queen ");
        Console.Write('\u2665'); // heart
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(": ");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(speakandspell + "\n");
        SpecialFx.stringtonum(speakandspell);
       
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" */  \n\n");

        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
       
        CinemaHelpers.Timer(timer);
    }
    #endregion

	
    #region FunNarrator
    public static void narr(object speakandspell)
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        synth.Rate = 0;
        synth.SelectVoice("Microsoft David Desktop");
        synth.Speak((string) speakandspell);
    }


    //public static void mynarr(object speakandspell)
    //{
    //    Console.WriteLine(speakandspell);
    //}
    public static void FunNarrator(string speakandspell)
    {
       
        Boolean a = true;
        string sentance = " ";

        //Process myProcess;
        //myProcess = Process.Start(FunNarrator);
        //myProcess.Close();
        //Personality.narr(speakandspell);
        Thread NVoice = new Thread(new ParameterizedThreadStart(Personality.narr));
      
        NVoice.Start(speakandspell);
        
        while (a)
        {

            for (int i = 0; i < speakandspell.Length; i++)
            {
				sentance += speakandspell[i];
				Console.Write(" " + "\n \n" + " *** " + "\t" + " Narrator: " + sentance + " *** " + " ");
				Thread.Sleep(67); //great for small lines
				Console.Clear();
            }
            a = false;
            Console.Write(" " + " \n \n " + " *** " + "\t" + " Narrator: " + sentance + " *** " + " ");
        }
       // Console.WriteLine(" " + " Narrator: " + speakandspell + " \n\n");
    }
    #endregion


    #region GlitchNarrator
    public static void GlitchNarrator(string speakandspell)
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        synth.Rate = 7;
        synth.Speak(speakandspell);

        synth.SelectVoice("Microsoft David Desktop");
        Boolean a = true;
        while (a)
        {
            for (int i = 0; i < speakandspell.Length; i++)
            {
                    Console.Write(" " + speakandspell + " " );
                    Thread.Sleep(10);
            }
            a = false;
        }
        Console.WriteLine(" \n \n" + " Narrator: " + speakandspell + " \n\n");
    }
    #endregion

	
    #region ConcertMind
    public static void ConcertMind(string speakandspell)
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        synth.Rate = 7;
        synth.Speak(speakandspell);
        synth.SelectVoice("Microsoft Zira Desktop");
        synth.Speak(speakandspell);
        synth.SelectVoice("Microsoft David Desktop");
        Console.WriteLine(" " + " ConcertMind:" + speakandspell + " \n\n");
    }
    #endregion

	
    #region BinaryFire
    public static void BinaryFire(string speakandspell)
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        synth.Rate = 10;
        synth.Speak(speakandspell);
        synth.SelectVoice("Microsoft Zira Desktop");
        synth.Speak(speakandspell);
        synth.SelectVoice("Microsoft David Desktop");
        Console.WriteLine(" " + " ConcertMind:" + speakandspell + " \n\n");
    }
    #endregion

	
    #region Simulus
    public static void Simulus()
    {
        Thread NVoice = new Thread(Scratchpad.Scratch1);
        Thread BVoice = new Thread(Scratchpad.Scratch2);

        NVoice.Start();
        BVoice.Start();
    }
    #endregion


    #region AsimNibble
    public static void AsimNibble(string speakandspell)
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        synth.SelectVoice("Microsoft Zira Desktop");
        synth.Rate = 3;
        SpecialFx.stringtonumWhiteBlue(speakandspell);
        Console.WriteLine();
        
        C.bluebg();
        C.white();
        synth.Speak(speakandspell);
        //Console.WriteLine(" /* " + " ASM_Nibble: " + speakandspell + " */ \n\n");
        C.bluebg();
        C.white();
        Console.Write(" /* ");
        C.bluebg();
        C.white();
        Console.Write(" ASM_Nibble");
        C.bluebg();
        C.white();
        Console.Write(": ");
        C.bluebg();
        C.white();
        Console.Write(speakandspell);
        C.bluebg();
        C.white();
        Console.Write(" */  \n\n");

        C.bluebg();
        C.white();
    }
    #endregion

	
    #region Otto
    public static void HelpOtto(object speakandspell)
    {

        SpeechSynthesizer synth = new SpeechSynthesizer();
        synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Teen);
        synth.SelectVoice("Microsoft Irina Desktop");

        synth.Rate = 2;
        synth.Speak((string)speakandspell);
    }

    public static void Otto(string speakandspell)
    {
        Thread NVoice = new Thread(new ParameterizedThreadStart(Personality.HelpOtto));

        NVoice.Start(speakandspell);
        CinemaHelpers.TextSpace();
        C.whitebg();
        Console.Write(" ");
        C.blue();
        
        Console.Write("Otto ");
        C.blackbg();
        C.white();
        Console.Write(": " + speakandspell + " \n\n");
       // Thread.Sleep(100);
       // Console.Clear();
    }
    #endregion

    #region OttoTypes
    public static void OttoTypes(string speakandspell)
    {
        Thread NVoice = new Thread(new ParameterizedThreadStart(Personality.HelpOtto));

        NVoice.Start(speakandspell);
       // CinemaHelpers.TextSpace();
        C.whitebg();
        Console.Write(" ");
        C.blue();
       // Console.Write("Otto ");
        C.blackbg();
        C.white();
        //Console.Write(": " + speakandspell + " \n\n");

       // Scratchpad.Format("Otto : " + speakandspell + " ");
        Boolean a = true;
        string sentance = " ";
        //Process myProcess;
        //myProcess = Process.Start(FunNarrator);
        //myProcess.Close();
        //Personality.narr(speakandspell);
        while (a)
        {
            for (int i = 0; i < speakandspell.Length; i++)
            {
                //if (speakandspell.Length <= 250)
                //{
                sentance += speakandspell[i];
                // Console.Write(" " + "\n \n" + " *** " + "\t" + " Narrator: " + sentance + " *** " + " ");
                Scratchpad.Format("Otto : " + sentance + " ");
                //Thread.Sleep(67); //great for small lines
                //Thread.Sleep(1);
                //Console.Clear();
                CinemaHelpers.RefreshConsole();
            }
            a = false;
            //Console.Write(" " + " \n \n " + " *** " + "\t" + " Narrator: " + sentance + " *** " + " ");
            Scratchpad.Format("Otto : " + sentance + " ");
           // Scratchpad.NewFormat(" Otto : " + sentance + " ", "+");
        }
    }
    #endregion


    #region Miamoto
    public static void HelpMiamoto(object speakandspell)
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Senior);
        //synth.SelectVoice("Microsoft Haruka Desktop");
        synth.SelectVoice("Ekho English");
        synth.Rate = 0;
        synth.Speak((string) speakandspell);
    }

    public static void Miamoto(string speakandspell)
    {
        try
        {
            Thread NVoice = new Thread(new ParameterizedThreadStart(Personality.HelpMiamoto));
            NVoice.Start(speakandspell);
        } catch
        {				// if the first thread failed, this will make a second identical thread
            CinemaHelpers.RefreshConsole();
           // NVoice.Abort();
            Thread NVoice2 = new Thread(new ParameterizedThreadStart(Personality.HelpMiamoto));
            NVoice2.Start(speakandspell);

        }
        CinemaHelpers.TextSpace();
        Console.Write("  ");
        C.white();
        C.lightgreenbg();
        Console.Write("'");
  
        C.black();
        Console.Write("\u2660");
        
        C.white();
        Console.Write("'");
        C.blackbg();
        C.darkgreybg();
        C.yellow();
        Console.Write(" Miamoto ");
        C.blackbg();
        C.white();

        C.lightgreenbg();
        Console.Write("'");
        C.black();
        Console.Write("\u2660");

        C.white();
        Console.Write("'");
        C.blackbg();
        Console.Write(" : ");
        C.lightgreen();
        Console.Write( speakandspell + " \n\n");
    }
    #endregion


    #region MiamotoTypes
    public static void MiamotoTypes(string speakandspell)
    {
			// Miamoto does not type
    }
    #endregion

	
    #region MegaByte
    public static void MegaByte(string speakandspell, string name = "MegaByte")
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        synth.SelectVoice("Microsoft Hazel Desktop");
        synth.Rate = 0;
       
        SpecialFx.stringtonumWhiteBlue(speakandspell);
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;

        C.bluebg();
        C.white();

        synth.Speak(speakandspell);
        //Console.WriteLine(" /* " + " Nibble: " + speakandspell + " */ \n\n");
        C.bluebg();
        C.white();
        Console.Write(" /* ");
        C.bluebg();
        C.white();
        Console.Write(name);
        //Console.Write(" MegaByte");
        C.bluebg();
        C.white();
        Console.Write(": ");
        C.bluebg();
        C.white();
        Console.Write(speakandspell);
        C.bluebg();
        C.white();
        Console.Write(" */  \n\n");

        C.bluebg();
        C.white();
    }
    #endregion


    #region ConsoleVoice
    public static void ConsoleVoice(string speakandspell)
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        synth.SelectVoice("Microsoft Hazel Desktop");
        synth.Rate = 6;
        synth.Speak(speakandspell);
    }
    #endregion
}
