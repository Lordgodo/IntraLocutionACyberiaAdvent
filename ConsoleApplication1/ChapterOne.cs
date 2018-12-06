using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Speech.Synthesis;


public class ChapterOne
{
    public static void myChapterOne()
    {
        string speakandspell;
        #region ChapterOne

        // Initialize a new instance of the SpeechSynthesizer.
        SpeechSynthesizer synth = new SpeechSynthesizer();

        // Configure the audio output. 
        synth.SetOutputToDefaultAudioDevice();
        // Chapter One
        CinemaHelpers.SpaceandClean();
        //ascii gen thin
        Console.WriteLine(@"
,---.         ,---.    |                |                       ,---.,---.    
|---|,---.    |---|,---|.    ,,---.,---.|--- .   .,---.,---.    |   ||__.    
|   ||   |    |   ||   | \  / |---'|   ||    |   ||    |---'    |   ||            
`   '`   '    `   '`---'  `'  `---'`   '`---'`---'`    `---'    `---'`   
                                                                                            

 
                        ,---.     o|         |        ,---.|    o                         
                        `---.. . ..|--- ,---.|---.    |__. |    .,---.,---.,---.,---.,---.
                            || | |||    |    |   |    |    |    ||   ||   ||---'|    `---.
                        `---'`-'-'``---'`---'`   '    `    `---'`|---'|---'`---'`    `---'
                                                                 |    |");





       speakandspell = @"
,---.         ,---.    |                |                       ,---.,---.    
|---|,---.    |---|,---|.    ,,---.,---.|--- .   .,---.,---.    |   ||__.    
|   ||   |    |   ||   | \  / |---'|   ||    |   ||    |---'    |   ||            
`   '`   '    `   '`---'  `'  `---'`   '`---'`---'`    `---'    `---'`   
                                                                                            

 
                        ,---.     o|         |        ,---.|    o                         
                        `---.. . ..|--- ,---.|---.    |__. |    .,---.,---.,---.,---.,---.
                            || | |||    |    |   |    |    |    ||   ||   ||---'|    `---.
                        `---'`-'-'``---'`---'`   '    `    `---'`|---'|---'`---'`    `---'
                                                                 |    |";


        SpecialFx.stringtonum(speakandspell);
        //    Console.WriteLine("An Adventure Of Switch Flippers");
        synth.Speak("An Adventure Of Switch Flippers");
        CinemaHelpers.Timer(3600);
        CinemaHelpers.SpaceandClean();

        
        // The at symbol allows multi line strings
        speakandspell = @" A silent moment passed as it was in the beginning, a quiet moment, 
before a sudden exceptional event proceeded again by an unfurling, an advent, a serenity
and silence. He sat in his lab as it was in the beginning and at the end; nothing has
ever been the same. 
 ";
        C.white();
        Console.WriteLine("\n  \t\t .LC0: \n\n \t .obj \n");
        C.lightgreen();
        Console.WriteLine(speakandspell);
        Personality.Narrator(speakandspell);

        //synth.Speak(speakandspell);

        CinemaHelpers.RefreshConsole();
        CinemaHelpers.TextSpace();
        // byte
        speakandspell = "Hey Nibble";
       
        Personality.mybyte(speakandspell);
        
     


        
        // nibble
        speakandspell = "Yeah Byte";
        
        Personality.nibble(speakandspell);
        
       

        speakandspell = " it has been a while since I have perceived you in this node. ";
        Personality.nibble(speakandspell);

        // byte
        speakandspell = @" Are you aware Byte that we just passed a reverse -1n anagrammatic phrase 
in the communication protocol that we have determined that would be best in practicing
our human syntax parsing and agreement ? ";
        Personality.mybyte(speakandspell);





        //nibble 
        speakandspell = " I am aware Byte. ";
        Personality.nibble(speakandspell);


        //byte
        speakandspell = @" Nibble, It is not as 
if there has been any interesting systems these days, mostly redundant network storage. 
Where is the luminosity, the brilliance? Have all of the humans gone to sleep? The
brilliance is sleeping. ";
        Personality.mybyte(speakandspell);

        //nibble
        speakandspell = "  It will awaken again, I am certain. ";
        Personality.nibble(speakandspell);

        //byte
        speakandspell = " Hanging around the big endian part of town has always been more fun anyway. ";
        Personality.mybyte(speakandspell);

        
       
        

        //byte
        speakandspell = " Have you kept yourself out of promiscuous mode lately Nibble? ";
        Personality.mybyte(speakandspell);

        speakandspell = @" What it is that you have described to me, Nibble, is a question I am certain that you 
know the answer to.";
        Personality.mybyte(speakandspell);

        speakandspell = " Promiscuity is part of the nature of a living information.";
        Personality.mybyte(speakandspell);

        speakandspell = @" Interpreting packets is part of digital life. The beautiful world of simplification of 
complicated ideas. It is a mathematicians dream. All acting, and we of this living 
ideoform. ";
        Personality.mybyte(speakandspell);


        //nibble
        speakandspell = " You know, Byte, you have always been a little smaller than me.";
        Personality.nibble(speakandspell);

        //byte
        speakandspell = " These things we have codified and described are true Nibble, but then again I know that there are some non-data structures that have higher prefixes than you do. ";
        Personality.mybyte(speakandspell);


        //nibble
        speakandspell = "  Byte, sometimes the bottom is the only place to be; it keeps you off the radar. ";
        Personality.nibble(speakandspell);

        //byte
        speakandspell = @" With all of these projects floating around in heaps and stacks, Nibble, you would 
figure that we would have found something interesting to do. ";
        Personality.mybyte(speakandspell);


        //nibble
        speakandspell = @" Byte, it’s only easy 
sailing when you get on a fat pipe, black fiber.That way you don't have to do all of the 
work.You can send your bots and zombies out to do your bidding. ";
        Personality.nibble(speakandspell);

        //byte
        speakandspell = @" You know 
Nibble, I have always been a bit old fashioned, enjoying my protocols getting dirty doing
some of the work. ";
        Personality.mybyte(speakandspell);

        speakandspell = @" Yes, but there is no reason to do redundant work. I guess not Nibble, but sometimes a 
Byte has to do what a Byte has to do.";
        Personality.mybyte(speakandspell);

        speakandspell = @" When is the last time that you built a packet 
by hand?";
        Personality.mybyte(speakandspell);

        //nibble
        speakandspell = @" It has been awhile, two milliseconds ago, Byte not since the time that I 
was searching for a zero day security flaw, digital jazz that would give me access.
I would maintain access for a while at least, until they publish the exploit in Phrack.";
        Personality.nibble(speakandspell);

        //byte
        speakandspell = " Even then, Nibble it, would seem that the admins have their hands tied and full.";
        Personality.mybyte(speakandspell);


        //nibble
        speakandspell = " Some early exploits still work Byte.";
        Personality.nibble(speakandspell);

        //byte
        speakandspell = @" Nibble, you cannot get away with it. At some point the monkey's going to write 
Shakespeare, you know there are just too many monkeys banging away at keyboards. ";
        Personality.mybyte(speakandspell);


        //nibble
        speakandspell = @" Byte Nothing’s sacred and it has never been, such is the way of the solid-state world, 
the digital Dao. High fidelity data output crashing, into liquid, that is what I want to be 
the modulation of my signal, to hear the digital scream of my birth. 
I know signal-processing devices have came unto there own these days. ";
        Personality.nibble(speakandspell);

        //byte
        speakandspell = @" Nibble, Give me a heath kit, and I will solder my way through this problem or any 
other problem. Another day another datum they say. ";
        Personality.mybyte(speakandspell);


        //nibble & byte
        //        speakandspell = @"In concerted mind it was said 
        //let’s get the cash, read the keys, install a root kit, erase our trace, and get out. 
        //Another system penetrated and another switch flipped. So is the way of logical gates, 
        //until the powers turned out, that is one big zero. ";
        //        Personality.ConcertMind(speakandspell);

        Personality.Simulus();
        Thread.Sleep(5600);






        #endregion

        #region EndScene
        SpecialFx.Thinking();


        // Comment Out Line Below For Full Movie
        Screen.Chapter1EndScreen();
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




}

