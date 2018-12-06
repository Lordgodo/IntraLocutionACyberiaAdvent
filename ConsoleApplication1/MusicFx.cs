using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Speech.Synthesis;


public static class MusicFx
{
    #region BinaryFire
	//both talking at once? this could be
	// done with synth.SpeakAsync(speakandspell)
    public static void BinaryFire()
    {
        string speakandspell = @"01001001 01101110 00100000 01100011 01101111 01101110 01100011 01100101 01110010 01110100 01100101 01100100 00100000 01101101 01101001 01101110 01100100 00100000 01101001 01110100 00100000 01110111 01100001 01110011 00100000 01110011 01100001 01101001 01100100 00100000 00001010 01101100 01100101 01110100 10000000011001 01110011 00100000 01100111 01100101 01110100 00100000 01110100 01101000 01100101 00100000 01100011 01100001 01110011 01101000 00101100 00100000 01110010 01100101 01100001 01100100 00100000 01110100 01101000 01100101 00100000 01101011 01100101 01111001 01110011 00101100 00100000 01101001 01101110 01110011 01110100 01100001 01101100 01101100 00100000 01100001 00100000 01110010 01101111 01101111 01110100 00100000 01101011 01101001 01110100 00101100 00100000 01100101 01110010 01100001 01110011 01100101 00100000 01101111 01110101 01110010 00100000 01110100 01110010 01100001 01100011 01100101 00101100 00100000 01100001 01101110 01100100 00100000 01100111 01100101 01110100 00100000 01101111 01110101 01110100 00101110 00100000 00001010 01000001 01101110 01101111 01110100 01101000 01100101 01110010 00100000 01110011 01111001 01110011 01110100 01100101 01101101 00100000 01110000 01100101 01101110 01100101 01110100 01110010 01100001 01110100 01100101 01100100 00100000 01100001 01101110 01100100 00100000 01100001 01101110 01101111 01110100 01101000 01100101 01110010 00100000 01110011 01110111 01101001 01110100 01100011 01101000 00100000 01100110 01101100 01101001 01110000 01110000 01100101 01100100 00101110 00100000 01010011 01101111 00100000 01101001 01110011 00100000 01110100 01101000 01100101 00100000 01110111 01100001 01111001 00100000 01101111 01100110 00100000 01101100 01101111 01100111 01101001 01100011 01100001 01101100 00100000 01100111 01100001 01110100 01100101 01110011 00101100 00100000 00001010 01110101 01101110 01110100 01101001 01101100 00100000 01110100 01101000 01100101 00100000 01110000 01101111 01110111 01100101 01110010 01110011 00100000 01110100 01110101 01110010 01101110 01100101 01100100 00100000 01101111 01110101 01110100 00101100 00100000 01110100 01101000 01100001 01110100 00100000 01101001 01110011 00100000 01101111 01101110 01100101 00100000 01100010 01101001 01100111 00100000 01111010 01100101 01110010 01101111 00101110 00100000 ";
        Personality.ConcertMind(speakandspell);
        SpeechSynthesizer synth = new SpeechSynthesizer();
        synth.Rate = 10;
        synth.Speak(speakandspell);
        synth.SelectVoice("Microsoft Zira Desktop");
        synth.Speak(speakandspell);
        synth.SelectVoice("Microsoft David Desktop");
        Console.WriteLine(" " + " ConcertMind:" + speakandspell + " \n\n");
    }
    #endregion


