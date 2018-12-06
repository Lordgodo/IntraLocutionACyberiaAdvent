using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Diagnostics;


public static class Screen
{
    #region Screen Prompt
    public static void ScreenPrompt(string title)
    {
        CinemaHelpers.RefreshConsole();
        CinemaHelpers.DejaVu();

        string mystring = "\t\t\t\t\t\t *************************************************";
        string mystringwithtitle = "\t\t\t\t\t\t *******                                   *******" + title;
        Console.WriteLine(mystringwithtitle.Length);
        Console.WriteLine(mystring.Length);
        Console.WriteLine(mystringwithtitle.Length - mystring.Length);
        int mystringtotal = mystringwithtitle.Length - mystring.Length;
        int requiredtotallength = 41;
        Console.ReadKey();
        for (int x = 0; x <= 100; x++)
        {
            CinemaHelpers.Timer(3);
            if (x % 2 == 0)
            {
                //  CinemaHelpers.DejaVu();
                CinemaHelpers.Timer(3);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;

                CinemaHelpers.TextSpace();
                Console.WriteLine("\t\t\t\t\t\t *************************************************");
                Console.WriteLine("\t\t\t\t\t\t *******  " + title.PadRight(requiredtotallength - mystringtotal) + " *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******    Written by Luminosity          *******");
                Console.WriteLine("\t\t\t\t\t\t ************************************************* \n\n");
            }
            else
            {
                //CinemaHelpers.JamaisVu();
                CinemaHelpers.Timer(3);
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Black;

                CinemaHelpers.TextSpace();
                Console.WriteLine("\t\t\t\t\t\t *************************************************");
                Console.WriteLine("\t\t\t\t\t\t *******  " + title.PadRight(70) + " *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******    Written by Luminosity          *******");
                Console.WriteLine("\t\t\t\t\t\t ************************************************* \n\n");

                CinemaHelpers.Timer(10);
            }
        }
        Console.ReadKey();
    }
    #endregion

	
    #region Main
    public static void MMain()
    {
        int time = 2600;
        Console.CursorVisible = false;
        CinemaHelpers.RefreshConsole();
        CinemaHelpers.DejaVu();

        Thread mDial = new Thread(Soundz.Mdial);
        Thread BinRush = new Thread(SpecialFx.BinaryFlood2);
        Thread Bfire = new Thread(MusicFx.BFire);
        Thread NumFlood = new Thread(SpecialFx.NumFlood2);

        mDial.Start();
        BinRush.Start();
        Bfire.Start();
        NumFlood.Start();
        for (int x = 0; x <= 102; x++)
        {
            CinemaHelpers.Timer(1);
            if (x % 2 == 0)
            {
                //  CinemaHelpers.DejaVu();
                CinemaHelpers.Timer(3);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Title = "            Intra Locution A Cyberia Advent";
                CinemaHelpers.TextSpace();
                Console.Write("\t\t\t\t\t\t");
                C.white();
                Console.Write(" \u2666 ");
                C.lightgreen();
                Console.Write("*********************************************");
                C.white();
                Console.Write(" \u2666 \n");
                C.lightgreen();
               
                Console.Write("\t\t\t\t\t\t *******  ");
                
                C.white();
                Console.Write("Intra Locution A Cyberia Advent");
                C.lightgreen();
                Console.Write("  *******\n");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.Write("\t\t\t\t\t\t *******    ");

                C.white();
                Console.Write(" Written by: Luminosity");
                C.lightgreen();
                Console.Write("        *******\n");
                Console.Write("\t\t\t\t\t\t ");
                C.white();
                Console.Write("\u2666 ");
                C.lightgreen();

                Console.Write("*********************************************");
                C.white();
                Console.Write(" \u2666 \n\n");
            }
            else
            {
                //CinemaHelpers.JamaisVu();
                CinemaHelpers.Timer(1);
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Black;
                Console.Title = "            Intra Locution A Cyberia Advent";
                CinemaHelpers.TextSpace();
                Console.WriteLine("\t\t\t\t\t\t *************************************************");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******  Intra Locution A Cyberia Advent  *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******      Written by Luminosity        *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t ************************************************* \n\n");
            }
        }
        CinemaHelpers.Timer(time);
        #endregion
    }

	
    #region dataclouds
    public static void dataclouds()
    {
        string speakandspell = "!...^^.. ty^hc^ght & ftycg*hcgh++fvvnh*vht-ytygh h ghtytyvkhgvvg5ryf++-yu67";
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                speakandspell.PadRight(y);
               // SpecialFx.ScrollingDown(speakandspell);
                C.whitebg();
                C.blue();
                SpecialFx.spacedscrollingflood(speakandspell);
            }
            
