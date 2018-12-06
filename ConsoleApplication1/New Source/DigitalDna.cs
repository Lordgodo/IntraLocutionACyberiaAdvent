using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace IntraLocution.New_Source
//{
   public static class DigitalDna
    {




        public static void DigitalGlyph1 ()
        {
            Console.WriteLine("");


            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1252);
            Console.WriteLine((char)169);
            Console.WriteLine((char)170);

            for (char c = (char)179; c <= (char)218; ++c)
            {
                Console.WriteLine(c);
            string b;
            b = c.ToString();
            SpecialFx.RainbowWriterBG(b + b + b + b + b + b + b);
            }






        }


    public static void DigitalGlyph2()
    {
        Console.WriteLine("[] [] [] [] [] [] [] []");
        Console.WriteLine("[] [] [] [] [] [] [] []");
        Console.WriteLine("[] [] [] [] [] [] [] []");
        Console.WriteLine("[] [] [] [] [] [] [] []");
        Console.WriteLine("[] [] [] [] [] [] [] []");
        Console.WriteLine("[] [] [] [] [] [] [] []");
        Console.WriteLine("[] [] [] [] [] [] [] []");
        Console.WriteLine("[] [] [] [] [] [] [] []");
        Console.WriteLine("[] [] [] [] [] [] [] []");
    }

    public static void DigitalGlyph3()
    {
        Console.WriteLine("                       ");
        Console.WriteLine("                       ");
        Console.WriteLine("                       ");
        Console.WriteLine("                       ");
        Console.WriteLine("                       ");
        Console.WriteLine("                       ");
        Console.WriteLine("                       ");
        Console.WriteLine("                       ");
       
    }

    public static void DigitalGlyph4()
    {

        // prints well formatted [] [] [] Grid
        string[] GlyphSymbol = { "    ", " [] " };
        Console.Clear();
        for (int x = 0; x <= 8; x++)
        {
            for(int y = 0; y <= 8; y++)
            {
                if (y != 8)
                {
                    Console.Write(GlyphSymbol[0] + " " + GlyphSymbol[1]);
                }else
                {
                    Console.Write("\n");
                }
            }
        }



    }



    public static void DigitalGlyph5()
    {

        // prints well formatted [] [] [] Grid
        string[] GlyphSymbol = { "    ", " [] " ,"[X]", "[0]", "[ ]"};
        Console.Clear();
        for (int x = 0; x <= 8; x++)
        {
            for (int y = 0; y <= 15; y++)
            {

                if( y /2 != 0)
                {
                    Console.Write(GlyphSymbol[0] + " " + GlyphSymbol[2] + "\t");
                }
                else if( y / 2 == 0)
                {
                    Console.Write(GlyphSymbol[0] + " " + GlyphSymbol[4] + "\t");
                }
                else
                {
                   Console.Write("\n");
                }



                //if (y != 8)
                //{
                //    Console.Write(GlyphSymbol[0] + " " + GlyphSymbol[1]);
                //}
                //else
                //{
                //    Console.Write("\n");
                //}
            }
        }



    }







    public static void DigitalGlyph6(int myy)
    {

        // prints well formatted [] [] [] Grid
        string[] GlyphSymbol = { "    ", " [] ", "[X]", "[0]", "[ ]" };
        Console.Clear();
        for (int x = 0; x <= 8; x++)
        {
            for (int y = 0; y <= myy; y++)
            {

                if (y / 2 != 0)
                {
                    Console.Write(GlyphSymbol[0] + " " + GlyphSymbol[2] + "\t");
                }
                else if (y / 2 == 0)
                {
                    Console.Write(GlyphSymbol[0] + " " + GlyphSymbol[4] + "\t");
                }
                else
                {
                    Console.Write("\n");
                }



                //if (y != 8)
                //{
                //    Console.Write(GlyphSymbol[0] + " " + GlyphSymbol[1]);
                //}
                //else
                //{
                //    Console.Write("\n");
                //}
            }
        }



    }


}
//}
