using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Speech.Synthesis;


public class ChapterTwo
{
    public static void myChapterTwo()
    {
        string speakandspell;
        #region ChapterTwo

        // Initialize a new instance of the SpeechSynthesizer.
        SpeechSynthesizer synth = new SpeechSynthesizer();

        // Configure the audio output. 
        synth.SetOutputToDefaultAudioDevice();
        
       // Chapter Two 11:42 pm - Another Flip Switched
        CinemaHelpers.SpaceandClean();
        CinemaHelpers.TheCorp();
        Console.WriteLine(@"
 '| '| |  |,--.                         ,---.          |    |                  ,---.|    o         ,---.     o|         |             |
  |  |o`--|,--'    ,---.,-.-.           |---|,---.,---.|--- |---.,---.,---.    |__. |    .,---.    `---.. . ..|--- ,---.|---.,---.,---|
  |  |    ||       |   || | |    ---    |   ||   ||   ||    |   ||---'|        |    |    ||   |        || | |||    |    |   ||---'|   |
  `  `o   ``--'    |---'` ' '           `   '`   '`---'`---'`   '`---'`        `    `---'`|---'    `---'`-'-'``---'`---'`   '`---'`---'");
        // Console.WriteLine(" 11:42 pm - Another Flip Switched  ");

        speakandspell = @"
 '| ' | |  |,--.                         ,---.          |    |                  ,---.| o         ,---.o |         |             |

|  | o`--|,--'    ,---.,-.-.           |---|,---.,---.|--- |---.,---.,---.    |__. |    .,---.    `---.. . ..|--- ,---.|---.,---.,---|
 |  |    ||       |   || | | ---    |   ||   ||   ||    |   || ---'|        |    |    ||   |        || | |||    |    |   ||---' |   |
  `  `o   ``--'    |---'` ' '           `   '`   '`---'`---'`   '`---'`        `    `---'`|---'    `---'`-' - '``---'`---'`   '`---'`---' " ;
       // Scratchpad.Format(speakandspell);
        // Console.WriteLine(" 11:42 pm - Another Flip Switched  "
        synth.Speak(" 11:42 pm - Another Flip Switched  ");
        CinemaHelpers.Timer(3600);
        CinemaHelpers.SpaceandClean();

        speakandspell = @"
            Connecting
            192.168.2.1";

        Personality.RedQueenNarrator(speakandspell, 10);

        Filez.readtxtbyline("defaultips.txt");

        speakandspell = @"
Zyxel
192.168.1.1
192.168.0.1
192.168.2.1
192.168.4.1
192.168.10.1
192.168.1.254
192.168.254.254
10.0.0.2
10.0.0.138";
        Personality.RedQueenNarrator(speakandspell, 10, 1000);
        CinemaHelpers.TheCorp();
        // The at symbol allows multi line strings
        speakandspell = @" In our last adventures, our friends Nibble and Byte were pushing their way through 
  the Big Iron. They have never given up, even when the honey pots are trying to trap 
  them, they are aware of their presence in the Beowulf cluster or working their way 
  through Athena operating systems. It is ok kids! Their encryption sorting is faster than 
  any Btree written. ";

        //  Console.WriteLine(speakandspell);

        Personality.FunNarrator(speakandspell);
        CinemaHelpers.TextSpace();


        speakandspell = @"
Scanning
192.168.254.254
10.0.0.2
10.0.0.138";
        Personality.RedQueenNarrator(speakandspell, 10, 1000);
        CinemaHelpers.TheCorp();
        //Personality.Narrator(speakandspell);


        speakandspell = @" Every quick sort laid dead, trying to keep up with their key work.  
  I would not call Nibble or Byte very human.
  They are AI and they love mischief more than any mere mortal. They were not written by
  human hands, or minds, at least not in their current form. They evolved from the ever
  growing robust network. Sometimes our friends experience such strange sensations such
  as that of an over intelligence glaring within them.";
        Personality.FunNarrator(speakandspell);

        CinemaHelpers.TextSpace();
        //create text spacer method
        speakandspell = @"
 Found
### ###
10.0.0.2";
        Personality.RedQueenNarrator(speakandspell, 10, 1000);
        CinemaHelpers.TheCorp();

        speakandspell = @" They have hired humans, who they pipe money through, so that they can acquire 
  more storage or gain access to other systems that they do not want to crack because 
  they become bored of the null cycles that they have to go through to acquire access to 
  new machines. These humans also perform other routine tasks that they don't want to 
  do themselves.";

        //Console.WriteLine(speakandspell);
        // Personality.Narrator(speakandspell);
        Personality.FunNarrator(speakandspell);
        CinemaHelpers.TextSpace();


        speakandspell = @"
@ # Saved PWD Dump ";
        Personality.RedQueenNarrator(speakandspell, 10, 1000);
        CinemaHelpers.TheCorp();

        speakandspell = @"  I suppose one might say that the computer passed the Turing test. 
    The now old Turks of AI would be proud. Some security experts are starting to believe that there may 
    be AI and they are in search of this mystery, like any crypto zoologist. They are simply 
    more obsessed. Obsession on occasion drives mortals to strange ends and 
    entanglements.  
    They think that the AI exists because they have discovered evidence of odd check sums 
    that do not look like the product of human algorithms. These investigators then 
    performed software forensics to help them to discover the who, of the matter no who 
    was found. This might confound. AI is still evolving and this AI thinks that another AI 
    may spontaneously generate. Another switch flipped. ";

        //Console.WriteLine(speakandspell);
        //Personality.Narrator(speakandspell);
        Personality.FunNarrator(speakandspell);
        //synth.Speak(speakandspell);


        speakandspell = @"
            Disconnecting
            192.168.2.1";

        Personality.RedQueenNarrator(speakandspell, 10);

        CinemaHelpers.RefreshConsole();
        CinemaHelpers.TextSpace();




        #endregion

        #region EndScene
        SpecialFx.Thinking();


        // Comment Out Line Below For Full Movie
        Screen.Chapter2EndScreen();
        #endregion
    }







}

