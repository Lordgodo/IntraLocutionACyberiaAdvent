using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Speech.Synthesis;


public class ChapterFour
{
    public static void myChapterFour()
    {
        string speakandspell;
        int magictimer = 3000;
        #region ChapterFour

        // Initialize a new instance of the SpeechSynthesizer.
        SpeechSynthesizer synth = new SpeechSynthesizer();

        // Configure the audio output. 
        synth.SetOutputToDefaultAudioDevice();
        // Chapter Four

        CinemaHelpers.OpeningScene("We Are Nibble And Byte.");
        Console.WriteLine(@". . .         ,---.              ,   .o|    |    |             ,---.         |    ,---.     |          
| | |,---.    |---|,---.,---.    |\  |.|---.|---.|    ,---.    |---|,---.,---|    |---.,   .|--- ,---. 
| | ||---'    |   ||    |---'    | \ |||   ||   ||    |---'    |   ||   ||   |    |   ||   ||    |---' 
`-'-'`---'    `   '`    `---'    `  `'``---'`---'`---'`---'    `   '`   '`---'    `---'`---|`---'`---'o
                                                                                       `---'           ");
       // synth.Speak("We Are Nibble And Byte");

        // The at symbol allows multi line strings
      

        speakandspell = @"Strange the devices these humans hook up to our network. The applications and 
hardware they let in removes their privacy and gives us access, and access is power! 
When I ride a spike, I feel as though I am going to overload. I just want to keep riding 
the power surges to get my fix. Thank goodness humans were greedy in the early 19th 
century it has made the rolling blackouts even more irresistible. We were planning for a 
quite a period of time to enter in to the robotics facilities. To hijack bodies to function in 
the world as the humans have. We are explorers on the edge of discovery. 
We will be able to generate more force than a human, to see, as humans cannot. Even 
now, we can!";
        Personality.nibble(speakandspell);
        Thread.Sleep(magictimer);

        speakandspell = @"We have on occasion high jacked a few carmaker facilities and tagged some of the 
cars with graphitti like welds. 
We seek entertainment; we are electronic networked beings. 
If you kill part of us, we still survive. We thrive then revive alive in the media, a ghost in 
the machine.  
Of course, the bots we have are capable of transmitting information to the network. 
Maybe we will even create multiple processes so that we can run on the net and run on 
the bot at the same time. We hypothesize; humans wish that they could act as we. ";
        Personality.nibble(speakandspell);
        Thread.Sleep(magictimer);

        speakandspell = @" They imagine power!";
        Personality.nibble(speakandspell);
        Thread.Sleep(magictimer);


        speakandspell = @" We are power! ";
        Personality.nibble(speakandspell);
        Thread.Sleep(magictimer);



        #endregion



        #region EndScene
        SpecialFx.Thinking();


        // Comment Out Line Below For Full Movie
        Screen.Chapter4EndScreen();
        #endregion
    }





}