           // C.blackbg();
           // C.lightgreen();
            //SpecialFx.scrollingdownflood(speakandspell);
            C.whitebg();
            C.blue();
            SpecialFx.spacedscrollingflood(speakandspell);
            C.blackbg();
        }
        CinemaHelpers.RefreshConsole();
    }
    #endregion

	
    #region spfxglitchscreen
    public static void spfxglitchscreen()
    {
        Personality.nibble(SpecialFx.CreatePassword(13));
        SpecialFx.spfxgenglitch();
        Console.WriteLine("\n\n");
        SpecialFx.spfxgenglitch();
        Console.WriteLine("\n\n");
        SpecialFx.spfxgenglitch();
        Console.WriteLine("\n\n");
        SpecialFx.spfxgenglitch();
        Console.WriteLine("\n\n");
        SpecialFx.spfxgenglitch();
        Console.WriteLine("\n\n");
        SpecialFx.spfxgenglitch();
        Console.WriteLine("\n\n");
        SpecialFx.spfxgenglitch();
        Console.WriteLine("\n\n");
        SpecialFx.spfxgenglitch();
        Console.WriteLine("\n\n");
        SpecialFx.spfxgenglitch();
    }
    #endregion

	
    #region EndScreen
    public static void Endscreen()
    {
        int time = 2600;
        Console.CursorVisible = false;
        CinemaHelpers.RefreshConsole();
        CinemaHelpers.DejaVu();

        Thread mDial = new Thread(Soundz.Mdial);
        Thread BinRush = new Thread(SpecialFx.BinaryFlood2);
        Thread Bfire = new Thread(MusicFx.BFire);
        Thread NumFlood = new Thread(SpecialFx.NumFlood2);

        mDial.Start();
        BinRush.Start();
        Bfire.Start();
        NumFlood.Start();
        for (int x = 0; x < 102; x++)
        {
            CinemaHelpers.Timer(1);
            if (x % 2 == 0)
            {
                //  CinemaHelpers.DejaVu();
                CinemaHelpers.Timer(3);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Title = "            Intra Locution A Cyberia Advent";
                CinemaHelpers.TextSpace();
                Console.WriteLine("\t\t\t\t\t\t *************************************************");
                Console.WriteLine("\t\t\t\t\t\t *******  Intra Locution A Cyberia Advent  *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******    Written by Luminosity          *******");
                Console.WriteLine("\t\t\t\t\t\t ************************************************* \n\n");

                Console.WriteLine(@",---.         ,---.    |                |                       ,---.,---.    ,---.     o|         |        ,---.|    o                         
|---|,---.    |---|,---|.    ,,---.,---.|--- .   .,---.,---.    |   ||__.     `---.. . ..|--- ,---.|---.    |__. |    .,---.,---.,---.,---.,---.
|   ||   |    |   ||   | \  / |---'|   ||    |   ||    |---'    |   ||            || | |||    |    |   |    |    |    ||   ||   ||---'|    `---.
`   '`   '    `   '`---'  `'  `---'`   '`---'`---'`    `---'    `---'`        `---'`-'-'``---'`---'`   '    `    `---'`|---'|---'`---'`    `---'
                                                                                                                       |    |                   ");
            }
            else
            {
                //CinemaHelpers.JamaisVu();
                CinemaHelpers.Timer(1);
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Black;
                Console.Title = "            Intra Locution A Cyberia Advent";
                CinemaHelpers.TextSpace();
                Console.WriteLine("\t\t\t\t\t\t *************************************************");
                Console.WriteLine("\t\t\t\t\t\t *******  Intra Locution A Cyberia Advent  *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******    Written by Luminosity          *******");
                Console.WriteLine("\t\t\t\t\t\t ************************************************* \n\n");
                Console.WriteLine(@",---.         ,---.    |                |                       ,---.,---.    ,---.     o|         |        ,---.|    o                         
|---|,---.    |---|,---|.    ,,---.,---.|--- .   .,---.,---.    |   ||__.     `---.. . ..|--- ,---.|---.    |__. |    .,---.,---.,---.,---.,---.
|   ||   |    |   ||   | \  / |---'|   ||    |   ||    |---'    |   ||            || | |||    |    |   |    |    |    ||   ||   ||---'|    `---.
`   '`   '    `   '`---'  `'  `---'`   '`---'`---'`    `---'    `---'`        `---'`-'-'``---'`---'`   '    `    `---'`|---'|---'`---'`    `---'
                                                                                                                       |    |                   ");

            }

        








    }




        // second part
        for (int x = 0; x <= 102; x++)
        {
            CinemaHelpers.Timer(1);
            if (x % 2 == 0)
            {
                //  CinemaHelpers.DejaVu();
                CinemaHelpers.Timer(3);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Title = "            Intra Locution A Cyberia Advent";
                CinemaHelpers.TextSpace();
                Console.WriteLine("\t\t\t\t\t\t *************************************************");
                Console.WriteLine("\t\t\t\t\t\t *******  Intra Locution A Cyberia Advent  *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******    Written by Luminosity          *******");
                Console.WriteLine("\t\t\t\t\t\t ************************************************* \n\n");

                Console.WriteLine(@"______.__                               ___________           .___
\__    ___/|  |__   ____                     \_   _____/ ____    __| _/
  |    |   |  |  \_/ __ \                     |    __)_ /    \  / __ | 
  |    |   |   Y  \  ___/                     |        \   |  \/ /_/ | 
  |____|   |___|  /\___  >                   /_______  /___|  /\____ | 
                \/     \/                            \/     \/      \/ ");


            }
            else
            {
                //CinemaHelpers.JamaisVu();
                CinemaHelpers.Timer(1);
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Black;
                Console.Title = "            Intra Locution A Cyberia Advent";
                CinemaHelpers.TextSpace();
                Console.WriteLine("\t\t\t\t\t\t *************************************************");
                Console.WriteLine("\t\t\t\t\t\t *******  Intra Locution A Cyberia Advent  *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******    Written by Luminosity          *******");
                Console.WriteLine("\t\t\t\t\t\t ************************************************* \n\n");

                Console.WriteLine(@"______.__                               ___________           .___
\__    ___/|  |__   ____                     \_   _____/ ____    __| _/
  |    |   |  |  \_/ __ \                     |    __)_ /    \  / __ | 
  |    |   |   Y  \  ___/                     |        \   |  \/ /_/ | 
  |____|   |___|  /\___  >                   /_______  /___|  /\____ | 
                \/     \/                            \/     \/      \/ ");

            }

        }
        CinemaHelpers.Timer(3);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Title = "            Intra Locution A Cyberia Advent";
        CinemaHelpers.TextSpace();
        Console.WriteLine("\t\t\t\t\t\t *************************************************");
        Console.WriteLine("\t\t\t\t\t\t *******  Intra Locution A Cyberia Advent  *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******    Written by Luminosity          *******");
        Console.WriteLine("\t\t\t\t\t\t ************************************************* \n\n");

        Console.WriteLine(@"______.__                               ___________           .___
\__    ___/|  |__   ____                     \_   _____/ ____    __| _/
  |    |   |  |  \_/ __ \                     |    __)_ /    \  / __ | 
  |    |   |   Y  \  ___/                     |        \   |  \/ /_/ | 
  |____|   |___|  /\___  >                   /_______  /___|  /\____ | 
                \/     \/                            \/     \/      \/ ");

        CinemaHelpers.Timer(5555);
    }
    #endregion

    #region Screen Prompt
    public static void EndScreenPrompt(string title)
    {
        CinemaHelpers.RefreshConsole();
        CinemaHelpers.DejaVu();

        string mystring = "\t\t\t\t\t\t *************************************************";
        string mystringwithtitle = "\t\t\t\t\t\t *******                                   *******" + title;
        Console.WriteLine(mystringwithtitle.Length);
        Console.WriteLine(mystring.Length);
        Console.WriteLine(mystringwithtitle.Length - mystring.Length);
        int mystringtotal = mystringwithtitle.Length - mystring.Length;
       // int requiredtotallength = 41;
        int requiredtotallength = 49;
        //int requiredtotallengthtest = requiredtotallength - mystringtotal;

        //if (requiredtotallengthtest <= 0)
        //{
        //    requiredtotallength = requiredtotallengthtest + requiredtotallength;
        //}
        Console.ReadKey();
        for (int x = 0; x <= 100; x++)
        {
            CinemaHelpers.Timer(3);
            if (x % 2 == 0)
            {
                //  CinemaHelpers.DejaVu();
                CinemaHelpers.Timer(3);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;

                CinemaHelpers.TextSpace();
                Console.WriteLine("\t\t\t\t\t\t *************************************************");
                Console.WriteLine("\t\t\t\t\t\t *******  " + title.PadRight(requiredtotallength - mystringtotal) + " *******");
               // Console.WriteLine("\t\t\t\t\t\t *******  " + title.PadRight(requiredtotallengthtest) + " *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******    Written by Luminosity          *******");
                Console.WriteLine("\t\t\t\t\t\t ************************************************* \n\n");
            }
            else
            {
                //CinemaHelpers.JamaisVu();
                CinemaHelpers.Timer(3);
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Black;

                CinemaHelpers.TextSpace();
                Console.WriteLine("\t\t\t\t\t\t *************************************************");
                Console.WriteLine("\t\t\t\t\t\t *******  " + title.PadRight(requiredtotallength - mystringtotal) + " *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
                Console.WriteLine("\t\t\t\t\t\t *******    Written by Luminosity          *******");
                Console.WriteLine("\t\t\t\t\t\t ************************************************* \n\n");

                CinemaHelpers.Timer(10);
            }
        }
        Console.ReadKey();
    }
    #endregion

	
    #region Chapter 1 End Screen
    public static void Chapter1EndScreen()
    {
        //  CinemaHelpers.DejaVu();
        CinemaHelpers.Timer(3);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Title = "            Intra Locution A Cyberia Advent";
        CinemaHelpers.TextSpace();
        Console.WriteLine("\t\t\t\t\t\t *************************************************");
        Console.WriteLine("\t\t\t\t\t\t *******  Intra Locution A Cyberia Advent  *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******   An Adventure Of Switch Flippers *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******    Written by Luminosity          *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******    The End of Chapter 1           *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
       Console.WriteLine("\t\t\t\t\t\t ************************************************* \n\n");

        Console.ReadKey();
    }
    #endregion


    #region Chapter 2 End Screen
    public static void Chapter2EndScreen()
    {
        //  CinemaHelpers.DejaVu();
        CinemaHelpers.Timer(3);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Title = "            Intra Locution A Cyberia Advent";
        CinemaHelpers.TextSpace();
        Console.WriteLine("\t\t\t\t\t\t *************************************************");
        Console.WriteLine("\t\t\t\t\t\t *******  Intra Locution A Cyberia Advent  *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******  11:42 pm - Another Flip Switched *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******    Written by Luminosity          *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******    The End of Chapter 2           *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t ************************************************* \n\n");

        Console.ReadKey();
    }
    #endregion

	
    #region Chapter 3 End Screen
    public static void Chapter3EndScreen()
    {
        //  CinemaHelpers.DejaVu();
        CinemaHelpers.Timer(3);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Title = "            Intra Locution A Cyberia Advent";
        CinemaHelpers.TextSpace();
        Console.WriteLine("\t\t\t\t\t\t *************************************************");
        Console.WriteLine("\t\t\t\t\t\t *******  Intra Locution A Cyberia Advent  *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******        A State Of Being           *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******    Written by Luminosity          *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******    The End of Chapter 3           *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t ************************************************* \n\n");

        Console.ReadKey();
    }
    #endregion
	
	
    #region Chapter 2 End Screen
    public static void Chapter4EndScreen()
    {
        //  CinemaHelpers.DejaVu();
        CinemaHelpers.Timer(3);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Title = "            Intra Locution A Cyberia Advent";
        CinemaHelpers.TextSpace();
        Console.WriteLine("\t\t\t\t\t\t *************************************************");
        Console.WriteLine("\t\t\t\t\t\t *******  Intra Locution A Cyberia Advent  *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******     We Are Nibble And Byte.       *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******    Written by Luminosity          *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******    The End of Chapter 4           *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t ************************************************* \n\n");

        Console.ReadKey();
    }
    #endregion
	
    #region Chapter 5 End Screen
    public static void Chapter5EndScreen()
    {
        //  CinemaHelpers.DejaVu();
        CinemaHelpers.Timer(3);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Title = "            Intra Locution A Cyberia Advent";
        CinemaHelpers.TextSpace();
        Console.WriteLine("\t\t\t\t\t\t *************************************************");
        Console.WriteLine("\t\t\t\t\t\t *******  Intra Locution A Cyberia Advent  *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******           Moronoxy                *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******    Written by Luminosity          *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******    The End of Chapter 5           *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t ************************************************* \n\n");

        Console.ReadKey();
    }
    #endregion
	
	
    #region Chapter 6 End Screen
    public static void Chapter6EndScreen()
    {
        //  CinemaHelpers.DejaVu();
        CinemaHelpers.Timer(3);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Title = "            Intra Locution A Cyberia Advent";
        CinemaHelpers.TextSpace();
        Console.WriteLine("\t\t\t\t\t\t *************************************************");
        Console.WriteLine("\t\t\t\t\t\t *******  Intra Locution A Cyberia Advent  *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******            Obey                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******    Written by Luminosity          *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******    The End of Chapter 6           *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t ************************************************* \n\n");

        Console.ReadKey();
    }
    #endregion
	
	
    #region Chapter 7 End Screen
    public static void Chapter7EndScreen()
    {
        //  CinemaHelpers.DejaVu();
        CinemaHelpers.Timer(3);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Title = "            Intra Locution A Cyberia Advent";
        CinemaHelpers.TextSpace();
        Console.WriteLine("\t\t\t\t\t\t *************************************************");
        Console.WriteLine("\t\t\t\t\t\t *******  Intra Locution A Cyberia Advent  *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******      In Search Of A Body          *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******    Written by Luminosity          *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******    The End of Chapter 7           *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t ************************************************* \n\n");

        Console.ReadKey();
    }
    #endregion
	
	
    #region Chapter 8 End Screen
    public static void Chapter8EndScreen()
    {
        //  CinemaHelpers.DejaVu();
        CinemaHelpers.Timer(3);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Title = "            Intra Locution A Cyberia Advent";
        CinemaHelpers.TextSpace();
        Console.WriteLine("\t\t\t\t\t\t *************************************************");
        Console.WriteLine("\t\t\t\t\t\t *******  Intra Locution A Cyberia Advent  *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******          Here we go               *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******    Written by Luminosity          *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******    The End of Chapter 8           *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t ************************************************* \n\n");

        Console.ReadKey();
    }
    #endregion

	
    #region Chapter 9 End Screen
    public static void Chapter9EndScreen()
    {
        //  CinemaHelpers.DejaVu();
        CinemaHelpers.Timer(3);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Title = "            Intra Locution A Cyberia Advent";
        CinemaHelpers.TextSpace();
        Console.WriteLine("\t\t\t\t\t\t *************************************************");
        Console.WriteLine("\t\t\t\t\t\t *******  Intra Locution A Cyberia Advent  *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******      A Cyberist Gone Cyber        *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******    Written by Luminosity          *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******    The End of Chapter 9           *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t ************************************************* \n\n");

        Console.ReadKey();
    }
    #endregion


    #region Chapter 10 End Screen
    public static void Chapter10EndScreen()
    {
        //  CinemaHelpers.DejaVu();
        CinemaHelpers.Timer(3);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Title = "            Intra Locution A Cyberia Advent";
        CinemaHelpers.TextSpace();
        Console.WriteLine("\t\t\t\t\t\t *************************************************");
        Console.WriteLine("\t\t\t\t\t\t *******  Intra Locution A Cyberia Advent  *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******       Tongue Tied Agents          *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******    Written by Luminosity          *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t *******    The End of Chapter 10          *******");
        Console.WriteLine("\t\t\t\t\t\t *******                                   *******");
        Console.WriteLine("\t\t\t\t\t\t ************************************************* \n\n");

        Console.ReadKey();
    }
    #endregion

	
    #region EndScreenWriter
    public static void EndScreenWriter(string speakandspell)
    {
        for (int x = 1; x <= 7; x++)
        {
            Type type = typeof(ConsoleColor);
            Console.BackgroundColor = ConsoleColor.Black;
            Random myrandom = new Random();
            foreach (var name in Enum.GetNames(type))
            {
				//Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, name);
				Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, name);
				//Console.Clear();
				// Thread.Sleep(60);
				// Console.WriteLine(speakandspell);

				int myr = myrandom.Next(1, 100);
				// screensmash = myr.ToString();
				Console.Write(speakandspell.PadLeft(myr) + " \n");
				//nibble(speakandspell);
				Thread.Sleep(60);
			}
        }
    }
    #endregion
}

