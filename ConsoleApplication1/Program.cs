using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Speech.Synthesis;
using System.Diagnostics;
using System.Media;
using System.Runtime.InteropServices;
using System.Drawing;


namespace ConsoleApplication1
{
    class Program
    {
     
        //maximizing console window
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;

        //     Console.WriteLine("Installed voices -");
        //    foreach (InstalledVoice voice in synth.GetInstalledVoices())
        //    {
        //        VoiceInfo info = voice.VoiceInfo;
        //        Console.WriteLine(" Voice Name: " + info.Name);
        //    }

        //    Console.WriteLine();
        //    Console.WriteLine("Press any key to exit...");
        //    Console.ReadKey();
        // Changing Console Font
		//        [DllImport("kernel32.dll", SetLastError = true)]
		//        static extern bool SetCurrentConsoleFontEx(
		//IntPtr consoleOutput,
		//bool maximumWindow);

        static void Main(string[] args)
        {

            #region Variables
            string speakandspell;
            string[] Azed = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
           int time = 2600;
            Console.CursorVisible = false;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ConsoleColor printblack = ConsoleColor.Black;
            ConsoleColor printwhite = ConsoleColor.White;
            ConsoleColor printdarkgrey = ConsoleColor.DarkGray;
            ConsoleColor printlightgrey = ConsoleColor.Gray;
            ConsoleColor printdarkblue = ConsoleColor.DarkBlue;
            ConsoleColor printlightblue = ConsoleColor.Blue;
            ConsoleColor printlightred = ConsoleColor.Red;
            ConsoleColor printdarkred = ConsoleColor.DarkRed;
            ConsoleColor printdarkyellow = ConsoleColor.DarkYellow;
            ConsoleColor printlightyellow = ConsoleColor.Yellow;
            ConsoleColor printlightgreen = ConsoleColor.Green;
            ConsoleColor printdarkgreen = ConsoleColor.DarkGreen;
            #endregion

            #region StartScreen
            //maximizing console
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);

            
            Console.ReadKey();
            //Screen.ScreenPrompt("Chapter 2");
           
            //maximizing console
            // play wav
            //Soundz.Actor("imalive.wav");
            //Soundz.Actor("mdial1.wav");
            Soundz.Mdial();
           // Soundz.Actor("opencmd.wav");
            Soundz.OpenCmdSnd();

            //Work on these lines ---------------------
            //CinemaHelpers.CmdConType(" Command the Console");
            //CinemaHelpers.commandconsole("Command the Console");
            //CinemaHelpers.CmdConWithTyping("Command the Console");

            // Main Start up Screen
            Console.ReadKey();
           // Screen.MMain();
            #endregion

            // Initialize a new instance of the SpeechSynthesizer.
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output. 
            synth.SetOutputToDefaultAudioDevice();

            //Console.WriteLine("Installed voices -");
            //foreach (InstalledVoice voice in synth.GetInstalledVoices())
            //{
            //    VoiceInfo info = voice.VoiceInfo;
            //    Console.WriteLine(" Voice Name: " + info.Name);
            //    Personality.Miamoto(" Voice Name: " + info.Name);
            //    Thread.Sleep(1500);
            //}

            //Console.WriteLine();
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();

            // Chapter One
            //            #region ChapterOne
            //            synth.Speak("An Adventure Of Switch Flippers");

            //            // The at symbol allows multi line strings
            //            speakandspell = @" A silent moment passed as it was in the beginning, a quite moment, before a
            //sudden exceptional event proceeded again by an unfurling, an advent, a serenity
            //and silence.He sat in his lab as it was in the beginning and at the end; nothing has
            //ever been the same.
            // ";
            //synth.Speak(speakandspell);

            //            speakandspell = "Hey Nibble";
            //            Personality.mybyte(speakandspell);
            //            speakandspell = "Yeah Byte";
            //            Personality.nibble(speakandspell);
            //            #endregion
            // ChapterOne.easteregg();

			
            #region MovieCore

            #region Chapter1
            MusicFx.BFire();
            SpecialFx.BinaryFlood();

            ChapterOne.myChapterOne();
            CinemaHelpers.Timer(1000);
            #endregion


            //////nibble & byte
            //ChapterTwo.myChapterTwo();
            //Thread.Sleep(1000);

            //ChapterThree.myChapterThree();
            //Thread.Sleep(1000);

            //ChapterFour.myChapterFour();
            //Thread.Sleep(1000);

            //ChapterFive.myChapterFive();
            //Thread.Sleep(1000);

            //ChapterSix.myChapterSix();
            //Thread.Sleep(1000);

            //// ch 7 and 8 work

            //ChapterSeven.myChapterSeven();
            //Thread.Sleep(1000);

            //ChapterEight.myChapterEight();
            //Thread.Sleep(1000);

            //ChapterNine.myChapterNine();
            //Thread.Sleep(1000);

            // Console.ReadKey();
            ChapterTen.myChapterTen();
            Thread.Sleep(1000);

            Screen.Endscreen();

            #region Test Region
            //Test
            //Personality.Simulus();
            //Scratchpad.Scratch1();
            // Scratchpad.Scratch2();
            // DigitalDna.DigitalGlyph5();

            Console.Write('\u2663'); // club
            Console.Write('\u2660'); // spade
            Console.Write('\u2665'); // heart
            Console.Write('\u2666'); //diamond
            // DigitalDna.DigitalGlyph6(10000);
            Console.ReadKey();