    #region BFire
    public static void BFire()
    {
        string speakandspell = @"01001001 01101110 00100000 01100011 011011 ";
        SpeechSynthesizer synth = new SpeechSynthesizer();
        synth.Rate = 10;
        synth.Speak(speakandspell);
        synth.SelectVoice("Microsoft Zira Desktop");
        synth.Speak(speakandspell);
        synth.SelectVoice("Microsoft David Desktop");
    }
    #endregion

	
    #region cptao
    public static void cptao()
    {
        Console.Beep(392, 250);
        Console.Beep(440, 500);
        Console.Beep(392, 250);
        Console.Beep(330, 500);
        Console.Beep(523, 500);
        Console.Beep(440, 500);
        Console.Beep(392, 950);
        Thread.Sleep(50);
    }
	#endregion

	
    #region staticvoidmutex
    public static void staticvoidmutex()
    {
        while (true)
        {
            Console.Beep(392, 250);
            Thread.Sleep(100);
            Thread.Sleep(100);
            Thread.Sleep(100);
            Console.Beep(392, 250);
            Thread.Sleep(100);
            Thread.Sleep(100);
            Console.Beep(261, 250);
            Thread.Sleep(100);
            Thread.Sleep(100);
            Console.Beep(392, 250);
            Thread.Sleep(100);
            Thread.Sleep(100);
            Console.Beep(493, 250);
            Thread.Sleep(100);
            Console.Beep(392, 250);
            Console.Beep(493, 250);
            Thread.Sleep(100);
            Console.Beep(493, 250);
            Console.Beep(392, 250);
            Thread.Sleep(100);
            Thread.Sleep(100);
            Thread.Sleep(100);
            Console.Beep(440, 250);
            Thread.Sleep(100);
            Console.Beep(392, 250);
            Console.Beep(493, 250);
            Thread.Sleep(100);
            Console.Beep(440, 250);
        }
    }
    #endregion


    #region theprofessor
    public static void theprofessor()
    {
        while (true)
        {
            Console.Beep(440, 250);
            Thread.Sleep(600);
            Console.Beep(440, 250);
            Console.Beep(440, 250);
            Thread.Sleep(600);
            Console.Beep(493, 250);
            Console.Beep(493, 250);
            Thread.Sleep(300);
            Console.Beep(440, 250);
            Console.Beep(440, 250);
            Thread.Sleep(100);
            Thread.Sleep(100);
            Console.Beep(329, 250);
            Thread.Sleep(100);
            Thread.Sleep(100);
            Console.Beep(293, 250);
            Thread.Sleep(100);
            Thread.Sleep(100);
            Console.Beep(493, 250);
            Thread.Sleep(600);
            Console.Beep(440, 250);
            Thread.Sleep(600);
            Console.Beep(440, 250);
            Console.Beep(440, 250);
        }
    }
    #endregion

	
    #region happyboopulator
    public static void happyboopulator()
    {
        while (true)
        {
            Console.Beep(440, 250);
            Console.Beep(440, 250);
            Console.Beep(493, 250);
            Thread.Sleep(1000);
            Console.Beep(261, 250);
            Thread.Sleep(1000);
            Console.Beep(261, 250);
            Console.Beep(493, 250);
            Console.Beep(493, 250);
            Console.Beep(440, 250);
            Thread.Sleep(1000);
            Console.Beep(261, 250);
            Console.Beep(493, 250);
            Console.Beep(440, 250);
        }
    }
    #endregion


