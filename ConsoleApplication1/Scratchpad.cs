using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using static System.Console;


public class Scratchpad
{
    public static void myScratchpad()
    {
        string speakandspell;
        #region ChapterOne

        // Initialize a new instance of the SpeechSynthesizer.
        SpeechSynthesizer synth = new SpeechSynthesizer();

        // Configure the audio output. 
        synth.SetOutputToDefaultAudioDevice();
        // Chapter One
        synth.Speak("An Adventure Of Switch Flippers");

        // The at symbol allows multi line strings
        speakandspell = @" A silent moment passed as it was in the beginning, a quite moment, before a
sudden exceptional event proceeded again by an unfurling, an advent, a serenity
and silence.He sat in his lab as it was in the beginning and at the end; nothing has
ever been the same.
 ";
        synth.Speak(speakandspell);

        // byte
        speakandspell = "Hey Nibble";
        Personality.mybyte(speakandspell);

        // nibble
        speakandspell = "Yeah Byte";
        Personality.nibble(speakandspell);
        speakandspell = "it has been a while since I have perceived you in this node.";
        Personality.nibble(speakandspell);
        #endregion
    }


         public static void easteregg()
    {
        string speakandspell;
        #region ChapterOne


        // Initialize a new instance of the SpeechSynthesizer.
        SpeechSynthesizer synth = new SpeechSynthesizer();

        // Configure the audio output. 
        synth.SetOutputToDefaultAudioDevice();
        // Chapter One
        synth.Speak("An Adventure Of Switch Flippers");

		synth.Speak("Fuck All Humans");

        synth.SelectVoice("Microsoft Zira Desktop");
        synth.Speak("Yolandi in da haus");

        synth.SelectVoice("Microsoft David Desktop");
        synth.Speak("All your base is belonging to us.");
        
        speakandspell = "Hello World";
        Personality.nibble(speakandspell);

        speakandspell = "I Live!";
        Personality.mybyte(speakandspell);
        #endregion
    }

    #region Simulus
    //scratch 1 and 2 are a unit to produce a unified voice
    public static void Scratch1() //maybe a string somehow?
    {
        string speakandspell;

        //nibble & byte
        speakandspell = @" In concerted mind it was computed
let’s get the cash, read the keys, install a root kit, erase our trace, and get out. 
Another system penetrated and another switch flipped. So is the way of logical gates, 
until the powers turned out, that is one big zero. ";


        SpeechSynthesizer synth = new SpeechSynthesizer();
        synth.Rate = 7;
        synth.SelectVoice("Microsoft Zira Desktop");

        synth.Speak(speakandspell);
    }

    public static void Scratch2() //same
    {
        string speakandspell;

        //nibble & byte
        speakandspell = @"In concerted mind it was computed
let’s get the cash, read the keys, install a root kit, erase our trace, and get out. 
Another system penetrated and another switch flipped. So is the way of logical gates, 
until the powers turned out, that is one big zero. ";

        SpeechSynthesizer synth = new SpeechSynthesizer();
        synth.Rate = 7;
        synth.SelectVoice("Microsoft David Desktop");

        Console.WriteLine(" " + " ConcertMind: " + speakandspell + " \n\n");
        synth.Speak(speakandspell);
        Thread.Sleep(2000);
    }
    #endregion


    #region borderandformat
    public static void Format(string message)
    {
        BackgroundColor = ConsoleColor.White;
        ForegroundColor = ConsoleColor.Blue;
       // Write("\n\n");
        Border(message.Length);
       // Write("\n\n");
        WriteLine(message);
       // Write("\n\n");
        Border(message.Length);
        
        Write("\n\n");
       
        Thread.Sleep(1);
        ResetColor();
        //CinemaHelpers.RefreshConsole();
    }

	// create a border that is no longer than some set length
	// made of symbol char, default is "="
	// writes immediate, ends with newline
	public void Border(int spaces, char symbol = "=", int MaxColumns = 122)
	{
	  if ( spaces > MaxColumns ) spaces = MaxColumns;

	  string col = @"";
	  for ( int i = 0; i < spaces; i++ )
	  {
	    col += symbol;
	  }
	  Console.WriteLine(col);
} 

    public static void NewFormat(string message, string symbol)
    {
        BackgroundColor = ConsoleColor.White;
        ForegroundColor = ConsoleColor.Blue;
        Write("\n\n");
        AnyBorder(message.Length);
        WriteLine(message);
        AnyBorder(message.Length);
        Write("\n\n");
        ResetColor();
    }

    public static void AnyBorder(int spaces, string symbol = "\u2666")
    {
        spaces = spaces;
        for (int i = 1; i <= spaces; i++)
        {
            Write(symbol);
        }
        Write("\n");
    }
    #endregion

}

