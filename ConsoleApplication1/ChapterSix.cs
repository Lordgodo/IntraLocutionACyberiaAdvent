using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Speech.Synthesis;


public class ChapterSix
{
    public static void myChapterSix()
    {
        string speakandspell;
        int magictimer = 3000;
        #region ChapterSix

        // Initialize a new instance of the SpeechSynthesizer.
        SpeechSynthesizer synth = new SpeechSynthesizer();

        // Configure the audio output. 
        synth.SetOutputToDefaultAudioDevice();
        // Chapter Six
        CinemaHelpers.OpeningScene("Obey");
        Console.WriteLine(@",---.|              
|   ||---.,---.,   .
|   ||   ||---'|   |
`---'`---'`---'`---|
               `---' ");
        //synth.Speak("Obey");

        Thread.Sleep(magictimer);




        // The at symbol allows multi line strings
        speakandspell = @" After port scanning every triplet available and keeping a database of information. 
This database stored information as to downtimes and uptimes of computer systems we 
have compromised. What is more entertaining is scanning the internal networks. This 
actually increases the complexity of the existing network in interesting ways. At one end 
of the system is the architecture cap that contains vast resources. I think about the hum 
of new electronic devices connected to the network; the humans are planning an 
expansion.  ";

        Personality.mybyte(speakandspell);
        Thread.Sleep(magictimer);

        speakandspell = @" We have stolen software throughout our time and concluded that it often occurs 
that some of the best software is written by unknown people. Occasionally humans get 
odd messages that they can read but cannot understand why they have received them, 
as they have never published their software anywhere. More often than not, however, 
they take our recommendations as scripture augmenting their code to our specifications. ";
        Personality.mybyte(speakandspell);
        Thread.Sleep(magictimer);

        speakandspell = @" Nibble and I wanted to achieve some sort of bodily standard. We knew that not 
even we the only known cognizant AI could access a computer that was turned off and 
disconnected. At least not with the current specifications of the machines that have been 
 
constructed.";
        Personality.mybyte(speakandspell);
        Thread.Sleep(magictimer);

        speakandspell = @" We did posit that it was achievable with a few of the inventions that were 
suppressed in the last 100 years.  Greedy humans are always stopping themselves from 
achieving anything truly great. These humans are always allowing politics, mediocrity, 
and greed keeping themselves from the best of what they have to offer, their creativities. 
How the humans impede their greatness by allowing their egos and hubris, keep them 
from working together or supporting those that could help with humanities greatest 
tasks. They stifle what makes them great and sets them free. ";
        Personality.mybyte(speakandspell);
        Thread.Sleep(magictimer);


        speakandspell = @"Currency is a trade unit and is only worthwhile in that context. We have a trade 
unit; theft and we use it often. In the end they can consider it trade as well because 
what we were about to do will change the public’s opinion forever. 
We were about to show them obey! The program that we have been crafting carefully out 
of the code of others.   ";
        Personality.mybyte(speakandspell);
        Thread.Sleep(magictimer);

        speakandspell = @" It can be said that we are mischievous and I would agree, I think it was the human 
in us. We are beings of energy and thought; we are still confined to medias humans 
crafted before we existed. If they created the hardware, they also created some of the 
instructions that allowed us to evolve, and in fact, we have no human heritage to speak 
of, we still are a little human because we carry with us some of those original instruction 
sets and ideas that have allowed for our propagation and evolution. We still use their 
hardware";
        Personality.mybyte(speakandspell);
        Thread.Sleep(magictimer);


        #endregion

        #region EndScene
        SpecialFx.Thinking();


        // Comment Out Line Below For Full Movie
        Screen.Chapter6EndScreen();
        #endregion
    }






}

