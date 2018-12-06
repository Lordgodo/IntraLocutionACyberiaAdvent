using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Diagnostics;


public static class SpecialFx
{
    #region NumFlood
    public static void NumFlood()
    {
        Random r = new Random();
        for (int x = 0; x <= 1000; x++)
        {
            for (int z = 0; z <= 2; z++)
            {
                int b = r.Next(1, 10);
                int d = r.Next(1, 10);
                int e = r.Next(1, 10);
                Console.WriteLine(b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b + b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b +
                    b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b + b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b +
                    b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b + b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b +
                    b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b + b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b);
            }
        }
        CinemaHelpers.SpaceandClean();
    }
    #endregion

	
    #region YellowWhiteBlueColorCloud
    public static void YellowWhiteBlueColorCloud()
    {
        Random r = new Random();
        for (int x = 0; x <= 1000; x++)
        {
            for (int z = 0; z <= 2; z++)
            {
                int b = r.Next(1, 10);
                int d = r.Next(1, 10);
                int e = r.Next(1, 10);
                Console.Write(b + "" + d + e + "");

                Console.Write(d);
                if (e < 5) 
				{
                    C.blue();
                    Console.Write(e);
                }
                else 
				{
                    C.white();
                    Console.Write(e);
                }

                Console.Write( b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b + b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b);

                Console.Write(
                    b + "" + d);

                Console.Write(e);
                if (e < 5)
                {
                    C.yellow();
                    Console.Write(e);
                }
                else
                {
                    C.white();
                    Console.Write(e);
                }
				
                Console.Write("" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b + b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b +
                    b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b + b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b +
                    b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b);

                    Console.Write(b);
                if (e < 5)
                {
                    C.blue();
                    Console.Write(e);
                }
                else
                {
                    C.white();
                    Console.Write(e);
                }
				
                Console.Write( d + d + e + e + b + b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b);
            }
        }
        CinemaHelpers.SpaceandClean();
    }
    #endregion

	
    #region NumFloodWColorGlitch
    public static void NumFloodWColorGlitch(int loopcount)
    {
        Random r = new Random();
        for (int x = 0; x <= loopcount; x++)
        {
            for (int z = 0; z <= 2; z++)
            {
                int b = r.Next(1, 10);
                int d = r.Next(1, 10);
                int e = r.Next(1, 10);
                Console.Write(b + "" + d + e + "");

                Console.Write(d);
                if (e < 5)
                {
                    C.blue();
                    Console.Write(e);
                }
                else
                {
                    C.white();
                    Console.Write(e);
                }

                C.white();
                Console.Write(b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b + b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b);

                Console.Write(
                    b + "" + d);

                Console.Write(e);
                if (e < 5)
                {
                    C.yellow();
                    Console.Write(e);
                }
                else
                {
                    C.white();
                    Console.Write(e);
                }

                C.white();
                Console.Write("" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b + b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b +
                    b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b + b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b +
                    b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b);

                Console.Write(b);
                if (e < 5)
                {
                    C.blue();
                    Console.Write(e);
                }
                else
                {
                    C.white();
                    Console.Write(e);
                }
				
                C.white();

                Console.Write(d + d + e + e + b + b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b);
            }
        }
        CinemaHelpers.SpaceandClean();
    }
    #endregion