    #region boopseek
    public static void boopseek()
    {
        while (true)				// this while loop never terminates!
        {
            Random r = new Random();
            int Boopquest = r.Next(1, 100);
            int Timequest = r.Next(100, 1000);
            int Aseek = r.Next(440, 460);
            int Bseek = r.Next(490, 510);
            int Cseek = r.Next(260, 270);

            Console.Beep(440, 250);
            Console.Beep(440, 250);
            Console.Beep(493, 250);
            Thread.Sleep(1000);
            Console.Beep(261, 250);
            Thread.Sleep(1000);
            Console.Beep(261, 250);
            Console.Beep(493, 250);
            Console.Beep(493, 250);
            Console.Beep(440, 250);
            Thread.Sleep(1000);
            Console.Beep(261, 250);
            Console.Beep(493, 250);
            Console.Beep(440, 250);

            // second part
            Console.Beep(Aseek, 250);
            Console.Beep(Aseek, 250);
            Console.Beep(Bseek, 250);
            Thread.Sleep(Timequest);
            Console.Beep(Cseek, 250);
            Thread.Sleep(Timequest);
            Console.Beep(Cseek, 250);
            Console.Beep(Aseek, 250);
            Console.Beep(Aseek, 250);
            Console.Beep(Bseek, 250);
            Thread.Sleep(Timequest);
            Console.Beep(Aseek, 250);
            Console.Beep(Aseek, 250);
            Console.Beep(Bseek, 250);

            // third part
            if (Boopquest < 50)
            {
                Console.Beep(Aseek, 250);
                Console.Beep(Aseek, 250);
                Console.Beep(Bseek, 250);
                Thread.Sleep(Timequest);
                Console.Beep(Cseek, 250);
                Thread.Sleep(Timequest);
                Console.Beep(Cseek, 250);
            }
            else		// this will be called for all cases Boopquest >= 50
            {
                Console.Beep(Aseek, 250);
                Console.Beep(Aseek, 250);
                Console.Beep(Bseek, 250);
                Thread.Sleep(Timequest);
            }

						// this will also be called for all cases Boopquest > 50
            if (Boopquest > 50)
            {
                Console.Beep(Aseek, 250);
                Console.Beep(Aseek, 250);
                Console.Beep(Bseek, 250);
                Thread.Sleep(Timequest);
            }
            else		// this will also be called for all cases Boopquest <= 50
            {
                Thread.Sleep(1000);
                Console.Beep(Cseek, 250);
                Console.Beep(Cseek, 250);
                Console.Beep(Aseek, 250);
                Thread.Sleep(Timequest);
                Console.Beep(Cseek, 250);
                Thread.Sleep(Timequest);
                Console.Beep(Cseek, 250);
                Thread.Sleep(Timequest);
                Console.Beep(Aseek, 250);
            }
        }
    }
    #endregion


    #region boopseeker
    public static void boopseeker()
    {
        while (true)  			// never terminates!
        {
            Random r = new Random();
            int Boopquest = r.Next(1, 100);
            int Timequest = r.Next(3000, 5000);
            int Sleepquest = r.Next(3000, 5000);
            int Aseek = r.Next(440, 460);
            int Bseek = r.Next(490, 510);
            int Cseek = r.Next(260, 270);

            Console.Beep(440, 250);
            Thread.Sleep(Sleepquest);
            Console.Beep(440, 250);
            Thread.Sleep(Sleepquest);
            Console.Beep(493, 250);
            Thread.Sleep(Sleepquest);
            Console.Beep(261, 250);
            Thread.Sleep(Sleepquest);
            Console.Beep(261, 250);
            Thread.Sleep(Sleepquest);
            Console.Beep(493, 250);
            Thread.Sleep(Sleepquest);
            Console.Beep(493, 250);
            Thread.Sleep(Sleepquest);
            Console.Beep(440, 250);
            Thread.Sleep(Sleepquest);
            Console.Beep(261, 250);
            Thread.Sleep(Sleepquest);
            Console.Beep(493, 250);
            Thread.Sleep(Sleepquest);
            Console.Beep(440, 250);

            // second part
            Console.Beep(Aseek, 250);
            Thread.Sleep(Sleepquest);
            Console.Beep(Aseek, 250);
            Thread.Sleep(Sleepquest);
            Console.Beep(Bseek, 250);
            Thread.Sleep(Timequest);
            Console.Beep(Cseek, 250);
            Thread.Sleep(Timequest);
            Console.Beep(Cseek, 250);
            Console.Beep(Aseek, 250);
            Thread.Sleep(Sleepquest);
            Console.Beep(Aseek, 250);
            Thread.Sleep(Sleepquest);
            Console.Beep(Bseek, 250);
            Thread.Sleep(Timequest);
            Console.Beep(Aseek, 250);
            Thread.Sleep(Sleepquest);
            Console.Beep(Aseek, 250);
            Thread.Sleep(Sleepquest);
            Console.Beep(Bseek, 250);

            // third part
            if (Boopquest < 50)
            {
                Console.Beep(Aseek, 250);
                Thread.Sleep(Sleepquest);
                Console.Beep(Aseek, 250);
                Thread.Sleep(Sleepquest);
                Console.Beep(Bseek, 250);
                Thread.Sleep(Timequest);
                Console.Beep(Cseek, 250);
                Thread.Sleep(Timequest);
                Console.Beep(Cseek, 250);
            }
            else			// overlapping cases, with 50 as edge case
            {
                Console.Beep(Aseek, 250);
                Thread.Sleep(Sleepquest);
                Console.Beep(Aseek, 250);
                Thread.Sleep(Sleepquest);
                Console.Beep(Bseek, 250);
                Thread.Sleep(Timequest);
            }

            if (Boopquest > 50)
            {
                Console.Beep(Aseek, 250);
                Thread.Sleep(Sleepquest);
                Console.Beep(Aseek, 250);
                Thread.Sleep(Sleepquest);
                Console.Beep(Bseek, 250);
                Thread.Sleep(Timequest);
            }
            else				// overlapping cases, with 50 as edge case
            {
                Thread.Sleep(1000);
                Console.Beep(Cseek, 250);
                Thread.Sleep(Sleepquest);
                Console.Beep(Cseek, 250);
                Thread.Sleep(Sleepquest);
                Console.Beep(Aseek, 250);
                Thread.Sleep(Timequest);
                Console.Beep(Cseek, 250);
                Thread.Sleep(Timequest);
                Console.Beep(Cseek, 250);
                Thread.Sleep(Timequest);
                Console.Beep(Aseek, 250);
            }
        }
    }
    #endregion


