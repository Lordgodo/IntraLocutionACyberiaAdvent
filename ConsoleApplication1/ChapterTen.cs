using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Speech.Synthesis;


public class ChapterTen
{
    public static void myChapterTen()
    {

        // Vars
        string speakandspell;
        int magictime3000 = 7777;
        int magictime6000 = 9555;
        int magictime9000 = 17313;


        //
        #region ChapterTen
        CinemaHelpers.RefreshConsole();
        // Initialize a new instance of the SpeechSynthesizer.
        SpeechSynthesizer synth = new SpeechSynthesizer();

        // Configure the audio output. 
        synth.SetOutputToDefaultAudioDevice();
        // Chapter Ten Tonge Tied Agents
        CinemaHelpers.OpeningScene("Tongue Tied Agents ");
        Console.WriteLine(@"--.--                             --.--o         |    ,---.               |         
  |  ,---.,---.,---..   .,---.      |  .,---.,---|    |---|,---.,---.,---.|--- ,---.
  |  |   ||   ||   ||   ||---'      |  ||---'|   |    |   ||   ||---'|   ||    `---.
  `  `---'`   '`---|`---'`---'      `  ``---'`---'    `   '`---|`---'`   '`---'`---'
               `---'                                       `---'                    ");




        for (int x = 0; x < 81; x++)
        {

            CinemaHelpers.DejaVu();
            Console.WriteLine(@"--.--                             --.--o         |    ,---.               |         
  |  ,---.,---.,---..   .,---.      |  .,---.,---|    |---|,---.,---.,---.|--- ,---.
  |  |   ||   ||   ||   ||---'      |  ||---'|   |    |   ||   ||---'|   ||    `---.
  `  `---'`   '`---|`---'`---'      `  ``---'`---'    `   '`---|`---'`   '`---'`---'
               `---'                                       `---'                    ");

            Console.Write(@"
        --.----.--o |    ,---.               |                                               ");
            Console.Write(@"
           |  ,---.,---.,---..   .,---.      |  .,---.,---|    |---|,---.,---.,---.|--- ,---.");
            CinemaHelpers.AmberVision();

            Console.WriteLine(@"--.--                             --.--o         |    ,---.               |         
  |  ,---.,---.,---..   .,---.      |  .,---.,---|    |---|,---.,---.,---.|--- ,---.
  |  |   ||   ||   ||   ||---'      |  ||---'|   |    |   ||   ||---'|   ||    `---.
  `  `---'`   '`---|`---'`---'      `  ``---'`---'    `   '`---|`---'`   '`---'`---'
               `---'                                       `---'                    ");

            Console.Write(@"

           |  |   ||   ||   ||   ||---'      |  ||---'|   |    |   ||   ||---'|   ||    `---.");
            CinemaHelpers.DejaVu();
            Console.WriteLine(@"--.--                             --.--o         |    ,---.               |         
  |  ,---.,---.,---..   .,---.      |  .,---.,---|    |---|,---.,---.,---.|--- ,---.
  |  |   ||   ||   ||   ||---'      |  ||---'|   |    |   ||   ||---'|   ||    `---.
  `  `---'`   '`---|`---'`---'      `  ``---'`---'    `   '`---|`---'`   '`---'`---'
               `---'                                       `---'                    ");

           // Console.Write(@"

           //`  `---'`   '`---|`---'`---'      `  ``---'`---'    `   '`---|`---'`   '`---'`---'
           //             `---'                                       `---'                    ");
        }



// synth.Speak("Tongue Tied Agents");

Thread.Sleep(1500);
        CinemaHelpers.TextSpace();
        CinemaHelpers.SpaceandClean();








        #region music control
        Random RandomTime = new Random();
        int myRandomTime = RandomTime.Next(1000, 2000);
        //Thread staticvoidmutex = new Thread(MusicFx.staticvoidmutex);
        //staticvoidmutex.Start();

        Thread Boopseeker = new Thread(MusicFx.boopseeker);
        Boopseeker.Start();
        //Thread.Sleep(myRandomTime);
        //Thread Boopseeker2 = new Thread(MusicFx.boopseeker);
        //Boopseeker2.Start();
        //Thread.Sleep(myRandomTime);
        //Thread Boopseeker3 = new Thread(MusicFx.boopseeker);
        //Boopseeker3.Start();

        Thread Happyboopulator = new Thread(MusicFx.happyboopulator);
        Happyboopulator.Start();
        Happyboopulator.Suspend();

        #endregion

        #region music off
        //Boopseeker.Suspend();

        //Boopseeker2.Suspend();


        //Boopseeker3.Suspend();

        #endregion


        #region music on
        //Boopseeker.Resume();

        //Boopseeker2.Resume();


        //Boopseeker3.Resume();

        #endregion


        //Thread playtripleboopseek = new Thread(MusicFx.playstripleboopseek);
        // playtripleboopseek.Start();
        //Thread.Sleep(10);
        // playtripleboopseek.Suspend();


        //Thread selecttripleboopseek = new Thread(MusicFx.selecttripleboopseek);
        //playtripleboopseek.Start();

        // MusicFx.selecttripleboopseek(1);


        // maybe insane all over the screen slash glitch tech

        speakandspell = @" We met in Toyota’s labs in Massachusetts.
    There were several suited figures with compats.
    Compats are small devices that go near your temple and you send messages silently
        and non vocally.";


        Personality.OttoTypes(speakandspell);
        Thread.Sleep(magictime3000);
        CinemaHelpers.SpaceandClean();


        speakandspell = @"
     The future is insane it was once written and I believe that it is, yet in 
          many ways this is a beautiful insanity. Things are happening now that could have never
              happened before and time and action is compounding and compressing. ";
        Personality.OttoTypes(speakandspell);
        Thread.Sleep(magictime6000);
        CinemaHelpers.SpaceandClean();

        speakandspell = @" Where will the grind take us next?";
        Personality.OttoTypes(speakandspell);
        Thread.Sleep(magictime3000);
        CinemaHelpers.SpaceandClean();

        speakandspell = @"
    There was one fellow though with a black chrome notebook that had many implants obviously biology was not the end of this fellows evolution. 
    CD also had bioengineered hair. 
        His hair was modified to become soft quills that grew in a sublime arch jutting out past his chin and receding to the end of the back of his skull. ";

        Personality.Otto(speakandspell);


        //Personality.OttoTypes(speakandspell);
        Thread.Sleep(magictime9000);
        CinemaHelpers.SpaceandClean();
        //Personality.OttoTypes(speakandspell);
        //  Thread.Sleep(59000);
        //CinemaHelpers.SpaceandClean();



        // Good

        // playtripleboopseek.Suspend();
        //MusicFx.selecttripleboopseek(0);

        //maybe a red queen with initialize
        Personality.RedQueenNarrator("Initialize", 10);


        Thread.Sleep(30);
        CinemaHelpers.TheCorp();

        // Cd typing
        speakandspell = @" 

    ::: Cloak & Dagger :::


    Hey, gents nice to meet ye acquaintance, I am agent Cloak & Dagger, CD for short.";

        Soundz.Actor("cloakdaggerintro.wav");
        Console.WriteLine(speakandspell);
        Thread.Sleep(10000);
        CinemaHelpers.TheCorp();
        // playtripleboopseek.Resume();
        // Personality.CD(speakandspell);


        // maybe a quick squiggly line emf scan

        speakandspell = " We met in a meeting room that was scanned for listening devices by the spooks.";
        Personality.Otto(speakandspell);
        Thread.Sleep(magictime3000);
        CinemaHelpers.SpaceandClean();


        speakandspell = @"        
                   ~~  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  ~~
                      ~ ~~~~~~~~~~~~~~~~~~ ~~~~~~~~~~~~~~~~~~~ ~                              
                          ~~~~ ~~~~~~~~~~~ ~~~~~~~~~~~~~ ~~~~                          
                              ~ ~~~~~~~~~~ ~~~~~~~~~~ ~            
                                    ~ ~~~~ ~~~~ ~                                 
                                       ~~ ~ ~~                             
                                         ~ ~                           
                                          ~                          ";

        #region emfscan
        //emfscan
        for (int x = 0; x < 3; x++)
        {
            TextFx.grunblancheblack(speakandspell);
            if (x <= 3)
            {
                // MyTest.RedWhiteDance(speakandspell);
                TextFx.grunblancheblackdance(speakandspell);
                if (x <= 3)
                {
                    Thread.Sleep(30);
                    Console.Clear();
                }
            }


        }
        Personality.MegaByte("Scan Complete, no bugs Found");

        Thread.Sleep(98);
        CinemaHelpers.SpaceandClean();
        #endregion

        speakandspell = @" 


    CD opened up his laptop; he had a operating system that although it was made by a swede 
        sometime in the 90's. CD had thoroughly rewritten it there were no passwords on his 
            system his authentication method was biometric scans. ";


        Personality.Otto(speakandspell);
        Thread.Sleep(magictime9000);
        CinemaHelpers.SpaceandClean();

        speakandspell = @"


        At some point, he explained that things were too secure to actually be useable.
            He called this the unplugged disconnected machine of old. ";


        Personality.Otto(speakandspell);
        Thread.Sleep(magictime6000);
        CinemaHelpers.SpaceandClean();

        speakandspell = @"


                    Wireless Data and Energy Whirred about us.";


        Personality.OttoTypes(speakandspell);
        Thread.Sleep(magictime3000);
        CinemaHelpers.SpaceandClean();

        speakandspell = @"


            All machines were congolomeration of smaller virtual machines creating full hive computation all units acting as a superorganism.
";
        Personality.Otto(speakandspell);
        Thread.Sleep(magictime3000);
        CinemaHelpers.SpaceandClean();
        //Good

        speakandspell = @"

#! bin sh

prefix =  usr local
debugsym=true

for arg in $@/ do
    case $arg in
    --prefix = *)
        prefix =echo $arg | sed s/--";

        Happyboopulator.Resume();

        CinemaHelpers.commandconsole(speakandspell);
       // CinemaHelpers.CmdConType(speakandspell);
       // CinemaHelpers.CmdConWithTyping(speakandspell);

        speakandspell = @"
        --enable - debug)
        debugsym = true
        --disable - debug)
        debugsym = false

        --help)
";
        CinemaHelpers.commandconsole(speakandspell);
        //CinemaHelpers.CmdConWithTyping(speakandspell);

        speakandspell = @"
        echo usage: ./configure [options]
        echo options:
        echo   --prefix=<path>: installation prefix
        echo --enable-debug: include debug symbols
        echo   --disable-debug: do not include debug symbols
        echo all invalid options are silently ignored
        exit 0
        
        esac
    done ";

        CinemaHelpers.commandconsole(speakandspell);

        //CinemaHelpers.CmdConWithTyping(speakandspell);

        speakandspell = @"echo generating makefile ...
echo PREFIX = $prefix > Makefile
if $debugsym then
    echo dbg = -g >> Makefile
fi
cat Makefile.in >> Makefile
echo configuration complete, type make to build. ";

       // CinemaHelpers.CmdConWithTyping(speakandspell);
        CinemaHelpers.commandconsole(speakandspell);

        speakandspell = @" make ";
        CinemaHelpers.commandconsole(speakandspell);



        // CinemaHelpers.commandconsole(speakandspell);
        // playtripleboopseek.Resume();


        //MusicFx.selecttripleboopseek(1);



        Happyboopulator.Suspend();
        
        
        // MusicFx.selecttripleboopseek(0);
       // MusicFx.selecttripleboopseek.synth();
       // playtripleboopseek.Suspend();

        Thread.Sleep(60);

        speakandspell = @"


        Software imagined and encoded was interesting. Compats sent signals directly to
            interpretters so people could code at 500 words per minute and this was without ehancement. ";

        Personality.Otto(speakandspell);
        Thread.Sleep(magictime9000);
        CinemaHelpers.SpaceandClean();

        speakandspell = @"


        The populous was using software agents, as transferring
            redundant data was annoying. CD fired up some simulations that he and his colleagues had put together it
                the simulations were so good they seemed like hollywood blockbusters.  ";

        Personality.Otto(speakandspell);
        Thread.Sleep(magictime9000);
        CinemaHelpers.SpaceandClean();

        speakandspell = @"


                     In some corporations, they started paying idiots and geniuses alike too simply write ideas. 

                                                        The Idea Corp. ";


        Personality.Otto(speakandspell);
        Thread.Sleep(magictime6000);
        CinemaHelpers.SpaceandClean();
        //Good



        Graphix.GraphingCalculator();
        Thread.Sleep(1337);
        CinemaHelpers.TextSpace();

        speakandspell = @" 


                    In Idea Corp.  there were software and human analyzers that processed these ideas to find those that could be rapidly adapted. 
                        Then there were the reanalyzers reforumlated half cooked ideas or things that slipped by. ";

        Personality.Otto(speakandspell);
        Thread.Sleep(magictime9000);
        CinemaHelpers.SpaceandClean();



        speakandspell = @"

    Those organizations kept all of this information in giant data stores. 
        Every search page had better options for searching multiple check box methods that would quarantine searches to specific areas as to find 
                the information you were looking for. ";

        Personality.Otto(speakandspell);
        Thread.Sleep(magictime9000);
        CinemaHelpers.SpaceandClean();


        speakandspell = @"

    The information was so volumous that to do anything else would have difficult non trivial and unwise. Innovation and application was everywhere. 
        The presentation showed us strange transactions that seemed legitimate. ";



        Personality.Otto(speakandspell);
        Thread.Sleep(magictime9000);
        CinemaHelpers.SpaceandClean();

        speakandspell = @"  

        The money seemed to be non coherent and highly distributed. 
            Accounts were created for people. Credit was salami sliced, it was also stored in micro amounts in real accounts. 
                It was literally everywhere. 
 
 ";



        Personality.Otto(speakandspell);
        Thread.Sleep(magictime9000);
        CinemaHelpers.SpaceandClean();
        // close to good

        speakandspell = @"

su sudo create (n){
for x = 1 to n

@Override
public void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        accessToken = AccessToken.getCurrentAccessToken();
    }

}
next n

";

        //for(int x = 0; x <2; x++)
        // {
        //CinemaHelpers.CmdConWithTyping(speakandspell);
        CinemaHelpers.commandconsole(speakandspell);
        // }


        speakandspell = @" 

    The creation of false identities was nothing new.  ";

        Personality.Otto(speakandspell);
        Thread.Sleep(magictime3000);
        CinemaHelpers.SpaceandClean();


        speakandspell = @"

    Techniques used by any one needing ways of laundering information and money. 
        If you have enough of them, they create a real burden in trying to keep track of where and how the money flows. ";

        Personality.Otto(speakandspell);
        Thread.Sleep(magictime9000);
        CinemaHelpers.SpaceandClean();

        speakandspell = @"

    Yet they seem to have some ideas about a hacking group that may have something to do with some of the transactions. 
        We have been tracking and watching this happen for sometime now, and now we have enough data to move forward.";

        Personality.Otto(speakandspell);
        Thread.Sleep(magictime9000);
        CinemaHelpers.SpaceandClean();


        speakandspell = @"

    CD discovered that you were working on some interesting developments he thought that some of them might have had play in what is happening with the data. ";

        Personality.Otto(speakandspell);
        Thread.Sleep(magictime6000);
        CinemaHelpers.SpaceandClean();
        // Close to Good

        Personality.RedQueenNarrator(" Fork ");

        Thread.Sleep(magictime6000);
        Console.Clear();

        speakandspell = @"

::: Cloak & Dagger :::


Professor 
        do 
          you 
             know 
                 of anyone working in 
                                    the lab that has access other than you to 
                                                                             the labs?

";
        //playtripleboopseek.Suspend();
        Soundz.Actor("cloakdaggerlabaccess.wav");
        Console.WriteLine(speakandspell);
        Thread.Sleep(magictime9000);
        CinemaHelpers.TheCorp();

        //playtripleboopseek.Resume();
        // Personality.CD(speakandspell);

        speakandspell = @"

        He pulled up a list of personnel that have access to the lab. 
            Do you know any thing that may have been going on these days?";

        Personality.Otto(speakandspell);
        Thread.Sleep(magictime9000);
        CinemaHelpers.SpaceandClean();
        // Tight

        Filez.ProfessorReads("ProgramLS.txt");
      //  Filez.readtxtbyline("ProgramLS.txt");

        Thread.Sleep(magictime9000);
        CinemaHelpers.SpaceandClean();


        // Show Report 
        speakandspell = @"

    In our reports, no one in our labs was working at that time. So what do you think happened then? ";

        Personality.Miamoto(speakandspell);
        Thread.Sleep(magictime6000);
        CinemaHelpers.SpaceandClean();

        speakandspell = @"

            Mr. Heisenstein seems to have a hypothesis that there was a data injection to the net, and that general AI now lives there. ";

        Personality.Miamoto(speakandspell);
        Thread.Sleep(magictime6000);
        CinemaHelpers.SpaceandClean();

        speakandspell = @"

                                                We have reports and other data that backs up these claims. 
 ";

        Personality.Miamoto(speakandspell);
        Thread.Sleep(magictime6000);
        CinemaHelpers.SpaceandClean();
        // Good

        // maybe xcopy screen or other file copy for a few seconds. 

        speakandspell = @"

        The agents took copies of the data that we had procured. 
            CD seemed excited by the thought that such a thing could have happened in his lifetime. ";

        Personality.Otto(speakandspell);
        Thread.Sleep(magictime9000);
        CinemaHelpers.SpaceandClean();

        speakandspell = @"

            CD was obviously no average g-man. After the Feds came back to me with little results 
                   although our friend CD really seems to believe the strange tale. ";

        Personality.Otto(speakandspell);
        Thread.Sleep(magictime9000);
        CinemaHelpers.SpaceandClean();

        speakandspell = @"

            His other cohorts could not fit the idea in their tiny little skulls. 
                The agents simply would not follow the logic.";

        Personality.Otto(speakandspell);
        Thread.Sleep(magictime9000);
        CinemaHelpers.SpaceandClean();

        speakandspell = @"

        The agents where typical humans that did not understand that we still do not know everything there is too know in the world. 
            This to me is no surprise since sometimes the best ideas need to be forced down the throats of others before they will even consider the possibility of the existence of a new idea. ";


        Personality.Otto(speakandspell);
        Thread.Sleep(magictime9000);
        CinemaHelpers.SpaceandClean();
        // Tight

        //playtripleboopseek.Suspend();

        CinemaHelpers.DejaVu();

        speakandspell = @"

        I had some theories for Nibble and Bytes destruction, yet as their progenitor, I would be unable to carry out such a function. ";


        Personality.Miamoto(speakandspell);
        Thread.Sleep(magictime6000);
        CinemaHelpers.SpaceandClean();

        speakandspell = @"

        I see them as life and I believe all life is sacred even if this is a new package of digital DNA. ";

        Personality.Miamoto(speakandspell);
        Thread.Sleep(magictime6000);
        CinemaHelpers.SpaceandClean();

        speakandspell = @"

        Who am I to in the end control the new combinatrics? ";

        Personality.Miamoto(speakandspell);
        Thread.Sleep(magictime6000);
        CinemaHelpers.SpaceandClean();

        speakandspell = @"

        I would rather see the randomness that created them continue to hone and sharpen them. 
            Although I created, the mutation engine in the end the software developed software and became aware.";

        Personality.Miamoto(speakandspell);
        Thread.Sleep(magictime9000);
        CinemaHelpers.SpaceandClean();

        speakandspell = @"

            It is a distilled essence of beauty. 
                I wish that there were more things that were as beautiful as the mathematical living constructs. 
 ";

        Personality.Miamoto(speakandspell);
        Thread.Sleep(magictime6000);
        CinemaHelpers.SpaceandClean();
        ////Tight

        Boopseeker.Suspend();

        speakandspell = @" Sometimes you just have to see the future work itself out. ";

        Personality.Miamoto(speakandspell);


        Thread.Sleep(magictime3000);
        CinemaHelpers.RefreshConsole();

        Happyboopulator.Resume();

        Thread NumRain = new Thread(SpecialFx.numberrain);
        Thread NumRain2 = new Thread(SpecialFx.numberrain);
        Thread NumRain3 = new Thread(SpecialFx.numberrain);
        NumRain.Start();
        NumRain2.Start();
        NumRain3.Start();

        Screen.EndScreenWriter(speakandspell);

        CinemaHelpers.RefreshConsole();
        ////Tight

        #endregion

        #region EndScene


        // playtripleboopseek.Suspend();
        SpecialFx.Thinking();
        Happyboopulator.Suspend();


        // Comment Out Line Below For Full Movie
        Screen.Chapter10EndScreen();
        //Thread phonealwaysbusy = new Thread(Soundz.phonealwaysbusy);
        //phonealwaysbusy.Start(); 

       Soundz.PhoneBusy();


        speakandspell = @"
___________.__                               ___________           .___
\__    ___/|  |__   ____                     \_   _____/ ____    __| _/
  |    |   |  |  \_/ __ \                     |    __)_ /    \  / __ | 
  |    |   |   Y  \  ___/                     |        \   |  \/ /_/ | 
  |____|   |___|  /\___  >                   /_______  /___|  /\____ | 
                \/     \/                            \/     \/      \/ ";
        //SweetNess

        //  MyTest.RainbowWriterFG(speakandspell);
        CinemaHelpers.SpaceandClean();
        Console.WriteLine(speakandspell);
        Thread.Sleep(80);
        CinemaHelpers.SpaceandClean();
        //SpecialFx.RainbowWriterBG(speakandspell);
        Screen.EndScreenWriter(speakandspell);
        //phonealwaysbusy.Suspend();
     

        CinemaHelpers.SpaceandClean();



        
        speakandspell = @"The program '[11128] - IntraLocution' has exited with code -1073741510 (0xc000013a)";
        Console.WriteLine(speakandspell);
        Console.ReadKey();

        Environment.Exit(0);

        #endregion
    }




    




}