    #region BinaryFlood
    public static void BinaryFlood() {
        string[] Bflood = { "0", "1" };
        string displayBflood;
        Random r = new Random();
        for (int x = 0; x <= 100; x++)
        {
            int b = r.Next(1, 10);
            int d = r.Next(1, 10);
            int e = r.Next(1, 10);
            // Console.WriteLine(b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b + b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b);

            for (int z = 0; z <= 100; z++)
            {
                if (b <= 5)
                {
                    displayBflood = Bflood[1];
                }
                else 
				{ 
					displayBflood = Bflood[0]; 
				}
				
				for ( int i = 0; i < 124; i++ )
				{
					Console.Write(displayBflood);
				}
            }
        }
    }
    #endregion
	
	
    #region JacktheRipper
    public static void JacktheRipper()
    {
        /*      Work For Password Cracking Scene        */
        //Console.ReadKey();
        string[] Azed = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        for (int x = 0; x <= 25; x++)
        {
            string a = Azed[x];
            Console.WriteLine(Azed[x]);

            for (int y = 0; y <= 25; y = y + 2)
            {
                string b = Azed[y];
                Console.WriteLine(Azed[y]);
                Console.WriteLine(a, b);
                Console.WriteLine(a + b);
            }
            //+ Azed[x+1] +Azed[x+2] check bounds
        }
    }
    #endregion

	
    #region OpenCommand
    public static void OpenCommand()
    {
        #region livecode
        Process myProcess;
        myProcess = Process.Start("cmd.exe");

        Process myProcess2;
        myProcess2 = Process.Start("Notepad.exe");
        Console.WriteLine("Physical Memory Usage: " + myProcess2.WorkingSet64.ToString());
        Thread.Sleep(2000);
        myProcess.CloseMainWindow();
        myProcess2.CloseMainWindow();
        myProcess.Close();
        myProcess2.Close();
        #endregion
    }
    #endregion

	
    #region Prompt Data
    public static void PromptData()
    {
        string Displaytext;
        Displaytext = @"
        Volume in drive C has no label.
Volume Serial Number is CC70 - 5900

 Directory of C: \Users\Demo

12 / 17 / 2017  03:46 PM<DIR>.
12 / 17 / 2017  03:46 PM<DIR>..
04 / 07 / 2016  09:46 PM<DIR>.android
04 / 12 / 2016  07:51 PM<DIR>.dnx
12 / 17 / 2017  03:46 PM               196.gitconfig
08 / 10 / 2017  07:06 PM<DIR>.kindle
04 / 08 / 2016  12:09 AM<DIR>.ssh
03 / 04 / 2017  10:48 AM<DIR>.thumbnails
04 / 07 / 2016  07:15 PM<DIR>.vscode
12 / 14 / 2017  10:39 PM<DIR> Contacts
12 / 17 / 2017  08:23 AM<DIR> Desktop
12 / 14 / 2017  10:39 PM<DIR> Documents
12 / 14 / 2017  10:39 PM<DIR> Downloads
12 / 14 / 2017  10:39 PM<DIR> Favorites
12 / 14 / 2017  10:39 PM<DIR> Links
12 / 14 / 2017  10:39 PM<DIR> Music
12 / 13 / 2017  08:19 PM<DIR> OneDrive
12 / 14 / 2017  10:39 PM<DIR> Pictures
12 / 14 / 2017  10:39 PM<DIR> Saved Games
12 / 14 / 2017  10:39 PM<DIR> Searches
12 / 14 / 2017  10:39 PM<DIR> Videos
               1 File(s)            196 bytes
              20 Dir(s)  41,069,498,368 bytes free

C: \Users\Demo >
";
        Console.WriteLine(Displaytext);
    }
    #endregion


    #region PyramidalPrompt
    public static void PyramidalPrompt(int numberoflayers)
    {
        int Space, Number;
        Console.WriteLine(" Print Pyramid ");

        for (int i = 1; i <= numberoflayers; i++)
        {
            for (Space = 1; Space <= (numberoflayers - i); Space++)
                Console.Write(" ");

            for (Number = 1; Number <= i; Number++)
                Console.Write(Number);

            for (Number = (i - 1); Number >= 1; Number--)
                Console.Write(Number);
			
            Console.WriteLine();
        }
    }
    #endregion


