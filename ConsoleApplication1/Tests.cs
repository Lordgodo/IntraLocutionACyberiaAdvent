using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Diagnostics;

public static class Tests
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
                Console.WriteLine(b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b + b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b+
                    b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b + b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b+
                    b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b + b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b+
                    b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b + b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b);
            }
        }
        CinemaHelpers.SpaceandClean();
    }

    #endregion

	
    #region ConsoleRows and Coloumns
    public static void ConsoleRowsColoumns()
    {
        Console.WriteLine("The current buffer height is {0} rows.",
                     Console.BufferHeight);
        Console.WriteLine("The current buffer width is {0} columns.",
                          Console.BufferWidth);
    }
    #endregion


    #region NumFlood
    public static void NumBurn()
    {
        Random r = new Random();
        for (int x = 0; x <= 1000; x++)
        {
            for (int z = 0; z <= 2; z++)
            {
                for (int de = 0; de <= 10; de++)
                {
                    int b = r.Next(1, 10);
                    int d = r.Next(1, 10);
                    int e = r.Next(1, 10);

                    Console.WriteLine(b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b + b + "" + d + e + "" + d + e + b + b + d + e + d + b + b + d + e + b + d + d + b + e + e + e + e + e + b + b + b + d + d + e + e + b);
                }
            }
        }
        CinemaHelpers.SpaceandClean();
    }
    #endregion
}

