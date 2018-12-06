using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using   System.Threading;

using System.Threading.Tasks;
using System.Speech.Synthesis;


public class ChapterSeven
{
    public static void myChapterSeven()
    {
        string speakandspell;
        Console.CursorVisible = false;
        #region ChapterSeven
        CinemaHelpers.RefreshConsole();
        Thread McpTao = new Thread(MusicFx.cptao);
        McpTao.Start();

        // Initialize a new instance of the SpeechSynthesizer.
        SpeechSynthesizer synth = new SpeechSynthesizer();

        // Configure the audio output. 
        synth.SetOutputToDefaultAudioDevice();
        // Chapter Seven
        CinemaHelpers.OpeningScene("In Search Of A Body ");
        Console.WriteLine(@"|         ,---.                    |        ,---.,---.    ,---.    ,---.         |     
|,---.    `---.,---.,---.,---.,---.|---.    |   ||__.     |---|    |---.,---.,---|,   .
||   |        ||---',---||    |    |   |    |   ||        |   |    |   ||   ||   ||   |
``   '    `---'`---'`---^`    `---'`   '    `---'`        `   '    `---'`---'`---'`---|
                                                                                  `---' ");

        Thread.Sleep(760);

        // The at symbol allows multi line strings
        speakandspell = @" Through our hacker’s actions and research, they still can do a few things that we 
cannot do. Like intercept auditory messages from engineers from the Toyota labs. 
  ";

        CinemaHelpers.SpaceandClean();
        Personality.nibble(speakandspell);
        Thread.Sleep(2000);

        speakandspell = @"Through Phyber, we discovered that Toyota was working on a top-secret prototype with 
neuronal chips in a optical media, an electronic brain. We thought it would be a great 
idea to inhabit the body and do some work of our own.";

        CinemaHelpers.SpaceandClean();
        Personality.nibble(speakandspell);
        Thread.Sleep(2000);



        speakandspell = @" There are a few problems that we 
must solve first. One, the robot is not always connected to the network. From the scans 
we have made when they were connected to the network, the neural chips work with 
different instruction sets than the logic that we are used to performing. We need to find 
and understand the data on the neural chips and then reverse engineer the data. This 
will allow for the construction of an interface. That when we are ready to connect, we will 
be prepared to take advantage of all of the idiosyncrasies of the architecture.";
        CinemaHelpers.SpaceandClean();
        Personality.nibble(speakandspell);
        Thread.Sleep(2000);




        speakandspell = @"

Scanning...
Null 
Scanning..... 
Null 
Initiating Vocoder software. 
Ring  
 


";


        // Console.Write("Scanning ");
        // Console.WriteLine(speakandspell);
        CinemaHelpers.commandconsole(speakandspell);

        SpecialFx.Throbber("Scanning");
        Console.WriteLine(" Null    \"u0000");
        Soundz.Actor("ring.wav");
        Console.Beep(37, 2);
        Thread.Sleep(50);
        SpecialFx.Throbber("Scanning");
        Console.WriteLine(" Null    \"u0000");
        Soundz.Actor("ring.wav");
        Console.Beep(37, 2);
        Thread.Sleep(100);
        // maybe import ringing and pop
        speakandspell = @"Initiating Vocoder software. ";
        CinemaHelpers.commandconsole(speakandspell);
        //Console.WriteLine(speakandspell);

        Thread.Sleep(500);

        speakandspell = @" Hello, Phyber can you tell me when they are connecting the U22 electronic robot prototype? ";
        Personality.mybyte(speakandspell);
        Thread.Sleep(250);
        Soundz.Actor("schedule.wav");
        Soundz.Actor("postinfo.wav");
        Thread.Sleep(5200);

        CinemaHelpers.DejaVu();
        CinemaHelpers.qproc(speakandspell = " ");

        Thread.Sleep(5000);


        speakandspell = @"

  .model small
        .stack 100h
        .data
SLIP_END        equ 0C0h
SLIP_ESC        equ 0DBh
SLIP_ESC_END    equ 0DCh
SLIP_ESC_ESC    equ 0DDh

SEND_CHAR macro char
        IFDIFI <char>, <al>
                mov al,char
        ENDIF
        out dx,al
endm

RECV_CHAR macro
        in al,dx
endm
        .code

";
        //Console.WriteLine(speakandspell);
        //CinemaHelpers.qproc(speakandspell);
        CinemaHelpers.commandconsole(speakandspell);
        Thread.Sleep(5000);
        Console.CursorVisible = false;
        CinemaHelpers.RefreshConsole();
        speakandspell = @"42: Port interface post message.

                              Maintenance offline until Friday.";
        CinemaHelpers.commandconsole(speakandspell);

        //Console.WriteLine("42: Port interface post message.");

        // Console.WriteLine("Maintenance offline until Friday.");

        SpecialFx.Throbber(" Scanning: ");
        Console.WriteLine(@"

Connection. 0x0000001 A46B CF16  14
Response Adfasdfe512544t 90234tugmvi[329 - 5 ypvg - y29 yefgvmmunjbp65 g54r - 321ygv9i5 = 30gvhb125vg5rbm = 452h1 - 0i59 = -0vkhb = 2 - 456hv  529j0t50 - j2 = 45vih5ihh42h9gkg5gh--wdfhh - 40i25yt95--5 = 4y2 = 4 - 5yg 

");
        Console.WriteLine("\n \t Disconnect \n \n");

        speakandspell = @" You obviously saw that sequence of gobbledygook. 
It seems that we are going to have to obtain the protocol  
specifications to write the proper methods to connect to this  
fiber optic neural network protocol. ";

        Personality.nibble(speakandspell);

        speakandspell = " Specifications should be easy to obtain.";

        Personality.nibble(speakandspell);

        speakandspell = @"


 Initializing search sequence. 

spec.omx 
design.doc 
operation.txt 
rfc 7^23.txt 

";
        CinemaHelpers.commandconsole(speakandspell);

        speakandspell = " I just found it.";
        Personality.nibble(speakandspell);

        speakandspell = @" Now that the text is processed, I need to sequence our neural nodes to work on the 
problem. ";

        Personality.nibble(speakandspell);

        speakandspell = @" I am going to allow my networks to work on this problem for half a week.";

        Personality.mybyte(speakandspell);

        speakandspell = @" Byte, I will also use my networks for a half a week. By then we should have an 
elegant enough solution to interface with this robot. ";

        Personality.nibble(speakandspell);


        speakandspell = @" Toyota network administrators noticed unusual usage of applications that seemed 
too be a little too large, and are working too long. Yet they write it off as working
engineers working even harder. This is because we created false profiles and engineers 
who no one had ever met or remembered hiring yet they were completely happy since
these engineers were always creating solutions that would help the company’s bottom
line.Little did they know that our soon to be notorious pleasant friends were about to
dive into a very expensive machine. Maybe their next project will be to fly some of the
unmanned drones.


 ";
        //Personality.Narrator(speakandspell);
        Personality.FunNarrator(speakandspell);

        speakandspell = @" Well, Nibble, I have my half of the program written. ";

        Personality.mybyte(speakandspell);


        speakandspell = @" Byte I have the classes to extend your work.  ";

        Personality.nibble(speakandspell);

        speakandspell = @"  It seems that we are ready. ";

        Personality.mybyte(speakandspell);

        speakandspell = @"  Ah, yes, what an adventure this will be, Byte I have never experienced the outside 
world.  ";

        Personality.nibble(speakandspell);

        speakandspell = @"  What will be better is that we should write, and give Phyber a wireless network 
specification so that Toyota will allow this machine to be a network device.  ";

        Personality.mybyte(speakandspell);

        speakandspell = @" 

Opening text buffer. 
 
Closing text buffer. 
 
Specification Written. 
 
Robotics communication protocol. 
 
Initiating zombies. 
Arp poisoning. 
Proxy enabled. 
Signal initialized. 
Connection enabled. 
Money transferred.
Signal bounced. 
Vox initiated. 
 
 
Ring… 

";

        CinemaHelpers.commandconsole(speakandspell);
        Thread.Sleep(250);

        Soundz.Actor("ring.wav");
        Console.Beep(37, 2);
        Thread.Sleep(1770);

        speakandspell = "Hello Phyber, we transferred the money for allocation to your false accounts.";
        Personality.nibble(speakandspell);
        Thread.Sleep(3000);
        // phyber

        Soundz.Actor("findyou.wav");
        Thread.Sleep(7500);
        Thread.SpinWait(10);

        speakandspell = @" We are the quiet sort and we have a lot of work to do. 
We also transferred the robotics communications protocol. ";
        Personality.nibble(speakandspell);
        Thread.Sleep(3500);

        Soundz.Actor("sayyouwroteit.wav");
        Thread.Sleep(2500);
        Thread.SpinWait(10);

        speakandspell = @" Forward it to your compatriots to read.";
        Personality.mybyte(speakandspell);
        Thread.Sleep(2000);

        speakandspell = @"  Message sent. ";

        CinemaHelpers.commandconsole(speakandspell);
        Thread.Sleep(2500);

        Soundz.Actor("hardwarespec.wav");
        Thread.Sleep(2000);
        Thread.SpinWait(10);


       

        speakandspell = @"  Message sent. ";

        CinemaHelpers.commandconsole(speakandspell);


        speakandspell = @"

Disconnect. 
 
 
 
Unloading software. 
Clearing Memory 
Editing time stamps, and log files. 
Consistency checking. 
Checking against old back up files. ";

        CinemaHelpers.commandconsole(speakandspell);

        speakandspell = @" We were just born this way. ";

        Personality.mybyte(speakandspell);

        speakandspell = @" Disconnect ";

        CinemaHelpers.commandconsole(speakandspell);


        speakandspell = "Everything is in order Nibble. ";
        Personality.mybyte(speakandspell);

        speakandspell = "That’s great Byte.  ";
        Personality.nibble(speakandspell);

        speakandspell = @"

Phybers email. 
 
123.432.23.21 
 
Opening Text Buffer. “The proposal was a great success; they want to give me a raise. I obviously accepted 
their proposal, after some renegotiating.” 
 
 
Next Friday Closing Text Buffer. 
 ";

        CinemaHelpers.commandconsole(speakandspell);


        #endregion



        #region EndScene
        Thread.Sleep(60);
        SpecialFx.Thinking();

        // Comment Out Line Below For Full Movie
        Screen.Chapter7EndScreen();
        #endregion
    }


}

