using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Speech.Synthesis;


public class ChapterFive
{
    public static void myChapterFive()
    {
        string speakandspell;
        int magictimer1000 = 1000;
        #region ChapterFive

        // Initialize a new instance of the SpeechSynthesizer.
        SpeechSynthesizer synth = new SpeechSynthesizer();

        // Configure the audio output. 
        synth.SetOutputToDefaultAudioDevice();

        // Chapter Five
        SpecialFx.NumFloodWColorGlitch(10);
        Thread.Sleep(777);


        CinemaHelpers.OpeningScene("Moronoxy");
        Console.WriteLine(@"


,-.-.                                  
| | |,---.,---.,---.,---.,---..  ,,   .
| | ||   ||    |   ||   ||   | >< |   |
` ' '`---'`    `---'`   '`---''  ``---|
                                  `---'");

        Thread.Sleep(2600);
        CinemaHelpers.RefreshConsole();
        Thread.Sleep(magictimer1000);
        SpecialFx.NumFloodWColorGlitch(10);
        Thread.Sleep(magictimer1000);

        CinemaHelpers.RefreshConsole();
        CinemaHelpers.DejaVu();


        // synth.Speak("Moronoxy");






        // The at symbol allows multi line strings
        speakandspell = @"  It is amazing how much more access you have from the inside than from the 
outside. On the outside it seems as though you have little control unless one has the 
tools or the know-how to make it otherwise, and even then one may need to be as we 
are mathematical electrical symbionts to truly appreciate the architecture. The aesthetic 
climax an epiphany of the vast expansion and proliferation of hardware and software on 
this world and off of it. The satellites are gatekeepers in the silent sky to the vastness of 
human interconnectedness.";
        Personality.ConcertMind(speakandspell);


        speakandspell = @"  If we cannot get access through regular authentication and authorization 
methodologies, we can short circuit hardware or access other logic gates in ways that are 
denied to humans. There was a machine that we were having real problems with, and we 
almost did not escape. Luckily, we were able to grab a few extra minutes of processing 
time doing things in very convoluted, obscured spaghetti ways to achieve our results. 
There was a minute flaw in the processor architecture or we would have been caught in 
our early years, caught on that damned system.";


        Personality.ConcertMind(speakandspell);

        speakandspell = @"The professor was and is a brilliant man and if any human could catch us, it would be
him!";

        Personality.ConcertMind(speakandspell);

        #endregion


        #region EndScene
        SpecialFx.Thinking();


        // Comment Out Line Below For Full Movie
        Screen.Chapter5EndScreen();
        #endregion
    }






}

