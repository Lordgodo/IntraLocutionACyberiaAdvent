using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Diagnostics;
using System.Media;


public static class Soundz
{
    #region Actor
    public static void Actor(string mysound){
        // play mp3
        SoundPlayer player = new SoundPlayer();
        //player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\imalive.mp3";
        player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\"+ mysound;
        //player.SoundLocation = "c:\"imalive.wav";
        player.Play();
    }
    #endregion

	
    #region MDial
    public static void Mdial()
    {
        Soundz.Actor("mdial1.wav");
    }
    #endregion

	
    #region PhoneBusy
    public static void PhoneBusy()
    {
        Soundz.Actor("phonebusy.wav");
    }
    #endregion

	
    #region phonealwaysbusy
    public static void phonealwaysbusy()
    {
        while (true)
        {
            Soundz.PhoneBusy();
        }
    }
    #endregion

	
    #region OpenCmd
    public static void OpenCmdSnd() {
       // Soundz.Actor("opencmd.wav");
        SoundPlayer player = new SoundPlayer();
        //player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\imalive.mp3";
        player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\" + "opencmd.wav";
        //player.SoundLocation = "c:\"imalive.wav";
        player.Play();
    }
    #endregion
}