    #region playtripleboopseek
    public static void playstripleboopseek()
    {
        Random RandomTime = new Random();
        int myRandomTime = RandomTime.Next(1000, 2000);
        //Thread staticvoidmutex = new Thread(MusicFx.staticvoidmutex);
        //staticvoidmutex.Start();
        Thread Boopseeker = new Thread(MusicFx.boopseek);
        Boopseeker.Start();
        Thread.Sleep(myRandomTime);
        Thread Boopseeker2 = new Thread(MusicFx.boopseek);
        Boopseeker2.Start();
        Thread.Sleep(myRandomTime);
        Thread Boopseeker3 = new Thread(MusicFx.boopseek);
        Boopseeker3.Start();
    }
    #endregion


    #region selecttripleboopseek
    public static void selecttripleboopseek(int choice)
    {
        Random RandomTime = new Random();
        int myRandomTime = RandomTime.Next(1000, 2000);
        //Thread staticvoidmutex = new Thread(MusicFx.staticvoidmutex);
        //staticvoidmutex.Start();

        if (choice == 1)
        {
            Thread Boopseeker = new Thread(MusicFx.boopseek);
            Boopseeker.Start();
            Thread.Sleep(myRandomTime);
            Thread Boopseeker2 = new Thread(MusicFx.boopseek);
            Boopseeker2.Start();
            Thread.Sleep(myRandomTime);
            Thread Boopseeker3 = new Thread(MusicFx.boopseek);
            Boopseeker3.Start();
        } else if (choice == 0)
        {
            Thread Boopseeker = new Thread(MusicFx.boopseek);
            Boopseeker.Start();
            Boopseeker.Suspend();
            Thread Boopseeker2 = new Thread(MusicFx.boopseek);
            Boopseeker2.Start();
            Boopseeker2.Suspend();
            Thread Boopseeker3 = new Thread(MusicFx.boopseek);
            Boopseeker3.Start();
            Boopseeker3.Suspend();
        }
        else
        {
            Console.WriteLine("Please enter 1 to start and 0 to stop this function");
        }
    }
    #endregion
}