            speakandspell = "Command Console!..... tyhcghtftycghcghfvvnhvhtytygh h ghtytyvkhgvvg5ryfyu67";
            // speakandspell = "Command Console!";
            //Personality.Haruka(speakandspell);
            //Personality.Hazel(speakandspell);
            //Personality.Otto(speakandspell);
            // CinemaHelpers.Asimbot(speakandspell);
            //CinemaHelpers.Asimbot(speakandspell);
            // CinemaHelpers.qproc(speakandspell);
            //  Personality.MegaByte(speakandspell, "u22");
            //Personality.MegaByte(speakandspell);
            //Personality.HelpMiamoto(speakandspell);
            
            Thread McpTao = new Thread(MusicFx.cptao);
            Thread staticvoidmutex = new Thread(MusicFx.staticvoidmutex);
            staticvoidmutex.Start();

            Scratchpad.Format(speakandspell);
            SpecialFx.stopwatch();
            Personality.FunNarrator(speakandspell);
            staticvoidmutex.Suspend();
            Console.ReadKey();

            //Thread SpfxThrob = new Thread(SpecialFx.spfxpassgenpyramid);
            // Thread SpfxThrob2 = new Thread(SpecialFx.spfxpassgenpyramid);

            // SpfxThrob.Start();
            //SpecialFx.spfxpassgenpyramid();
            //SpecialFx.Throbber("Thor");
            // SpfxThrob2.Start();

            //Screen.spfxglitchscreen();
            //SpecialFx.spfxgenglitch();

            //CinemaHelpers.commandconsole(speakandspell);
            //SpecialFx.spfxpassgenpyramid();

            //SpecialFx.ScrollingDown(speakandspell);
            //SpecialFx.spacedscrollingflood(speakandspell);
            //SpecialFx.scrollingdownflood(speakandspell);

            //Screen.dataclouds();

            //Personality.BinaryFire(speakandspell);
            //SpecialFx.OpenCommand();
            //SpecialFx.JacktheRipper();

            //SpecialFx.NumFlood();

            //SpecialFx.PyramidalPrompt(1000);
            //SpecialFx.PyramidalPrompt(100);

            //SpecialFx.PromptData();
            //Graphix.GraphingCalculator();
            //SpecialFx.Thinking();
            // Screen.ScreenPrompt("Funky");
            // SpecialFx.RacingStar();
            // SpecialFx.speedRacingStar();
            //SpecialFx.RacingRabbit();
            // SpecialFx.BackandForth();

            // move to special fx
            //Tests.NumBurn();

            //            Console.CursorTop = 15;
            //            Console.CursorLeft = 52;
            //            Console.WriteLine("Winter has come \n");
            //            Console.WriteLine();
            //            SpecialFx.Cswatch();

            //            SpecialFx.AsciiTable();
            //            Console.WriteLine();
            //            Scratchpad.Format(@"-.-.
            //| | |, ---., ---., ---., ---., ---..  ,,   .
            //| | ||   ||    |   ||   ||   | >< |   |
            //` ' '`---'`    `---'`   '`---''  ``---|
            //                                  `---'");
            //            Console.ReadKey();
            //            Console.ReadKey();
            //            Console.CursorTop = 15;
            //            Console.CursorLeft = 52;
            //            Console.WriteLine("Winter has come");
            //            Scratchpad.Format("Try me");
            //            Console.ReadKey();
            //            SpecialFx.Throbber(" Scanning: ");
            //            Console.ReadKey();
            //            Personality.nibble(@"-.-.
            //| | |, ---., ---., ---., ---., ---..  ,,   .
            //| | ||   ||    |   ||   ||   | >< |   |
            //` ' '`---'`    `---'`   '`---''  ``---|
            //                                  `---'");
            //            SpecialFx.splitstring(@"-.-.                                  
            //| | |,---.,---.,---.,---.,---..  ,,   .
            //| | ||   ||    |   ||   ||   | >< |   |
            //` ' '`---'`    `---'`   '`---''  ``---|
            //                                  `---'");

            //            Console.ReadKey();
            Soundz.Actor("schedule.wav");
            Soundz.OpenCmdSnd();
            Soundz.OpenCmdSnd();
            Soundz.Mdial();
            Soundz.Actor("ring.wav");

            SpecialFx.splitstring(speakandspell);
            SpecialFx.splitstring(" DDDDDDDDDF  FEFEE            FFFFFFFFFFFF EEEEEEEE GGGGGGGGG");
            SpecialFx.ScreenTyper(" DDDDDDDDDF  FEFEE            FFFFFFFFFFFF EEEEEEEE GGGGGGGGG");

            //SpecialFx.stringtonum("hello world");
            Console.Write('\u2103');
            Console.Write('\u058D');
            Console.Write('\u2116');
            Console.Write('\u2620');
            Console.Write('\u0169');
            Console.Write('\u4042');
            // card suits
            Console.Write('\u2663');
            Console.Write('\u2660');
            Console.Write('\u2665');
            Console.Write('\u2666');
            #endregion

            #endregion


            //Console.WriteLine("Installed voices -");
            //foreach (InstalledVoice voice in synth.GetInstalledVoices())
            //{
            //    VoiceInfo info = voice.VoiceInfo;
            //    Console.WriteLine(" Voice Name: " + info.Name);
            //}

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        } 
    } 
} // end of namespace!