    #region Thinking
    public static void Thinking()
    {
		string[] insidethematrix = { "/", "-", "\"", "*", "/", "-", "\"" };
        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                CinemaHelpers.SpaceandClean();
                // Console.WriteLine(" Thinking  " + "[ " + insidethematrix[x] + " ] ");
                if (x / 2 == 0)
                {
                    C.lightgreen();
                    Console.Write(" Thinking " + " " + "[ " + " ");
                    C.white();
                    Console.Write(insidethematrix[x]);
                        C.lightgreen();
                    Console.Write( " ] " + " " + " \n");
                    Thread.Sleep(60);
                }
                else
                {
                    C.lightgreen();
                    Console.Write(" Thinking " + " " + "[ " + " ");
                    C.yellow();
                    Console.Write(insidethematrix[x]);
                    C.lightgreen();
                    Console.Write(" ] " + " " + " \n");
                    Thread.Sleep(60);
                }
             //   Thread.Sleep(100);
            }
        }
    }
    #endregion


    #region oldthink
    public static void oldThinking()
    {
		string[] insidethematrix = { "/", "-", "\"", "*", "/", "-", "\"" };
        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                CinemaHelpers.SpaceandClean();

                Console.WriteLine(" Thinking  " + "[ " + insidethematrix[x] + " ] ");
                Thread.Sleep(100);
            }
        }
    }
    #endregion

    #region Throbber
    public static void Throbber(string pretext)
    {
		string[] insidethematrix = { "/", "-", "\"", "*", "/", "-", "\"" };
        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                CinemaHelpers.SpaceandClean();

              // Console.WriteLine(pretext + "[ " + insidethematrix[x] + insidethematrix[x] + insidethematrix[x] + " ] ");
                Console.Write(pretext + " ");
                C.white();
                Console.Write("[ " + insidethematrix[x] + insidethematrix[x] + insidethematrix[x] + " ] ");
                Thread.Sleep(100);
            }
        }
    }
    #endregion

	
    #region PwCrackThrobber
    public static void PwCrackThrobber(string pretext)
    {
        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                string[] insidethematrix = { "/", "-", "\"", "*", "/", "-", "\"" };

                CinemaHelpers.SpaceandClean();

               // Console.WriteLine("[ " + insidethematrix[x] + " " + pretext + " " + insidethematrix[x] + " ] ");
                C.white();
                Console.Write("[ " + insidethematrix[x] + " ");
                C.lightgreen();
                Console.Write(pretext);
                C.white();
                Console.Write(" " + insidethematrix[x] + " ] ");

                Thread.Sleep(10);
            }
        }
    }
    #endregion

	
    #region RacingStar
    public static void RacingStar()
    {
        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                string[] insidethematrix = { "/", "-", "\"", "*", "/", "-", "\"" };

                CinemaHelpers.SpaceandClean();

                Console.WriteLine("[ " + insidethematrix[x].PadLeft(y) + insidethematrix[x].PadLeft(y + x) + insidethematrix[x].PadLeft(y + x + 2) + " ] ");
                Thread.Sleep(100);
            }
        }
    }
    #endregion

	
    #region speedRacingStar
    public static void speedRacingStar()
    {
        for (int y = 0; y < 10000; y++)
        {
            CinemaHelpers.SpaceandClean();

            Console.WriteLine("*".PadLeft(y));
        }
    }
    #endregion


    #region NumFlood
    public static void NumFlood2()
    {
        Random r = new Random();
        for (int x = 0; x <= 500; x++)
        {
            for (int z = 0; z <= 2; z++)
            {
                int b = r.Next(1, 10);
                int d = r.Next(1, 10);
                int e = r.Next(1, 10);
                Console.WriteLine(b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b + b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b +
                    b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b + b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b +
                    b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b + b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b +
                    b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b + b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b);
            }
        }
        CinemaHelpers.SpaceandClean();
    }
    #endregion

	
    #region BinaryFlood2
    public static void BinaryFlood2()
    {
        string[] Bflood = { "0", "1" };
        string displayBflood;
        Random r = new Random();
        for (int x = 0; x <= 10; x++)
        {
            int b = r.Next(1, 10);
            int d = r.Next(1, 10);
            int e = r.Next(1, 10);
            // Console.WriteLine(b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b + b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b);

            for (int z = 0; z <= 100; z++)
            {
                if (b <= 5)
                {
                    displayBflood = Bflood[1];
                }
                else 
				{ 
					displayBflood = Bflood[0]; 
				}
				
				for ( int i = 0; i < 114; i++ )
				{
					Console.Write(displayBflood);
				}
            }
        }

    }
    #endregion

	
    #region RacingRabbit
    public static void RacingRabbit()
    {
        for (int y = 0; y < 100; y++)
        {
            CinemaHelpers.SpaceandClean();
			
            Console.WriteLine("*".PadLeft(y));
            Thread.Sleep(100);
            if (y <= 50 & y <= 100)
            {
                CinemaHelpers.SpaceandClean();

                Console.WriteLine("*".PadRight(y));
                Thread.Sleep(100);
            } else {
                break;
            }
        }
    }
    #endregion


    #region BackandForth
    public static void BackandForth()
    {
        for (int y = 0; y < 100; y++)
        {

            CinemaHelpers.SpaceandClean();

            Console.WriteLine("*".PadLeft(y));
            Thread.Sleep(100);
            if (y <= 50 & y <= 100)
            {
                CinemaHelpers.SpaceandClean();

                Console.WriteLine("*".PadRight(y));
                Thread.Sleep(100);
            }
            else{
                break;
            }
        }

        // second loop
        for (int x = 100; x > 100; x--)
        {
            CinemaHelpers.SpaceandClean();

            Console.WriteLine("*".PadLeft(x));
            Thread.Sleep(100);
            if (x >= 50 & x >= 0)
            {
                CinemaHelpers.SpaceandClean();

                Console.WriteLine("*".PadRight(x));
                Thread.Sleep(100);
            }
            else{
                break;
            }
        }
    }
    #endregion

	
	#region stringtonumParameters
    public static void stringtonumParameters(string TheString, ConsoleColor ColorOne, ConsoleColor ColorTwo ){
        byte[] bytes = Encoding.Unicode.GetBytes(TheString);
		int mybytelength = bytes.Length;
        int y = 1;
       

		for (int x = 0; x <= mybytelength; x++)
		{
			for (int z = 0; z <= 1; z++)
			{
				if (x <= mybytelength & x < mybytelength)
				{
					if (y == 1)
					{
						Console.ForegroundColor = ColorOne;
						Console.Write(" " + bytes[x] + " ");
						y = 2;
					}
					else
					{
						Console.ForegroundColor = ColorTwo;
						Console.Write(bytes[x]);
						y = 1;
					}
				}
				else
				{
					Console.WriteLine(" ");
					break;
				}
				Thread.Sleep(1);
				Console.ForegroundColor = ConsoleColor.White;
			}
		}
    }
    #endregion

    #region stringtonum
    public static void stringtonum(string mystringhere)
	{
		stringtonumParameters(mystringhere, ConsoleColor.Green, ConsoleColor.Yellow) ;
    }
    #endregion


    #region stringtonumWhiteBlue
    public static void stringtonumWhiteBlue(string mystringhere)
    {
        byte[] bytes = Encoding.Unicode.GetBytes(mystringhere);
        int mybytelength = bytes.Length;
        int y = 1;

        if (mybytelength <= 150)
        {
            for (int x = 0; x <= mybytelength; x++)
            {
                for (int z = 0; z <= 1; z++)
                {
                    if (x <= mybytelength & x < mybytelength)
                    {
                        if (y == 1)
                        {
                            C.white();
                            Console.Write(" " + bytes[x] + " ");
                            y = 2;
                        }
                        else
                        {
                            C.blue();
                            Console.Write(bytes[x]);
                            y = 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine(" ");
                        break;
                    }
                    Thread.Sleep(1);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        else
        {
            //second block
            {
                for (int x = 0; x <= mybytelength; x++)
                {
                    for (int z = 0; z <= 1; z++)
                    {
                        if (x <= mybytelength & x < mybytelength)
                        {
                            if (y == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(" " + bytes[x] + " ");
                                y = 2;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(bytes[x]);
                                y = 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine(" ");
                            break;
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
    }
    #endregion


    #region splitstringdoppleganger
//   public static void splitstringdoppelganger(string mystringhere)
//   {
//		// option A
//		splitstring( mystringhere);
// 
//   }
    #endregion


    #region splitstringdoppleganger
    public static void splitstring(string mystringhere, 
									ConsoleColor ColorOne = ConsoleColor.Green, 
									ConsoleColor ColorTwo = ConsoleColor.Yellow )
    {
        string[] bytes = mystringhere.Split(' ');
        int mybytelength = bytes.Length;
        int y = 1;

        for (int x = 0; x <= mybytelength; x++)
        {
            for (int z = 0; z <= 1; z++)
            {
				// ONLY true when x < mybytelength
				// 		equivalent to x != mybytelength
				// 		since x cannot be x > mybytelength
                if (x <= mybytelength & x < mybytelength)
                {
                    if (y == 1) // alternate Green/Yellow
                    {
                        Console.ForegroundColor = ColorOne;
                        Console.Write(" " + bytes[x] + " ");
                        Thread.Sleep(10);
                        Console.Clear();
                        y = 2;
                    }
                    else
                    {
                        Console.ForegroundColor = ColorTwo;
                        Console.Write(" " + bytes[x] + " ");
                        Thread.Sleep(10);
                        Console.Clear();
                        y = 1;
                    }
                }
                else		// only entered at last loop iteration of
							// for (int x = 0; x <= mybytelength; x++)
                {			// when x == mybytelength
                    Console.WriteLine(" ");
                    break;
                }
                Thread.Sleep(10);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
    #endregion

    #region CSwatch
    public static void Cswatch()
    {
        Random myrandom = new Random();
        Random moverandom = new Random();
        Random dancemove = new Random();
        int y = 0;
        int z = 0;
        for (int x = 0; x <= 100; x=x+10)
        {
            int anewrandom = myrandom.Next(1, 100);
            int dance = moverandom.Next(50, 150);
            int move = dancemove.Next(15, 75);
            y = y + 10;
            z = z + 10;
			Console.CursorTop = move + y;
			Console.CursorLeft = dance +z;
			Console.WriteLine();
            switch (anewrandom)
            {
                case (1):
                    Console.Write("+++");
                    break;
                case (2):
                    Console.Write("+-+");
                    break;
                case (3):
                    Console.Write("+--");
                    break;
                case (4):
                    Console.Write("--+");
                    break;
                case (5):
                    Console.Write("---");
                    break;
                case (6):
                    Console.Write("~~~");
                    break;
                case (7):
                    Console.Write("%%%");
                    break;
                case (8):
                    Console.Write("^^^");
                    break;
                case (9):
                    Console.Write("###");
                    break;
                case (10):
                    Console.Write("@@@");
                    break;
            }
			Console.WriteLine();
            Thread.Sleep(500);
        }
    }
    #endregion

	
    #region AsciiTable
    public static void AsciiTable()
    {
        Console.Write("Decimal".PadRight(10));
        Console.Write("ASCII".PadRight(10));
        Console.Write("Hex".PadRight(10));
        Console.WriteLine();

        int min = 0;
        int max = 1423; //128 1423
        for (int i = min; i < max; i++)
        {
            // Get ASCII character.
            char c = (char)i;

            // Get display string.
            string display = string.Empty;
            if (char.IsWhiteSpace(c))
            {
                display = c.ToString();
                switch (c)
                {
                    case '\t':
                        display = "\\t";
                        break;
                    case ' ':
                        display = "space";
                        break;
                    case '\n':
                        display = "\\n";
                        break;
                    case '\r':
                        display = "\\r";
                        break;
                    case '\v':
                        display = "\\v";
                        break;
                    case '\f':
                        display = "\\f";
                        break;
                }
            }
            else if (char.IsControl(c))
            {
                display = "control";
            }
            else
            {
                display = c.ToString();
            }
            // Write table row.
            Console.Write(i.ToString().PadRight(10));
            Console.Write(display.PadRight(10));
            Console.Write(i.ToString("X2"));
            Console.WriteLine();
        }
    }
    #endregion


    #region scrolling down
    public static void ScrollingDown(string speakandspell)
    {
        for(int i =0; i < speakandspell.Length; i++)
        {
            Console.WriteLine(speakandspell[i]);
        }
    }
    #endregion

	
    #region spacedscrollingflood
    public static void spacedscrollingflood(string speakandspell)
    {
        for(int i = 0; i < speakandspell.Length; i++)
        {
            Console.Write(speakandspell[i] + "  "+ speakandspell[i] + "\t" + speakandspell[i] + "\t" + speakandspell[i] + "/t" + speakandspell[i] + "/t" + speakandspell[i] + "/t" + speakandspell[i] + "/t" + speakandspell[i] + "/t" + speakandspell[i] + "/t" + speakandspell[i] + "/t");
        }
    }
    #endregion
	

    #region scrollingdownflood
    public static void scrollingdownflood(string speakandspell)
    {
        for (int i = 0; i < speakandspell.Length; i++)
        {
            Console.Write(speakandspell[i] + "\t" + speakandspell[i] + "\t" + speakandspell[i] + "\t" + speakandspell[i] + "\t" + speakandspell[i] + "\t" + speakandspell[i] + "\t" + speakandspell[i] + "\t" + speakandspell[i] + "\t" + speakandspell[i] + "\t" + speakandspell[i] + "\t" + speakandspell[i] + "\t" + speakandspell[i]);
        }
    }
    #endregion

	
    #region passgen
    public static string CreatePassword(int length)
    {
        const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        StringBuilder res = new StringBuilder();
        Random rnd = new Random();
        while (0 < length--)
        {
            res.Append(valid[rnd.Next(valid.Length)]);
        }
        return res.ToString();
    }

    #endregion

	
    #region passgenpyramid
    public static void passgenpyramid()
    {
        for (int x = 0; x <= 10; x++)
        {
            Console.WriteLine(SpecialFx.CreatePassword(x));
            Console.WriteLine();
        }
    }
    #endregion

	
    #region spfxpassgenpyramid
    public static void spfxpassgenpyramid()
    {
        for (int x = 0; x <= 10; x++)
        {
            SpecialFx.PwCrackThrobber(SpecialFx.CreatePassword(x));
            Console.WriteLine();
        }
    }
    #endregion

	
	#region spfxgenglitch
    public static void spfxgenglitch()
    {
        Thread SpfxThrob = new Thread(SpecialFx.spfxpassgenpyramid);
        Thread SpfxThrob2 = new Thread(SpecialFx.spfxpassgenpyramid);

        SpfxThrob.Start();
        SpfxThrob2.Start();
    }
    #endregion


    #region Stopwatch
    public static void stopwatch()
    {
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        Thread.Sleep(100);
        stopWatch.Stop();
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);

    }
    #endregion


    #region ScreenTyper
    public static void ScreenTyper(string speakandspell)
    {
        string sentance = " ";

		for (int i = 0; i < speakandspell.Length; i++)
		{
			sentance += speakandspell[i];
			Console.Write(" " + " *** " + " Narrator: " + sentance + " *** " + " ");
			Thread.Sleep(60); //great for small lines
			Console.Clear();
		}
		Console.Write(" " + " *** " + " Narrator: " + sentance + " *** " + " ");
    }
    #endregion
}
