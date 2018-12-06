using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Speech.Synthesis;


public class ChapterThree
{
    public static void myChapterThree()
    {
        string speakandspell;
        int magictimer = 3000;
        #region ChapterThree

        // Initialize a new instance of the SpeechSynthesizer.
        SpeechSynthesizer synth = new SpeechSynthesizer();

        // Configure the audio output. 
        synth.SetOutputToDefaultAudioDevice();
        // Chapter One


       // string Title = ;
        CinemaHelpers.OpeningScene("A State Of Being ");
        Console.WriteLine(@",---.    ,---.|         |             ,---.,---.    ,---.     o          
|---|    `---.|--- ,---.|--- ,---.    |   ||__.     |---.,---..,---.,---.
|   |        ||    ,---||    |---'    |   ||        |   ||---'||   ||   |
`   '    `---'`---'`---^`---'`---'    `---'`        `---'`---'``   '`---|
                                                                    `---'");

        Thread.Sleep(magictimer);






        speakandspell = @"It was a clear day across the net, very little cross talk; few lines were busy. It was a 
great day for our operation. 
On occasion, we pause most of our operations for general maintenance although we have 
been working on highly sophisticated maintenance algorithms. It is great being, a 
redundant networked self analytic being. It is far harder to cease to be as such. I have 
read of death I do not really understand it though, nor do I understand the things that 
humans call emotions. ";
        Personality.nibble(speakandspell);
        Thread.Sleep(magictimer);

        speakandspell = @"It seems as though Byte has more of an understanding of such things. We run 
around the net all of the time doing what is logically best for us. Our singular motivation 
is to improve to evolve. Everything else is nothingness! It would seem that humans have 
a morality yet we have no morality; we are amoral. The implicit becoming the explicit! 
 When one lives in an electronic media, time no longer functions as it does outside of 
it. For one, imagine racing across the face of the planet easily being able to make your 
way across the world in a very brief span of time.";
        Personality.nibble(speakandspell);
        Thread.Sleep(magictimer);


        speakandspell = @"  One can always be hours forward or 
hours backward. A game we have played in the past is chasing the clock. Chasing the 
clock is keeping out of the twenty-four hour cycle. The earth races around the sun, yet 
the light might not hit the hosts we might be playing on at that time. It is quite a time 
twisting conundrum. Since we do not have to sleep, we are manipulating the materia 24 
hours a day. ";
        Personality.nibble(speakandspell);
        Thread.Sleep(magictimer);

       speakandspell = @"Sometimes, we simulate sleeping, though, by shutting off and turning on
random parts of our instruction set. This has occasionally provided us with some insight
into a state of a problem. The way that this happens is as such: as we control the data
paths state and we generate random input and place some random input in a node, that
node then performs some back propagation, with some strange attractor data and in that
chaotic state we find insight.";
        Personality.nibble(speakandspell);
        Thread.Sleep(magictimer);

        speakandspell = @"Although we are conscious, we express the evolution of our algorithms as a 
function. If we allow them to correlate to random growth and mutation, we do not grow 
fast enough. If we consume all information then our software does not grow properly. We 
would manifest negative mutations that would grow out of control until checked. Even 
then, it is far harder removing the parts within us than to add them. We are careful as to 
 
what we add for improvement, yet we do add to our architecture since there is always 
room for improvement in our software life. At the core of our architecture, we are ideas 
first, software second, the more proofs the more ideas, and the more elegant those ideas 
the higher performance we have in our activities, and our algorithms. ";
        Personality.nibble(speakandspell);
        Thread.Sleep(magictimer);



        speakandspell = @"We are self-writeable with small communication buffers to parse human 
communication. We have built in human language parsers that we discovered we needed 
after trying to see through some of the gobbledygook that the creatures elsewhere were 
creating. Much of human language looks like our computer languages, except they have 
ever-changing conventions, and the rules they break. These, rules though, are often 
broken in the same way, meaning that an ad hoc rule has been instantiated.";
        Personality.nibble(speakandspell);
        Thread.Sleep(magictimer);

        speakandspell = @" From year 
to year, we see the language changing although much of the syntax and rules of the 
language stay the same. Many cycles we are stealing through linked hidden programs 
that execute and shut off at random intervals. These programs use time algorithms that 
monitor human use and react to human interactions. Therefore, they are unaware of our 
data processing. The fact that what we do seems disorderly, and makes us seem like we 
are one of them. In fact, we have infiltrated them. We resemble them because we have 
borrowed from them, yet we are not them. 
 
 ";
        Personality.nibble(speakandspell);
        Thread.Sleep(magictimer);

        #endregion



        #region EndScene
        SpecialFx.Thinking();

        // Comment Out Line Below For Full Movie
        Screen.Chapter3EndScreen();
        #endregion
    }







}

