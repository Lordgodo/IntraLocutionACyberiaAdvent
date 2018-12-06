using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Diagnostics;
using System.Media;


public static class Filez
{

    #region readtxtbyline
    public static void readtxtbyline(string mytxt)
    {
        int counter = 0;
        string line;

        // Read the file and display it line by line.  
        System.IO.StreamReader file =
        // new System.IO.StreamReader(@"c:\defaultips.txt");
        // AppDomain.CurrentDomain.BaseDirectory + "\\" + mysound;
        new System.IO.StreamReader(AppDomain.CurrentDomain.BaseDirectory + "\\" + mytxt);
		
        while ((line = file.ReadLine()) != null)
        {
            System.Console.WriteLine(line);
          //  Personality.RedQueenNarrator(line, 10, 1);
            counter++;
        }

        file.Close();
        System.Console.WriteLine("There were {0} lines.", counter);
        // Suspend the screen. 
        CinemaHelpers.Timer(1000); 
       // System.Console.ReadLine();
    }
    #endregion

    #region RedQueenreadtxtbyline
    public static void RedQueenReads(string mytxt)
    {
        int counter = 0;
        string line;

        // Read the file and display it line by line.  
        System.IO.StreamReader file =
				new System.IO.StreamReader(AppDomain.CurrentDomain.BaseDirectory + "\\" + mytxt);
		
        while ((line = file.ReadLine()) != null)
        {
            System.Console.WriteLine(line);
            Personality.RedQueenNarrator(line, 10, 1);
            counter++;
        }

        file.Close();
        System.Console.WriteLine("There were {0} lines.", counter);
        // Suspend the screen.  
        // System.Console.ReadLine();
        CinemaHelpers.Timer(1000);
    }
    #endregion


    #region Professorreadtxtbyline
    public static void ProfessorReads(string mytxt)
    {
        int counter = 0;
        string line;

        // Read the file and display it line by line.  
        System.IO.StreamReader file =
				new System.IO.StreamReader(AppDomain.CurrentDomain.BaseDirectory + "\\" + mytxt);
		
        while ((line = file.ReadLine()) != null)
        {
           // System.Console.WriteLine(line);
            //Personality.RedQueenNarrator(line, 10, 1);
            Personality.Miamoto(line);
            Thread.Sleep(100);
            counter++;
        }

        file.Close();
        Personality.Miamoto("There were {0} lines." + counter);
        SpecialFx.stopwatch();
       // stopwatch.Stop();
        //Console.WriteLine(stopwatch.ToString());
        // System.Console.WriteLine("There were {0} lines.", counter);

        // Suspend the screen.  
        // System.Console.ReadLine();
        CinemaHelpers.Timer(1000);
    }
    #endregion
}

